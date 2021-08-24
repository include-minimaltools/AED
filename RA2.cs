using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AED
{
    public partial class RA2 : Form
    {
        int n = 0, size, i, pos, x, x2;
        int[] Age, Id;
        string[] Names;
        public RA2()
        {
            InitializeComponent();
        }

        private void RA2_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            size = int.Parse(txtCount.Text);
            Id = new int[size];
            Age = new int[size];
            Names = new string[size];
            n = 0;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (n > 0)
            {
                x2 = int.Parse(txtId.Text);
                pos = Search(x2);
                if (pos <= -1)
                    MessageBox.Show(x2 + " no esta registrado");
                else
                {
                    txtAge.Text = Age[pos].ToString();
                    txtName.Text = Names[pos];
                    btnUpdate.Enabled = true;
                }
            }
            else
                MessageBox.Show("No hay registros");
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            lbPrint.Items.Clear();
            for (i = 0; i < n; i++)
                lbPrint.Items.Add(Id[i] + "\t" + Names[i] + "\t" + Age[i]);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Update();
            btnUpdate.Enabled = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            x = int.Parse(txtId.Text);
            Delete(x);
            Clean();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            x = int.Parse(txtId.Text);
            Insert(x);
            Clean();
            
        }
        
        void Clean()
        {
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
        }

        int Search(int x)
        {
            i = 0;

            while (i < n && Id[i] < x)
                i++;

            if (i >= n || Id[i] > x)
                pos = -i;
            else
                pos = i;

            return pos;
        }

        void Delete(int x)
        {
            if (n > 0)
            {
                x = int.Parse(txtId.Text);
                pos = Search(x);

                if (pos <= -1)
                    MessageBox.Show(x + " no esta registrado");
                else
                {
                    for (i = pos; i < n - 1; i++)
                    {
                        Id[i] = Id[i + 1];
                        Names[i] = Names[i + 1];
                        Age[i] = Age[i + 1];
                    }
                    n--;
                    MessageBox.Show("La persona con id=" + x + " se ha eliminado");
                }
            }
            else
                MessageBox.Show("No hay registros");
        }

        void Insert(int x)
        {
            if(n > 0)
            {
                if (n <= size - 1)
                {
                    pos = Search(x);
                    if (pos > 0)
                        MessageBox.Show("El elemento ya existe");
                    else
                    {
                        pos *= -1;
                        for (i = n; i >= pos + 1; i--)
                        {
                            Id[i] = Id[i - 1];
                            Names[i] = Names[i - 1];
                            Age[i] = Age[i - 1];
                        }

                        Id[pos] = int.Parse(txtId.Text);
                        Age[pos] = int.Parse(txtAge.Text);
                        Names[pos] = txtName.Text;
                        n++;
                        MessageBox.Show("Elemento insertado");
                    }
                }
                else
                    MessageBox.Show("No hay espacio");
            }
            else
            {
                Id[n] = int.Parse(txtId.Text);
                Age[n] = int.Parse(txtAge.Text);
                Names[n] = txtName.Text;
                n++;
                MessageBox.Show("Elemento Insertado");
            }
        }

        void Update()
        {
            x = int.Parse(txtId.Text);
            Delete(x);
            Insert(x);
        }
        
    }
}
