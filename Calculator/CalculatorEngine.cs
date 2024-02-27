namespace Calculator
{
    public class CalculatorEngine
    {
        public event EventHandler<CalculatorEngineEventArgs>? OutputValueChanged;

        private State CurrentState { 
            get; 
            set; 
        }

        private Alphabet? LastOperation { 
            get; 
            set; 
        }

        private double FirstOperand { 
            get; 
            set; 
        }

        private double SecondOperand { 
            get; 
            set; 
        }

        private string _output;
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
            CurrentState = State.Init;
        }

        public void Process(Alphabet input)
        {
            ValidateInput(input);
            var nextState = StateMachine.GetNextState(CurrentState, input);

            if (nextState == State.FirstOperand)
            {
                if (input.IsNumeric())
                {
                    if (IsOutputZero())
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
                    Output = (FirstOperand * -1).ToString();
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

                FirstOperand = double.Parse(Output);
            }
            else if (nextState == State.SecondOperand)
            {
                if (input.IsNumeric())
                {
                    // Use of field prevents the event to be raised.
                    _output = $"{SecondOperand}{input.GetSymbol()}";
                    SecondOperand = double.Parse(_output);

                    Output = SecondOperand.ToString();
                }
            }

            CurrentState = nextState;
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

        private bool IsOutputZero()
        {
            double.TryParse(Output, out var result);
            return result == 0;
        }
    }
}
