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
            _currentState = State.Init;
        }

        public void Process(Alphabet input)
        {
            ValidateInput(input);
            _currentState = StateMachine.GetNextState(_currentState, input);
        }

        private bool InputAndOutputAreZero(Alphabet input)
        {
            return 
            	input == Alphabet.Zero && 
            	double.TryParse(Output, out var result) && result == 0.0;
        }

        private void ValidateInput(Alphabet input)
        {
            if (!Enum.IsDefined(typeof(Alphabet), input))
                throw new ArgumentException(
                	$"{input} is not a valid argument for this calculator.");
        }

        private void OnOutputValueChanged(string newOutput)
        {
            OutputValueChanged?.Invoke(
            	this, 
            	new CalculatorEngineEventArgs(newOutput));
        }
    }
}
