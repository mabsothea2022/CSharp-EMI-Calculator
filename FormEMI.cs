namespace WinFormsApp1
{
    public partial class FormEMI : Form
    {
        private double emi;
        private double p, r;
        private int n;
        private double totalPayment;
        public FormEMI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void termNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }
        private void UpdateOutput()
        {
            //get the input
            GetInput();

            //Processing
            emi = CalculateEmi(p, r, n);
            totalPayment = emi * n;

            //output result to label
            OutputResult(emi, totalPayment);
        }
        private void GetInput()
        {
            p = double.Parse(amountTextBox.Text);
            r = double.Parse(rateTextBox.Text) / 1200;
            n = decimal.ToInt32(termNumericUpDown.Value);
        }
        private double CalculateEmi(double p, double r, int n)
        {
            // (P x r x (1 + r)^n )/((1 + r)^n - 1)
            double emi = (p * r * (Math.Pow((1 + r), n))) / (Math.Pow((1 + r), n) - 1);
            return emi;
        }
        private void OutputResult(double emi, double payment)
        {
            // output result to label
            outputLabel.Text = "Payment/month is:" + emi.ToString("00.00") + "\r\nTotal Payment is:" + payment.ToString("00.00");
        }
    }
}