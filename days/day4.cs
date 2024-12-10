namespace days;

public static class Day4{
	
	public static int part1() {
		var stream = new StreamReader("days/inputs/day4.txt");	
		var line = stream.ReadLine();
		var map = new List<List<char>>();
		var sum = 0;
		while (line != null) {
			map.Add(new List<char>(line.ToCharArray()));
			line = stream.ReadLine();
		}
		for (var i = 0; i < map.Count; i++) {
			for (var j = 0; j< map[i].Count; j++) {
				if (map[i][j] == 'X') {
					sum += check1(map,i,j);	
				}
			}	
		}
		return sum;
	}

	public static int part2() {
		var stream = new StreamReader("days/inputs/day4.txt");	
		var line = stream.ReadLine();
		var map = new List<List<char>>();
		var sum = 0;
		while (line != null) {
			map.Add(new List<char>(line.ToCharArray()));
			line = stream.ReadLine();
		}
		for (var i = 0; i < map.Count; i++) {
			for (var j = 0; j< map[i].Count; j++) {
				if (map[i][j] == 'A') {
					sum += check2(map,i,j);	
				}
			}	
		}
		return sum;
	}

	private static int check1(List<List<char>> map, int i, int j) {
		var count = 0;
		if( j + 3 < map[i].Count){
			if (map[i][j+1] == 'M' && map[i][j+2] == 'A' && map[i][j+3] == 'S') count++;	
		}
		if( j - 3 >= 0){
			if (map[i][j-1] == 'M' && map[i][j-2] == 'A' && map[i][j-3] == 'S') count++;	
		}
		if (i + 3 < map.Count) {
			if (map[i+1][j] == 'M' && map[i+2][j] == 'A' && map[i+3][j] == 'S') count++;	
		}
		if (i - 3 >= 0) {
			if (map[i-1][j] == 'M' && map[i-2][j] == 'A' && map[i-3][j] == 'S') count++;	
		}

		if (i + 3 < map.Count &&  j + 3 < map[i].Count) {
			if (map[i+1][j+1] == 'M' && map[i+2][j+2] == 'A' && map[i+3][j+3] == 'S') count++;	
		}
		if (i + 3 < map.Count &&  j - 3 >= 0) {
			if (map[i+1][j-1] == 'M' && map[i+2][j-2] == 'A' && map[i+3][j-3] == 'S') count++;	
		}
		if (i - 3 >= 0 &&  j - 3 >= 0) {
			if (map[i-1][j-1] == 'M' && map[i-2][j-2] == 'A' && map[i-3][j-3] == 'S') count++;	
		}
		if (i - 3 >= 0 &&  j + 3 < map[i].Count) {
			if (map[i-1][j+1] == 'M' && map[i-2][j+2] == 'A' && map[i-3][j+3] == 'S') count++;	
		}

		return count;
	}

	private static int check2(List<List<char>> map, int i, int j) {
		var firstDiagonal = false;
		var secondDiagonal = false;
		if (i+1 < map.Count && i-1 >= 0 && j+1 < map[0].Count && j-1 >= 0){
			if (map[i+1][j+1] == 'M' && map[i-1][j-1] == 'S') {
				firstDiagonal = true;
			}
			if (map[i+1][j+1] == 'S' && map[i-1][j-1] == 'M') {
				firstDiagonal = true;
			}
			if (map[i-1][j+1] == 'M' && map[i+1][j-1] == 'S') {
				secondDiagonal = true;
			}
			if (map[i-1][j+1] == 'S' && map[i+1][j-1] == 'M') {
				secondDiagonal = true;
			}
		}
		if (firstDiagonal && secondDiagonal) return 1;
		return 0;
	}
}
