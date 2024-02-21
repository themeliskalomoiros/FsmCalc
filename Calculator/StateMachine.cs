namespace Calculator;

public static class StateMachine
{
    public static State GetNextState(State state, Alphabet input)
    {
        var stateIndex = Array.IndexOf(_States, state);
        var inputIndex = Array.IndexOf(_Input, input);

        return _TransitionTable[stateIndex][inputIndex];
    }

    private static readonly State[] _States =
    {
        State.A,
        State.B,
        State.C,
        State.D,
        State.E,
        State.F,
        State.G,
        State.H,
        State.I,
        State.J,
        State.K,
        State.L,
        State.M
    };

    private static readonly Alphabet[] _Input =
    {
        Alphabet.Zero,
        Alphabet.One,
        Alphabet.Two,
        Alphabet.Three,
        Alphabet.Four,
        Alphabet.Five,
        Alphabet.Six,
        Alphabet.Seven,
        Alphabet.Eight,
        Alphabet.Nine,
        Alphabet.Percent,
        Alphabet.OneOfTerm,
        Alphabet.TermSquared,
        Alphabet.SquareRoot,
        Alphabet.Division,
        Alphabet.Multiplication,
        Alphabet.Addition,
        Alphabet.Subtraction,
        Alphabet.PlusMinus,
        Alphabet.Dot,
        Alphabet.ClearEntry,
        Alphabet.Clear,
        Alphabet.Backspace,
        Alphabet.Equation,
    };

    private static readonly Dictionary<int, State[]> _TransitionTable = new Dictionary<int, State[]>
    {
        {
            0, 
            new State[]
            { 
                State.B, State.B, State.B, State.B, State.B, State.B, State.B, State.B, State.B, State.B, 
                State.B, State.B, State.B, State.B, State.B, State.B, State.B, State.B, 
                State.B, State.B, State.M, State.M, State.M, State.M, 
            } 
        },
        {
            1, 
            new State[]
            { 
                State.B, State.B, State.B, State.B, State.B, State.B, State.B, State.B, State.B, State.B, 
                State.C, State.C, State.C, State.C, State.C, State.C, State.C, State.C, 
                State.B, State.B, State.A, State.A, State.D, State.M, 
            } 
        },
        {
            2, 
            new State[]
            { 
                State.E, State.E, State.E, State.E, State.E, State.E, State.E, State.E, State.E, State.E, 
                State.C, State.C, State.C, State.C, State.C, State.C, State.C, State.C, 
                State.C, State.E, State.A, State.A, State.B, State.M, 
            } 
        },
        {
            3, 
            new State[]
            { 
                State.B, State.B, State.B, State.B, State.B, State.B, State.B, State.B, State.B, State.B, 
                State.F, State.F, State.F, State.F, State.F, State.F, State.F, State.F, 
                State.B, State.B, State.A, State.A, State.D, State.M, 
            } 
        },
        {
            4, 
            new State[]
            { 
                State.E, State.E, State.E, State.E, State.E, State.E, State.E, State.E, State.E, State.E, 
                State.C, State.C, State.C, State.C, State.C, State.C, State.C, State.C, 
                State.E, State.E, State.E, State.A, State.G, State.H, 
            } 
        },
        {
            5, 
            new State[]
            { 
                State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, 
                State.C, State.C, State.C, State.C, State.C, State.C, State.C, State.C, 
                State.F, State.I, State.A, State.A, State.D, State.M, 
            } 
        },
        {
            6, 
            new State[]
            { 
                State.E, State.E, State.E, State.E, State.E, State.E, State.E, State.E, State.E, State.E, 
                State.C, State.C, State.C, State.C, State.C, State.C, State.C, State.C, 
                State.G, State.E, State.J, State.A, State.K, State.H, 
            } 
        },
        {
            7, 
            new State[]
            { 
                State.B, State.B, State.B, State.B, State.B, State.B, State.B, State.B, State.B, State.B, 
                State.C, State.C, State.C, State.C, State.C, State.C, State.C, State.C, 
                State.M, State.M, State.A, State.A, State.M, State.H }
                 }
                 ,
        {
            8, 
            new State[]
            { 
                State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, 
                State.C, State.C, State.C, State.C, State.C, State.C, State.C, State.C, 
                State.I, State.I, State.J, State.A, State.L, State.H, 
            } 
        },
        {
            9, 
            new State[]
            { 
                State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, 
                State.F, State.F, State.F, State.F, State.F, State.F, State.F, State.F, 
                State.I, State.I, State.E, State.A, State.G, State.H, 
            } 
        },
        {
            10, 
            new State[]
            { 
                State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, 
                State.C, State.C, State.C, State.C, State.C, State.C, State.C, State.C, 
                State.K, State.I, State.J, State.A, State.L, State.H, 
            } 
        },
        {
            11, 
            new State[]
            { 
                State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, State.I, 
                State.F, State.F, State.F, State.F, State.F, State.F, State.F, State.F, 
                State.K, State.I, State.J, State.B, State.L, State.H, 
            } 
        },
        {
           12, 
            new State[]
            { 
                State.M, State.M, State.M, State.M, State.M, State.M, State.M, State.M, State.M, State.M, 
                State.M, State.M, State.M, State.M, State.M, State.M, State.M, State.M, 
                State.M, State.M, State.M, State.M, State.M, State.M, 
            } 
        },
    };
}