using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScroogeDesktop
{
    public partial class Form1 : Form
    {
        public Button button1;
        public Form1()
        {
            // Just some From test stuffs
            button1 = new Button();
            button1.Size = new Size(40, 40);
            button1.Location = new Point(30, 30);
            button1.Text = "Click me";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(button1_Click);
            button1.Click += (s, e) =>
            {
                MessageBox.Show("I'm wired up as well.");
                ((Button)s).Click -= button1_Click;
            };
            EventHandler clickHandler = (s, e) =>
            {
                MessageBox.Show(s.ToString());
                MessageBox.Show("Another set up for event handlers.");

            };
            button1.Click += clickHandler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
