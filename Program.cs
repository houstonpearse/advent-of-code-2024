using days;
namespace adventofcode;

public class Runner {

	public Runner() {}	

	public static void Main() {
		runSolution(Day1.part1);
		runSolution(Day1.part2);
	}


	public static void runSolution(Func<int> solution) {
		var watch = System.Diagnostics.Stopwatch.StartNew();
		var value = solution();
		watch.Stop();
		Console.WriteLine($"{solution.Method.DeclaringType} - {solution.Method.Name} - {value} ({watch.ElapsedMilliseconds.ToString()}ms)");
	}

}
