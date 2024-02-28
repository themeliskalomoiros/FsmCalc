namespace Calculator
{
    public class CalculatorEngine
    {
        public event EventHandler? DivisionByZeroOccurred;
        public event EventHandler<CalculatorEngineEventArgs>? OutputValueChanged;

        private State CurrentState
        {
            get;
            set;
        }

        /// <summary>
        /// A main operation is +, -, *, or ÷.
        /// </summary>
        private Alphabet? LastMainOperation
        {
            get;
            set;
        }

        private double FirstOperand
        {
            get;
            set;
        }

        private double SecondOperand
        {
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

            try
            {
                switch (nextState)
                {
                    case State.Init:
                        Output = "0";
                        FirstOperand = 0.0;
                        SecondOperand = 0.0;
                        LastMainOperation = null;
                        break;
                    case State.FirstOperand:
                        ProcessFirstOperand(input);
                        if (double.TryParse(Output, out var result))
                        {
                            FirstOperand = result;
                        }
                        else
                        {
                            FirstOperand = 0;
                        }
                        break;
                    case State.SecondOperand:
                        ProcessSecondOperand(input);
                        break;
                    case State.Result:
                        ProcessResult(input);
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                DivisionByZeroOccurred?.Invoke(this, EventArgs.Empty);
            }

            CurrentState = nextState;
        }

        private void ProcessFirstOperand(Alphabet input)
        {
            if (IsOutputZero() && input == Alphabet.Zero)
            {
                return;
            }

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
            else if (input == Alphabet.Decimal)
            {
                if (Output.Contains("."))
                {
                    Output = Output.Replace(".", string.Empty);
                }
                else
                {
                    Output += input.GetSymbol();
                }
            }
            else if (input == Alphabet.Sign)
            {
                if (Output.Contains("-"))
                {
                    Output = Output.Replace("-", string.Empty);
                }
                else
                {
                    Output = "-" + Output;
                }
            }
            else if (input == Alphabet.Backspace)
            {
                if (Output.Length > 1)
                {
                    Output = Output.Substring(0, Output.Length - 1);
                }
                else
                {
                    Output = "0";
                }
            }
            else if (input == Alphabet.OneOfTerm)
            {
                Output = (1.0 / FirstOperand).ToString();
            }
            else if (input == Alphabet.PowerOfTwo)
            {
                Output = Math.Pow(FirstOperand, 2.0).ToString();
            }
            else if (input == Alphabet.SquareRoot)
            {
                Output = Math.Sqrt(FirstOperand).ToString();
            }
        }

        private void ProcessSecondOperand(Alphabet input)
        {
            if (IsOutputZero() && input == Alphabet.Zero)
            {
                return;
            }

            if (input.IsNumeric())
            {
                if (SecondOperand == 0.0)
                {
                    Output = string.Empty;
                }

                Output += input.GetSymbol();
                SecondOperand = double.Parse(Output);
            }
            else if (input.IsMainOperation())
            {
                LastMainOperation = input;
            }
            else if (input == Alphabet.ClearEntry)
            {
                Output = "0";
            }
            else if (input == Alphabet.Decimal)
            {
                if (Output.Contains("."))
                {
                    Output = Output.Replace(".", string.Empty);
                }
                else
                {
                    Output += input.GetSymbol();
                }
            }
            else if (input == Alphabet.Sign)
            {
                if (Output.Contains("-"))
                {
                    Output = Output.Replace("-", string.Empty);
                }
                else
                {
                    Output = "-" + Output;
                }
            }
            else if (input == Alphabet.Backspace)
            {
                if (Output.Length > 1)
                {
                    Output = Output.Substring(0, Output.Length - 1);
                }
                else
                {
                    Output = "0";
                }
            }
            else if (input == Alphabet.Percent)
            {
                SecondOperand = FirstOperand * SecondOperand / 100.0;
                Output = SecondOperand.ToString();
            }
            else if (input == Alphabet.OneOfTerm)
            {
                SecondOperand = 1.0 / SecondOperand;
                Output = SecondOperand.ToString();
            }
            else if (input == Alphabet.PowerOfTwo)
            {
                SecondOperand = Math.Pow(SecondOperand, 2.0);
                Output = SecondOperand.ToString();
            }
            else if (input == Alphabet.SquareRoot)
            {
                SecondOperand = Math.Sqrt(SecondOperand);
                Output = SecondOperand.ToString();
            }
        }

        private void ProcessResult(Alphabet input)
        {
            if (input == Alphabet.Equation)
            {
                switch (LastMainOperation)
                {
                    case Alphabet.Addition:
                        FirstOperand = FirstOperand + SecondOperand;
                        break;
                    case Alphabet.Subtraction:
                        FirstOperand = FirstOperand - SecondOperand;
                        break;
                    case Alphabet.Multiplication:
                        FirstOperand = FirstOperand * SecondOperand;
                        break;
                    case Alphabet.Division:
                        FirstOperand = FirstOperand / SecondOperand;
                        break;
                }
            }
            else if (input == Alphabet.OneOfTerm)
            {
                switch (LastMainOperation)
                {
                    case Alphabet.Addition:
                        FirstOperand = FirstOperand + (1.0 / SecondOperand);
                        break;
                    case Alphabet.Subtraction:
                        FirstOperand = FirstOperand - (1.0 / SecondOperand);
                        break;
                    case Alphabet.Multiplication:
                        FirstOperand = FirstOperand * (1.0 / SecondOperand);
                        break;
                    case Alphabet.Division:
                        FirstOperand = FirstOperand / (1.0 / SecondOperand);
                        break;
                }
            }
            else if (input == Alphabet.SquareRoot)
            {
                switch (LastMainOperation)
                {
                    case Alphabet.Addition:
                        FirstOperand = FirstOperand + Math.Sqrt(SecondOperand);
                        break;
                    case Alphabet.Subtraction:
                        FirstOperand = FirstOperand - Math.Sqrt(SecondOperand);
                        break;
                    case Alphabet.Multiplication:
                        FirstOperand = FirstOperand * Math.Sqrt(SecondOperand);
                        break;
                    case Alphabet.Division:
                        FirstOperand = FirstOperand / Math.Sqrt(SecondOperand);
                        break;
                }
            }
            else if (input == Alphabet.PowerOfTwo)
            {
                switch (LastMainOperation)
                {
                    case Alphabet.Addition:
                        FirstOperand = FirstOperand + Math.Pow(SecondOperand, 2);
                        break;
                    case Alphabet.Subtraction:
                        FirstOperand = FirstOperand - Math.Pow(SecondOperand, 2);
                        break;
                    case Alphabet.Multiplication:
                        FirstOperand = FirstOperand * Math.Pow(SecondOperand, 2);
                        break;
                    case Alphabet.Division:
                        FirstOperand = FirstOperand / Math.Pow(SecondOperand, 2);
                        break;
                }
            }
            else if (input == Alphabet.Percent)
            {
                switch (LastMainOperation)
                {
                    case Alphabet.Addition:
                        FirstOperand = FirstOperand + (SecondOperand / 100);
                        break;
                    case Alphabet.Subtraction:
                        FirstOperand = FirstOperand - (SecondOperand / 100);
                        break;
                    case Alphabet.Multiplication:
                        FirstOperand = FirstOperand * (SecondOperand / 100);
                        break;
                    case Alphabet.Division:
                        FirstOperand = FirstOperand / (SecondOperand / 100);
                        break;
                }
            }

            Output = FirstOperand.ToString();
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
