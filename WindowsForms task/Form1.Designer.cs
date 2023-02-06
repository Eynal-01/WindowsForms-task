namespace WindowsFormsApp1
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
            this.londonbtn = new System.Windows.Forms.Button();
            this.bakubtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // londonbtn
            // 
            this.londonbtn.BackColor = System.Drawing.Color.Transparent;
            this.londonbtn.ForeColor = System.Drawing.Color.Red;
            this.londonbtn.Location = new System.Drawing.Point(508, 350);
            this.londonbtn.Name = "londonbtn";
            this.londonbtn.Size = new System.Drawing.Size(108, 43);
            this.londonbtn.TabIndex = 1;
            this.londonbtn.Text = "LONDON";
            this.londonbtn.UseVisualStyleBackColor = false;
            this.londonbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.londonbtn_MouseClick);
            // 
            // bakubtn
            // 
            this.bakubtn.BackColor = System.Drawing.Color.Transparent;
            this.bakubtn.ForeColor = System.Drawing.Color.Red;
            this.bakubtn.Location = new System.Drawing.Point(361, 350);
            this.bakubtn.Name = "bakubtn";
            this.bakubtn.Size = new System.Drawing.Size(108, 43);
            this.bakubtn.TabIndex = 2;
            this.bakubtn.Text = "BAKU";
            this.bakubtn.UseVisualStyleBackColor = false;
            this.bakubtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bakubtn_MouseClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::WindowsForms_task.Properties.Resources.Baku_photo1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bakubtn);
            this.Controls.Add(this.londonbtn);
            this.ForeColor = System.Drawing.Color.LightBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button londonbtn;
        private System.Windows.Forms.Button bakubtn;
    }
}

