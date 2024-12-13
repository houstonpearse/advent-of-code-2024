namespace days;

public static class Day6{
	
	public static int part1() {
		var stream = new StreamReader("days/inputs/day6.txt");	
		var input = stream.ReadToEnd();
		var map = input.Split("\n").SkipLast(1).Select(x => x.ToList<char>()).ToList();
		int x=0,y=0;	
		int xM = map.Count;
		int yM = map[0].Count;
		for (var i = 0; i< xM; i++){
			for (var j = 0; j < yM; j++) {
				if (map[i][j] == 'V' || map[i][j] == '^' || map[i][j] == '<' || map[i][j] == '>') {
					x = i;
					y = j;
				}
			}
		}
		while (true) {
			if (map[x][y] == '^') {
				if (x == 0) 
					break;
				if (map[x-1][y] == '#') {
					map[x][y] = '>';
				} else {
					map[x][y] = 'X';
					map[x-1][y] = '^';
					x = x-1;
				}
			} else if (map[x][y] == 'V') {
				if (x+1 == xM) 
					break;
				if (map[x+1][y] == '#') {
					map[x][y] = '<';
				} else {
					map[x][y] = 'X';
					map[x+1][y] = 'V';
					x = x+1;
				}
			} else if (map[x][y] == '>') {
				if (y+1 == yM) 
					break;
				if (map[x][y+1] == '#') {
					map[x][y] = 'V';
				} else {
					map[x][y] = 'X';
					map[x][y+1] = '>';
					y = y+1;
				}
			} else if (map[x][y] == '<') {
				if (y == 0) 
					break;
				if (map[x][y-1] == '#') {
					map[x][y] = '^';
				} else {
					map[x][y] = 'X';
					map[x][y-1] = '<';
					y=y-1;
				}
			}
		}
		var sum = 0;
		foreach (var line in map) {
			foreach (var c in line) {
				if (c == 'X') sum++;
			}
		}
		return sum+1;
	}

	public static int part2() {
		var stream = new StreamReader("days/inputs/day6.txt");	
		var input = stream.ReadToEnd();
		var map = input.Split("\n").SkipLast(1).Select(x => x.ToList<char>());
		var sum = 0;
		return sum;
	}
}

