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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 mainForm;

        public Form2(Form1 mainForm)        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)        {
            if (this.textBox1.Text != string.Empty)         {

                string[] stringsEntered = textBox1.Lines;

                for (int count = 0; count < stringsEntered.Length; count++)                {
                    mainForm.listBox1.Items.Add(stringsEntered[count]);
                    }
            }
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) Form2.ActiveForm.AcceptButton = null;
            else Form2.ActiveForm.AcceptButton = button1;
        }
    }
}
