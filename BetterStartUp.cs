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
    public partial class BetterStartUp : Form
    {
        private RegistryKey key;

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

        private void btnEditarSelecionado_Click(object sender, EventArgs e)
        {
            if (listBoxBetterStartUp.SelectedItem != null)
            {
                FormEditarPrograma f2 = new FormEditarPrograma((Programa)listBoxBetterStartUp.SelectedItem, this);
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione algum programa para editar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void editPrograma(Programa original, Programa editado)
        {
            for(int i = 0; i < listBoxBetterStartUp.Items.Count; i++)
            {
                Programa g = (Programa)listBoxBetterStartUp.Items[i];
                if (g.caminho == original.caminho)
                {
                    listBoxBetterStartUp.Items[i] = editado;
                    break;
                }
            }
        }

        private void btnRemoverSelecionado_Click(object sender, EventArgs e)
        {
            if (listBoxBetterStartUp.SelectedItem != null)
            {
                listBoxBetterStartUp.Items.Remove(listBoxBetterStartUp.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione algum programa para remover.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (listBoxBetterStartUp.SelectedItem != null)
            {
                Programa selected = (Programa)listBoxBetterStartUp.SelectedItem;

                for (int i = 0; i < listBoxBetterStartUp.Items.Count; i++)
                {
                    Programa g = (Programa)listBoxBetterStartUp.Items[i];
                    if (g.caminho == selected.caminho)
                    {
                        if (i == 0)
                        {
                            MessageBox.Show("Programa já é o primeiro da lista.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Programa anterior = (Programa)listBoxBetterStartUp.Items[i - 1];
                            listBoxBetterStartUp.Items[i - 1] = listBoxBetterStartUp.Items[i];
                            listBoxBetterStartUp.Items[i] = anterior;
                            listBoxBetterStartUp.SelectedIndex = listBoxBetterStartUp.SelectedIndex - 1;
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum programa para modificar sua ordem.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (listBoxBetterStartUp.SelectedItem != null)
            {
                Programa selected = (Programa)listBoxBetterStartUp.SelectedItem;

                for (int i = 0; i < listBoxBetterStartUp.Items.Count; i++)
                {
                    Programa g = (Programa)listBoxBetterStartUp.Items[i];
                    if (g.caminho == selected.caminho)
                    {
                        if (i == (listBoxBetterStartUp.Items.Count - 1))
                        {
                            MessageBox.Show("Programa já é o último da lista.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Programa proximo = (Programa)listBoxBetterStartUp.Items[i + 1];
                            listBoxBetterStartUp.Items[i + 1] = listBoxBetterStartUp.Items[i];
                            listBoxBetterStartUp.Items[i] = proximo;
                            listBoxBetterStartUp.SelectedIndex = listBoxBetterStartUp.SelectedIndex + 1;
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione algum programa para modificar sua ordem.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBoxBetterStartUp_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxBetterStartUp.SelectedItem != null)
            {
                btnEditarSelecionado_Click(null, null);
            }
        }
    }
}
