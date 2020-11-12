namespace BetterStartUp
{
    partial class FormEditarPrograma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarPrograma));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCaminho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.textBoxNomeExibicao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caminho ";
            // 
            // textBoxCaminho
            // 
            this.textBoxCaminho.Location = new System.Drawing.Point(15, 64);
            this.textBoxCaminho.Name = "textBoxCaminho";
            this.textBoxCaminho.Size = new System.Drawing.Size(457, 20);
            this.textBoxCaminho.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Delay";
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Location = new System.Drawing.Point(15, 103);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(457, 20);
            this.numericUpDownDelay.TabIndex = 4;
            // 
            // textBoxNomeExibicao
            // 
            this.textBoxNomeExibicao.Location = new System.Drawing.Point(15, 25);
            this.textBoxNomeExibicao.Name = "textBoxNomeExibicao";
            this.textBoxNomeExibicao.Size = new System.Drawing.Size(457, 20);
            this.textBoxNomeExibicao.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome de Exibição";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(316, 141);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(397, 141);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormEditarPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 176);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxNomeExibicao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownDelay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCaminho);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 215);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 215);
            this.Name = "FormEditarPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Programa";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCaminho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.TextBox textBoxNomeExibicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancelar;
    }
}