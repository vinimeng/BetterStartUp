using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterStartUp
{
    [Serializable]
    public struct Programa
    {
        public string nome; // Nome para exibição.
        public string caminho; // Caminho completo para executável.
        public string argumentos; // Argumentos de linha de comando.
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
        private bool hasBeenEdited;

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

            List<Programa> data = new List<Programa>();
            try
            {
                string path = System.Reflection.Assembly.GetEntryAssembly().Location;
                path = System.IO.Path.GetDirectoryName(path) + "\\startup.bsu";

                using (var file = File.OpenRead(path))
                {
                    var reader = new BinaryFormatter();
                    data = (List<Programa>)reader.Deserialize(file);
                }
                foreach (Programa p in data)
                {
                    listBoxBetterStartUp.Items.Add(p);
                }
            } 
            catch(System.IO.FileNotFoundException)
            {
                // do nothing
            }
            
            openFileAddPrograma.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            hasBeenEdited = false;
        }

        private void btnWindowsAddBetterStartUp_Click(object sender, EventArgs e)
        {
            if (!listBoxWindows.Items.Contains("BetterStartUp"))
            {
                string path = System.Reflection.Assembly.GetEntryAssembly().Location;
                key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("BetterStartUp", "\"" + path + "\" -startup");
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
                    p.argumentos = "";
                    p.delay = 0;
                    p.ordem = listBoxBetterStartUp.Items.Count;

                    listBoxBetterStartUp.Items.Add(p);
                    hasBeenEdited = true;
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
                    hasBeenEdited = true;
                    break;
                }
            }
        }

        private void btnRemoverSelecionado_Click(object sender, EventArgs e)
        {
            if (listBoxBetterStartUp.SelectedItem != null)
            {
                listBoxBetterStartUp.Items.Remove(listBoxBetterStartUp.SelectedItem);
                hasBeenEdited = true;
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
                            listBoxBetterStartUp.SelectedIndex -= 1;
                            hasBeenEdited = true;
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
                            listBoxBetterStartUp.SelectedIndex += 1;
                            hasBeenEdited = true;
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

        private void BetterStartUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(hasBeenEdited)
            {
                DialogResult dr = MessageBox.Show("Deseja salvar as alterações feitas?", "Salvar alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    List<Programa> data = new List<Programa>();
                    
                    foreach (Programa p in listBoxBetterStartUp.Items)
                        data.Add(p);

                    string path = System.Reflection.Assembly.GetEntryAssembly().Location;
                    path = System.IO.Path.GetDirectoryName(path) + "\\startup.bsu";

                    using (var file = File.OpenWrite(path))
                    {
                        var writer = new BinaryFormatter();
                        writer.Serialize(file, data);
                    }
                }
            }
        }
    }
}
