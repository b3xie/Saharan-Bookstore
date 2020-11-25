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
            this.principalLogoff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.Produtos = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTerminal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultaC = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVenda = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Produtos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.label1.Location = new System.Drawing.Point(381, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Boa tarde!\r\n";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 718);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1431, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 18);
            // 
            // monthCalendar1
            // 
<<<<<<< HEAD
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.BackColor = System.Drawing.Color.Black;
            this.monthCalendar1.Location = new System.Drawing.Point(818, 181);
=======
            this.monthCalendar1.Location = new System.Drawing.Point(1108, 106);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
>>>>>>> parent of a7918a9... design
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1260, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "17:45";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // principalLogoff
            // 
<<<<<<< HEAD
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(25, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Painel principal";
=======
            this.principalLogoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.75F, System.Drawing.FontStyle.Bold);
            this.principalLogoff.Location = new System.Drawing.Point(1268, 599);
            this.principalLogoff.Margin = new System.Windows.Forms.Padding(4);
            this.principalLogoff.Name = "principalLogoff";
            this.principalLogoff.Size = new System.Drawing.Size(143, 64);
            this.principalLogoff.TabIndex = 6;
            this.principalLogoff.Text = "Sair";
            this.principalLogoff.UseVisualStyleBackColor = true;
>>>>>>> parent of a7918a9... design
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LivrariaSaharan.Properties.Resources.CDP_LOGO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(37, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 127);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(227, 34);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(195, 119);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "CONSULTA";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Image = global::LivrariaSaharan.Properties.Resources.baseline_create_white_18dp;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(32, 180);
=======
            this.btnCadastro.Location = new System.Drawing.Point(8, 34);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> parent of a7918a9... design
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(195, 119);
            this.btnCadastro.TabIndex = 9;
            this.btnCadastro.Text = "CADASTRO";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.button2_Click);
            // 
            // Produtos
            // 
<<<<<<< HEAD
            this.btnConsulta.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Image = global::LivrariaSaharan.Properties.Resources.baseline_find_in_page_white_18dp1;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(271, 181);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Padding = new System.Windows.Forms.Padding(10);
            this.btnConsulta.Size = new System.Drawing.Size(228, 116);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "Consulta de Produtos";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
=======
            this.Produtos.Controls.Add(this.btnConsulta);
            this.Produtos.Controls.Add(this.btnCadastro);
            this.Produtos.Location = new System.Drawing.Point(123, 239);
            this.Produtos.Margin = new System.Windows.Forms.Padding(4);
            this.Produtos.Name = "Produtos";
            this.Produtos.Padding = new System.Windows.Forms.Padding(4);
            this.Produtos.Size = new System.Drawing.Size(429, 183);
            this.Produtos.TabIndex = 10;
            this.Produtos.TabStop = false;
            this.Produtos.Text = "Produtos";
>>>>>>> parent of a7918a9... design
            // 
            // groupBox1
            // 
<<<<<<< HEAD
            this.btnVenda.BackColor = System.Drawing.Color.Tomato;
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.ForeColor = System.Drawing.Color.White;
            this.btnVenda.Image = global::LivrariaSaharan.Properties.Resources.baseline_storefront_white_18dp;
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenda.Location = new System.Drawing.Point(505, 180);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Padding = new System.Windows.Forms.Padding(10);
            this.btnVenda.Size = new System.Drawing.Size(228, 117);
            this.btnVenda.TabIndex = 8;
            this.btnVenda.Text = "Venda";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
=======
            this.groupBox1.Controls.Add(this.btnTerminal);
            this.groupBox1.Location = new System.Drawing.Point(131, 430);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(303, 234);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terminal Consulta";
>>>>>>> parent of a7918a9... design
            // 
            // btnTerminal
            // 
            this.btnTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnTerminal.ForeColor = System.Drawing.Color.White;
            this.btnTerminal.Image = global::LivrariaSaharan.Properties.Resources.baseline_dvr_white_18dp;
            this.btnTerminal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerminal.Location = new System.Drawing.Point(505, 313);
=======
            this.btnTerminal.Location = new System.Drawing.Point(52, 60);
            this.btnTerminal.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> parent of a7918a9... design
            this.btnTerminal.Name = "btnTerminal";
            this.btnTerminal.Size = new System.Drawing.Size(195, 119);
            this.btnTerminal.TabIndex = 8;
            this.btnTerminal.Text = "TERMINAL";
            this.btnTerminal.UseVisualStyleBackColor = true;
            this.btnTerminal.Click += new System.EventHandler(this.btnTerminal_Click);
            // 
            // groupBox2
            // 
<<<<<<< HEAD
            this.btnFuncionario.BackColor = System.Drawing.Color.Blue;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnFuncionario.Image = global::LivrariaSaharan.Properties.Resources.baseline_supervisor_account_white_18dp;
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionario.Location = new System.Drawing.Point(32, 313);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Padding = new System.Windows.Forms.Padding(10);
            this.btnFuncionario.Size = new System.Drawing.Size(228, 117);
            this.btnFuncionario.TabIndex = 10;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
=======
            this.groupBox2.Controls.Add(this.btnConsultaC);
            this.groupBox2.Controls.Add(this.btnFuncionario);
            this.groupBox2.Location = new System.Drawing.Point(459, 430);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(531, 234);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro";
>>>>>>> parent of a7918a9... design
            // 
            // btnConsultaC
            // 
            this.btnConsultaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnConsultaC.ForeColor = System.Drawing.Color.White;
            this.btnConsultaC.Image = global::LivrariaSaharan.Properties.Resources.baseline_person_search_white_18dp;
            this.btnConsultaC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaC.Location = new System.Drawing.Point(271, 312);
=======
            this.btnConsultaC.Location = new System.Drawing.Point(19, 29);
            this.btnConsultaC.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> parent of a7918a9... design
            this.btnConsultaC.Name = "btnConsultaC";
            this.btnConsultaC.Size = new System.Drawing.Size(245, 183);
            this.btnConsultaC.TabIndex = 11;
            this.btnConsultaC.Text = "CONSULTA";
            this.btnConsultaC.UseVisualStyleBackColor = true;
            this.btnConsultaC.Click += new System.EventHandler(this.btnConsultaC_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Location = new System.Drawing.Point(272, 29);
            this.btnFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(240, 183);
            this.btnFuncionario.TabIndex = 10;
            this.btnFuncionario.Text = "FUNCIONÁRIO";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVenda);
            this.groupBox3.Location = new System.Drawing.Point(560, 239);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(429, 183);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendas";
            // 
            // btnVenda
            // 
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.Location = new System.Drawing.Point(116, 34);
            this.btnVenda.Margin = new System.Windows.Forms.Padding(4);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(195, 119);
            this.btnVenda.TabIndex = 8;
            this.btnVenda.Text = "VENDAS";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 742);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Produtos);
            this.Controls.Add(this.principalLogoff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.Text = "CDP Bookstore Intranet";
            this.Load += new System.EventHandler(this.Consulta_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Produtos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox Produtos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTerminal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConsultaC;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVenda;
    }
}