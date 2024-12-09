namespace days;


public static class Day1{
	
	public static int part1() {
		var stream = new StreamReader("days/inputs/day1.txt");	
		var line = stream.ReadLine();
		var leftList = new List<int>();
		var rightList = new List<int>();
		while (line != null) {
			var left = line.Split(" ")[0];
			leftList.Add(Int32.Parse(left));
			var right = line.Split(" ")[3];
			rightList.Add(Int32.Parse(right));
			line = stream.ReadLine();
		}
		leftList.Sort();
		rightList.Sort();
		int sum = 0;	
		for (var i = 0; i < leftList.Count; i++) {
			sum += Math.Abs(leftList[i]-rightList[i]);	
		} 
		return sum;	
	}

		public static int part2() {
		var stream = new StreamReader("days/inputs/day1.txt");	
		var line = stream.ReadLine();
		var leftList = new List<int>();
		var rightList = new List<int>();
		var rightDict = new Dictionary<int,int>();
		while (line != null) {
			var left = Int32.Parse(line.Split(" ")[0]);
			var right = Int32.Parse(line.Split(" ")[3]);
			leftList.Add(left);
			if (rightDict.ContainsKey(right)) {
				rightDict[right]++;
			} else {
				rightDict[right] = 1;
			}
			line = stream.ReadLine();
		}
		leftList.Sort();
		rightList.Sort();
		
		int sum = 0;	
		for (var i = 0; i < leftList.Count; i++) {
			if (rightDict.ContainsKey(leftList[i])) {
				sum += leftList[i] * rightDict[leftList[i]];
			}
		} 
		return sum;	
	}

}
