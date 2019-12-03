namespace WSR_BONCH
{
    partial class LogINForm
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
            this.pbLogotype = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.inpLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.inpPassword = new System.Windows.Forms.TextBox();
            this.btnLogIN = new System.Windows.Forms.Button();
            this.btnSingUP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogotype)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogotype
            // 
            this.pbLogotype.Image = global::WSR_BONCH.Properties.Resources.logo_02;
            this.pbLogotype.InitialImage = global::WSR_BONCH.Properties.Resources.logo_02;
            this.pbLogotype.Location = new System.Drawing.Point(90, 12);
            this.pbLogotype.Name = "pbLogotype";
            this.pbLogotype.Size = new System.Drawing.Size(115, 103);
            this.pbLogotype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogotype.TabIndex = 1;
            this.pbLogotype.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(12, 130);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(54, 18);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Логин:";
            // 
            // inpLogin
            // 
            this.inpLogin.Location = new System.Drawing.Point(12, 151);
            this.inpLogin.Name = "inpLogin";
            this.inpLogin.Size = new System.Drawing.Size(271, 20);
            this.inpLogin.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(12, 174);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 18);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Пароль:";
            // 
            // inpPassword
            // 
            this.inpPassword.Location = new System.Drawing.Point(12, 195);
            this.inpPassword.Name = "inpPassword";
            this.inpPassword.Size = new System.Drawing.Size(271, 20);
            this.inpPassword.TabIndex = 5;
            // 
            // btnLogIN
            // 
            this.btnLogIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btnLogIN.FlatAppearance.BorderSize = 0;
            this.btnLogIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogIN.ForeColor = System.Drawing.Color.White;
            this.btnLogIN.Location = new System.Drawing.Point(12, 222);
            this.btnLogIN.Name = "btnLogIN";
            this.btnLogIN.Size = new System.Drawing.Size(271, 29);
            this.btnLogIN.TabIndex = 7;
            this.btnLogIN.Text = "Авторизоваться";
            this.btnLogIN.UseVisualStyleBackColor = false;
            this.btnLogIN.Click += new System.EventHandler(this.BtnLogIN_Click);
            // 
            // btnSingUP
            // 
            this.btnSingUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btnSingUP.FlatAppearance.BorderSize = 0;
            this.btnSingUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSingUP.ForeColor = System.Drawing.Color.White;
            this.btnSingUP.Location = new System.Drawing.Point(12, 257);
            this.btnSingUP.Name = "btnSingUP";
            this.btnSingUP.Size = new System.Drawing.Size(271, 29);
            this.btnSingUP.TabIndex = 7;
            this.btnSingUP.Text = "У меня нет аккаунта";
            this.btnSingUP.UseVisualStyleBackColor = false;
            this.btnSingUP.Click += new System.EventHandler(this.BtnSingUP_Click);
            // 
            // LogINForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(295, 313);
            this.Controls.Add(this.btnSingUP);
            this.Controls.Add(this.btnLogIN);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.inpPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.inpLogin);
            this.Controls.Add(this.pbLogotype);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogINForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.LogINForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogotype)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogotype;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox inpLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox inpPassword;
        private System.Windows.Forms.Button btnLogIN;
        private System.Windows.Forms.Button btnSingUP;
    }
}

