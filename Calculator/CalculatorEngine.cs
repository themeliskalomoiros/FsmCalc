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
            var nextState = StateMachine.GetNextState(_currentState, input);

            if (nextState == State.FirstOperand)
            {
                if (input.IsNumeric())
                {
                    if (Output == "0")
                    {
                        Output = input.GetSymbol();
                    }
                    else 
                    {
                        Output += input.GetSymbol();
                    }
                }
                else if (input == Alphabet.Sign)
                {
                    var firstOperand = double.Parse(Output);
                    Output = (firstOperand * -1).ToString();
                }
                else if (input == Alphabet.Dot)
                {
                    if (Output.Contains("."))
                    {
                        Output = Output.Replace(".", string.Empty);
                    }
                    else
                    {
                        Output += ".";
                    }
                }
            }

            _currentState = nextState;
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
