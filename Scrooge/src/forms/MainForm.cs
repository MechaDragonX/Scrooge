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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            button1.Click += (s, e) =>
            {
                MessageBox.Show("I'm wired up as well.");
            };
        }
    }
}
