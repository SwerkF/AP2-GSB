namespace Projet_AP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {
            if(tb_user.Text == "Administrateur" && tb_mdp.Text == "Admin123")
            {
                new Form2().Show();
                new Form1().Close();
            }
            else
            {
                MessageBox.Show("Une des données est fausse !");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set to no text.
            tb_mdp.Text = "";
            // The password character is an asterisk.
            tb_mdp.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            tb_mdp.MaxLength = 14;
        }
    }
}