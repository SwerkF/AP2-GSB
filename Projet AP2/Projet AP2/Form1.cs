namespace Projet_AP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Globale.cnx = new System.Data.SqlClient.SqlConnection();
            Globale.cnx.ConnectionString = "Data Source=DESKTOP-3COT5C9\\SQLTEST;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True";
            Globale.cnx.Open();

            Globale.lesFamilles = new Dictionary<string, Famille>();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {
            if(tb_user.Text == "a" && tb_mdp.Text == "a")
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
            tb_mdp.Text = "";
            tb_mdp.PasswordChar = '*';
            tb_mdp.MaxLength = 14;
        }
    }
}