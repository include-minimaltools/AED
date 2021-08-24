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
    public partial class RA3 : Form
    {
        int[] numbers;
        int n = 0, comparisons = 0, movements = 0;
        public RA3()
        {
            InitializeComponent();
        }

        private void RA3_Load(object sender, EventArgs e)
        {
            cbOrderMethods.Items.Add("Burbuja menor");
            cbOrderMethods.Items.Add("Burbuja mayor");
            cbOrderMethods.Items.Add("Burbuja por señal");
            cbOrderMethods.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CbOrderMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNumbers();

            if (cbOrderMethods.SelectedIndex == 0)
                MinorBubble();
            else if (cbOrderMethods.SelectedIndex == 1)
                MajorBubble();
            else if (cbOrderMethods.SelectedIndex == 2)
                SignBubble();
            else if (cbOrderMethods.SelectedIndex == 3)
                ShakerSort();
            else if (cbOrderMethods.SelectedIndex == 4)
                DirectInsert();
            else if (cbOrderMethods.SelectedIndex == 5)
                Shell();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOrderResult.Clear();
            lbNumbers.Items.Clear();
            lblElements.Text = "Elementos ingresados: 0";
            lblMovements.Text = "Movimientos: 0";
            lblComparisons.Text = "Comparacionies: 0";
        }

        private void TxtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
            {
                txtInput.Clear();
                return;
            }

            int newNumber;

            if (!int.TryParse(txtInput.Text, out newNumber))
                MessageBox.Show("No se ha ingresado un número");

            else
            {
                lbNumbers.Items.Add(newNumber);
                lblElements.Text = "Elementos ingresados: " + lbNumbers.Items.Count;
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void DirectInsert()
        {
            for(int i = 1; i < n; i++)
            {
                int temp = numbers[i];
                int k = i - 1;

                while((k >= 0) && (temp < numbers[k]))
                {
                    numbers[k + 1] = numbers[k];
                    k = k - 1;
                }

                numbers[k + 1] = temp;
            }
        }

        private void Shell()
        {
            bool hasChange;
            int inta = n;

            while(inta > 0)
            {
                inta /= 2;
                hasChange = true;
                while(hasChange)
                {
                    hasChange = false;
                    inta = 0;
                    for(int i = 0; (inta + inta) <= (n - 1); i++)
                    {
                        if (numbers[i] > numbers[i + inta])
                        {
                            InvertPosition(i, i + inta);
                        }
                    }
                }
            }

        }

        private void ShakerSort()
        {
            int left = 1, right = n - 1, k = right;

            while(right >= left)
            {
                for(int i = right; i >= left; i--)
                {
                    if(numbers[i - 1] > numbers[i])
                    {
                        InvertPosition(i - 1, i);
                        k = i;
                    }
                }
                left = k + 1;
                for (int i = left; i <= right; i++)
                {
                    if (numbers[i - 1] > numbers[i])
                    {
                        InvertPosition(i - 1, i);
                        k = i;
                    }
                }
                right = k - 1;
            }
        }

        private void InvertPosition(int pos1, int pos2)
        {
            int temp;
            temp = numbers[pos1];
            numbers[pos1] = numbers[pos2];
            numbers[pos2] = temp;
        }

        private void SetNumbers()
        {
            n = comparisons = movements = 0;
            foreach (int item in lbNumbers.Items)
            {
                Array.Resize(ref numbers, n + 1);
                numbers[n] = item;
                n++;
            }
        }

        private void SignBubble()
        {
            txtOrderResult.Clear();

            bool isFinish = false;
            for(int i = 0; i < n - 1 && isFinish == false; i++)
            {
                isFinish = true;
                for(int j = 0; j < n - 1; j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                        int aux = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = aux;
                        isFinish = false;
                        movements++;
                    }
                    comparisons++;
                    Print();
                }
            }
        }

        private void MajorBubble()
        {
            n = comparisons = movements = 0;
            foreach (int item in lbNumbers.Items)
            {
                Array.Resize(ref numbers, n + 1);
                numbers[n] = item;
                n++;
            }

            txtOrderResult.Clear();

            for(int i = n - 1; i > 0; i --)
            {
                for(int j = 0; j < i; j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                        int aux = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = aux;
                        movements++;
                    }
                    comparisons++;
                    Print();
                }
            }
        }

        private void MinorBubble()
        {
            n = comparisons = movements = 0;

            foreach (int item in lbNumbers.Items)
            {
                Array.Resize(ref numbers, n + 1);
                numbers[n] = item;
                n++;
            }

            txtOrderResult.Clear();

            for(int i = 1; i < n; i++)
            {
                for(int j = n - 1; j > 0; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        int aux = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = aux;
                        movements++;
                    }
                    comparisons++;
                    Print();
                }
            }
        }

        private void Print()
        {
            foreach (int number in numbers)
                txtOrderResult.Text += number + " ";
            txtOrderResult.Text += "\r\n";

            lblMovements.Text = "Movimientos: " + movements;
            lblComparisons.Text = "Comparaciones " + comparisons;
        }
    }
}