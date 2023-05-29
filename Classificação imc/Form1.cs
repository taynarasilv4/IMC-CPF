namespace Classificação_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


  
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }void button1_Click(object sender, EventArgs e)
        {
           string nome = tx_Nome.Text;
           string cpf = tx_CPF.Text;
           int idade = Convert.ToInt32(tx_Idade.Text);
           string sexo = tx_Sexo.Text;
           double peso = Convert.ToDouble(tx_Peso.Text);
           double altura = Convert.ToDouble(tx_Altura.Text);
           Pessoa p = new Pessoa(nome,cpf,idade,sexo,peso,altura);
           (double a, string b, string c) = p.CalcularIMC();
           tx_Calcular.Text = $"O IMC é: {a.ToString("0.00")}\n A Classificacao é: {b}\n  Grau é: {c}\n";
           bool resultadocpf = Validacoes.ValidaCPF(cpf);
           MessageBox.Show(resultadocpf.ToString());


        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}