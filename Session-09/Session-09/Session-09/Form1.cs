using Session_09__library;

namespace Session_09
{
    public partial class Form1 : Form
    {
        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;
        private CalcOperation _calcOperation;
        enum CalcOperation
        {
            Addition, 
            Subtraction, 
            Multiplication, 
            Division,
            Power,
            Squared_root
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            start();
            txtDisplay.Text += "1";
            if (_value1 == null)
            {
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            start();
            txtDisplay.Text += "2";
            if (_value1 == null)
            {
                _value1 = 2;
            }
            else
            {
                _value2 = 2;
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            start();
            txtDisplay.Text += "3";
            if (_value1 == null)
            {
                _value1 = 3;
            }
            else
            {
                _value2 = 3;
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            start();
            txtDisplay.Text += "4";
            if (_value1 == null)
            {
                _value1 = 4;
            }
            else
            {
                _value2 = 4;
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            start();
            txtDisplay.Text += "5";
            if (_value1 == null)
            {
                _value1 = 5;
            }
            else
            {
                _value2 = 5;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            start();
            txtDisplay.Text += "6";
            if (_value1 == null)
            {
                _value1 = 6;
            }
            else
            {
                _value2 = 6;
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            start();
            txtDisplay.Text += "7";
            if (_value1 == null)
            {
                _value1 = 7;
            }
            else
            {
                _value2 = 7;
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            start();
            txtDisplay.Text += "8";
            if (_value1 == null)
            {
                _value1 = 8;
            }
            else
            {
                _value2 = 8;
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            start();
            txtDisplay.Text += "9";
            if (_value1 == null)
            {
                _value1 = 9;
            }
            else
            {
                _value2 = 9;
            }
        }
        public void start()
        {
            if (_result != null)
            {
                txtDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " +";
            _calcOperation = CalcOperation.Addition;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " -";
            _calcOperation = CalcOperation.Subtraction;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " *";
            _calcOperation = CalcOperation.Multiplication;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " /";
            _calcOperation = CalcOperation.Division;
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " ^";
            _calcOperation = CalcOperation.Power;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " Sqrt";
            _calcOperation = CalcOperation.Squared_root;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "=";
            switch (_calcOperation)
            {
                case CalcOperation.Addition:
                    Addition addition = new Addition();
                    _result = addition.Do(_value1, _value1);
                    break;
                case CalcOperation.Subtraction:
                    Subtraction subtraction = new Subtraction();
                    _result = subtraction.Do(_value2, _value2);
                    break;
                case CalcOperation.Multiplication:
                    Multiplication multiplication = new Multiplication();
                    _result = multiplication.Do(_value1, _value1);
                     break;
                case CalcOperation.Division:
                    Division division = new Division();
                    _result= division.Do(_value1, _value2);
                    break;
                case CalcOperation.Power:
                    Power power = new Power();
                    _result = power.Do(_value1, _value1);
                    break;
                case CalcOperation.Squared_root:
                    Squared_Root squared_root = new Squared_Root();
                    _result = squared_root.Do(_value1);
                    break;

            }
            txtDisplay.Text = _result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            start();
            txtDisplay.Text += "0";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            start();
            txtDisplay.Text += "0";
            if (_value1 == null)
            {
                _value1 = 0;
            }
            else
            {
                _value2 = 0;
            }
        }
    }
}