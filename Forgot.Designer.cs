
namespace FOTOFIRST
{
    partial class frmForgot
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
            this.txtForgotPosition = new System.Windows.Forms.TextBox();
            this.txtForgotUsername = new System.Windows.Forms.TextBox();
            this.btnForgotConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your position:";
            // 
            // txtForgotPosition
            // 
            this.txtForgotPosition.Location = new System.Drawing.Point(158, 95);
            this.txtForgotPosition.Name = "txtForgotPosition";
            this.txtForgotPosition.Size = new System.Drawing.Size(100, 20);
            this.txtForgotPosition.TabIndex = 2;
            // 
            // txtForgotUsername
            // 
            this.txtForgotUsername.Location = new System.Drawing.Point(158, 35);
            this.txtForgotUsername.Name = "txtForgotUsername";
            this.txtForgotUsername.Size = new System.Drawing.Size(100, 20);
            this.txtForgotUsername.TabIndex = 3;
            // 
            // btnForgotConfirm
            // 
            this.btnForgotConfirm.Location = new System.Drawing.Point(183, 140);
            this.btnForgotConfirm.Name = "btnForgotConfirm";
            this.btnForgotConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnForgotConfirm.TabIndex = 4;
            this.btnForgotConfirm.Text = "Confirm";
            this.btnForgotConfirm.UseVisualStyleBackColor = true;
            this.btnForgotConfirm.Click += new System.EventHandler(this.btnForgotConfirm_Click);
            // 
            // frmForgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 204);
            this.Controls.Add(this.btnForgotConfirm);
            this.Controls.Add(this.txtForgotUsername);
            this.Controls.Add(this.txtForgotPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmForgot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForgotPosition;
        private System.Windows.Forms.TextBox txtForgotUsername;
        private System.Windows.Forms.Button btnForgotConfirm;
    }
}