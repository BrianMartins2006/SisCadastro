namespace Trabalho
{
    partial class Auterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auterar));
            this.label3 = new System.Windows.Forms.Label();
            this.txtauterapreço = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbauteracategoria = new System.Windows.Forms.ComboBox();
            this.txtauteranome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btsalvar = new System.Windows.Forms.Button();
            this.btfechar = new System.Windows.Forms.Button();
            this.dglista = new System.Windows.Forms.DataGridView();
            this.ProdutoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomeproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomecategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btdeauterar = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dglista)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(135, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 3;
            // 
            // txtauterapreço
            // 
            this.txtauterapreço.Location = new System.Drawing.Point(16, 241);
            this.txtauterapreço.Name = "txtauterapreço";
            this.txtauterapreço.Size = new System.Drawing.Size(131, 20);
            this.txtauterapreço.TabIndex = 23;
            this.txtauterapreço.TextChanged += new System.EventHandler(this.txtauterapreço_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(16, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Categoria\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbauteracategoria
            // 
            this.cbauteracategoria.FormattingEnabled = true;
            this.cbauteracategoria.Location = new System.Drawing.Point(16, 151);
            this.cbauteracategoria.Name = "cbauteracategoria";
            this.cbauteracategoria.Size = new System.Drawing.Size(174, 21);
            this.cbauteracategoria.TabIndex = 21;
            this.cbauteracategoria.SelectedIndexChanged += new System.EventHandler(this.cbauteracategoria_SelectedIndexChanged);
            // 
            // txtauteranome
            // 
            this.txtauteranome.Location = new System.Drawing.Point(16, 63);
            this.txtauteranome.Name = "txtauteranome";
            this.txtauteranome.Size = new System.Drawing.Size(177, 20);
            this.txtauteranome.TabIndex = 18;
            this.txtauteranome.TextChanged += new System.EventHandler(this.txtauteranome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(21, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Preço\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(405, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(116, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 25;
            // 
            // btsalvar
            // 
            this.btsalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btsalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btsalvar.Location = new System.Drawing.Point(831, 403);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(121, 36);
            this.btsalvar.TabIndex = 31;
            this.btsalvar.Text = "Salvar Auteração";
            this.btsalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // btfechar
            // 
            this.btfechar.BackColor = System.Drawing.Color.Tomato;
            this.btfechar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btfechar.FlatAppearance.BorderSize = 0;
            this.btfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfechar.ForeColor = System.Drawing.SystemColors.Control;
            this.btfechar.Location = new System.Drawing.Point(25, 403);
            this.btfechar.Margin = new System.Windows.Forms.Padding(0);
            this.btfechar.Name = "btfechar";
            this.btfechar.Size = new System.Drawing.Size(80, 36);
            this.btfechar.TabIndex = 29;
            this.btfechar.Text = "Fechar";
            this.btfechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btfechar.UseVisualStyleBackColor = false;
            this.btfechar.Click += new System.EventHandler(this.btfechar_Click);
            // 
            // dglista
            // 
            this.dglista.AllowUserToAddRows = false;
            this.dglista.AllowUserToDeleteRows = false;
            this.dglista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutoID,
            this.Nomeproduto,
            this.Preco,
            this.Nomecategoria});
            this.dglista.Location = new System.Drawing.Point(218, 54);
            this.dglista.Name = "dglista";
            this.dglista.ReadOnly = true;
            this.dglista.RowHeadersWidth = 5;
            this.dglista.Size = new System.Drawing.Size(734, 343);
            this.dglista.TabIndex = 32;
            this.dglista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dglista_CellContentClick);
            // 
            // ProdutoID
            // 
            this.ProdutoID.DataPropertyName = "ProdutoID";
            this.ProdutoID.HeaderText = "Código";
            this.ProdutoID.Name = "ProdutoID";
            this.ProdutoID.ReadOnly = true;
            this.ProdutoID.Width = 80;
            // 
            // Nomeproduto
            // 
            this.Nomeproduto.DataPropertyName = "Nomeproduto";
            this.Nomeproduto.HeaderText = "        Nome       ";
            this.Nomeproduto.Name = "Nomeproduto";
            this.Nomeproduto.ReadOnly = true;
            this.Nomeproduto.Width = 400;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // Nomecategoria
            // 
            this.Nomecategoria.DataPropertyName = "categoria";
            this.Nomecategoria.HeaderText = "Categorias";
            this.Nomecategoria.Name = "Nomecategoria";
            this.Nomecategoria.ReadOnly = true;
            this.Nomecategoria.Width = 225;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(237, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(438, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Selecione o item que deseja alterar e clique no botão ao lado";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btdeauterar
            // 
            this.btdeauterar.BackColor = System.Drawing.Color.Green;
            this.btdeauterar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btdeauterar.FlatAppearance.BorderSize = 0;
            this.btdeauterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdeauterar.ForeColor = System.Drawing.SystemColors.Control;
            this.btdeauterar.Location = new System.Drawing.Point(738, 9);
            this.btdeauterar.Margin = new System.Windows.Forms.Padding(0);
            this.btdeauterar.Name = "btdeauterar";
            this.btdeauterar.Size = new System.Drawing.Size(76, 31);
            this.btdeauterar.TabIndex = 34;
            this.btdeauterar.Text = "Novo";
            this.btdeauterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btdeauterar.UseVisualStyleBackColor = false;
            this.btdeauterar.Click += new System.EventHandler(this.btdeauterar_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Auterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(982, 470);
            this.Controls.Add(this.btdeauterar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dglista);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btfechar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtauterapreço);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbauteracategoria);
            this.Controls.Add(this.txtauteranome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Auterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dglista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtauterapreço;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbauteracategoria;
        private System.Windows.Forms.TextBox txtauteranome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Button btfechar;
        private System.Windows.Forms.DataGridView dglista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomeproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomecategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btdeauterar;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
    }
}