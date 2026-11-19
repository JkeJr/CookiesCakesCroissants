//using OliveBranchBakes;

namespace CookiesCakesCroissants
{
    public partial class GroupAdminConsoleForm : Form
    {
        public GroupAdminConsoleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OliveBranchBakes.PayesWelcomeForm().Show();
        }
    }
}
