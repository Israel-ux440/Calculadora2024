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
            decimal resultado = 0;
            string descricaoOperacao = "";

            if (rdbAdicao.Checked)
            {
                resultado = primeimoNumero + segundoNumero;
                descricaoOperacao = primeimoNumero + " + " + segundoNumero + " = " + resultado;
            }

            else if (rdbSubtracao.Checked)
            {
                resultado = primeimoNumero - segundoNumero;
                descricaoOperacao = primeimoNumero + " - " + segundoNumero + " = " + resultado;
            }

            else if (rdbMultiplicacao.Checked)
            {
                resultado = primeimoNumero * segundoNumero;
                descricaoOperacao = primeimoNumero + " * " + segundoNumero + " = " + resultado;
            }

            else if (rdbDivisao.Checked)
            {
                resultado = primeimoNumero / segundoNumero;
                descricaoOperacao = primeimoNumero + " / " + segundoNumero + " = " + resultado;
            }

            lblResultado.Text = resultado.ToString();
            listHitoricooperacoes.Items.Add(descricaoOperacao);

        }
    }
}
