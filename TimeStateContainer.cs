using System.Diagnostics;

namespace BlazorDependenciesDemo;

public static class TimeStateContainer
{
    private static readonly Stopwatch Stopwatch = new ();

    public static void Start() => Stopwatch.Start();

    public static long Stop()
    {
        Stopwatch.Stop();
        return Stopwatch.ElapsedMilliseconds;
    }
}