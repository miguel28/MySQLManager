namespace MySQL_Manager
{
    partial class frmCodeGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodeGenerator));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpCodeGenerator = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnCopy = new System.Windows.Forms.Button();
            this.EditCodeGenerator = new System.Windows.Forms.Button();
            this.btnGenerateCode = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCI_Model = new System.Windows.Forms.TabPage();
            this.txt_CI_Model_CodeGenerator = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabEmptyJSON = new System.Windows.Forms.TabPage();
            this.txt_JSONEmptyGen = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpCodeGenerator.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCI_Model.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CI_Model_CodeGenerator)).BeginInit();
            this.tabEmptyJSON.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_JSONEmptyGen)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.grpCodeGenerator, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 585);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpCodeGenerator
            // 
            this.grpCodeGenerator.Controls.Add(this.progressBar);
            this.grpCodeGenerator.Controls.Add(this.btnCopy);
            this.grpCodeGenerator.Controls.Add(this.EditCodeGenerator);
            this.grpCodeGenerator.Controls.Add(this.btnGenerateCode);
            this.grpCodeGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCodeGenerator.Location = new System.Drawing.Point(4, 4);
            this.grpCodeGenerator.Margin = new System.Windows.Forms.Padding(4);
            this.grpCodeGenerator.Name = "grpCodeGenerator";
            this.grpCodeGenerator.Padding = new System.Windows.Forms.Padding(4);
            this.grpCodeGenerator.Size = new System.Drawing.Size(849, 115);
            this.grpCodeGenerator.TabIndex = 6;
            this.grpCodeGenerator.TabStop = false;
            this.grpCodeGenerator.Text = "Code Generator";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(295, 23);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(322, 23);
            this.progressBar.TabIndex = 4;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCopy.Location = new System.Drawing.Point(712, 22);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(128, 85);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy To Clipboard";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // EditCodeGenerator
            // 
            this.EditCodeGenerator.Location = new System.Drawing.Point(149, 23);
            this.EditCodeGenerator.Margin = new System.Windows.Forms.Padding(4);
            this.EditCodeGenerator.Name = "EditCodeGenerator";
            this.EditCodeGenerator.Size = new System.Drawing.Size(139, 85);
            this.EditCodeGenerator.TabIndex = 1;
            this.EditCodeGenerator.Text = "Edit Code Generator Settings";
            this.EditCodeGenerator.UseVisualStyleBackColor = true;
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.Location = new System.Drawing.Point(13, 23);
            this.btnGenerateCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(128, 85);
            this.btnGenerateCode.TabIndex = 0;
            this.btnGenerateCode.Text = "Generate Code";
            this.btnGenerateCode.UseVisualStyleBackColor = true;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCI_Model);
            this.tabControl1.Controls.Add(this.tabEmptyJSON);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 456);
            this.tabControl1.TabIndex = 7;
            // 
            // tabCI_Model
            // 
            this.tabCI_Model.Controls.Add(this.txt_CI_Model_CodeGenerator);
            this.tabCI_Model.Location = new System.Drawing.Point(4, 25);
            this.tabCI_Model.Name = "tabCI_Model";
            this.tabCI_Model.Padding = new System.Windows.Forms.Padding(3);
            this.tabCI_Model.Size = new System.Drawing.Size(843, 427);
            this.tabCI_Model.TabIndex = 0;
            this.tabCI_Model.Text = "CI Model";
            this.tabCI_Model.UseVisualStyleBackColor = true;
            // 
            // txt_CI_Model_CodeGenerator
            // 
            this.txt_CI_Model_CodeGenerator.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txt_CI_Model_CodeGenerator.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.txt_CI_Model_CodeGenerator.BackBrush = null;
            this.txt_CI_Model_CodeGenerator.CharHeight = 18;
            this.txt_CI_Model_CodeGenerator.CharWidth = 10;
            this.txt_CI_Model_CodeGenerator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CI_Model_CodeGenerator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_CI_Model_CodeGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_CI_Model_CodeGenerator.IsReplaceMode = false;
            this.txt_CI_Model_CodeGenerator.Language = FastColoredTextBoxNS.Language.PHP;
            this.txt_CI_Model_CodeGenerator.Location = new System.Drawing.Point(3, 3);
            this.txt_CI_Model_CodeGenerator.Name = "txt_CI_Model_CodeGenerator";
            this.txt_CI_Model_CodeGenerator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_CI_Model_CodeGenerator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_CI_Model_CodeGenerator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_CI_Model_CodeGenerator.ServiceColors")));
            this.txt_CI_Model_CodeGenerator.Size = new System.Drawing.Size(837, 421);
            this.txt_CI_Model_CodeGenerator.TabIndex = 0;
            this.txt_CI_Model_CodeGenerator.Zoom = 100;
            // 
            // tabEmptyJSON
            // 
            this.tabEmptyJSON.Controls.Add(this.txt_JSONEmptyGen);
            this.tabEmptyJSON.Location = new System.Drawing.Point(4, 25);
            this.tabEmptyJSON.Name = "tabEmptyJSON";
            this.tabEmptyJSON.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmptyJSON.Size = new System.Drawing.Size(843, 427);
            this.tabEmptyJSON.TabIndex = 1;
            this.tabEmptyJSON.Text = "Empty JSON";
            this.tabEmptyJSON.UseVisualStyleBackColor = true;
            // 
            // txt_JSONEmptyGen
            // 
            this.txt_JSONEmptyGen.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txt_JSONEmptyGen.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.txt_JSONEmptyGen.BackBrush = null;
            this.txt_JSONEmptyGen.CharHeight = 18;
            this.txt_JSONEmptyGen.CharWidth = 10;
            this.txt_JSONEmptyGen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_JSONEmptyGen.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_JSONEmptyGen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_JSONEmptyGen.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txt_JSONEmptyGen.IsReplaceMode = false;
            this.txt_JSONEmptyGen.Language = FastColoredTextBoxNS.Language.JS;
            this.txt_JSONEmptyGen.Location = new System.Drawing.Point(3, 3);
            this.txt_JSONEmptyGen.Name = "txt_JSONEmptyGen";
            this.txt_JSONEmptyGen.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_JSONEmptyGen.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_JSONEmptyGen.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_JSONEmptyGen.ServiceColors")));
            this.txt_JSONEmptyGen.Size = new System.Drawing.Size(837, 421);
            this.txt_JSONEmptyGen.TabIndex = 1;
            this.txt_JSONEmptyGen.Zoom = 100;
            // 
            // frmCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCodeGenerator";
            this.Text = "Code Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpCodeGenerator.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCI_Model.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_CI_Model_CodeGenerator)).EndInit();
            this.tabEmptyJSON.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_JSONEmptyGen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpCodeGenerator;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button EditCodeGenerator;
        private System.Windows.Forms.Button btnGenerateCode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCI_Model;
        private System.Windows.Forms.TabPage tabEmptyJSON;
        private FastColoredTextBoxNS.FastColoredTextBox txt_CI_Model_CodeGenerator;
        private System.Windows.Forms.ProgressBar progressBar;
        private FastColoredTextBoxNS.FastColoredTextBox txt_JSONEmptyGen;
    }
}