namespace MySQL_Manager
{
    partial class frmCodeGeneratorFromJson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodeGeneratorFromJson));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpCodeGenerator = new System.Windows.Forms.GroupBox();
            this.txtElementName = new System.Windows.Forms.TextBox();
            this.txtJsonInput = new FastColoredTextBoxNS.FastColoredTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnGenerateCode = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHTML = new System.Windows.Forms.TabPage();
            this.txt_HTML_FromJsonObj = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpCodeGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJsonInput)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabHTML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HTML_FromJsonObj)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 585);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpCodeGenerator
            // 
            this.grpCodeGenerator.Controls.Add(this.txtElementName);
            this.grpCodeGenerator.Controls.Add(this.txtJsonInput);
            this.grpCodeGenerator.Controls.Add(this.progressBar);
            this.grpCodeGenerator.Controls.Add(this.btnCopy);
            this.grpCodeGenerator.Controls.Add(this.btnGenerateCode);
            this.grpCodeGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCodeGenerator.Location = new System.Drawing.Point(4, 4);
            this.grpCodeGenerator.Margin = new System.Windows.Forms.Padding(4);
            this.grpCodeGenerator.Name = "grpCodeGenerator";
            this.grpCodeGenerator.Padding = new System.Windows.Forms.Padding(4);
            this.grpCodeGenerator.Size = new System.Drawing.Size(849, 185);
            this.grpCodeGenerator.TabIndex = 6;
            this.grpCodeGenerator.TabStop = false;
            this.grpCodeGenerator.Text = "Code Generator";
            // 
            // txtElementName
            // 
            this.txtElementName.Location = new System.Drawing.Point(325, 23);
            this.txtElementName.Name = "txtElementName";
            this.txtElementName.Size = new System.Drawing.Size(100, 22);
            this.txtElementName.TabIndex = 5;
            this.txtElementName.Text = "Element";
            // 
            // txtJsonInput
            // 
            this.txtJsonInput.AutoCompleteBracketsList = new char[] {
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
            this.txtJsonInput.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.txtJsonInput.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.txtJsonInput.BackBrush = null;
            this.txtJsonInput.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtJsonInput.CharHeight = 18;
            this.txtJsonInput.CharWidth = 10;
            this.txtJsonInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJsonInput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtJsonInput.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtJsonInput.IsReplaceMode = false;
            this.txtJsonInput.Language = FastColoredTextBoxNS.Language.JS;
            this.txtJsonInput.LeftBracket = '(';
            this.txtJsonInput.LeftBracket2 = '{';
            this.txtJsonInput.Location = new System.Drawing.Point(8, 22);
            this.txtJsonInput.Name = "txtJsonInput";
            this.txtJsonInput.Paddings = new System.Windows.Forms.Padding(0);
            this.txtJsonInput.RightBracket = ')';
            this.txtJsonInput.RightBracket2 = '}';
            this.txtJsonInput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtJsonInput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtJsonInput.ServiceColors")));
            this.txtJsonInput.Size = new System.Drawing.Size(282, 145);
            this.txtJsonInput.TabIndex = 2;
            this.txtJsonInput.Zoom = 100;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(556, 22);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(264, 23);
            this.progressBar.TabIndex = 4;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCopy.Location = new System.Drawing.Point(692, 68);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(128, 85);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy To Clipboard";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.Location = new System.Drawing.Point(556, 68);
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
            this.tabControl1.Controls.Add(this.tabHTML);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 196);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 386);
            this.tabControl1.TabIndex = 7;
            // 
            // tabHTML
            // 
            this.tabHTML.Controls.Add(this.txt_HTML_FromJsonObj);
            this.tabHTML.Location = new System.Drawing.Point(4, 25);
            this.tabHTML.Name = "tabHTML";
            this.tabHTML.Size = new System.Drawing.Size(843, 357);
            this.tabHTML.TabIndex = 3;
            this.tabHTML.Text = "HTML";
            this.tabHTML.UseVisualStyleBackColor = true;
            // 
            // txt_HTML_FromJsonObj
            // 
            this.txt_HTML_FromJsonObj.AutoCompleteBracketsList = new char[] {
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
            this.txt_HTML_FromJsonObj.AutoIndentCharsPatterns = "";
            this.txt_HTML_FromJsonObj.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.txt_HTML_FromJsonObj.BackBrush = null;
            this.txt_HTML_FromJsonObj.CharHeight = 18;
            this.txt_HTML_FromJsonObj.CharWidth = 10;
            this.txt_HTML_FromJsonObj.CommentPrefix = null;
            this.txt_HTML_FromJsonObj.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HTML_FromJsonObj.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_HTML_FromJsonObj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_HTML_FromJsonObj.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txt_HTML_FromJsonObj.IsReplaceMode = false;
            this.txt_HTML_FromJsonObj.Language = FastColoredTextBoxNS.Language.HTML;
            this.txt_HTML_FromJsonObj.LeftBracket = '<';
            this.txt_HTML_FromJsonObj.LeftBracket2 = '(';
            this.txt_HTML_FromJsonObj.Location = new System.Drawing.Point(0, 0);
            this.txt_HTML_FromJsonObj.Name = "txt_HTML_FromJsonObj";
            this.txt_HTML_FromJsonObj.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_HTML_FromJsonObj.RightBracket = '>';
            this.txt_HTML_FromJsonObj.RightBracket2 = ')';
            this.txt_HTML_FromJsonObj.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_HTML_FromJsonObj.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_HTML_FromJsonObj.ServiceColors")));
            this.txt_HTML_FromJsonObj.Size = new System.Drawing.Size(843, 357);
            this.txt_HTML_FromJsonObj.TabIndex = 1;
            this.txt_HTML_FromJsonObj.Zoom = 100;
            // 
            // frmCodeGeneratorFromJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCodeGeneratorFromJson";
            this.Text = "Code Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpCodeGenerator.ResumeLayout(false);
            this.grpCodeGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJsonInput)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabHTML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_HTML_FromJsonObj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpCodeGenerator;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnGenerateCode;
        private System.Windows.Forms.ProgressBar progressBar;
        private FastColoredTextBoxNS.FastColoredTextBox txtJsonInput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHTML;
        private FastColoredTextBoxNS.FastColoredTextBox txt_HTML_FromJsonObj;
        private System.Windows.Forms.TextBox txtElementName;
    }
}