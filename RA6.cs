using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AED
{
    public partial class RA6 : Form
    {
        Stack<string> MyStack = new Stack<string>();

        public RA6()
        {
            InitializeComponent();
        }

        #region Events
        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Add();
        }

        private void rbPop_CheckedChanged(object sender, EventArgs e)
        {
            try {
                if (rbPop.Checked == true)
                {
                    lbPrint.Items.Add("Popping / Desapilar : " + MyStack.Pop());
                    lbRowCopy.Items.Clear();

                    foreach (var Item in MyStack)
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

        private void rbPeek_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPeek.Checked == true)
            {
                lbPrint.Items.Add("Primer elemento en pila : " + MyStack.Peek());
                lbRowCopy.Items.Clear();

                foreach (var Item in MyStack)
                {
                    lbRowCopy.Items.Add(Item);
                    lbRowCopy.Items.Add("------");
                }
            }
        }

        private void rbCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCopy.Checked == true)
            {
                lbRowCopy.Items.Clear();

                foreach (var Item in MyStack)
                {
                    lbRowCopy.Items.Add(Item);
                    lbRowCopy.Items.Add("------");
                }
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            lbPrint.Items.Clear();

            foreach (var Item in MyStack)
            {
                lbPrint.Items.Add(Item);
                lbPrint.Items.Add("------");
            }
        }
        #endregion

        #region Methods
        public void Add()
        {
            MyStack.Push(txtItem.Text);
            lbPrint.Items.Clear();

            foreach (var Item in MyStack)
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
