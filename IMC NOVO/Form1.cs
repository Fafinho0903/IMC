namespace IMC_NOVO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double CalcIMC(float peso, float altura)
        {
            double imc;
            float valorPeso = float.Parse(txtVisor.Text);
            float valorAltura = float.Parse(txtVisor2.Text);
            double ResultIMC = valorPeso / Math.Pow(valorAltura, 2);

            if (ResultIMC < 18.5)
            {
                lblSituacao.Text = "Abaixo do Peso";
            }
            if (ResultIMC >= 18.5 && ResultIMC < 24.9)
            {
                lblSituacao.Text = "Peso Normal";
            }
            if (ResultIMC >= 25.0 && ResultIMC < 29.9)
            {
                lblSituacao.Text = "Acima do Peso";
            }
            if (ResultIMC >= 30.0 && ResultIMC < 34.9)
            {
                lblSituacao.Text = "Obesidade I";
            }
            if (ResultIMC >= 35.0 && ResultIMC < 39.9)
            {
                lblSituacao.Text = "Obesidade II";
            }
            if (ResultIMC >= 40.0)
            {
                lblSituacao.Text = "Obesidade III";
            }
            imc = ResultIMC;

            return imc;
        }
        
        private void enter5_Click(object sender, EventArgs e)
        {
            float peso = float.Parse(txtVisor.Text);
            float altura = float.Parse(txtVisor.Text);
            double ResultImc = CalcIMC(peso, altura);
            txtVisor3.Text = ResultImc.ToString("N1");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtVisor.BackColor == Color.Red)
            {
                txtVisor.ResetText();
            }
            if (txtVisor2.BackColor == Color.Red) { }
        }
    }
}