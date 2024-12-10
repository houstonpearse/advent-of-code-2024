namespace days;


public static class Day2{
	
	public static int part1() {
		var stream = new StreamReader("days/inputs/day2.txt");	
		var line = stream.ReadLine();
		var sum = 0;
		while (line != null) {
			var list = line.Split(' ').Select(Int32.Parse).ToList();
			if (Day2.checkReport(list)) sum++;
			line = stream.ReadLine();
		}
		return sum;
	}

	public static int part2() {
		var stream = new StreamReader("days/inputs/day2.txt");	
		var line = stream.ReadLine();
		var sum = 0;
		while (line != null) {
			var list = line.Split(' ').Select(Int32.Parse).ToList();
			if (Day2.checkReport(list)){
				sum++;
			} else {
				for (var i = 0; i< list.Count; i++) {
					var tempList = new List<int>(list);
					tempList.RemoveAt(i);
					if (Day2.checkReport(tempList)) {
						sum++;
						break;
					}

				}
			};
			line = stream.ReadLine();
		}
		return sum;
	}

	private static bool checkReport(List<int> list) {
		var prev = list[0];
		var increasing = (list[0] - list[1]) > 0 ? 1 : -1;
		var safe = true;
		for (var i = 1; i<list.Count; i++) {
			if ((prev - list[i])*increasing > 3 || (prev - list[i])*increasing < 1){
				safe = false;
				break;
			};
			prev = list[i];
		}	
		return safe;
	}

}
