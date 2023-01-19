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
           if (_result != null)
            {
                txtDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result= null;
            }
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
            if (_result != null)
            {
                txtDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
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
            if (_result != null)
            {
                txtDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
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
            if (_result != null)
            {
                txtDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
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
            if (_result != null)
            {
                txtDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
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
            if (_result != null)
            {
                txtDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
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
            if (_result != null)
            {
                txtDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
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
            if (_result != null)
            {
                txtDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
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
            if (_result != null)
            {
                txtDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
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
    }
}