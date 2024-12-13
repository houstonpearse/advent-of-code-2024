using days;
namespace adventofcode;

public class Runner {

	public Runner() {}	

	public static void Main() {
		runSolution(Day1.part1);
		runSolution(Day1.part2);
		runSolution(Day2.part1);
		runSolution(Day2.part2);
		runSolution(Day3.part1);
		runSolution(Day3.part2);
		runSolution(Day4.part1);
		runSolution(Day4.part2);
		runSolution(Day5.part1);
		runSolution(Day5.part2);
		runSolution(Day6.part1);
		runSolution(Day6.part2);
	}


	public static void runSolution(Func<int> solution) {
		var watch = System.Diagnostics.Stopwatch.StartNew();
		var value = solution();
		watch.Stop();
		Console.WriteLine($"{solution.Method.DeclaringType} - {solution.Method.Name} - {value} ({watch.ElapsedMilliseconds.ToString()}ms)");
	}

}
