namespace GRU_H8_Test
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
            this.txtBoxLogName = new System.Windows.Forms.TextBox();
            this.txtBoxLogPass = new System.Windows.Forms.TextBox();
            this.BtnLogLogin = new System.Windows.Forms.Button();
            this.LblLogName = new System.Windows.Forms.Label();
            this.LblLogPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxLogName
            // 
            this.txtBoxLogName.Location = new System.Drawing.Point(116, 31);
            this.txtBoxLogName.Name = "txtBoxLogName";
            this.txtBoxLogName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLogName.TabIndex = 0;
            this.txtBoxLogName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxLogName_KeyDown);
            // 
            // txtBoxLogPass
            // 
            this.txtBoxLogPass.Location = new System.Drawing.Point(116, 83);
            this.txtBoxLogPass.Name = "txtBoxLogPass";
            this.txtBoxLogPass.PasswordChar = '*';
            this.txtBoxLogPass.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLogPass.TabIndex = 1;
            this.txtBoxLogPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxLogPass_KeyDown);
            // 
            // BtnLogLogin
            // 
            this.BtnLogLogin.Location = new System.Drawing.Point(88, 135);
            this.BtnLogLogin.Name = "BtnLogLogin";
            this.BtnLogLogin.Size = new System.Drawing.Size(103, 31);
            this.BtnLogLogin.TabIndex = 2;
            this.BtnLogLogin.Text = "Login";
            this.BtnLogLogin.UseVisualStyleBackColor = true;
            this.BtnLogLogin.Click += new System.EventHandler(this.BtnLogLogin_Click);
            // 
            // LblLogName
            // 
            this.LblLogName.AutoSize = true;
            this.LblLogName.Location = new System.Drawing.Point(52, 34);
            this.LblLogName.Name = "LblLogName";
            this.LblLogName.Size = new System.Drawing.Size(58, 13);
            this.LblLogName.TabIndex = 3;
            this.LblLogName.Text = "Username:";
            // 
            // LblLogPass
            // 
            this.LblLogPass.AutoSize = true;
            this.LblLogPass.Location = new System.Drawing.Point(54, 86);
            this.LblLogPass.Name = "LblLogPass";
            this.LblLogPass.Size = new System.Drawing.Size(56, 13);
            this.LblLogPass.TabIndex = 4;
            this.LblLogPass.Text = "Password:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 197);
            this.Controls.Add(this.LblLogPass);
            this.Controls.Add(this.LblLogName);
            this.Controls.Add(this.BtnLogLogin);
            this.Controls.Add(this.txtBoxLogPass);
            this.Controls.Add(this.txtBoxLogName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.ShowIcon = false;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxLogName;
        private System.Windows.Forms.TextBox txtBoxLogPass;
        private System.Windows.Forms.Button BtnLogLogin;
        private System.Windows.Forms.Label LblLogName;
        private System.Windows.Forms.Label LblLogPass;
    }
}

