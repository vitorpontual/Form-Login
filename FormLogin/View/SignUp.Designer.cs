
namespace FormLogin.View
{
    partial class SignUp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btSubmit = new System.Windows.Forms.Button();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.txRePassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Repeat Password";
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(68, 168);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(144, 38);
            this.btSubmit.TabIndex = 3;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(47, 37);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(195, 23);
            this.txEmail.TabIndex = 0;
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(47, 81);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(195, 23);
            this.txPassword.TabIndex = 1;
            // 
            // txRePassword
            // 
            this.txRePassword.Location = new System.Drawing.Point(47, 125);
            this.txRePassword.Name = "txRePassword";
            this.txRePassword.Size = new System.Drawing.Size(195, 23);
            this.txRePassword.TabIndex = 2;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 247);
            this.Controls.Add(this.txRePassword);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.TextBox txRePassword;
    }
}