
namespace RemotingServer
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
            this.Button1_Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button1_Load
            // 
            this.Button1_Load.Location = new System.Drawing.Point(263, 105);
            this.Button1_Load.Name = "Button1_Load";
            this.Button1_Load.Size = new System.Drawing.Size(305, 94);
            this.Button1_Load.TabIndex = 0;
            this.Button1_Load.Text = "button1";
            this.Button1_Load.UseVisualStyleBackColor = true;
            this.Button1_Load.Click += new System.EventHandler(this.Button1_Load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button1_Load);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button1_Load;
    }
}

