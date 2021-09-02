using System;
using System.Windows.Forms;

namespace AED.RA8
{
    public partial class RA8 : Form
    {
        FrmEmployee frmEmployee = new FrmEmployee();
        FrmQuery frmQuery = new FrmQuery();

        public RA8()
        {
            InitializeComponent();

            frmEmployee.MdiParent = frmQuery.MdiParent = this;
            frmEmployee.Dock = frmQuery.Dock = DockStyle.Fill;
        }

        private void TsmiSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea salir del programa?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
                Close();
        }

        private void TsmiEmployee_Click(object sender, EventArgs e)
        {
            frmQuery.Hide();
            frmEmployee.Show();
        }

        private void TsmiQuery_Click(object sender, EventArgs e)
        {
            frmEmployee.Hide();
            frmQuery.Show();
        }
    }
}
