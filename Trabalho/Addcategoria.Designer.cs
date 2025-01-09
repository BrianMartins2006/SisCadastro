namespace Trabalho
{
    partial class Addcategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addcategoria));
            this.btfechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaddcategoria = new System.Windows.Forms.TextBox();
            this.btsalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btfechar
            // 
            this.btfechar.BackColor = System.Drawing.Color.Tomato;
            this.btfechar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btfechar.FlatAppearance.BorderSize = 0;
            this.btfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfechar.ForeColor = System.Drawing.SystemColors.Control;
            this.btfechar.Location = new System.Drawing.Point(9, 188);
            this.btfechar.Margin = new System.Windows.Forms.Padding(0);
            this.btfechar.Name = "btfechar";
            this.btfechar.Size = new System.Drawing.Size(71, 24);
            this.btfechar.TabIndex = 30;
            this.btfechar.Text = "Fechar";
            this.btfechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btfechar.UseVisualStyleBackColor = false;
            this.btfechar.Click += new System.EventHandler(this.btfechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(142, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Adicionar categoria";
            // 
            // txtaddcategoria
            // 
            this.txtaddcategoria.Location = new System.Drawing.Point(189, 96);
            this.txtaddcategoria.Name = "txtaddcategoria";
            this.txtaddcategoria.Size = new System.Drawing.Size(327, 20);
            this.txtaddcategoria.TabIndex = 32;
            // 
            // btsalvar
            // 
            this.btsalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btsalvar.Location = new System.Drawing.Point(428, 188);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(120, 24);
            this.btsalvar.TabIndex = 33;
            this.btsalvar.Text = "Salvar Categoria";
            this.btsalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(35, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nova categoria";
            // 
            // Addcategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(569, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.txtaddcategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btfechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Addcategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btfechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaddcategoria;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Label label2;
    }
}