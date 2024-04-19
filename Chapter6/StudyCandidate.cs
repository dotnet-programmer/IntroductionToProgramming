namespace Chapter6;

internal readonly struct StudyCandidate(string name, int math, int it, int foreignLanguage)
{
	private readonly int _math = math;
	private readonly int _it = it;
	private readonly int _foreignLanguage = foreignLanguage;

	public string Name { get; } = name;

	public double TotalPoints()
		=> 0.6 * _math + 0.5 * _it + 0.2 * _foreignLanguage;
}