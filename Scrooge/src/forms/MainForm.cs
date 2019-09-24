using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrooge
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartForm start = new StartForm();
            start.ShowDialog();
            button1.Click += (s, e) =>
            {
                if
                (
                    !string.IsNullOrWhiteSpace(details.Text) && !string.IsNullOrWhiteSpace(state.Text)
                )
                {
                    Client.SetPresence(details.Text, state.Text);
                }
                else if
                (
                    !string.IsNullOrWhiteSpace(details.Text) && !string.IsNullOrWhiteSpace(state.Text) &&
                    !string.IsNullOrWhiteSpace(lik.Text)
                )
                {
                    Client.SetPresence(details.Text, state.Text, lik.Text);
                }
                else if
                (
                    !string.IsNullOrWhiteSpace(details.Text) && !string.IsNullOrWhiteSpace(state.Text) &&
                    !string.IsNullOrWhiteSpace(lik.Text) && !string.IsNullOrWhiteSpace(lit.Text)
                )
                {
                    Client.SetPresence(details.Text, state.Text, lik.Text, lit.Text);
                }
                else if
                (
                    !string.IsNullOrWhiteSpace(details.Text) && !string.IsNullOrWhiteSpace(state.Text) &&
                    !string.IsNullOrWhiteSpace(lik.Text) && !string.IsNullOrWhiteSpace(lit.Text) &&
                    !string.IsNullOrWhiteSpace(sik.Text)
                )
                {
                    Client.SetPresence(details.Text, state.Text, lik.Text, lit.Text, sik.Text);
                }
                else if
                (
                    !string.IsNullOrWhiteSpace(details.Text) && !string.IsNullOrWhiteSpace(state.Text) &&
                    !string.IsNullOrWhiteSpace(lik.Text) && !string.IsNullOrWhiteSpace(lit.Text) &&
                    !string.IsNullOrWhiteSpace(sik.Text) && !string.IsNullOrWhiteSpace(sit.Text)
                )
                {
                    Client.SetPresence(details.Text, state.Text, lik.Text, lit.Text, sik.Text, sit.Text);
                }
                else
                {
                    MessageBox.Show("The fields are blank!");
                }
            };
        }
    }
}
