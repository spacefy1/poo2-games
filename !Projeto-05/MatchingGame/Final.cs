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
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // Pega o formulário da coleção.
                Form form = Application.OpenForms[i];

                // Verifica se o formulário não é o formulário principal (o que contém o botão).
                // Isso impede que a aplicação feche por completo, a menos que seja o que você deseja.
                if (form.Name != this.Name)
                {
                    // Fecha o formulário.
                    form.Close();
                }
            }
    }
}
