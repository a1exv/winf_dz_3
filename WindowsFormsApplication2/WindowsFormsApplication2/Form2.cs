using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        tovar temp;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(tovar t, bool addnew)
        {
            temp = t;
            InitializeComponent();
            if (addnew == true)
            {
                button1.Text = "Add";

            }
            else
            {
                button1.Text = "Edit";
                textBox1.Text = t.Name;
                textBox2.Text = t.Descr;
                textBox3.Text = t.Price.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || textBox1.Text == String.Empty || textBox1.Text == String.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                temp.Name = textBox1.Text;
                temp.Descr = textBox2.Text;
                temp.Price = Convert.ToInt32(textBox3.Text);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
