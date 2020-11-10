namespace BetterStartUp
{
    partial class BetterStartUp
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BetterStartUp));
            this.groupBoxWindows = new System.Windows.Forms.GroupBox();
            this.groupBoxBetterStartUp = new System.Windows.Forms.GroupBox();
            this.listBoxWindows = new System.Windows.Forms.ListBox();
            this.btnWindowsAddBetterStartUp = new System.Windows.Forms.Button();
            this.btnWindowsRemover = new System.Windows.Forms.Button();
            this.listBoxBetterStartUp = new System.Windows.Forms.ListBox();
            this.btnAddPrograma = new System.Windows.Forms.Button();
            this.btnRemoverSelecionado = new System.Windows.Forms.Button();
            this.btnEditarSelecionado = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.groupBoxWindows.SuspendLayout();
            this.groupBoxBetterStartUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxWindows
            // 
            this.groupBoxWindows.Controls.Add(this.btnWindowsRemover);
            this.groupBoxWindows.Controls.Add(this.btnWindowsAddBetterStartUp);
            this.groupBoxWindows.Controls.Add(this.listBoxWindows);
            this.groupBoxWindows.Location = new System.Drawing.Point(12, 12);
            this.groupBoxWindows.Name = "groupBoxWindows";
            this.groupBoxWindows.Size = new System.Drawing.Size(200, 337);
            this.groupBoxWindows.TabIndex = 0;
            this.groupBoxWindows.TabStop = false;
            this.groupBoxWindows.Text = "Windows StartUp";
            // 
            // groupBoxBetterStartUp
            // 
            this.groupBoxBetterStartUp.Controls.Add(this.btnUp);
            this.groupBoxBetterStartUp.Controls.Add(this.btnDown);
            this.groupBoxBetterStartUp.Controls.Add(this.btnEditarSelecionado);
            this.groupBoxBetterStartUp.Controls.Add(this.btnRemoverSelecionado);
            this.groupBoxBetterStartUp.Controls.Add(this.btnAddPrograma);
            this.groupBoxBetterStartUp.Controls.Add(this.listBoxBetterStartUp);
            this.groupBoxBetterStartUp.Location = new System.Drawing.Point(218, 12);
            this.groupBoxBetterStartUp.Name = "groupBoxBetterStartUp";
            this.groupBoxBetterStartUp.Size = new System.Drawing.Size(354, 337);
            this.groupBoxBetterStartUp.TabIndex = 1;
            this.groupBoxBetterStartUp.TabStop = false;
            this.groupBoxBetterStartUp.Text = "BetterStartUp";
            // 
            // listBoxWindows
            // 
            this.listBoxWindows.FormattingEnabled = true;
            this.listBoxWindows.Location = new System.Drawing.Point(7, 20);
            this.listBoxWindows.Name = "listBoxWindows";
            this.listBoxWindows.Size = new System.Drawing.Size(187, 264);
            this.listBoxWindows.TabIndex = 0;
            // 
            // btnWindowsAddBetterStartUp
            // 
            this.btnWindowsAddBetterStartUp.Location = new System.Drawing.Point(7, 294);
            this.btnWindowsAddBetterStartUp.Name = "btnWindowsAddBetterStartUp";
            this.btnWindowsAddBetterStartUp.Size = new System.Drawing.Size(82, 37);
            this.btnWindowsAddBetterStartUp.TabIndex = 1;
            this.btnWindowsAddBetterStartUp.Text = "Add BetterStartUp";
            this.btnWindowsAddBetterStartUp.UseVisualStyleBackColor = true;
            this.btnWindowsAddBetterStartUp.Click += new System.EventHandler(this.btnWindowsAddBetterStartUp_Click);
            // 
            // btnWindowsRemover
            // 
            this.btnWindowsRemover.Location = new System.Drawing.Point(112, 294);
            this.btnWindowsRemover.Name = "btnWindowsRemover";
            this.btnWindowsRemover.Size = new System.Drawing.Size(82, 37);
            this.btnWindowsRemover.TabIndex = 2;
            this.btnWindowsRemover.Text = "Remover Selecionado";
            this.btnWindowsRemover.UseVisualStyleBackColor = true;
            this.btnWindowsRemover.Click += new System.EventHandler(this.btnWindowsRemover_Click);
            // 
            // listBoxBetterStartUp
            // 
            this.listBoxBetterStartUp.FormattingEnabled = true;
            this.listBoxBetterStartUp.Location = new System.Drawing.Point(6, 19);
            this.listBoxBetterStartUp.Name = "listBoxBetterStartUp";
            this.listBoxBetterStartUp.Size = new System.Drawing.Size(342, 264);
            this.listBoxBetterStartUp.TabIndex = 3;
            // 
            // btnAddPrograma
            // 
            this.btnAddPrograma.Location = new System.Drawing.Point(6, 294);
            this.btnAddPrograma.Name = "btnAddPrograma";
            this.btnAddPrograma.Size = new System.Drawing.Size(82, 37);
            this.btnAddPrograma.TabIndex = 3;
            this.btnAddPrograma.Text = "Add Programa";
            this.btnAddPrograma.UseVisualStyleBackColor = true;
            // 
            // btnRemoverSelecionado
            // 
            this.btnRemoverSelecionado.Location = new System.Drawing.Point(182, 294);
            this.btnRemoverSelecionado.Name = "btnRemoverSelecionado";
            this.btnRemoverSelecionado.Size = new System.Drawing.Size(82, 37);
            this.btnRemoverSelecionado.TabIndex = 4;
            this.btnRemoverSelecionado.Text = "Remover Selecionado";
            this.btnRemoverSelecionado.UseVisualStyleBackColor = true;
            // 
            // btnEditarSelecionado
            // 
            this.btnEditarSelecionado.Location = new System.Drawing.Point(94, 294);
            this.btnEditarSelecionado.Name = "btnEditarSelecionado";
            this.btnEditarSelecionado.Size = new System.Drawing.Size(82, 37);
            this.btnEditarSelecionado.TabIndex = 5;
            this.btnEditarSelecionado.Text = "Editar Selecionado";
            this.btnEditarSelecionado.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(316, 294);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(32, 37);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(278, 294);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(32, 37);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // BetterStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.groupBoxBetterStartUp);
            this.Controls.Add(this.groupBoxWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "BetterStartUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetterStartUp";
            this.groupBoxWindows.ResumeLayout(false);
            this.groupBoxBetterStartUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWindows;
        private System.Windows.Forms.Button btnWindowsRemover;
        private System.Windows.Forms.Button btnWindowsAddBetterStartUp;
        private System.Windows.Forms.ListBox listBoxWindows;
        private System.Windows.Forms.GroupBox groupBoxBetterStartUp;
        private System.Windows.Forms.Button btnEditarSelecionado;
        private System.Windows.Forms.Button btnRemoverSelecionado;
        private System.Windows.Forms.Button btnAddPrograma;
        private System.Windows.Forms.ListBox listBoxBetterStartUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
    }
}

