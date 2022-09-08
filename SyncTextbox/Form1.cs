using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncTextbox
{
    public partial class Form1 : Form
    {
        Form1 destiantion;
        public string TextboxText
        {
            set
            {
                textBox1.Text = value;
            }
            get { return textBox1.Text; }
        }
        public Form1(string name, Form1 parent)
        {
            if (parent == null)
            {
                Form1 child = new Form1("Child", this);
                destiantion = child;
                child.Show();
            }
            else
                destiantion = parent;
            InitializeComponent();
            this.Text = name;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            destiantion.TextboxText = textBox1.Text;
        }
    }
}
