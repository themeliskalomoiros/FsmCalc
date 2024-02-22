namespace CalculatorApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _screenTextBox = new TextBox();
            ButtonsPanel = new TableLayoutPanel();
            _equalsButton = new Button();
            _dotButton = new Button();
            _zeroButton = new Button();
            _plusMinusButton = new Button();
            _plusButton = new Button();
            _threeButton = new Button();
            _twoButton = new Button();
            _oneButton = new Button();
            _minusButton = new Button();
            _sixButton = new Button();
            _fiveButton = new Button();
            _fourButton = new Button();
            _multiplicationButton = new Button();
            _nineButton = new Button();
            _eightButton = new Button();
            _sevenButton = new Button();
            _divisionButton = new Button();
            _squareRootButton = new Button();
            _powerOfTwoButton = new Button();
            _oneByXButton = new Button();
            _backspaceButton = new Button();
            _cButton = new Button();
            _ceButton = new Button();
            _percentButton = new Button();
            ButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // _screenTextBox
            // 
            _screenTextBox.Dock = DockStyle.Top;
            _screenTextBox.Enabled = false;
            _screenTextBox.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _screenTextBox.Location = new Point(0, 0);
            _screenTextBox.Margin = new Padding(13);
            _screenTextBox.Name = "_screenTextBox";
            _screenTextBox.Size = new Size(396, 64);
            _screenTextBox.TabIndex = 0;
            _screenTextBox.Text = "0";
            _screenTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.ColumnCount = 4;
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsPanel.Controls.Add(_equalsButton, 3, 5);
            ButtonsPanel.Controls.Add(_dotButton, 2, 5);
            ButtonsPanel.Controls.Add(_zeroButton, 1, 5);
            ButtonsPanel.Controls.Add(_plusMinusButton, 0, 5);
            ButtonsPanel.Controls.Add(_plusButton, 3, 4);
            ButtonsPanel.Controls.Add(_threeButton, 2, 4);
            ButtonsPanel.Controls.Add(_twoButton, 1, 4);
            ButtonsPanel.Controls.Add(_oneButton, 0, 4);
            ButtonsPanel.Controls.Add(_minusButton, 3, 3);
            ButtonsPanel.Controls.Add(_sixButton, 2, 3);
            ButtonsPanel.Controls.Add(_fiveButton, 1, 3);
            ButtonsPanel.Controls.Add(_fourButton, 0, 3);
            ButtonsPanel.Controls.Add(_multiplicationButton, 3, 2);
            ButtonsPanel.Controls.Add(_nineButton, 2, 2);
            ButtonsPanel.Controls.Add(_eightButton, 1, 2);
            ButtonsPanel.Controls.Add(_sevenButton, 0, 2);
            ButtonsPanel.Controls.Add(_divisionButton, 3, 1);
            ButtonsPanel.Controls.Add(_squareRootButton, 2, 1);
            ButtonsPanel.Controls.Add(_powerOfTwoButton, 1, 1);
            ButtonsPanel.Controls.Add(_oneByXButton, 0, 1);
            ButtonsPanel.Controls.Add(_backspaceButton, 3, 0);
            ButtonsPanel.Controls.Add(_cButton, 2, 0);
            ButtonsPanel.Controls.Add(_ceButton, 1, 0);
            ButtonsPanel.Controls.Add(_percentButton, 0, 0);
            ButtonsPanel.Dock = DockStyle.Fill;
            ButtonsPanel.Location = new Point(0, 64);
            ButtonsPanel.Margin = new Padding(4, 5, 4, 5);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.RowCount = 6;
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            ButtonsPanel.Size = new Size(396, 492);
            ButtonsPanel.TabIndex = 1;
            // 
            // _equalsButton
            // 
            _equalsButton.BackColor = Color.Firebrick;
            _equalsButton.Dock = DockStyle.Fill;
            _equalsButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _equalsButton.ForeColor = Color.WhiteSmoke;
            _equalsButton.Location = new Point(301, 415);
            _equalsButton.Margin = new Padding(4, 5, 4, 5);
            _equalsButton.Name = "_equalsButton";
            _equalsButton.Size = new Size(91, 72);
            _equalsButton.TabIndex = 23;
            _equalsButton.Text = "=";
            _equalsButton.UseVisualStyleBackColor = false;
            _equalsButton.Click += EqualsButton_Click;
            // 
            // _dotButton
            // 
            _dotButton.BackColor = Color.Firebrick;
            _dotButton.Dock = DockStyle.Fill;
            _dotButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _dotButton.ForeColor = Color.WhiteSmoke;
            _dotButton.Location = new Point(202, 415);
            _dotButton.Margin = new Padding(4, 5, 4, 5);
            _dotButton.Name = "_dotButton";
            _dotButton.Size = new Size(91, 72);
            _dotButton.TabIndex = 22;
            _dotButton.Text = ".";
            _dotButton.UseVisualStyleBackColor = false;
            _dotButton.Click += DotButton_Click;
            // 
            // _zeroButton
            // 
            _zeroButton.BackColor = Color.IndianRed;
            _zeroButton.Dock = DockStyle.Fill;
            _zeroButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _zeroButton.ForeColor = Color.WhiteSmoke;
            _zeroButton.Location = new Point(103, 415);
            _zeroButton.Margin = new Padding(4, 5, 4, 5);
            _zeroButton.Name = "_zeroButton";
            _zeroButton.Size = new Size(91, 72);
            _zeroButton.TabIndex = 21;
            _zeroButton.Text = "0";
            _zeroButton.UseVisualStyleBackColor = false;
            _zeroButton.Click += ZeroButton_Click;
            // 
            // _plusMinusButton
            // 
            _plusMinusButton.BackColor = Color.Firebrick;
            _plusMinusButton.Dock = DockStyle.Fill;
            _plusMinusButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _plusMinusButton.ForeColor = Color.WhiteSmoke;
            _plusMinusButton.Location = new Point(4, 415);
            _plusMinusButton.Margin = new Padding(4, 5, 4, 5);
            _plusMinusButton.Name = "_plusMinusButton";
            _plusMinusButton.Size = new Size(91, 72);
            _plusMinusButton.TabIndex = 20;
            _plusMinusButton.Text = "±";
            _plusMinusButton.UseVisualStyleBackColor = false;
            _plusMinusButton.Click += PlusMinusButton_Click;
            // 
            // _plusButton
            // 
            _plusButton.BackColor = Color.Firebrick;
            _plusButton.Dock = DockStyle.Fill;
            _plusButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _plusButton.ForeColor = Color.WhiteSmoke;
            _plusButton.Location = new Point(301, 333);
            _plusButton.Margin = new Padding(4, 5, 4, 5);
            _plusButton.Name = "_plusButton";
            _plusButton.Size = new Size(91, 72);
            _plusButton.TabIndex = 19;
            _plusButton.Text = "+";
            _plusButton.UseVisualStyleBackColor = false;
            _plusButton.Click += PlusButton_Click;
            // 
            // _threeButton
            // 
            _threeButton.BackColor = Color.IndianRed;
            _threeButton.Dock = DockStyle.Fill;
            _threeButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _threeButton.ForeColor = Color.WhiteSmoke;
            _threeButton.Location = new Point(202, 333);
            _threeButton.Margin = new Padding(4, 5, 4, 5);
            _threeButton.Name = "_threeButton";
            _threeButton.Size = new Size(91, 72);
            _threeButton.TabIndex = 18;
            _threeButton.Text = "3";
            _threeButton.UseVisualStyleBackColor = false;
            _threeButton.Click += ThreeButton_Click;
            // 
            // _twoButton
            // 
            _twoButton.BackColor = Color.IndianRed;
            _twoButton.Dock = DockStyle.Fill;
            _twoButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _twoButton.ForeColor = Color.WhiteSmoke;
            _twoButton.Location = new Point(103, 333);
            _twoButton.Margin = new Padding(4, 5, 4, 5);
            _twoButton.Name = "_twoButton";
            _twoButton.Size = new Size(91, 72);
            _twoButton.TabIndex = 17;
            _twoButton.Text = "2";
            _twoButton.UseVisualStyleBackColor = false;
            _twoButton.Click += TwoButton_Click;
            // 
            // _oneButton
            // 
            _oneButton.BackColor = Color.IndianRed;
            _oneButton.Dock = DockStyle.Fill;
            _oneButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _oneButton.ForeColor = Color.WhiteSmoke;
            _oneButton.Location = new Point(4, 333);
            _oneButton.Margin = new Padding(4, 5, 4, 5);
            _oneButton.Name = "_oneButton";
            _oneButton.Size = new Size(91, 72);
            _oneButton.TabIndex = 16;
            _oneButton.Text = "1";
            _oneButton.UseVisualStyleBackColor = false;
            _oneButton.Click += OneButton_Click;
            // 
            // _minusButton
            // 
            _minusButton.BackColor = Color.Firebrick;
            _minusButton.Dock = DockStyle.Fill;
            _minusButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _minusButton.ForeColor = Color.WhiteSmoke;
            _minusButton.Location = new Point(301, 251);
            _minusButton.Margin = new Padding(4, 5, 4, 5);
            _minusButton.Name = "_minusButton";
            _minusButton.Size = new Size(91, 72);
            _minusButton.TabIndex = 15;
            _minusButton.Text = "-";
            _minusButton.UseVisualStyleBackColor = false;
            _minusButton.Click += MinusButton_Click;
            // 
            // _sixButton
            // 
            _sixButton.BackColor = Color.IndianRed;
            _sixButton.Dock = DockStyle.Fill;
            _sixButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _sixButton.ForeColor = Color.WhiteSmoke;
            _sixButton.Location = new Point(202, 251);
            _sixButton.Margin = new Padding(4, 5, 4, 5);
            _sixButton.Name = "_sixButton";
            _sixButton.Size = new Size(91, 72);
            _sixButton.TabIndex = 14;
            _sixButton.Text = "6";
            _sixButton.UseVisualStyleBackColor = false;
            _sixButton.Click += SixButton_Click;
            // 
            // _fiveButton
            // 
            _fiveButton.BackColor = Color.IndianRed;
            _fiveButton.Dock = DockStyle.Fill;
            _fiveButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _fiveButton.ForeColor = Color.WhiteSmoke;
            _fiveButton.Location = new Point(103, 251);
            _fiveButton.Margin = new Padding(4, 5, 4, 5);
            _fiveButton.Name = "_fiveButton";
            _fiveButton.Size = new Size(91, 72);
            _fiveButton.TabIndex = 13;
            _fiveButton.Text = "5";
            _fiveButton.UseVisualStyleBackColor = false;
            _fiveButton.Click += FiveButton_Click;
            // 
            // _fourButton
            // 
            _fourButton.BackColor = Color.IndianRed;
            _fourButton.Dock = DockStyle.Fill;
            _fourButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _fourButton.ForeColor = Color.WhiteSmoke;
            _fourButton.Location = new Point(4, 251);
            _fourButton.Margin = new Padding(4, 5, 4, 5);
            _fourButton.Name = "_fourButton";
            _fourButton.Size = new Size(91, 72);
            _fourButton.TabIndex = 12;
            _fourButton.Text = "4";
            _fourButton.UseVisualStyleBackColor = false;
            _fourButton.Click += FourButton_Click;
            // 
            // _multiplicationButton
            // 
            _multiplicationButton.BackColor = Color.Firebrick;
            _multiplicationButton.Dock = DockStyle.Fill;
            _multiplicationButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _multiplicationButton.ForeColor = Color.WhiteSmoke;
            _multiplicationButton.Location = new Point(301, 169);
            _multiplicationButton.Margin = new Padding(4, 5, 4, 5);
            _multiplicationButton.Name = "_multiplicationButton";
            _multiplicationButton.Size = new Size(91, 72);
            _multiplicationButton.TabIndex = 11;
            _multiplicationButton.Text = "x";
            _multiplicationButton.UseVisualStyleBackColor = false;
            _multiplicationButton.Click += MultiplyButton_Click;
            // 
            // _nineButton
            // 
            _nineButton.BackColor = Color.IndianRed;
            _nineButton.Dock = DockStyle.Fill;
            _nineButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _nineButton.ForeColor = Color.WhiteSmoke;
            _nineButton.Location = new Point(202, 169);
            _nineButton.Margin = new Padding(4, 5, 4, 5);
            _nineButton.Name = "_nineButton";
            _nineButton.Size = new Size(91, 72);
            _nineButton.TabIndex = 10;
            _nineButton.Text = "9";
            _nineButton.UseVisualStyleBackColor = false;
            _nineButton.Click += NineButton_Click;
            // 
            // _eightButton
            // 
            _eightButton.BackColor = Color.IndianRed;
            _eightButton.Dock = DockStyle.Fill;
            _eightButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _eightButton.ForeColor = Color.WhiteSmoke;
            _eightButton.Location = new Point(103, 169);
            _eightButton.Margin = new Padding(4, 5, 4, 5);
            _eightButton.Name = "_eightButton";
            _eightButton.Size = new Size(91, 72);
            _eightButton.TabIndex = 9;
            _eightButton.Text = "8";
            _eightButton.UseVisualStyleBackColor = false;
            _eightButton.Click += EightButton_Click;
            // 
            // _sevenButton
            // 
            _sevenButton.BackColor = Color.IndianRed;
            _sevenButton.Dock = DockStyle.Fill;
            _sevenButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _sevenButton.ForeColor = Color.WhiteSmoke;
            _sevenButton.Location = new Point(4, 169);
            _sevenButton.Margin = new Padding(4, 5, 4, 5);
            _sevenButton.Name = "_sevenButton";
            _sevenButton.Size = new Size(91, 72);
            _sevenButton.TabIndex = 8;
            _sevenButton.Text = "7";
            _sevenButton.UseVisualStyleBackColor = false;
            _sevenButton.Click += SevenButton_Click;
            // 
            // _divisionButton
            // 
            _divisionButton.BackColor = Color.Firebrick;
            _divisionButton.Dock = DockStyle.Fill;
            _divisionButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _divisionButton.ForeColor = Color.WhiteSmoke;
            _divisionButton.Location = new Point(301, 87);
            _divisionButton.Margin = new Padding(4, 5, 4, 5);
            _divisionButton.Name = "_divisionButton";
            _divisionButton.Size = new Size(91, 72);
            _divisionButton.TabIndex = 7;
            _divisionButton.Text = "÷";
            _divisionButton.UseVisualStyleBackColor = false;
            _divisionButton.Click += DivisionButton_Click;
            // 
            // _squareRootButton
            // 
            _squareRootButton.BackColor = Color.Firebrick;
            _squareRootButton.Dock = DockStyle.Fill;
            _squareRootButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _squareRootButton.ForeColor = Color.WhiteSmoke;
            _squareRootButton.Location = new Point(202, 87);
            _squareRootButton.Margin = new Padding(4, 5, 4, 5);
            _squareRootButton.Name = "_squareRootButton";
            _squareRootButton.Size = new Size(91, 72);
            _squareRootButton.TabIndex = 6;
            _squareRootButton.Text = "√";
            _squareRootButton.UseVisualStyleBackColor = false;
            _squareRootButton.Click += SquareRootButton_Click;
            // 
            // _powerOfTwoButton
            // 
            _powerOfTwoButton.BackColor = Color.Firebrick;
            _powerOfTwoButton.Dock = DockStyle.Fill;
            _powerOfTwoButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _powerOfTwoButton.ForeColor = Color.WhiteSmoke;
            _powerOfTwoButton.Location = new Point(103, 87);
            _powerOfTwoButton.Margin = new Padding(4, 5, 4, 5);
            _powerOfTwoButton.Name = "_powerOfTwoButton";
            _powerOfTwoButton.Size = new Size(91, 72);
            _powerOfTwoButton.TabIndex = 5;
            _powerOfTwoButton.Text = "x²";
            _powerOfTwoButton.UseVisualStyleBackColor = false;
            _powerOfTwoButton.Click += PowerOfTwoButton_Click;
            // 
            // _oneByXButton
            // 
            _oneByXButton.BackColor = Color.Firebrick;
            _oneByXButton.Dock = DockStyle.Fill;
            _oneByXButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _oneByXButton.ForeColor = Color.WhiteSmoke;
            _oneByXButton.Location = new Point(4, 87);
            _oneByXButton.Margin = new Padding(4, 5, 4, 5);
            _oneByXButton.Name = "_oneByXButton";
            _oneByXButton.Size = new Size(91, 72);
            _oneByXButton.TabIndex = 4;
            _oneByXButton.Text = "1/x";
            _oneByXButton.UseVisualStyleBackColor = false;
            _oneByXButton.Click += OneOfXButton_Click;
            // 
            // _backspaceButton
            // 
            _backspaceButton.BackColor = Color.Firebrick;
            _backspaceButton.Dock = DockStyle.Fill;
            _backspaceButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _backspaceButton.ForeColor = Color.WhiteSmoke;
            _backspaceButton.Location = new Point(301, 5);
            _backspaceButton.Margin = new Padding(4, 5, 4, 5);
            _backspaceButton.Name = "_backspaceButton";
            _backspaceButton.Size = new Size(91, 72);
            _backspaceButton.TabIndex = 3;
            _backspaceButton.Text = "<-";
            _backspaceButton.UseVisualStyleBackColor = false;
            _backspaceButton.Click += BackspaceButton_Click;
            // 
            // _cButton
            // 
            _cButton.BackColor = Color.Firebrick;
            _cButton.Dock = DockStyle.Fill;
            _cButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _cButton.ForeColor = Color.WhiteSmoke;
            _cButton.Location = new Point(202, 5);
            _cButton.Margin = new Padding(4, 5, 4, 5);
            _cButton.Name = "_cButton";
            _cButton.Size = new Size(91, 72);
            _cButton.TabIndex = 2;
            _cButton.Text = "C";
            _cButton.UseVisualStyleBackColor = false;
            _cButton.Click += CButton_Click;
            // 
            // _ceButton
            // 
            _ceButton.BackColor = Color.Firebrick;
            _ceButton.Dock = DockStyle.Fill;
            _ceButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _ceButton.ForeColor = Color.WhiteSmoke;
            _ceButton.Location = new Point(103, 5);
            _ceButton.Margin = new Padding(4, 5, 4, 5);
            _ceButton.Name = "_ceButton";
            _ceButton.Size = new Size(91, 72);
            _ceButton.TabIndex = 1;
            _ceButton.Text = "CE";
            _ceButton.UseVisualStyleBackColor = false;
            _ceButton.Click += CeButton_Click;
            // 
            // _percentButton
            // 
            _percentButton.BackColor = Color.Firebrick;
            _percentButton.Dock = DockStyle.Fill;
            _percentButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _percentButton.ForeColor = Color.WhiteSmoke;
            _percentButton.Location = new Point(4, 5);
            _percentButton.Margin = new Padding(4, 5, 4, 5);
            _percentButton.Name = "_percentButton";
            _percentButton.Size = new Size(91, 72);
            _percentButton.TabIndex = 0;
            _percentButton.Text = "%";
            _percentButton.UseVisualStyleBackColor = false;
            _percentButton.Click += PercentButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(19F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(396, 556);
            Controls.Add(ButtonsPanel);
            Controls.Add(_screenTextBox);
            Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 9, 8, 9);
            Name = "MainForm";
            Text = "Calculator";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox _screenTextBox;
        private TableLayoutPanel ButtonsPanel;
        private Button _percentButton;
        private Button _equalsButton;
        private Button _dotButton;
        private Button _zeroButton;
        private Button _plusMinusButton;
        private Button _plusButton;
        private Button _threeButton;
        private Button _twoButton;
        private Button _oneButton;
        private Button _minusButton;
        private Button _sixButton;
        private Button _fiveButton;
        private Button _fourButton;
        private Button _multiplicationButton;
        private Button _nineButton;
        private Button _eightButton;
        private Button _sevenButton;
        private Button _divisionButton;
        private Button _squareRootButton;
        private Button _powerOfTwoButton;
        private Button _oneByXButton;
        private Button _backspaceButton;
        private Button _cButton;
        private Button _ceButton;
    }
}
