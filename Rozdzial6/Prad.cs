namespace Rozdzial6;

internal class Prad
{
	public double InitialState { get; }
	public double CurrentState { get; set; }

	public Prad(double initialState) : this(initialState, initialState)
	{
	}

	public Prad(double initialState, double currentState)
	{
		InitialState = initialState;
		CurrentState = currentState;
	}

	public double ObliczZuzycie() => CurrentState - InitialState;
}