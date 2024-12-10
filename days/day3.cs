using System.Text.RegularExpressions;
namespace days;


public static class Day3{
	
	public static int part1() {
		var stream = new StreamReader("days/inputs/day3.txt");	
		var line = stream.ReadLine();
		var sum = 0;
		while (line != null) {
			var mul = new Regex(@"mul\((\d+),(\d+)\)");
			foreach (Match match in mul.Matches(line)) {
				sum += Int32.Parse(match.Groups[1].Value)*Int32.Parse(match.Groups[2].Value);
			}
			line = stream.ReadLine();
		}
		return sum;
	}

	public static int part2() {
		var stream = new StreamReader("days/inputs/day3.txt");	
		var line = stream.ReadLine();
		var sum = 0;
		var disabled = false;
		var rg = new Regex(@"mul\((\d+),(\d+)\)|do\(\)|don't\(\)");
		while (line != null) {
			foreach (Match match in rg.Matches(line)) {
				if (match.Value == "don't()") {
					disabled = true;
				} else if (match.Value == "do()") {
					disabled = false;
				} else if (!disabled) {
					sum += Int32.Parse(match.Groups[1].Value)*Int32.Parse(match.Groups[2].Value);
				}
			}
			line = stream.ReadLine();
		}
		return sum;
	}
}
