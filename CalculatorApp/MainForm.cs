using Calculator;

namespace CalculatorApp
{
    public partial class MainForm : Form
    {
        private CalculatorEngine _calc;

        public MainForm()
        {
            InitializeComponent();
            _calc = new CalculatorEngine();
        }

        private void OnCalclOutputValueChanged(object? sender, CalculatorEngineEventArgs e)
        {
            _screenTextBox.Text = e.Output;
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Zero);
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.One);
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Two);
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Three);
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Four);
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Five);
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Six);
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Seven);
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Eight);
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Nine);
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.PlusMinus);
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Dot);
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Equation);
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.PlusMinus);
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Subtraction);
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Multiplication);
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Division);
        }

        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.SquareRoot);
        }

        private void PowerOfTwoButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.TermSquared);
        }

        private void OneOfXButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.OneOfTerm);
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Backspace);
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Clear);
        }

        private void CeButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.ClearEntry);
        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            _calc.Process(Alphabet.Percent);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _calc.OutputValueChanged += OnCalclOutputValueChanged;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _calc.OutputValueChanged -= OnCalclOutputValueChanged;
        }
    }
}
