namespace LivrariaSaharan
{
    partial class TerminalResultado
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultadoTitulo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAutEstud = new System.Windows.Forms.Label();
            this.ResultadoAutor = new System.Windows.Forms.RichTextBox();
            this.txtPreco = new System.Windows.Forms.RichTextBox();
            this.lblISxN = new System.Windows.Forms.Label();
            this.ResultadoIS = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LivrariaSaharan.Properties.Resources.CDP_LOGO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(255, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 114);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Título";
            // 
            // ResultadoTitulo
            // 
            this.ResultadoTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.ResultadoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoTitulo.Location = new System.Drawing.Point(68, 192);
            this.ResultadoTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultadoTitulo.Name = "ResultadoTitulo";
            this.ResultadoTitulo.ReadOnly = true;
            this.ResultadoTitulo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ResultadoTitulo.Size = new System.Drawing.Size(649, 93);
            this.ResultadoTitulo.TabIndex = 8;
            this.ResultadoTitulo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 486);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Preço";
            // 
            // lblAutEstud
            // 
            this.lblAutEstud.AutoSize = true;
            this.lblAutEstud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutEstud.Location = new System.Drawing.Point(68, 289);
            this.lblAutEstud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutEstud.Name = "lblAutEstud";
            this.lblAutEstud.Size = new System.Drawing.Size(59, 25);
            this.lblAutEstud.TabIndex = 10;
            this.lblAutEstud.Text = "Autor";
            // 
            // ResultadoAutor
            // 
            this.ResultadoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoAutor.Location = new System.Drawing.Point(68, 318);
            this.ResultadoAutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultadoAutor.Name = "ResultadoAutor";
            this.ResultadoAutor.ReadOnly = true;
            this.ResultadoAutor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ResultadoAutor.Size = new System.Drawing.Size(649, 58);
            this.ResultadoAutor.TabIndex = 11;
            this.ResultadoAutor.Text = "";
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(255, 486);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPreco.Size = new System.Drawing.Size(261, 70);
            this.txtPreco.TabIndex = 12;
            this.txtPreco.Text = "";
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // lblISxN
            // 
            this.lblISxN.AutoSize = true;
            this.lblISxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISxN.Location = new System.Drawing.Point(68, 380);
            this.lblISxN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISxN.Name = "lblISxN";
            this.lblISxN.Size = new System.Drawing.Size(167, 25);
            this.lblISxN.TabIndex = 13;
            this.lblISxN.Text = "ISBN/ISAN/ISMN";
            // 
            // ResultadoIS
            // 
            this.ResultadoIS.BackColor = System.Drawing.SystemColors.Control;
            this.ResultadoIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoIS.Location = new System.Drawing.Point(68, 409);
            this.ResultadoIS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultadoIS.Name = "ResultadoIS";
            this.ResultadoIS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultadoIS.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ResultadoIS.Size = new System.Drawing.Size(649, 43);
            this.ResultadoIS.TabIndex = 14;
            this.ResultadoIS.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(255, 590);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 95);
            this.button1.TabIndex = 15;
            this.button1.Text = "Nova Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // TerminalResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultadoIS);
            this.Controls.Add(this.lblISxN);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.ResultadoAutor);
            this.Controls.Add(this.lblAutEstud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultadoTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TerminalResultado";
            this.Load += new System.EventHandler(this.TerminalResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ResultadoTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAutEstud;
        private System.Windows.Forms.RichTextBox ResultadoAutor;
        private System.Windows.Forms.RichTextBox txtPreco;
        private System.Windows.Forms.Label lblISxN;
        private System.Windows.Forms.RichTextBox ResultadoIS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
    }
}