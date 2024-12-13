namespace days;

public static class Day5{
	
	public static int part1() {
		var stream = new StreamReader("days/inputs/day5.txt");	
		var input = stream.ReadToEnd();
		var split = input.Split("\n\n");
		var firstInput = split[0];
		var secondInput = split[1].Remove(split[1].Count() - 1);
		var map = new Dictionary<int,List<int>>();
		var sum = 0;
		foreach (var line in firstInput.Split("\n")) {
			var a = Int32.Parse(line.Split("|")[0]);
			var b = Int32.Parse(line.Split("|")[1]);
			if (map.ContainsKey(a)) {
				map[a].Add(b);
			} else {
				map[a] = new List<int>(){b};
			}
		}
		foreach (var line in secondInput.Split("\n")) {
			var list = line.Split(",").Select(Int32.Parse).ToList();
			if (isValid(map,list)) {
				sum += list[list.Count / 2];
			} 
		}
		return sum;
	}

	public static int part2() {
		var stream = new StreamReader("days/inputs/day5.txt");	
		var input = stream.ReadToEnd();
		var split = input.Split("\n\n");
		var firstInput = split[0];
		var secondInput = split[1].Remove(split[1].Count() - 1);
		var map = new Dictionary<int,List<int>>();
		var sum = 0;
		foreach (var line in firstInput.Split("\n")) {
			var a = Int32.Parse(line.Split("|")[0]);
			var b = Int32.Parse(line.Split("|")[1]);
			if (map.ContainsKey(a)) {
				map[a].Add(b);
			} else {
				map[a] = new List<int>(){b};
			}
		}
		foreach (var line in secondInput.Split("\n")) {
			var list = line.Split(",").Select(Int32.Parse).ToList();
			if (!isValid(map,list)) {
				list.Sort((a,b) => {
					if (map[a].Contains(b)) return 1;
					if (map[b].Contains(a)) return -1;
					return 0;
				});
				sum+=list[list.Count / 2];
				
			} 
		}
		return sum;
	}

	public static bool isValid(Dictionary<int,List<int>> map, List<int> list) {
		var check = new List<int>();
		for (var i = 0; i < list.Count; i++) {
			if (!check.All(x => !map[list[i]].Contains(x))) {
				return false;
			}
			check.Add(list[i]);
		}
		return true;
	}
}

