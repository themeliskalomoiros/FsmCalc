namespace Calculator;

public static class StateMachine
{
    public static State GetNextState(State state, Alphabet input)
    {
        var stateIndex = Array.IndexOf(_States, state);
        var inputIndex = Array.IndexOf(_Input, input);

        return _TransitionTable[stateIndex][inputIndex];
    }

    static readonly State[] _States =
    {
        State.Init,
        State.FirstOperand,
        State.SecondOperand,
        State.Result,
    };

    static readonly Alphabet[] _Input =
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
        Alphabet.Addition,
        Alphabet.Subtraction,
        Alphabet.Multiplication,
        Alphabet.Division,
        Alphabet.Percent,
        Alphabet.OneOfTerm,
        Alphabet.SquareRoot,
        Alphabet.PowerOfTwo,
        Alphabet.Sign,
        Alphabet.Dot,
        Alphabet.ClearEntry,
        Alphabet.Clear,
        Alphabet.Backspace,
        Alphabet.Equation,
    };

    static readonly Dictionary<int, State[]> _TransitionTable = new Dictionary<int, State[]>
    {
        {
            0, 
            new State[]
            { 
                State.Init, State.FirstOperand, State.FirstOperand, 
                State.FirstOperand, State.FirstOperand, State.FirstOperand, 
                State.FirstOperand, State.FirstOperand, State.FirstOperand, 
                State.FirstOperand, State.SecondOperand, State.SecondOperand, 
                State.SecondOperand, State.SecondOperand, State.Init, 
                State.Init, State.Result, State.Result, 
                State.Init, State.FirstOperand, State.Init, 
                State.Init, State.Init, State.Init, 
            } 
        },
        {
            1, 
            new State[]
            { 
                State.FirstOperand, State.FirstOperand, State.FirstOperand, 
                State.FirstOperand, State.FirstOperand, State.FirstOperand, 
                State.FirstOperand, State.FirstOperand, State.FirstOperand, 
                State.FirstOperand, State.SecondOperand, State.SecondOperand, 
                State.SecondOperand, State.SecondOperand, State.Init, 
                State.Result, State.Result, State.Result, 
                State.FirstOperand, State.FirstOperand, State.Init, 
                State.Init, State.FirstOperand, State.FirstOperand, 
            } 
        },
        {
            2, 
            new State[]
            { 
                State.SecondOperand, State.SecondOperand, State.SecondOperand, 
                State.SecondOperand, State.SecondOperand, State.SecondOperand, 
                State.SecondOperand, State.SecondOperand, State.SecondOperand, 
                State.SecondOperand, State.SecondOperand, State.SecondOperand, 
                State.SecondOperand, State.SecondOperand, State.Result, 
                State.Result, State.Result, State.Result, 
                State.SecondOperand, State.SecondOperand, State.SecondOperand, 
                State.Init, State.SecondOperand, State.Result, 
            } 
        },
        {
            3, 
            new State[]
            { 
                State.FirstOperand, State.FirstOperand, State.FirstOperand, 
                State.FirstOperand, State.FirstOperand, State.FirstOperand, 
                State.FirstOperand, State.FirstOperand, State.FirstOperand, 
                State.FirstOperand, State.FirstOperand, State.FirstOperand, 
                State.FirstOperand, State.FirstOperand, State.Result, 
                State.Result, State.Result, State.Result, 
                State.Result, State.Result, State.Init, 
                State.Init, State.Result, State.Result, 
            } 
        },
    };
}