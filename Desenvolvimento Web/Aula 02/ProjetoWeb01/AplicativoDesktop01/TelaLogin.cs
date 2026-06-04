namespace AplicativoDesktop01
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = "Ronaldo";
            string senha = "123456";

            bool comparacao1 = textBox1.Text == usuario;
            bool comparacao2 = textBox2.Text == senha;

            if (comparacao1 == comparacao2)
            {
                MessageBox.Show("Usuario e senha corretos!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
