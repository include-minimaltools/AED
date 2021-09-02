using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AED
{
    public partial class RA7 : Form
    {
        Queue<string> MyQueue = new Queue<string>();

        public RA7()
        {
            InitializeComponent();
        }

        #region Events
        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Add();
        }

        private void rbPeek_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPeek.Checked == true)
            {
                lbPrint.Items.Add("Primer elemento en pila : " + MyQueue.Peek());
                lbRowCopy.Items.Clear();

                foreach (var Item in MyQueue)
                {
                    lbRowCopy.Items.Add(Item);
                    lbRowCopy.Items.Add("------");
                }
            }
        }

        private void rbDequeue_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbPop.Checked == true)
                {
                    lbPrint.Items.Add("Dequeue : " + MyQueue.Dequeue());
                    lbRowCopy.Items.Clear();

                    foreach (var Item in MyQueue)
                    {
                        lbRowCopy.Items.Add(Item);
                        lbRowCopy.Items.Add("------");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void rbCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCopy.Checked == true)
            {
                lbRowCopy.Items.Clear();

                foreach (var Item in MyQueue)
                {
                    lbRowCopy.Items.Add(Item);
                    lbRowCopy.Items.Add("------");
                }
            }
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            lbPrint.Items.Clear();

            foreach (var Item in MyQueue)
            {
                lbPrint.Items.Add(Item);
                lbPrint.Items.Add("------");
            }
        }
        #endregion

        #region Methods
        public void Add()
        {
            MyQueue.Enqueue(txtItem.Text);
            lbPrint.Items.Clear();

            foreach (var Item in MyQueue)
            {
                lbPrint.Items.Add(Item);
                lbPrint.Items.Add("------");
            }

            txtItem.Clear();
            txtItem.Focus();

        }
        #endregion
    }
}
