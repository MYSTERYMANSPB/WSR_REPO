namespace WSR_BONCH
{
    partial class SignUPForm
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
            this.inpLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.inpPassword = new System.Windows.Forms.TextBox();
            this.btnSignUP = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbLogotype = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogotype)).BeginInit();
            this.SuspendLayout();
            // 
            // inpLogin
            // 
            this.inpLogin.Location = new System.Drawing.Point(12, 151);
            this.inpLogin.Name = "inpLogin";
            this.inpLogin.Size = new System.Drawing.Size(271, 20);
            this.inpLogin.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(12, 130);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(54, 18);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Логин:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(12, 174);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 18);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Пароль:";
            // 
            // inpPassword
            // 
            this.inpPassword.Location = new System.Drawing.Point(12, 195);
            this.inpPassword.Name = "inpPassword";
            this.inpPassword.Size = new System.Drawing.Size(271, 20);
            this.inpPassword.TabIndex = 1;
            // 
            // btnSignUP
            // 
            this.btnSignUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btnSignUP.FlatAppearance.BorderSize = 0;
            this.btnSignUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignUP.ForeColor = System.Drawing.Color.White;
            this.btnSignUP.Location = new System.Drawing.Point(12, 222);
            this.btnSignUP.Name = "btnSignUP";
            this.btnSignUP.Size = new System.Drawing.Size(271, 29);
            this.btnSignUP.TabIndex = 3;
            this.btnSignUP.Text = "Зарегистрироваться";
            this.btnSignUP.UseVisualStyleBackColor = false;
            this.btnSignUP.Click += new System.EventHandler(this.BtnSignUP_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 257);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(271, 29);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pbLogotype
            // 
            this.pbLogotype.Image = global::WSR_BONCH.Properties.Resources.logo_02;
            this.pbLogotype.InitialImage = global::WSR_BONCH.Properties.Resources.logo_02;
            this.pbLogotype.Location = new System.Drawing.Point(90, 12);
            this.pbLogotype.Name = "pbLogotype";
            this.pbLogotype.Size = new System.Drawing.Size(115, 103);
            this.pbLogotype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogotype.TabIndex = 0;
            this.pbLogotype.TabStop = false;
            // 
            // SignUPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(295, 313);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSignUP);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.inpPassword);
            this.Controls.Add(this.inpLogin);
            this.Controls.Add(this.pbLogotype);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SignUPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogotype)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogotype;
        private System.Windows.Forms.TextBox inpLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox inpPassword;
        private System.Windows.Forms.Button btnSignUP;
        private System.Windows.Forms.Button btnBack;
    }
}