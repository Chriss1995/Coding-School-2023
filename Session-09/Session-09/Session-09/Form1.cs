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
            txtDisplay.Text += " 2";
            if (_value1 == null)
            {
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
            }
        }
    }
}