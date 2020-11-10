using Microsoft.Win32;
using System;
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

        private struct Program
        {
            string nome; // Nome para exibição
            string caminho; // Caminho completo para executável
            int ordem; // Inteiro com a ordem que deve ser executado
            int delay; // Inteiro com delay em segundos
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
                MessageBox.Show("BetterStartUp já adicionado.");
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
                MessageBox.Show("Selecione algum programa para remover.");
            }
        }
    }
}
