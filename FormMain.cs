namespace LB1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                labelUsers.Text = "Список пользователей: ";

                foreach (var user in users)
                {
                    LabelInfAboutUsers.Text += ( $"{user.Id}.{user.Name} - {user.Age}\n");
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelUsers_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelUsers_Click_1(object sender, EventArgs e)
        {

        }
    }
}
