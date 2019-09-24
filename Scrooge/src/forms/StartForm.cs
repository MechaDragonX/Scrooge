using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrooge
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            bool success;
            button1.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Textbox is blank!");
                    textBox1.Text = "";
                }
                else
                {
                    success = Client.Start(textBox1.Text);
                    if (!success)
                    {
                        MessageBox.Show("Connection Failed!\nPlease try again!");
                        textBox1.Text = "";
                    }
                    else
                    {
                        this.Close();
                    }
                }
            };
        }
    }
}
