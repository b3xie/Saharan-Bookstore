namespace LivrariaSaharan
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnTerminal = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnConsultaC = new System.Windows.Forms.Button();
            this.principalLogoff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(256, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Boa tarde!\r\n";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 768);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1447, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.BackColor = System.Drawing.Color.Black;
            this.monthCalendar1.Location = new System.Drawing.Point(1091, 167);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1308, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "17:45";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, -4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1447, 123);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LivrariaSaharan.Properties.Resources.CDP_LOGO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 103);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(25, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Painel principal";
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Image = global::LivrariaSaharan.Properties.Resources.baseline_create_white_18dp;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(35, 287);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnCadastro.Size = new System.Drawing.Size(304, 144);
            this.btnCadastro.TabIndex = 9;
            this.btnCadastro.Text = "Cadastro de Produtos";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Image = global::LivrariaSaharan.Properties.Resources.baseline_find_in_page_white_18dp1;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(353, 288);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnConsulta.Size = new System.Drawing.Size(304, 143);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "Consulta de Produtos";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.Tomato;
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.ForeColor = System.Drawing.Color.White;
            this.btnVenda.Image = global::LivrariaSaharan.Properties.Resources.baseline_storefront_white_18dp;
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenda.Location = new System.Drawing.Point(665, 287);
            this.btnVenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnVenda.Size = new System.Drawing.Size(304, 144);
            this.btnVenda.TabIndex = 8;
            this.btnVenda.Text = "Venda";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnTerminal
            // 
            this.btnTerminal.BackColor = System.Drawing.Color.Green;
            this.btnTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminal.ForeColor = System.Drawing.Color.White;
            this.btnTerminal.Image = global::LivrariaSaharan.Properties.Resources.baseline_dvr_white_18dp;
            this.btnTerminal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerminal.Location = new System.Drawing.Point(665, 450);
            this.btnTerminal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTerminal.Name = "btnTerminal";
            this.btnTerminal.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnTerminal.Size = new System.Drawing.Size(304, 144);
            this.btnTerminal.TabIndex = 8;
            this.btnTerminal.Text = "Terminal";
            this.btnTerminal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerminal.UseVisualStyleBackColor = false;
            this.btnTerminal.Click += new System.EventHandler(this.btnTerminal_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.Blue;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnFuncionario.Image = global::LivrariaSaharan.Properties.Resources.baseline_supervisor_account_white_18dp;
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionario.Location = new System.Drawing.Point(35, 450);
            this.btnFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnFuncionario.Size = new System.Drawing.Size(304, 144);
            this.btnFuncionario.TabIndex = 10;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnConsultaC
            // 
            this.btnConsultaC.BackColor = System.Drawing.Color.Blue;
            this.btnConsultaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaC.ForeColor = System.Drawing.Color.White;
            this.btnConsultaC.Image = global::LivrariaSaharan.Properties.Resources.baseline_person_search_white_18dp;
            this.btnConsultaC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaC.Location = new System.Drawing.Point(353, 449);
            this.btnConsultaC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultaC.Name = "btnConsultaC";
            this.btnConsultaC.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnConsultaC.Size = new System.Drawing.Size(304, 144);
            this.btnConsultaC.TabIndex = 11;
            this.btnConsultaC.Text = "Consulta de cadastro";
            this.btnConsultaC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultaC.UseVisualStyleBackColor = false;
            this.btnConsultaC.Click += new System.EventHandler(this.btnConsultaC_Click);
            // 
            // principalLogoff
            // 
            this.principalLogoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.principalLogoff.BackColor = System.Drawing.Color.Firebrick;
            this.principalLogoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.75F, System.Drawing.FontStyle.Bold);
            this.principalLogoff.ForeColor = System.Drawing.Color.White;
            this.principalLogoff.Image = global::LivrariaSaharan.Properties.Resources.baseline_exit_to_app_white_18dp;
            this.principalLogoff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.principalLogoff.Location = new System.Drawing.Point(1223, 667);
            this.principalLogoff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.principalLogoff.Name = "principalLogoff";
            this.principalLogoff.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.principalLogoff.Size = new System.Drawing.Size(208, 81);
            this.principalLogoff.TabIndex = 6;
            this.principalLogoff.Text = "Sair";
            this.principalLogoff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.principalLogoff.UseVisualStyleBackColor = false;
            this.principalLogoff.Click += new System.EventHandler(this.principalLogoff_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::LivrariaSaharan.Properties.Resources.baseline_dvr_white_18dp;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(353, 614);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.button1.Size = new System.Drawing.Size(304, 134);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sobre Nós";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1447, 790);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnTerminal);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnConsultaC);
            this.Controls.Add(this.principalLogoff);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1462, 827);
            this.Name = "Principal";
            this.Text = "CDP Bookstore Intranet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consulta_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button principalLogoff;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnTerminal;
        private System.Windows.Forms.Button btnConsultaC;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}