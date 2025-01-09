namespace Trabalho
{
    partial class Pagina_Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagina_Inicial));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btremover = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btaddproduto = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dglista = new System.Windows.Forms.DataGridView();
            this.ProdutoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomeproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomecategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.btaddcategoria = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btremover);
            this.groupBox1.Controls.Add(this.bteditar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btaddproduto);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // btremover
            // 
            this.btremover.BackColor = System.Drawing.Color.Transparent;
            this.btremover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btremover.FlatAppearance.BorderSize = 0;
            this.btremover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btremover.Image = global::Trabalho.Properties.Resources.icons8_remover_48;
            this.btremover.Location = new System.Drawing.Point(148, 21);
            this.btremover.Name = "btremover";
            this.btremover.Size = new System.Drawing.Size(48, 48);
            this.btremover.TabIndex = 7;
            this.btremover.UseVisualStyleBackColor = false;
            this.btremover.Click += new System.EventHandler(this.btremover_Click);
            // 
            // bteditar
            // 
            this.bteditar.BackColor = System.Drawing.Color.Transparent;
            this.bteditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bteditar.FlatAppearance.BorderSize = 0;
            this.bteditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditar.Image = global::Trabalho.Properties.Resources.icons8_editar_48;
            this.bteditar.Location = new System.Drawing.Point(77, 21);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(48, 48);
            this.bteditar.TabIndex = 5;
            this.bteditar.UseVisualStyleBackColor = false;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btaddproduto
            // 
            this.btaddproduto.BackColor = System.Drawing.Color.Transparent;
            this.btaddproduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btaddproduto.FlatAppearance.BorderSize = 0;
            this.btaddproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btaddproduto.Image = global::Trabalho.Properties.Resources.icons8_adicionar_48;
            this.btaddproduto.Location = new System.Drawing.Point(6, 24);
            this.btaddproduto.Name = "btaddproduto";
            this.btaddproduto.Size = new System.Drawing.Size(48, 48);
            this.btaddproduto.TabIndex = 1;
            this.btaddproduto.UseVisualStyleBackColor = false;
            this.btaddproduto.Click += new System.EventHandler(this.button1_Click);
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
            this.dglista.Location = new System.Drawing.Point(101, 147);
            this.dglista.Name = "dglista";
            this.dglista.ReadOnly = true;
            this.dglista.RowHeadersWidth = 5;
            this.dglista.Size = new System.Drawing.Size(734, 343);
            this.dglista.TabIndex = 1;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(269, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtbusca
            // 
            this.txtbusca.Location = new System.Drawing.Point(272, 69);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(170, 25);
            this.txtbusca.TabIndex = 4;
            this.txtbusca.TextChanged += new System.EventHandler(this.txtbusca_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(486, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(489, 69);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(170, 25);
            this.txtpreco.TabIndex = 6;
            this.txtpreco.TextChanged += new System.EventHandler(this.txtpreco_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(722, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(725, 69);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(145, 25);
            this.txtcategoria.TabIndex = 9;
            this.txtcategoria.TextChanged += new System.EventHandler(this.txtcategoria_TextChanged);
            // 
            // btaddcategoria
            // 
            this.btaddcategoria.BackColor = System.Drawing.Color.DarkGreen;
            this.btaddcategoria.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btaddcategoria.FlatAppearance.BorderSize = 0;
            this.btaddcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btaddcategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.btaddcategoria.Image = global::Trabalho.Properties.Resources.icons8_lista_16;
            this.btaddcategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btaddcategoria.Location = new System.Drawing.Point(641, 502);
            this.btaddcategoria.Margin = new System.Windows.Forms.Padding(0);
            this.btaddcategoria.Name = "btaddcategoria";
            this.btaddcategoria.Size = new System.Drawing.Size(168, 26);
            this.btaddcategoria.TabIndex = 13;
            this.btaddcategoria.Text = "Nova Categoria";
            this.btaddcategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btaddcategoria.UseVisualStyleBackColor = false;
            this.btaddcategoria.Click += new System.EventHandler(this.btaddcategoria_Click_1);
            // 
            // Pagina_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(922, 548);
            this.Controls.Add(this.btaddcategoria);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbusca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dglista);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pagina_Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Inicial";
            this.Load += new System.EventHandler(this.menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btaddproduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dglista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Button btremover;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button btaddcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomeproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomecategoria;
    }
}