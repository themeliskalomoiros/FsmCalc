using System;

namespace Calculator
{
    public class CalculatorEngine
    {
        public event EventHandler<CalculatorEngineEventArgs>? OutputValueChanged;

        private string _output;
        private State _currentState;

        public string Output
        {
            get => _output;
            private set
            {
                _output = value;
                OnOutputValueChanged(_output);
            }
        }

        public CalculatorEngine()
        {
            _output = "0";
            _currentState = State.A;
        }

        public void Process(Alphabet input)
        {
            ValidateInput(input);

            _currentState = StateMachine.GetNextState(_currentState, input);

            if (_currentState == State.B && input.IsNumeric())
            {
                if (ShouldIgnoreZeroInput(input))
                    return;

                UpdateOutput(input);
            }
        }

        private void UpdateOutput(Alphabet input)
        {
            var firstOperand = double.Parse(Output + input.GetSymbol());
            Output = firstOperand.ToString();
        }

        private bool ShouldIgnoreZeroInput(Alphabet input)
        {
            return input == Alphabet.Zero && double.TryParse(Output, out var result) && result == 0.0;
        }

        private void ValidateInput(Alphabet input)
        {
            if (!Enum.IsDefined(typeof(Alphabet), input))
                throw new ArgumentException($"{input} is not a valid argument for this calculator.");
        }

        private void OnOutputValueChanged(string newOutput)
        {
            OutputValueChanged?.Invoke(this, new CalculatorEngineEventArgs(newOutput));
        }
    }
}
