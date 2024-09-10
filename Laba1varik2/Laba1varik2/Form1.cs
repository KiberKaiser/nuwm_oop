namespace Laba1varik2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {   
            if (!double.TryParse(textBoxRadius.Text, out double R) || R <= 0)
            {
                MessageBox.Show("Введіть коректне числове значення для радіуса (тільки позитивні числа і без літер).", "Некоректний ввід", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double formula = (4 / 3 * Math.PI) * Math.Pow(R, 3);
            textBoxVolume.Text = formula.ToString();
        
        }      
    }
}