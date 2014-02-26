using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)      // Диалог открытия файла
        {
            OpenFileDialog ofd = new OpenFileDialog() {
                Filter = "Список книг|*.xml" };
            var result = ofd.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)      // Диалог сохранения файла
        {
            SaveFileDialog sfd = new SaveFileDialog()   {
                Filter = "Список книг|*.xml"};
            var result = sfd.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 subForm = new Form2(this);
            subForm.Show();
        }
    }

}
