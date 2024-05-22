namespace Calculadora.WinForms
{
    public partial class CalculadoraForm : Form
    {
        public CalculadoraForm()
        {
            InitializeComponent();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal primeimoNumero = Convert.ToDecimal(txtPrimeiroNumero.Text);
            decimal segundoNumero = Convert.ToDecimal(txtSegundoNumero.Text);
            decimal resutado = 0;

            if (rdbAdicao.Checked)
            {
                resutado = primeimoNumero + segundoNumero;
            }
            lblResultado.Text = resutado.ToString();
        }
    }
}
