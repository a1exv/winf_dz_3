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
   
    public partial class Form1 : Form
    {
        List<tovar> tovars = new List<tovar>();
        int total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tovar tov = new tovar();
            Form2 addform = new Form2(tov, true);
            addform.ShowDialog();
            tovars.Add(tov);
            comboBox1.Items.Add(tov);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int n = comboBox1.SelectedIndex;
                tovar tmp = (tovar)comboBox1.SelectedItem;
                Form2 editform = new Form2(tmp, false);
                editform.ShowDialog();
                comboBox1.Items.RemoveAt(n);
                
                comboBox1.Items.Insert(n, tmp);
                comboBox1.SelectedItem = comboBox1.Items[0];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listBox1.Items.Add(comboBox1.SelectedItem);
                tovar tmp = (tovar)comboBox1.SelectedItem;
                textBox1.Text = tmp.Price.ToString();
                total += tmp.Price;
                textBox2.Text = total.ToString();
            }
         
        }
    }
    public class tovar
    {
        public string Name { get; set; }
        public string Descr { get; set; }
        public int Price { get; set; }
        public tovar()
        {
            Name = "unknown";
            Descr = "unknown";
            Price = 0;
        }
        public tovar(string name, string descr, int price)
        {
            Name = name;
            Descr = descr;
            Price = price;
        }
        public override string ToString()
        {
            return string.Format(Name + " " + Descr);
        }
    }
}
