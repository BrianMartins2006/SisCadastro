namespace Trabalho
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btfechar = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(121, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(234, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Produto\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(234, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(238, 106);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(406, 20);
            this.txtnome.TabIndex = 1;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // btfechar
            // 
            this.btfechar.BackColor = System.Drawing.Color.Tomato;
            this.btfechar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btfechar.FlatAppearance.BorderSize = 0;
            this.btfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfechar.ForeColor = System.Drawing.SystemColors.Control;
            this.btfechar.Location = new System.Drawing.Point(35, 395);
            this.btfechar.Margin = new System.Windows.Forms.Padding(0);
            this.btfechar.Name = "btfechar";
            this.btfechar.Size = new System.Drawing.Size(72, 23);
            this.btfechar.TabIndex = 12;
            this.btfechar.Text = "Fechar";
            this.btfechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btfechar.UseVisualStyleBackColor = false;
            this.btfechar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btsalvar.Location = new System.Drawing.Point(697, 395);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(80, 23);
            this.btsalvar.TabIndex = 14;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbcategoria
            // 
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(238, 175);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(174, 21);
            this.cbcategoria.TabIndex = 15;
            this.cbcategoria.SelectedIndexChanged += new System.EventHandler(this.cbcategoria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(234, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Categoria\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(238, 254);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(131, 20);
            this.txtpreco.TabIndex = 17;
            this.txtpreco.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-266, -199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(747, 655);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btfechar);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btfechar;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

