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
            this.btnOpenGenByJson = new System.Windows.Forms.Button();
            this.btnOpenCodeGenerator = new System.Windows.Forms.Button();
            this.EditCodeGenerator = new System.Windows.Forms.Button();
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
            this.btnBackup.Location = new System.Drawing.Point(9, 70);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(139, 33);
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
            this.grpBackup.Location = new System.Drawing.Point(4, 4);
            this.grpBackup.Margin = new System.Windows.Forms.Padding(4);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Padding = new System.Windows.Forms.Padding(4);
            this.grpBackup.Size = new System.Drawing.Size(641, 117);
            this.grpBackup.TabIndex = 1;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "Backup Excel";
            this.grpBackup.UseCompatibleTextRendering = true;
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(521, 68);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(100, 28);
            this.btnCustom.TabIndex = 5;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnDesktop
            // 
            this.btnDesktop.Location = new System.Drawing.Point(413, 68);
            this.btnDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesktop.Name = "btnDesktop";
            this.btnDesktop.Size = new System.Drawing.Size(100, 28);
            this.btnDesktop.TabIndex = 4;
            this.btnDesktop.Text = "Desktop";
            this.btnDesktop.UseVisualStyleBackColor = true;
            this.btnDesktop.Click += new System.EventHandler(this.btnDesktop_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(273, 32);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(347, 22);
            this.txtFolder.TabIndex = 3;
            // 
            // lbl_Folder
            // 
            this.lbl_Folder.AutoSize = true;
            this.lbl_Folder.Location = new System.Drawing.Point(173, 36);
            this.lbl_Folder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Folder.Name = "lbl_Folder";
            this.lbl_Folder.Size = new System.Drawing.Size(92, 17);
            this.lbl_Folder.TabIndex = 2;
            this.lbl_Folder.Text = "Export Folder";
            // 
            // btnBackupselected
            // 
            this.btnBackupselected.Location = new System.Drawing.Point(11, 26);
            this.btnBackupselected.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackupselected.Name = "btnBackupselected";
            this.btnBackupselected.Size = new System.Drawing.Size(137, 31);
            this.btnBackupselected.TabIndex = 1;
            this.btnBackupselected.Text = "Backup Selected";
            this.btnBackupselected.UseVisualStyleBackColor = true;
            this.btnBackupselected.Click += new System.EventHandler(this.btnBackupselected_Click);
            // 
            // lstTables
            // 
            this.lstTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTables.FormattingEnabled = true;
            this.lstTables.ItemHeight = 16;
            this.lstTables.Location = new System.Drawing.Point(4, 4);
            this.lstTables.Margin = new System.Windows.Forms.Padding(4);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(219, 255);
            this.lstTables.TabIndex = 2;
            // 
            // grpRestore
            // 
            this.grpRestore.Controls.Add(this.btnRestoreToSelected);
            this.grpRestore.Controls.Add(this.txtImportFile);
            this.grpRestore.Controls.Add(this.lblFiles);
            this.grpRestore.Controls.Add(this.btnBrowse);
            this.grpRestore.Location = new System.Drawing.Point(4, 128);
            this.grpRestore.Margin = new System.Windows.Forms.Padding(4);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Padding = new System.Windows.Forms.Padding(4);
            this.grpRestore.Size = new System.Drawing.Size(641, 113);
            this.grpRestore.TabIndex = 3;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "Restore";
            // 
            // btnRestoreToSelected
            // 
            this.btnRestoreToSelected.Location = new System.Drawing.Point(13, 53);
            this.btnRestoreToSelected.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestoreToSelected.Name = "btnRestoreToSelected";
            this.btnRestoreToSelected.Size = new System.Drawing.Size(124, 46);
            this.btnRestoreToSelected.TabIndex = 3;
            this.btnRestoreToSelected.Text = "Restore To Selected";
            this.btnRestoreToSelected.UseVisualStyleBackColor = true;
            this.btnRestoreToSelected.Click += new System.EventHandler(this.btnRestoreToSelected_Click);
            // 
            // txtImportFile
            // 
            this.txtImportFile.Location = new System.Drawing.Point(48, 21);
            this.txtImportFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtImportFile.Name = "txtImportFile";
            this.txtImportFile.ReadOnly = true;
            this.txtImportFile.Size = new System.Drawing.Size(467, 22);
            this.txtImportFile.TabIndex = 2;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(9, 25);
            this.lblFiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(30, 17);
            this.lblFiles.TabIndex = 1;
            this.lblFiles.Text = "File";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(524, 17);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(4, 267);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(219, 28);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grpCodeGenerator
            // 
            this.grpCodeGenerator.Controls.Add(this.btnOpenGenByJson);
            this.grpCodeGenerator.Controls.Add(this.btnOpenCodeGenerator);
            this.grpCodeGenerator.Controls.Add(this.EditCodeGenerator);
            this.grpCodeGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCodeGenerator.Location = new System.Drawing.Point(4, 312);
            this.grpCodeGenerator.Margin = new System.Windows.Forms.Padding(4);
            this.grpCodeGenerator.Name = "grpCodeGenerator";
            this.grpCodeGenerator.Padding = new System.Windows.Forms.Padding(4);
            this.grpCodeGenerator.Size = new System.Drawing.Size(900, 117);
            this.grpCodeGenerator.TabIndex = 5;
            this.grpCodeGenerator.TabStop = false;
            this.grpCodeGenerator.Text = "Code Generator";
            // 
            // btnOpenGenByJson
            // 
            this.btnOpenGenByJson.Location = new System.Drawing.Point(292, 22);
            this.btnOpenGenByJson.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenGenByJson.Name = "btnOpenGenByJson";
            this.btnOpenGenByJson.Size = new System.Drawing.Size(128, 85);
            this.btnOpenGenByJson.TabIndex = 5;
            this.btnOpenGenByJson.Text = "Open Code Generator By Json";
            this.btnOpenGenByJson.UseVisualStyleBackColor = true;
            this.btnOpenGenByJson.Click += new System.EventHandler(this.btnOpenGenByJson_Click);
            // 
            // btnOpenCodeGenerator
            // 
            this.btnOpenCodeGenerator.Location = new System.Drawing.Point(156, 22);
            this.btnOpenCodeGenerator.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenCodeGenerator.Name = "btnOpenCodeGenerator";
            this.btnOpenCodeGenerator.Size = new System.Drawing.Size(128, 85);
            this.btnOpenCodeGenerator.TabIndex = 4;
            this.btnOpenCodeGenerator.Text = "Open Code Generator";
            this.btnOpenCodeGenerator.UseVisualStyleBackColor = true;
            this.btnOpenCodeGenerator.Click += new System.EventHandler(this.btnOpenCodeGenerator_Click);
            // 
            // EditCodeGenerator
            // 
            this.EditCodeGenerator.Location = new System.Drawing.Point(9, 23);
            this.EditCodeGenerator.Margin = new System.Windows.Forms.Padding(4);
            this.EditCodeGenerator.Name = "EditCodeGenerator";
            this.EditCodeGenerator.Size = new System.Drawing.Size(139, 85);
            this.EditCodeGenerator.TabIndex = 1;
            this.EditCodeGenerator.Text = "Edit Code Generator Settings";
            this.EditCodeGenerator.UseVisualStyleBackColor = true;
            this.EditCodeGenerator.Click += new System.EventHandler(this.EditCodeGenerator_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpCodeGenerator, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(908, 433);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnRefresh, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lstTables, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(900, 300);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpBackup);
            this.panel1.Controls.Add(this.grpRestore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(231, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 255);
            this.panel1.TabIndex = 5;
            // 
            // frmManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManagerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MySQL Manager";
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            this.grpCodeGenerator.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpenCodeGenerator;
        private System.Windows.Forms.Button btnOpenGenByJson;
    }
}