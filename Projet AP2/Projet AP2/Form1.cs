namespace Projet_AP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Connexion à la base de données
            Globale.cnx = new System.Data.SqlClient.SqlConnection();
            Globale.cnx.ConnectionString = "Data Source=BTS2021-17\\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True";
            Globale.cnx.Open();
        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {
            if(tb_user.Text == "a" && tb_mdp.Text == "a")
            {
                new Form2().Show();
                this.Hide();
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