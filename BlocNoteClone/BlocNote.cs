using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocNoteClone
{
    public partial class BlocNote : Form
    {
        public string? copieText;
        public string? file;
        public BlocNote()
        {
            InitializeComponent();
            this.Text = "untitle " + ".txt" + " - notepad";
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copieText = contain_text.SelectedText;
            contain_text.SelectedText = "";
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Fait avec le language C#");
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choississez un fichier ";
            ofd.DefaultExt = "txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                contain_text.Text = sr.ReadToEnd(); ;
                this.Text = ofd.FileName;
            }
        }

        private void BlocNote_Load(object sender, EventArgs e)
        {

        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contain_text.Text = "";
            this.Text = "untitle " + ".txt" + " - notepad";
        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text == "untitle " + ".txt" + " - notepad")
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Title = "Sauvegarder fichier texte";
                saveDialog.Filter = "Text Files (*.txt)|*.txt" + "|" +
                                    "All Files (*.*)|*.*";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    file = saveDialog.FileName;
                    this.Text = file;
                    StreamWriter fichier = new StreamWriter(file);
                    fichier.Write(contain_text.Text);
                   
                }
            }
            else
            {
                    StreamWriter fichier = new StreamWriter(file);
                    fichier.Write(contain_text.Text);
                
            }

        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copieText = contain_text.SelectedText;
        }

        private void collerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            contain_text.Text = contain_text.Text + copieText;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
