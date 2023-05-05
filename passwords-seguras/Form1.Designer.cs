namespace passwords_seguras
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_username = new System.Windows.Forms.TextBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_confirm_password = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.error_email = new System.Windows.Forms.PictureBox();
            this.error_username = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_confirm_password = new System.Windows.Forms.Label();
            this.error_password = new System.Windows.Forms.PictureBox();
            this.error_confirm_password = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_confirm_password)).BeginInit();
            this.SuspendLayout();
            // 
            // text_username
            // 
            this.text_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_username.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.text_username.Location = new System.Drawing.Point(233, 129);
            this.text_username.Multiline = true;
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(359, 29);
            this.text_username.TabIndex = 0;
            this.text_username.TextChanged += new System.EventHandler(this.text_username_TextChanged);
            // 
            // text_email
            // 
            this.text_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_email.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.text_email.Location = new System.Drawing.Point(233, 181);
            this.text_email.Multiline = true;
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(359, 29);
            this.text_email.TabIndex = 1;
            this.text_email.TextChanged += new System.EventHandler(this.text_email_TextChanged);
            // 
            // text_confirm_password
            // 
            this.text_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_confirm_password.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.text_confirm_password.Location = new System.Drawing.Point(233, 283);
            this.text_confirm_password.Multiline = true;
            this.text_confirm_password.Name = "text_confirm_password";
            this.text_confirm_password.PasswordChar = '*';
            this.text_confirm_password.Size = new System.Drawing.Size(359, 29);
            this.text_confirm_password.TabIndex = 3;
            this.text_confirm_password.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // text_password
            // 
            this.text_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_password.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.text_password.Location = new System.Drawing.Point(233, 231);
            this.text_password.Multiline = true;
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(359, 29);
            this.text_password.TabIndex = 2;
            this.text_password.TextChanged += new System.EventHandler(this.text_password_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(505, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // error_email
            // 
            this.error_email.Location = new System.Drawing.Point(598, 181);
            this.error_email.Name = "error_email";
            this.error_email.Size = new System.Drawing.Size(34, 29);
            this.error_email.TabIndex = 10;
            this.error_email.TabStop = false;
            // 
            // error_username
            // 
            this.error_username.BackColor = System.Drawing.SystemColors.HotTrack;
            this.error_username.Location = new System.Drawing.Point(598, 129);
            this.error_username.Name = "error_username";
            this.error_username.Size = new System.Drawing.Size(34, 29);
            this.error_username.TabIndex = 9;
            this.error_username.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::passwords_seguras.Properties.Resources.key_fill;
            this.pictureBox4.Location = new System.Drawing.Point(195, 283);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 29);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::passwords_seguras.Properties.Resources.lock_fill;
            this.pictureBox3.Location = new System.Drawing.Point(195, 231);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 29);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::passwords_seguras.Properties.Resources.at_line;
            this.pictureBox2.Location = new System.Drawing.Point(195, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 29);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::passwords_seguras.Properties.Resources.user_3_fill2;
            this.pictureBox1.Location = new System.Drawing.Point(195, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.DarkRed;
            this.label_username.Location = new System.Drawing.Point(233, 110);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(11, 15);
            this.label_username.TabIndex = 11;
            this.label_username.Text = " ";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.DarkRed;
            this.label_email.Location = new System.Drawing.Point(233, 163);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(11, 15);
            this.label_email.TabIndex = 12;
            this.label_email.Text = " ";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.DarkRed;
            this.label_password.Location = new System.Drawing.Point(233, 213);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(11, 15);
            this.label_password.TabIndex = 13;
            this.label_password.Text = " ";
            // 
            // label_confirm_password
            // 
            this.label_confirm_password.AutoSize = true;
            this.label_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confirm_password.ForeColor = System.Drawing.Color.DarkRed;
            this.label_confirm_password.Location = new System.Drawing.Point(233, 263);
            this.label_confirm_password.Name = "label_confirm_password";
            this.label_confirm_password.Size = new System.Drawing.Size(11, 15);
            this.label_confirm_password.TabIndex = 14;
            this.label_confirm_password.Text = " ";
            // 
            // error_password
            // 
            this.error_password.Location = new System.Drawing.Point(598, 231);
            this.error_password.Name = "error_password";
            this.error_password.Size = new System.Drawing.Size(34, 29);
            this.error_password.TabIndex = 15;
            this.error_password.TabStop = false;
            // 
            // error_confirm_password
            // 
            this.error_confirm_password.Location = new System.Drawing.Point(598, 283);
            this.error_confirm_password.Name = "error_confirm_password";
            this.error_confirm_password.Size = new System.Drawing.Size(34, 29);
            this.error_confirm_password.TabIndex = 16;
            this.error_confirm_password.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(189, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Register";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(313, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.error_confirm_password);
            this.Controls.Add(this.error_password);
            this.Controls.Add(this.label_confirm_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.error_email);
            this.Controls.Add(this.error_username);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_confirm_password);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.text_username);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_confirm_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_confirm_password;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox error_username;
        private System.Windows.Forms.PictureBox error_email;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_confirm_password;
        private System.Windows.Forms.PictureBox error_password;
        private System.Windows.Forms.PictureBox error_confirm_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

