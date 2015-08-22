namespace MySQL_Manager
{
	partial class frmEditFunctionSettings
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
			this.txtFunctionName = new System.Windows.Forms.TextBox();
			this.lblFunctionName = new System.Windows.Forms.Label();
			this.lstAvailableColumns = new System.Windows.Forms.ListBox();
			this.lstSelectedColumns = new System.Windows.Forms.ListBox();
			this.btnAddCol = new System.Windows.Forms.Button();
			this.btnRemoveCol = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.grpType = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// txtFunctionName
			// 
			this.txtFunctionName.Location = new System.Drawing.Point(96, 6);
			this.txtFunctionName.Name = "txtFunctionName";
			this.txtFunctionName.Size = new System.Drawing.Size(215, 20);
			this.txtFunctionName.TabIndex = 5;
			// 
			// lblFunctionName
			// 
			this.lblFunctionName.AutoSize = true;
			this.lblFunctionName.Location = new System.Drawing.Point(12, 9);
			this.lblFunctionName.Name = "lblFunctionName";
			this.lblFunctionName.Size = new System.Drawing.Size(79, 13);
			this.lblFunctionName.TabIndex = 4;
			this.lblFunctionName.Text = "Function Name";
			// 
			// lstAvailableColumns
			// 
			this.lstAvailableColumns.FormattingEnabled = true;
			this.lstAvailableColumns.Location = new System.Drawing.Point(12, 38);
			this.lstAvailableColumns.Name = "lstAvailableColumns";
			this.lstAvailableColumns.Size = new System.Drawing.Size(120, 173);
			this.lstAvailableColumns.TabIndex = 0;
			// 
			// lstSelectedColumns
			// 
			this.lstSelectedColumns.FormattingEnabled = true;
			this.lstSelectedColumns.Location = new System.Drawing.Point(191, 38);
			this.lstSelectedColumns.Name = "lstSelectedColumns";
			this.lstSelectedColumns.Size = new System.Drawing.Size(120, 173);
			this.lstSelectedColumns.TabIndex = 1;
			// 
			// btnAddCol
			// 
			this.btnAddCol.Location = new System.Drawing.Point(138, 87);
			this.btnAddCol.Name = "btnAddCol";
			this.btnAddCol.Size = new System.Drawing.Size(47, 23);
			this.btnAddCol.TabIndex = 2;
			this.btnAddCol.Text = ">>";
			this.btnAddCol.UseVisualStyleBackColor = true;
			// 
			// btnRemoveCol
			// 
			this.btnRemoveCol.Location = new System.Drawing.Point(138, 116);
			this.btnRemoveCol.Name = "btnRemoveCol";
			this.btnRemoveCol.Size = new System.Drawing.Size(47, 23);
			this.btnRemoveCol.TabIndex = 3;
			this.btnRemoveCol.Text = "<<";
			this.btnRemoveCol.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(331, 188);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// grpType
			// 
			this.grpType.Location = new System.Drawing.Point(331, 38);
			this.grpType.Name = "grpType";
			this.grpType.Size = new System.Drawing.Size(221, 120);
			this.grpType.TabIndex = 7;
			this.grpType.TabStop = false;
			this.grpType.Text = "Type of Function";
			// 
			// frmEditFunctionSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 224);
			this.Controls.Add(this.grpType);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lstSelectedColumns);
			this.Controls.Add(this.lstAvailableColumns);
			this.Controls.Add(this.btnRemoveCol);
			this.Controls.Add(this.btnAddCol);
			this.Controls.Add(this.lblFunctionName);
			this.Controls.Add(this.txtFunctionName);
			this.Name = "frmEditFunctionSettings";
			this.Text = "frmEditFunctionSettings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtFunctionName;
		private System.Windows.Forms.Label lblFunctionName;
		private System.Windows.Forms.ListBox lstAvailableColumns;
		private System.Windows.Forms.ListBox lstSelectedColumns;
		private System.Windows.Forms.Button btnAddCol;
		private System.Windows.Forms.Button btnRemoveCol;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox grpType;

	}
}