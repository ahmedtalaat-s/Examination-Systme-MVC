using BL.Contracts;
using Domains;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.Admin
{
    public partial class ManageUser : Form
    {
        private readonly IAdmin _context;
        private IServiceProvider _serviceProvider;

        private User _user;
        public bool backPressed = false;


        public ManageUser(IAdmin context, User user, IServiceProvider serviceProvider  )
        {
            _context = context;
            InitializeComponent();
            _user = user;
            _serviceProvider = serviceProvider;
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
           
            LoadUsers();
        }

        private void LoadUsers()
        {
            var Users = _context.GetAllUsers();

            // Make sure the DataGridView does not auto-generate columns
            lstStudent.AutoGenerateColumns = false;
            lstStudent.Columns.Clear();

            // Define columns manually

            // Full Name
            lstStudent.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "Full name",
                Width = 150
            });

            // Status
            lstStudent.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                Width = 100
            });

            // Subject
            lstStudent.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Role",
                Width = 150,
                DataPropertyName = "Role"
            });



            // Edit Button
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
            {
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            lstStudent.Columns.Add(editButton);

            // Delete Button
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            lstStudent.Columns.Add(deleteButton);

            // Bind data
            lstStudent.DataSource = Users;

            // Handle displaying Subject name manually


            lstStudent.ReadOnly = true;
            foreach (DataGridViewColumn col in lstStudent.Columns)
            {
                if (col is DataGridViewButtonColumn)
                {
                    col.ReadOnly = false;
                }
            }
            lstStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lstStudent.EnableHeadersVisualStyles = false;
            lstStudent.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            lstStudent.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            lstStudent.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            lstStudent.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            //// Handle button clicks
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            backPressed = true;
            Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            backPressed = true;
            Close();
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            var addSubject = ActivatorUtilities.CreateInstance<AddUser>(_serviceProvider);
            addSubject.Owner = this;
            addSubject.FormClosed += (s, args) => this.LoadUsers();
            addSubject.ShowDialog();
        }
    }
}
