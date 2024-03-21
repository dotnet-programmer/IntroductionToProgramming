namespace Rozdzial6;

internal struct StudyCandidate
{
	public string Name { get; }
	private readonly int _math;
	private readonly int _it;
	private readonly int _foreignLanguage;

	public StudyCandidate(string name, int math, int it, int foreignLanguage)
	{
		Name = name;
		_math = math;
		_it = it;
		_foreignLanguage = foreignLanguage;
	}

	public double TotalPoints() => 0.6 * _math + 0.5 * _it + 0.2 * _foreignLanguage;
}