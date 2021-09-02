using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AED.RA8
{
    public partial class FrmQuery : Form
    {
        public FrmQuery()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            dgvUniversity.DataSource = Tools.UniversityCatalog;
        }
    }
}
