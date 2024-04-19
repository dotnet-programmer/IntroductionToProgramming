namespace Chapter6;

internal class Electricity(double initialState, double currentState)
{
	public double InitialState { get; } = initialState;
	public double CurrentState { get; set; } = currentState;

	public Electricity(double initialState) : this(initialState, initialState)
	{
	}

	public double CalculateUsage()
		=> CurrentState - InitialState;
}