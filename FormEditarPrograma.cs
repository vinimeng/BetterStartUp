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
    public partial class FormEditarPrograma : Form
    {
        Programa prg;
        BetterStartUp bsup;
        public FormEditarPrograma(Programa p, BetterStartUp bs)
        {
            InitializeComponent();
            prg = p;
            bsup = bs;
            textBoxNomeExibicao.Text = p.nome;
            textBoxCaminho.Text = p.caminho;
            numericUpDownDelay.Value = p.delay;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Programa original = prg;
            prg.nome = textBoxNomeExibicao.Text;
            prg.caminho = textBoxCaminho.Text;
            prg.delay = (int)numericUpDownDelay.Value;
            bsup.editPrograma(original, prg);
            this.Dispose();
        }
    }
}
