namespace MySQL_Manager
{
    partial class frmEditSetting
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
			this.lbl_className = new System.Windows.Forms.Label();
			this.txtClassName = new System.Windows.Forms.TextBox();
			this.lstFunctions = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_className
			// 
			this.lbl_className.AutoSize = true;
			this.lbl_className.Location = new System.Drawing.Point(13, 13);
			this.lbl_className.Name = "lbl_className";
			this.lbl_className.Size = new System.Drawing.Size(63, 13);
			this.lbl_className.TabIndex = 4;
			this.lbl_className.Text = "Class Name";
			// 
			// txtClassName
			// 
			this.txtClassName.Location = new System.Drawing.Point(82, 10);
			this.txtClassName.Name = "txtClassName";
			this.txtClassName.Size = new System.Drawing.Size(233, 20);
			this.txtClassName.TabIndex = 5;
			// 
			// lstFunctions
			// 
			this.lstFunctions.FormattingEnabled = true;
			this.lstFunctions.Location = new System.Drawing.Point(16, 41);
			this.lstFunctions.Name = "lstFunctions";
			this.lstFunctions.Size = new System.Drawing.Size(299, 134);
			this.lstFunctions.TabIndex = 7;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(321, 41);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(322, 71);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 9;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(322, 101);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 10;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(322, 151);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmEditSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 187);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lstFunctions);
			this.Controls.Add(this.txtClassName);
			this.Controls.Add(this.lbl_className);
			this.Name = "frmEditSetting";
			this.Text = "Generator Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label lbl_className;
		private System.Windows.Forms.TextBox txtClassName;
		private System.Windows.Forms.ListBox lstFunctions;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnSave;
    }
}