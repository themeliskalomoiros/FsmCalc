namespace StateMachineTests;

using Calculator;

public class StateMachineShould
{
    [Theory]
    [InlineData(State.A, Alphabet.Zero, State.B)]
    [InlineData(State.A, Alphabet.One, State.B)]
    [InlineData(State.A, Alphabet.Two, State.B)]
    [InlineData(State.A, Alphabet.Three, State.B)]
    [InlineData(State.A, Alphabet.Four, State.B)]
    [InlineData(State.A, Alphabet.Five, State.B)]
    [InlineData(State.A, Alphabet.Six, State.B)]
    [InlineData(State.A, Alphabet.Seven, State.B)]
    [InlineData(State.A, Alphabet.Eight, State.B)]
    [InlineData(State.A, Alphabet.Nine, State.B)] // end of numeric input
    [InlineData(State.A, Alphabet.Percent, State.B)]
    [InlineData(State.A, Alphabet.OneOfTerm, State.B)]
    [InlineData(State.A, Alphabet.TermSquared, State.B)]
    [InlineData(State.A, Alphabet.SquareRoot, State.B)]
    [InlineData(State.A, Alphabet.Division, State.B)]
    [InlineData(State.A, Alphabet.Multiplication, State.B)]
    [InlineData(State.A, Alphabet.Addition, State.B)]
    [InlineData(State.A, Alphabet.Subtraction, State.B)] // end of operation input
    [InlineData(State.A, Alphabet.PlusMinus, State.B)]
    [InlineData(State.A, Alphabet.Dot, State.B)]
    [InlineData(State.A, Alphabet.ClearEntry, State.M)]
    [InlineData(State.A, Alphabet.Clear, State.M)]
    [InlineData(State.A, Alphabet.Backspace, State.M)]
    [InlineData(State.A, Alphabet.Equation, State.M)]
    [InlineData(State.B, Alphabet.Zero, State.B)]
    [InlineData(State.B, Alphabet.One, State.B)]
    [InlineData(State.B, Alphabet.Two, State.B)]
    [InlineData(State.B, Alphabet.Three, State.B)]
    [InlineData(State.B, Alphabet.Four, State.B)]
    [InlineData(State.B, Alphabet.Five, State.B)]
    [InlineData(State.B, Alphabet.Six, State.B)]
    [InlineData(State.B, Alphabet.Seven, State.B)]
    [InlineData(State.B, Alphabet.Eight, State.B)]
    [InlineData(State.B, Alphabet.Nine, State.B)] // end of numeric input
    [InlineData(State.B, Alphabet.Percent, State.C)]
    [InlineData(State.B, Alphabet.OneOfTerm, State.C)]
    [InlineData(State.B, Alphabet.TermSquared, State.C)]
    [InlineData(State.B, Alphabet.SquareRoot, State.C)]
    [InlineData(State.B, Alphabet.Division, State.C)]
    [InlineData(State.B, Alphabet.Multiplication, State.C)]
    [InlineData(State.B, Alphabet.Addition, State.C)]
    [InlineData(State.B, Alphabet.Subtraction, State.C)] // end of operation input
    [InlineData(State.B, Alphabet.PlusMinus, State.B)]
    [InlineData(State.B, Alphabet.Dot, State.B)]
    [InlineData(State.B, Alphabet.ClearEntry, State.A)]
    [InlineData(State.B, Alphabet.Clear, State.A)]
    [InlineData(State.B, Alphabet.Backspace, State.D)]
    [InlineData(State.B, Alphabet.Equation, State.M)]
    [InlineData(State.C, Alphabet.Zero, State.E)]
    [InlineData(State.C, Alphabet.One, State.E)]
    [InlineData(State.C, Alphabet.Two, State.E)]
    [InlineData(State.C, Alphabet.Three, State.E)]
    [InlineData(State.C, Alphabet.Four, State.E)]
    [InlineData(State.C, Alphabet.Five, State.E)]
    [InlineData(State.C, Alphabet.Six, State.E)]
    [InlineData(State.C, Alphabet.Seven, State.E)]
    [InlineData(State.C, Alphabet.Eight, State.E)]
    [InlineData(State.C, Alphabet.Nine, State.E)] // end of numeric input
    [InlineData(State.C, Alphabet.Percent, State.C)]
    [InlineData(State.C, Alphabet.OneOfTerm, State.C)]
    [InlineData(State.C, Alphabet.TermSquared, State.C)]
    [InlineData(State.C, Alphabet.SquareRoot, State.C)]
    [InlineData(State.C, Alphabet.Division, State.C)]
    [InlineData(State.C, Alphabet.Multiplication, State.C)]
    [InlineData(State.C, Alphabet.Addition, State.C)]
    [InlineData(State.C, Alphabet.Subtraction, State.C)] // end of operation input
    [InlineData(State.C, Alphabet.PlusMinus, State.C)]
    [InlineData(State.C, Alphabet.Dot, State.E)]
    [InlineData(State.C, Alphabet.ClearEntry, State.A)]
    [InlineData(State.C, Alphabet.Clear, State.A)]
    [InlineData(State.C, Alphabet.Backspace, State.B)]
    [InlineData(State.C, Alphabet.Equation, State.M)]
    [InlineData(State.D, Alphabet.Zero, State.B)]
    [InlineData(State.D, Alphabet.One, State.B)]
    [InlineData(State.D, Alphabet.Two, State.B)]
    [InlineData(State.D, Alphabet.Three, State.B)]
    [InlineData(State.D, Alphabet.Four, State.B)]
    [InlineData(State.D, Alphabet.Five, State.B)]
    [InlineData(State.D, Alphabet.Six, State.B)]
    [InlineData(State.D, Alphabet.Seven, State.B)]
    [InlineData(State.D, Alphabet.Eight, State.B)]
    [InlineData(State.D, Alphabet.Nine, State.B)] // end of numeric input
    [InlineData(State.D, Alphabet.Percent, State.F)]
    [InlineData(State.D, Alphabet.OneOfTerm, State.F)]
    [InlineData(State.D, Alphabet.TermSquared, State.F)]
    [InlineData(State.D, Alphabet.SquareRoot, State.F)]
    [InlineData(State.D, Alphabet.Division, State.F)]
    [InlineData(State.D, Alphabet.Multiplication, State.F)]
    [InlineData(State.D, Alphabet.Addition, State.F)]
    [InlineData(State.D, Alphabet.Subtraction, State.F)] // end of operation input
    [InlineData(State.D, Alphabet.PlusMinus, State.B)]
    [InlineData(State.D, Alphabet.Dot, State.B)]
    [InlineData(State.D, Alphabet.ClearEntry, State.A)]
    [InlineData(State.D, Alphabet.Clear, State.A)]
    [InlineData(State.D, Alphabet.Backspace, State.D)]
    [InlineData(State.D, Alphabet.Equation, State.M)]
    [InlineData(State.E, Alphabet.Zero, State.E)]
    [InlineData(State.E, Alphabet.One, State.E)]
    [InlineData(State.E, Alphabet.Two, State.E)]
    [InlineData(State.E, Alphabet.Three, State.E)]
    [InlineData(State.E, Alphabet.Four, State.E)]
    [InlineData(State.E, Alphabet.Five, State.E)]
    [InlineData(State.E, Alphabet.Six, State.E)]
    [InlineData(State.E, Alphabet.Seven, State.E)]
    [InlineData(State.E, Alphabet.Eight, State.E)]
    [InlineData(State.E, Alphabet.Nine, State.E)] // end of numeric input
    [InlineData(State.E, Alphabet.Percent, State.C)]
    [InlineData(State.E, Alphabet.OneOfTerm, State.C)]
    [InlineData(State.E, Alphabet.TermSquared, State.C)]
    [InlineData(State.E, Alphabet.SquareRoot, State.C)]
    [InlineData(State.E, Alphabet.Division, State.C)]
    [InlineData(State.E, Alphabet.Multiplication, State.C)]
    [InlineData(State.E, Alphabet.Addition, State.C)]
    [InlineData(State.E, Alphabet.Subtraction, State.C)] // end of operation input
    [InlineData(State.E, Alphabet.PlusMinus, State.E)]
    [InlineData(State.E, Alphabet.Dot, State.E)]
    [InlineData(State.E, Alphabet.ClearEntry, State.E)]
    [InlineData(State.E, Alphabet.Clear, State.A)]
    [InlineData(State.E, Alphabet.Backspace, State.G)]
    [InlineData(State.E, Alphabet.Equation, State.H)]
    [InlineData(State.F, Alphabet.Zero, State.I)]
    [InlineData(State.F, Alphabet.One, State.I)]
    [InlineData(State.F, Alphabet.Two, State.I)]
    [InlineData(State.F, Alphabet.Three, State.I)]
    [InlineData(State.F, Alphabet.Four, State.I)]
    [InlineData(State.F, Alphabet.Five, State.I)]
    [InlineData(State.F, Alphabet.Six, State.I)]
    [InlineData(State.F, Alphabet.Seven, State.I)]
    [InlineData(State.F, Alphabet.Eight, State.I)]
    [InlineData(State.F, Alphabet.Nine, State.I)] // end of numeric input
    [InlineData(State.F, Alphabet.Percent, State.C)]
    [InlineData(State.F, Alphabet.OneOfTerm, State.C)]
    [InlineData(State.F, Alphabet.TermSquared, State.C)]
    [InlineData(State.F, Alphabet.SquareRoot, State.C)]
    [InlineData(State.F, Alphabet.Division, State.C)]
    [InlineData(State.F, Alphabet.Multiplication, State.C)]
    [InlineData(State.F, Alphabet.Addition, State.C)]
    [InlineData(State.F, Alphabet.Subtraction, State.C)] // end of operation input
    [InlineData(State.F, Alphabet.PlusMinus, State.F)]
    [InlineData(State.F, Alphabet.Dot, State.I)]
    [InlineData(State.F, Alphabet.ClearEntry, State.A)]
    [InlineData(State.F, Alphabet.Clear, State.A)]
    [InlineData(State.F, Alphabet.Backspace, State.D)]
    [InlineData(State.F, Alphabet.Equation, State.M)]
    [InlineData(State.G, Alphabet.Zero, State.E)]
    [InlineData(State.G, Alphabet.One, State.E)]
    [InlineData(State.G, Alphabet.Two, State.E)]
    [InlineData(State.G, Alphabet.Three, State.E)]
    [InlineData(State.G, Alphabet.Four, State.E)]
    [InlineData(State.G, Alphabet.Five, State.E)]
    [InlineData(State.G, Alphabet.Six, State.E)]
    [InlineData(State.G, Alphabet.Seven, State.E)]
    [InlineData(State.G, Alphabet.Eight, State.E)]
    [InlineData(State.G, Alphabet.Nine, State.E)] // end of numeric input
    [InlineData(State.G, Alphabet.Percent, State.C)]
    [InlineData(State.G, Alphabet.OneOfTerm, State.C)]
    [InlineData(State.G, Alphabet.TermSquared, State.C)]
    [InlineData(State.G, Alphabet.SquareRoot, State.C)]
    [InlineData(State.G, Alphabet.Division, State.C)]
    [InlineData(State.G, Alphabet.Multiplication, State.C)]
    [InlineData(State.G, Alphabet.Addition, State.C)]
    [InlineData(State.G, Alphabet.Subtraction, State.C)] // end of operation input
    [InlineData(State.G, Alphabet.PlusMinus, State.G)]
    [InlineData(State.G, Alphabet.Dot, State.E)]
    [InlineData(State.G, Alphabet.ClearEntry, State.J)]
    [InlineData(State.G, Alphabet.Clear, State.A)]
    [InlineData(State.G, Alphabet.Backspace, State.K)]
    [InlineData(State.G, Alphabet.Equation, State.H)]
    [InlineData(State.H, Alphabet.Zero, State.B)]
    [InlineData(State.H, Alphabet.One, State.B)]
    [InlineData(State.H, Alphabet.Two, State.B)]
    [InlineData(State.H, Alphabet.Three, State.B)]
    [InlineData(State.H, Alphabet.Four, State.B)]
    [InlineData(State.H, Alphabet.Five, State.B)]
    [InlineData(State.H, Alphabet.Six, State.B)]
    [InlineData(State.H, Alphabet.Seven, State.B)]
    [InlineData(State.H, Alphabet.Eight, State.B)]
    [InlineData(State.H, Alphabet.Nine, State.B)] // end of numeric input
    [InlineData(State.H, Alphabet.Percent, State.C)]
    [InlineData(State.H, Alphabet.OneOfTerm, State.C)]
    [InlineData(State.H, Alphabet.TermSquared, State.C)]
    [InlineData(State.H, Alphabet.SquareRoot, State.C)]
    [InlineData(State.H, Alphabet.Division, State.C)]
    [InlineData(State.H, Alphabet.Multiplication, State.C)]
    [InlineData(State.H, Alphabet.Addition, State.C)]
    [InlineData(State.H, Alphabet.Subtraction, State.C)] // end of operation input
    [InlineData(State.H, Alphabet.PlusMinus, State.M)]
    [InlineData(State.H, Alphabet.Dot, State.M)]
    [InlineData(State.H, Alphabet.ClearEntry, State.A)]
    [InlineData(State.H, Alphabet.Clear, State.A)]
    [InlineData(State.H, Alphabet.Backspace, State.M)]
    [InlineData(State.H, Alphabet.Equation, State.H)]
    [InlineData(State.I, Alphabet.Zero, State.I)]
    [InlineData(State.I, Alphabet.One, State.I)]
    [InlineData(State.I, Alphabet.Two, State.I)]
    [InlineData(State.I, Alphabet.Three, State.I)]
    [InlineData(State.I, Alphabet.Four, State.I)]
    [InlineData(State.I, Alphabet.Five, State.I)]
    [InlineData(State.I, Alphabet.Six, State.I)]
    [InlineData(State.I, Alphabet.Seven, State.I)]
    [InlineData(State.I, Alphabet.Eight, State.I)]
    [InlineData(State.I, Alphabet.Nine, State.I)] // end of numeric input
    [InlineData(State.I, Alphabet.Percent, State.C)]
    [InlineData(State.I, Alphabet.OneOfTerm, State.C)]
    [InlineData(State.I, Alphabet.TermSquared, State.C)]
    [InlineData(State.I, Alphabet.SquareRoot, State.C)]
    [InlineData(State.I, Alphabet.Division, State.C)]
    [InlineData(State.I, Alphabet.Multiplication, State.C)]
    [InlineData(State.I, Alphabet.Addition, State.C)]
    [InlineData(State.I, Alphabet.Subtraction, State.C)] // end of operation input
    [InlineData(State.I, Alphabet.PlusMinus, State.I)]
    [InlineData(State.I, Alphabet.Dot, State.I)]
    [InlineData(State.I, Alphabet.ClearEntry, State.J)]
    [InlineData(State.I, Alphabet.Clear, State.A)]
    [InlineData(State.I, Alphabet.Backspace, State.L)]
    [InlineData(State.I, Alphabet.Equation, State.H)]
    [InlineData(State.J, Alphabet.Zero, State.I)]
    [InlineData(State.J, Alphabet.One, State.I)]
    [InlineData(State.J, Alphabet.Two, State.I)]
    [InlineData(State.J, Alphabet.Three, State.I)]
    [InlineData(State.J, Alphabet.Four, State.I)]
    [InlineData(State.J, Alphabet.Five, State.I)]
    [InlineData(State.J, Alphabet.Six, State.I)]
    [InlineData(State.J, Alphabet.Seven, State.I)]
    [InlineData(State.J, Alphabet.Eight, State.I)]
    [InlineData(State.J, Alphabet.Nine, State.I)] // end of numeric input
    [InlineData(State.J, Alphabet.Percent, State.F)]
    [InlineData(State.J, Alphabet.OneOfTerm, State.F)]
    [InlineData(State.J, Alphabet.TermSquared, State.F)]
    [InlineData(State.J, Alphabet.SquareRoot, State.F)]
    [InlineData(State.J, Alphabet.Division, State.F)]
    [InlineData(State.J, Alphabet.Multiplication, State.F)]
    [InlineData(State.J, Alphabet.Addition, State.F)]
    [InlineData(State.J, Alphabet.Subtraction, State.F)] // end of operation input
    [InlineData(State.J, Alphabet.PlusMinus, State.I)]
    [InlineData(State.J, Alphabet.Dot, State.I)]
    [InlineData(State.J, Alphabet.ClearEntry, State.E)]
    [InlineData(State.J, Alphabet.Clear, State.A)]
    [InlineData(State.J, Alphabet.Backspace, State.G)]
    [InlineData(State.J, Alphabet.Equation, State.H)]
    [InlineData(State.K, Alphabet.Zero, State.I)]
    [InlineData(State.K, Alphabet.One, State.I)]
    [InlineData(State.K, Alphabet.Two, State.I)]
    [InlineData(State.K, Alphabet.Three, State.I)]
    [InlineData(State.K, Alphabet.Four, State.I)]
    [InlineData(State.K, Alphabet.Five, State.I)]
    [InlineData(State.K, Alphabet.Six, State.I)]
    [InlineData(State.K, Alphabet.Seven, State.I)]
    [InlineData(State.K, Alphabet.Eight, State.I)]
    [InlineData(State.K, Alphabet.Nine, State.I)] // end of numeric input
    [InlineData(State.K, Alphabet.Percent, State.C)]
    [InlineData(State.K, Alphabet.OneOfTerm, State.C)]
    [InlineData(State.K, Alphabet.TermSquared, State.C)]
    [InlineData(State.K, Alphabet.SquareRoot, State.C)]
    [InlineData(State.K, Alphabet.Division, State.C)]
    [InlineData(State.K, Alphabet.Multiplication, State.C)]
    [InlineData(State.K, Alphabet.Addition, State.C)]
    [InlineData(State.K, Alphabet.Subtraction, State.C)] // end of operation input
    [InlineData(State.K, Alphabet.PlusMinus, State.K)]
    [InlineData(State.K, Alphabet.Dot, State.I)]
    [InlineData(State.K, Alphabet.ClearEntry, State.J)]
    [InlineData(State.K, Alphabet.Clear, State.A)]
    [InlineData(State.K, Alphabet.Backspace, State.L)]
    [InlineData(State.K, Alphabet.Equation, State.H)]
    [InlineData(State.L, Alphabet.Zero, State.I)]
    [InlineData(State.L, Alphabet.One, State.I)]
    [InlineData(State.L, Alphabet.Two, State.I)]
    [InlineData(State.L, Alphabet.Three, State.I)]
    [InlineData(State.L, Alphabet.Four, State.I)]
    [InlineData(State.L, Alphabet.Five, State.I)]
    [InlineData(State.L, Alphabet.Six, State.I)]
    [InlineData(State.L, Alphabet.Seven, State.I)]
    [InlineData(State.L, Alphabet.Eight, State.I)]
    [InlineData(State.L, Alphabet.Nine, State.I)] // end of numeric input
    [InlineData(State.L, Alphabet.Percent, State.F)]
    [InlineData(State.L, Alphabet.OneOfTerm, State.F)]
    [InlineData(State.L, Alphabet.TermSquared, State.F)]
    [InlineData(State.L, Alphabet.SquareRoot, State.F)]
    [InlineData(State.L, Alphabet.Division, State.F)]
    [InlineData(State.L, Alphabet.Multiplication, State.F)]
    [InlineData(State.L, Alphabet.Addition, State.F)]
    [InlineData(State.L, Alphabet.Subtraction, State.F)] // end of operation input
    [InlineData(State.L, Alphabet.PlusMinus, State.K)]
    [InlineData(State.L, Alphabet.Dot, State.I)]
    [InlineData(State.L, Alphabet.ClearEntry, State.J)]
    [InlineData(State.L, Alphabet.Clear, State.B)]
    [InlineData(State.L, Alphabet.Backspace, State.L)]
    [InlineData(State.L, Alphabet.Equation, State.H)]
    [InlineData(State.M, Alphabet.Zero, State.M)]
    [InlineData(State.M, Alphabet.One, State.M)]
    [InlineData(State.M, Alphabet.Two, State.M)]
    [InlineData(State.M, Alphabet.Three, State.M)]
    [InlineData(State.M, Alphabet.Four, State.M)]
    [InlineData(State.M, Alphabet.Five, State.M)]
    [InlineData(State.M, Alphabet.Six, State.M)]
    [InlineData(State.M, Alphabet.Seven, State.M)]
    [InlineData(State.M, Alphabet.Eight, State.M)]
    [InlineData(State.M, Alphabet.Nine, State.M)] // end of numeric input
    [InlineData(State.M, Alphabet.Percent, State.M)]
    [InlineData(State.M, Alphabet.OneOfTerm, State.M)]
    [InlineData(State.M, Alphabet.TermSquared, State.M)]
    [InlineData(State.M, Alphabet.SquareRoot, State.M)]
    [InlineData(State.M, Alphabet.Division, State.M)]
    [InlineData(State.M, Alphabet.Multiplication, State.M)]
    [InlineData(State.M, Alphabet.Addition, State.M)]
    [InlineData(State.M, Alphabet.Subtraction, State.M)] // end of operation input
    [InlineData(State.M, Alphabet.PlusMinus, State.M)]
    [InlineData(State.M, Alphabet.Dot, State.M)]
    [InlineData(State.M, Alphabet.ClearEntry, State.M)]
    [InlineData(State.M, Alphabet.Clear, State.M)]
    [InlineData(State.M, Alphabet.Backspace, State.M)]
    [InlineData(State.M, Alphabet.Equation, State.M)]
    public void ReturnCorrectNextState(State currentState, Alphabet input, State expectedNextState)
    {
        var nextState = StateMachine.GetNextState(currentState, input);
        Assert.Equal(expectedNextState, nextState);
    }
}
