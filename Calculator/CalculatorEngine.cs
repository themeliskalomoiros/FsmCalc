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
                        break;
                    case State.FirstOperand:
                        ProcessFirstOperand(input);
                        FirstOperand = double.Parse(Output);
                        break;
                    case State.SecondOperand:
                        ProcessSecondOperand(input);
                        break;
                    case State.Result:
                        ProcessResult(input);
                        FirstOperand = 0.0;
                        SecondOperand = 0.0;
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                DivisionByZeroOccurred?.Invoke(this, EventArgs.Empty);
            }

            CurrentState = nextState;
        }

        private void ProcessResult(Alphabet input)
        {
            if (CurrentState == State.FirstOperand)
            {
                if (input == Alphabet.OneOfTerm)
                {
                    Output = (1.0 / FirstOperand).ToString();
                }
                else if (input == Alphabet.SquareRoot)
                {
                    Output = Math.Sqrt(FirstOperand).ToString();
                }
                else if (input == Alphabet.PowerOfTwo)
                {
                    Output = Math.Pow(FirstOperand, 2).ToString();
                }
            }
            else if (CurrentState == State.SecondOperand)
            {
                var result = 0.0;

                if (input == Alphabet.OneOfTerm)
                {

                }
                else if (input == Alphabet.SquareRoot)
                {

                }
                else if (input == Alphabet.PowerOfTwo)
                {

                }
                else if (input == Alphabet.Percent)
                {

                }
                else if (input == Alphabet.Equation)
                {
                    switch (LastMainOperation)
                    {
                        case Alphabet.Addition:
                            result = FirstOperand + SecondOperand;
                            break;
                        case Alphabet.Subtraction:
                            result = FirstOperand - SecondOperand;
                            break;
                        case Alphabet.Multiplication:
                            result = FirstOperand * SecondOperand;
                            break;
                        case Alphabet.Division:
                            result = FirstOperand / SecondOperand;
                            break;
                    }
                }

                Output = result.ToString();
            }
        }

        private void ProcessFirstOperand(Alphabet input)
        {
            if (IsOutputZero() && input == Alphabet.Zero)
            {
                return;
            }

            if (IsOutputZero() && input != Alphabet.Zero)
            {
                Output = string.Empty;
            }

            if (input.IsNumeric())
            {
                Output += input.GetSymbol();
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
                // FIXME: hitting backspace on '-455.3' results to '-', fix it
                if (Output.Length > 1)
                {
                    Output = Output.Substring(0, Output.Length - 1);
                }
                else
                {
                    Output = "0";
                }
            }
        }

        private void ProcessSecondOperand(Alphabet input)
        {
            if (input == Alphabet.ClearEntry)
            {
                Output = "0";
                return;
            }

            if (IsOutputZero() && input == Alphabet.Zero)
            {
                return;
            }

            if (input.IsMainOperation())
            {
                LastMainOperation = input;
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
                // FIXME: hitting backspace on '-455.3' results to '-', fix it
                if (Output.Length > 1)
                {
                    Output = Output.Substring(0, Output.Length - 1);
                }
                else
                {
                    Output = "0";
                }
            }
            else if (input == Alphabet.Equation)
            {
                var result = 0.0;

                switch (LastMainOperation)
                {
                    case Alphabet.Addition:
                        result = FirstOperand + SecondOperand;
                        break;
                    case Alphabet.Subtraction:
                        result = FirstOperand - SecondOperand;
                        break;
                    case Alphabet.Multiplication:
                        result = FirstOperand * SecondOperand;
                        break;
                    case Alphabet.Division:
                        result = FirstOperand / SecondOperand;
                        break;
                }

                Output = result.ToString();
            }
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
