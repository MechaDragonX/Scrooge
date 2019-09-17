using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotnetRPC;

namespace Scrooge
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            button1.Click += (s, e) =>
            {
                var admin = false;
                using (var identity = WindowsIdentity.GetCurrent())
                {
                    var principal = new WindowsPrincipal(identity);
                    admin = principal.IsInRole(WindowsBuiltInRole.Administrator);
                }

                var asx = new AsyncExecutor();
                RPC pres = new RPC(textBox1.Text);
                asx.Execute(pres.StartAsync(admin));
            };
        }
    }
}
