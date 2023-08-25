using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01BASIC
{
    public partial class winform : Form
    {

        
        public winform()
        {
            InitializeComponent();
        }

        private void PortNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("HELLO WORLD");
            //Console.WriteLine("sender : " + sender);
            //Console.WriteLine("EventArgs : " + e);
            ComboBox cb = (ComboBox)sender;
            Console.Write("Selected Idx : " + cb.SelectedIndex+"  ");
            Console.WriteLine("Selected Value : " + cb.Items[cb.SelectedIndex]);

        }

        private void conn_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Conn_Btn Click : "+ this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString());
            ;
            if (PortNumber.SelectedItem != null)
            {
                string selectedItem = PortNumber.SelectedItem.ToString();
                textBox1.Text = selectedItem;
            }
        }


        private void View_area(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            Console.WriteLine("LED_01 ON");
            textBox1.Text = "LED_01 ON";

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 OFF");
            textBox1.Text = "LED_01 OFF";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 ON");
            textBox1.Text = "LED_02 ON";
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 OFF");
            textBox1.Text = "LED_02 OFF";
        }
    }
}
