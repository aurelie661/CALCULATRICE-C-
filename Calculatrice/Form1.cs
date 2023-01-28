namespace Calculatrice
{
    public partial class Calculatrice : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Calculatrice()
        {
            InitializeComponent();

        }

        private void Button_Click_Number(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
            {
                textBoxResult.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ",")
            {
                if (!textBoxResult.Text.Contains(','))
                {
                    textBoxResult.Text += button.Text;
                }
            }else
            textBoxResult.Text += button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0 )
            {
                buttonEquals.PerformClick();
                operationPerformed = button.Text;
                //labelOperationResult.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Convert.ToDouble(textBoxResult.Text);
                //labelOperationResult.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }          
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void ButtonClearE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultValue = 0;
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBoxResult.Text = (resultValue + Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultValue - Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resultValue * Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultValue / Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Convert.ToDouble(textBoxResult.Text);
            labelOperationResult.Text = " ";
        }
        
    }
}