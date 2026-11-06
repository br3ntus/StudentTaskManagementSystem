namespace StudentTaskManagementForm
{
    public partial class EntrySelectionWindow : Form
    {
        public EntrySelectionWindow()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            Show();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Hide();

            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();

            Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}