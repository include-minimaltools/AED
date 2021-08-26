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
    public partial class RA5 : Form
    {
        Student[] Registry;
        int n;

        public RA5()
        {
            InitializeComponent();
        }

        #region Events
        private void RA5_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 30; i++)
                cbDay.Items.Add(i);
            
            
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                int tam;
                if (int.TryParse(txtElements.Text, out tam))
                    Registry = new Student[tam];
                else
                    Registry = null;
                n = 0;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Add();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateStudent();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                ShowInfo();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        #endregion

        #region Methods
        private void Add()
        {
            if (!VerificateSpace())
                return;

            RegisterStudent(n);

            Clean();
            n++;
        }

        private void Delete()
        {
            string id = txtIdCard.Text;
            int index = GetIndexStudent(id);

            if (index == -1)
            {
                MessageBox.Show(id + " no está registrado");
                return;
            }
            
            for(int k = index; k < n; k++)
                Registry[k] = Registry[k + 1];

            Clean();
            ShowInfo();
            n--;
            MessageBox.Show("El estudiante con el carnet " + id + " se ha eliminado");
        }

        private void RegisterStudent(int index)
        {
            Registry[index] = new Student()
            {
                IdCard = txtIdCard.Text,
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Sex = cbSex.Text,
                Birth = new Date()
                {
                    Day = int.Parse(cbDay.Text),
                    Month = cbMonth.Text,
                    Age = int.Parse(txtAge.Text)
                }
            };
        }

        private bool VerificateSpace()
        {
            if (n > Registry.Length - 1)
            {
                MessageBox.Show("No hay espacio");
                return false;
            }
            return true;
        }
    
        private int GetIndexStudent(string id)
        {
            int i;

            for (i = 0; i < n && id != Registry[i].IdCard; i++) ;

            if (id == Registry[i].IdCard)
                return i;
            else
                return -1;

        }

        private void UpdateStudent()
        {
            string id = txtIdCard.Text;
            int index = GetIndexStudent(id);

            if (index >= n)
            {
                MessageBox.Show(id + " no está registrado");
                return;
            }

            RegisterStudent(index);
            Clean();
            MessageBox.Show($"El estudiante con carnet {id} se ha actualizado");
        }

        private void ShowInfo()
        {
            lbConsole.Items.Clear();
            lbConsole.Items.Add("Carnet\t\tNombre\t\tApellidos\t\tNacimiento");

            foreach(Student item in Registry)
            {
                if(item != null)
                    lbConsole.Items.Add($"{item.IdCard}\t\t{item.Name}\t\t{item.LastName}\t\t{item.Birth.Day}-{item.Birth.Month}-{item.Birth.Age}");
            }

        }

        private void Clean()
        {
            txtIdCard.Clear();
            txtName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
        }
        #endregion
    }
}