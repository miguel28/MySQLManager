namespace MySQL_Manager
{
    partial class frmManagerMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerMain));
			this.btnBackup = new System.Windows.Forms.Button();
			this.grpBackup = new System.Windows.Forms.GroupBox();
			this.btnCustom = new System.Windows.Forms.Button();
			this.btnDesktop = new System.Windows.Forms.Button();
			this.txtFolder = new System.Windows.Forms.TextBox();
			this.lbl_Folder = new System.Windows.Forms.Label();
			this.btnBackupselected = new System.Windows.Forms.Button();
			this.lstTables = new System.Windows.Forms.ListBox();
			this.grpRestore = new System.Windows.Forms.GroupBox();
			this.btnRestoreToSelected = new System.Windows.Forms.Button();
			this.txtImportFile = new System.Windows.Forms.TextBox();
			this.lblFiles = new System.Windows.Forms.Label();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.grpCodeGenerator = new System.Windows.Forms.GroupBox();
			this.EditCodeGenerator = new System.Windows.Forms.Button();
			this.btnGenerateCode = new System.Windows.Forms.Button();
			this.txtGeneratedCode = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.grpBackup.SuspendLayout();
			this.grpRestore.SuspendLayout();
			this.grpCodeGenerator.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBackup
			// 
			this.btnBackup.Location = new System.Drawing.Point(7, 57);
			this.btnBackup.Name = "btnBackup";
			this.btnBackup.Size = new System.Drawing.Size(104, 27);
			this.btnBackup.TabIndex = 0;
			this.btnBackup.Text = "Backup All Tables";
			this.btnBackup.UseVisualStyleBackColor = true;
			this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
			// 
			// grpBackup
			// 
			this.grpBackup.Controls.Add(this.btnCustom);
			this.grpBackup.Controls.Add(this.btnDesktop);
			this.grpBackup.Controls.Add(this.txtFolder);
			this.grpBackup.Controls.Add(this.lbl_Folder);
			this.grpBackup.Controls.Add(this.btnBackupselected);
			this.grpBackup.Controls.Add(this.btnBackup);
			this.grpBackup.Location = new System.Drawing.Point(3, 3);
			this.grpBackup.Name = "grpBackup";
			this.grpBackup.Size = new System.Drawing.Size(481, 95);
			this.grpBackup.TabIndex = 1;
			this.grpBackup.TabStop = false;
			this.grpBackup.Text = "Backup Excel";
			this.grpBackup.UseCompatibleTextRendering = true;
			// 
			// btnCustom
			// 
			this.btnCustom.Location = new System.Drawing.Point(391, 55);
			this.btnCustom.Name = "btnCustom";
			this.btnCustom.Size = new System.Drawing.Size(75, 23);
			this.btnCustom.TabIndex = 5;
			this.btnCustom.Text = "Custom";
			this.btnCustom.UseVisualStyleBackColor = true;
			this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
			// 
			// btnDesktop
			// 
			this.btnDesktop.Location = new System.Drawing.Point(310, 55);
			this.btnDesktop.Name = "btnDesktop";
			this.btnDesktop.Size = new System.Drawing.Size(75, 23);
			this.btnDesktop.TabIndex = 4;
			this.btnDesktop.Text = "Desktop";
			this.btnDesktop.UseVisualStyleBackColor = true;
			this.btnDesktop.Click += new System.EventHandler(this.btnDesktop_Click);
			// 
			// txtFolder
			// 
			this.txtFolder.Location = new System.Drawing.Point(205, 26);
			this.txtFolder.Name = "txtFolder";
			this.txtFolder.ReadOnly = true;
			this.txtFolder.Size = new System.Drawing.Size(261, 20);
			this.txtFolder.TabIndex = 3;
			// 
			// lbl_Folder
			// 
			this.lbl_Folder.AutoSize = true;
			this.lbl_Folder.Location = new System.Drawing.Point(130, 29);
			this.lbl_Folder.Name = "lbl_Folder";
			this.lbl_Folder.Size = new System.Drawing.Size(69, 13);
			this.lbl_Folder.TabIndex = 2;
			this.lbl_Folder.Text = "Export Folder";
			// 
			// btnBackupselected
			// 
			this.btnBackupselected.Location = new System.Drawing.Point(8, 21);
			this.btnBackupselected.Name = "btnBackupselected";
			this.btnBackupselected.Size = new System.Drawing.Size(103, 25);
			this.btnBackupselected.TabIndex = 1;
			this.btnBackupselected.Text = "Backup Selected";
			this.btnBackupselected.UseVisualStyleBackColor = true;
			this.btnBackupselected.Click += new System.EventHandler(this.btnBackupselected_Click);
			// 
			// lstTables
			// 
			this.lstTables.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstTables.FormattingEnabled = true;
			this.lstTables.Location = new System.Drawing.Point(3, 3);
			this.lstTables.Name = "lstTables";
			this.lstTables.Size = new System.Drawing.Size(164, 208);
			this.lstTables.TabIndex = 2;
			// 
			// grpRestore
			// 
			this.grpRestore.Controls.Add(this.btnRestoreToSelected);
			this.grpRestore.Controls.Add(this.txtImportFile);
			this.grpRestore.Controls.Add(this.lblFiles);
			this.grpRestore.Controls.Add(this.btnBrowse);
			this.grpRestore.Location = new System.Drawing.Point(3, 104);
			this.grpRestore.Name = "grpRestore";
			this.grpRestore.Size = new System.Drawing.Size(481, 92);
			this.grpRestore.TabIndex = 3;
			this.grpRestore.TabStop = false;
			this.grpRestore.Text = "Restore";
			// 
			// btnRestoreToSelected
			// 
			this.btnRestoreToSelected.Location = new System.Drawing.Point(10, 43);
			this.btnRestoreToSelected.Name = "btnRestoreToSelected";
			this.btnRestoreToSelected.Size = new System.Drawing.Size(93, 37);
			this.btnRestoreToSelected.TabIndex = 3;
			this.btnRestoreToSelected.Text = "Restore To Selected";
			this.btnRestoreToSelected.UseVisualStyleBackColor = true;
			this.btnRestoreToSelected.Click += new System.EventHandler(this.btnRestoreToSelected_Click);
			// 
			// txtImportFile
			// 
			this.txtImportFile.Location = new System.Drawing.Point(36, 17);
			this.txtImportFile.Name = "txtImportFile";
			this.txtImportFile.ReadOnly = true;
			this.txtImportFile.Size = new System.Drawing.Size(351, 20);
			this.txtImportFile.TabIndex = 2;
			// 
			// lblFiles
			// 
			this.lblFiles.AutoSize = true;
			this.lblFiles.Location = new System.Drawing.Point(7, 20);
			this.lblFiles.Name = "lblFiles";
			this.lblFiles.Size = new System.Drawing.Size(23, 13);
			this.lblFiles.TabIndex = 1;
			this.lblFiles.Text = "File";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(393, 14);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 0;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(3, 217);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(164, 23);
			this.btnRefresh.TabIndex = 4;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// grpCodeGenerator
			// 
			this.grpCodeGenerator.Controls.Add(this.EditCodeGenerator);
			this.grpCodeGenerator.Controls.Add(this.btnGenerateCode);
			this.grpCodeGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpCodeGenerator.Location = new System.Drawing.Point(3, 253);
			this.grpCodeGenerator.Name = "grpCodeGenerator";
			this.grpCodeGenerator.Size = new System.Drawing.Size(675, 94);
			this.grpCodeGenerator.TabIndex = 5;
			this.grpCodeGenerator.TabStop = false;
			this.grpCodeGenerator.Text = "Code Generator";
			// 
			// EditCodeGenerator
			// 
			this.EditCodeGenerator.Location = new System.Drawing.Point(112, 19);
			this.EditCodeGenerator.Name = "EditCodeGenerator";
			this.EditCodeGenerator.Size = new System.Drawing.Size(104, 69);
			this.EditCodeGenerator.TabIndex = 1;
			this.EditCodeGenerator.Text = "Edit Code Generator Settings";
			this.EditCodeGenerator.UseVisualStyleBackColor = true;
			this.EditCodeGenerator.Click += new System.EventHandler(this.EditCodeGenerator_Click);
			// 
			// btnGenerateCode
			// 
			this.btnGenerateCode.Location = new System.Drawing.Point(10, 19);
			this.btnGenerateCode.Name = "btnGenerateCode";
			this.btnGenerateCode.Size = new System.Drawing.Size(96, 69);
			this.btnGenerateCode.TabIndex = 0;
			this.btnGenerateCode.Text = "Generate Code";
			this.btnGenerateCode.UseVisualStyleBackColor = true;
			this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
			// 
			// txtGeneratedCode
			// 
			this.txtGeneratedCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtGeneratedCode.Location = new System.Drawing.Point(3, 353);
			this.txtGeneratedCode.Multiline = true;
			this.txtGeneratedCode.Name = "txtGeneratedCode";
			this.txtGeneratedCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtGeneratedCode.Size = new System.Drawing.Size(675, 269);
			this.txtGeneratedCode.TabIndex = 2;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.txtGeneratedCode, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.grpCodeGenerator, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 625);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.btnRefresh, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.lstTables, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(675, 244);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.grpBackup);
			this.panel1.Controls.Add(this.grpRestore);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(173, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(499, 208);
			this.panel1.TabIndex = 5;
			// 
			// frmManagerMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(681, 625);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmManagerMain";
			this.Text = "MySQL Manager";
			this.grpBackup.ResumeLayout(false);
			this.grpBackup.PerformLayout();
			this.grpRestore.ResumeLayout(false);
			this.grpRestore.PerformLayout();
			this.grpCodeGenerator.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.Button btnBackupselected;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnDesktop;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lbl_Folder;
        private System.Windows.Forms.GroupBox grpRestore;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRestoreToSelected;
        private System.Windows.Forms.TextBox txtImportFile;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox grpCodeGenerator;
        private System.Windows.Forms.Button EditCodeGenerator;
        private System.Windows.Forms.Button btnGenerateCode;
        private System.Windows.Forms.TextBox txtGeneratedCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
    }
}