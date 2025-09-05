using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Menu : Form
    {
        private frmMain gameForm;

        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameForm = new frmMain();
            gameForm.ShowDialog(); // Use ShowDialog() pois frmMain não herda de Form
            this.Close();
        }
    }
}
