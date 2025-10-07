using Domains;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace ExaminationSystem.Admin
{
    public partial class AdminMainPage : Form
    {
        private readonly User _user;
        private readonly IServiceProvider _serviceProvider;

        public AdminMainPage(User user, IServiceProvider serviceProvider)
        {
            _user = user ?? throw new ArgumentNullException(nameof(user));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            InitializeComponent();
        }

        private void AdminMainPage_Load(object sender, EventArgs e)
        {
            lbAdminName.Text = _user.FullName;
        }

        private void btnLogou_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Hide();

                // إنشاء login form من خلال DI
                var loginForm = ActivatorUtilities.CreateInstance<LoginForm>(_serviceProvider);

                // لما تتقفل صفحة اللوجن، تتقفل الفورم دي كمان
                loginForm.FormClosed += (s, args) => Close();

                loginForm.Show();
            }
        }
    }
}
