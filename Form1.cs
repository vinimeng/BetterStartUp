using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterStartUp
{
    public partial class BetterStartUp : Form
    {
        private RegistryKey key;

        public struct Programa
        {
            public string nome; // Nome para exibição.
            public string caminho; // Caminho completo para executável.
            public int ordem; // Inteiro com a ordem que deve ser executado.
            public int delay; // Inteiro com delay em segundos.
            public override string ToString()
            {
                return nome;
            }
        };

        public BetterStartUp()
        {
            InitializeComponent();
            key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            if (key != null)
            {
                foreach (string valor in key.GetValueNames())
                {
                    listBoxWindows.Items.Add(valor);
                }
            }
            key.Close();
            openFileAddPrograma.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void btnWindowsAddBetterStartUp_Click(object sender, EventArgs e)
        {
            if (!listBoxWindows.Items.Contains("BetterStartUp"))
            {
                string path = System.Reflection.Assembly.GetEntryAssembly().Location;
                key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("BetterStartUp", path);
                key.Close();
                listBoxWindows.Items.Add("BetterStartUp");
            }
            else
            {
                MessageBox.Show("BetterStartUp já adicionado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnWindowsRemover_Click(object sender, EventArgs e)
        {
            if(listBoxWindows.SelectedItem != null)
            {
                key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue(listBoxWindows.SelectedItem.ToString());
                key.Close();
                listBoxWindows.Items.Remove(listBoxWindows.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione algum programa para remover.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddPrograma_Click(object sender, EventArgs e)
        {
            if(openFileAddPrograma.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileAddPrograma.FileName;
                string fileName = openFileAddPrograma.SafeFileName;

                bool doIt = true;

                foreach(Programa g in listBoxBetterStartUp.Items)
                {
                    if (g.caminho == filePath)
                    {
                        doIt = false;
                    }
                }

                if (doIt)
                {
                    Programa p;
                    p.nome = fileName;
                    p.caminho = filePath;
                    p.delay = 0;
                    p.ordem = listBoxBetterStartUp.Items.Count;

                    listBoxBetterStartUp.Items.Add(p);
                }
                else
                {
                    MessageBox.Show("Programa já adicionado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
