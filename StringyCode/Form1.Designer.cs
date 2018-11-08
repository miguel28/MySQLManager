namespace StringyCode
{
    partial class frmStringy
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
            this.btnStringy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStringy
            // 
            this.btnStringy.Location = new System.Drawing.Point(12, 12);
            this.btnStringy.Name = "btnStringy";
            this.btnStringy.Size = new System.Drawing.Size(231, 109);
            this.btnStringy.TabIndex = 0;
            this.btnStringy.Text = "Stringy Clipboard";
            this.btnStringy.UseVisualStyleBackColor = true;
            this.btnStringy.Click += new System.EventHandler(this.btnStringy_Click);
            // 
            // frmStringy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 133);
            this.Controls.Add(this.btnStringy);
            this.Name = "frmStringy";
            this.Text = "Stringy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStringy;
    }
}

