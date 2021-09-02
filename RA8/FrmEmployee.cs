using AED.RA8.Models;
using System;
using System.Windows.Forms;

namespace AED.RA8
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void TxtUniversity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Add();
        }

        private void Add()
        {
            if (string.IsNullOrEmpty(txtUniversity.Text))
                return;

            Tools.UniversityCatalog.Add(new University() { Name = txtUniversity.Text });
            txtUniversity.Clear();
        }
    }
}
