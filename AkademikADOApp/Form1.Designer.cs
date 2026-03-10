namespace AkademikADOApp
{
    partial class Form1
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
            this.btnconnect = new System.Windows.Forms.Button();
            this.btndisconnected = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(506, 312);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(195, 25);
            this.btnconnect.TabIndex = 0;
            this.btnconnect.Text = "connect Database";
            this.btnconnect.UseVisualStyleBackColor = true;
            // 
            // btndisconnected
            // 
            this.btndisconnected.Location = new System.Drawing.Point(126, 312);
            this.btndisconnected.Name = "btndisconnected";
            this.btndisconnected.Size = new System.Drawing.Size(195, 25);
            this.btndisconnected.TabIndex = 1;
            this.btndisconnected.Text = "disconnect Database";
            this.btndisconnected.UseVisualStyleBackColor = true;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(269, 88);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(53, 20);
            this.lblstatus.TabIndex = 2;
            this.lblstatus.Text = "status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btndisconnected);
            this.Controls.Add(this.btnconnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Button btndisconnected;
        private System.Windows.Forms.Label lblstatus;
    }
}

