namespace Trabalho
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btfechar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusernome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btfechar
            // 
            this.btfechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btfechar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btfechar.FlatAppearance.BorderSize = 0;
            this.btfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfechar.ForeColor = System.Drawing.SystemColors.Control;
            this.btfechar.Image = global::Trabalho.Properties.Resources.icons8_close_window_161;
            this.btfechar.Location = new System.Drawing.Point(406, -1);
            this.btfechar.Margin = new System.Windows.Forms.Padding(0);
            this.btfechar.Name = "btfechar";
            this.btfechar.Size = new System.Drawing.Size(25, 28);
            this.btfechar.TabIndex = 13;
            this.btfechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btfechar.UseVisualStyleBackColor = false;
            this.btfechar.Click += new System.EventHandler(this.btfechar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(48, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtusernome
            // 
            this.txtusernome.Location = new System.Drawing.Point(52, 191);
            this.txtusernome.Name = "txtusernome";
            this.txtusernome.Size = new System.Drawing.Size(343, 20);
            this.txtusernome.TabIndex = 15;
            this.txtusernome.TextChanged += new System.EventHandler(this.txtusernome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(48, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Senha";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(52, 265);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(343, 20);
            this.txtsenha.TabIndex = 17;
            this.txtsenha.TextChanged += new System.EventHandler(this.txtsenha_TextChanged);
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btlogin.Location = new System.Drawing.Point(170, 320);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(91, 27);
            this.btlogin.TabIndex = 19;
            this.btlogin.Text = "Login";
            this.btlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-169, -194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(48, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 8);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(430, 394);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusernome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btfechar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btfechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusernome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}