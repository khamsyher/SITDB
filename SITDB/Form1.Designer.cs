namespace SITDB
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
            this.cnbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cnbt
            // 
            this.cnbt.Location = new System.Drawing.Point(43, 34);
            this.cnbt.Name = "cnbt";
            this.cnbt.Size = new System.Drawing.Size(204, 52);
            this.cnbt.TabIndex = 0;
            this.cnbt.Text = "ConnectDB";
            this.cnbt.UseVisualStyleBackColor = true;
            this.cnbt.Click += new System.EventHandler(this.Cnbt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 487);
            this.Controls.Add(this.cnbt);
            this.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cnbt;
    }
}

