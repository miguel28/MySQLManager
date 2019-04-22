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
            this.tabCIController = new System.Windows.Forms.TabPage();
            this.txt_CI_Controler_Generator = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabHTML = new System.Windows.Forms.TabPage();
            this.txt_HTML_Generator = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabASPCOREModel = new System.Windows.Forms.TabPage();
            this.txt_ASPCore_Model_Generator = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabASPCoreClassModel = new System.Windows.Forms.TabPage();
            this.txt_ASPCore_ModelClass_Generator = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabASPCoreController = new System.Windows.Forms.TabPage();
            this.txt_ASPCore_Controller_Generator = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpCodeGenerator.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCI_Model.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CI_Model_CodeGenerator)).BeginInit();
            this.tabEmptyJSON.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_JSONEmptyGen)).BeginInit();
            this.tabCIController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CI_Controler_Generator)).BeginInit();
            this.tabHTML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HTML_Generator)).BeginInit();
            this.tabASPCOREModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ASPCore_Model_Generator)).BeginInit();
            this.tabASPCoreClassModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ASPCore_ModelClass_Generator)).BeginInit();
            this.tabASPCoreController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ASPCore_Controller_Generator)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabCIController);
            this.tabControl1.Controls.Add(this.tabHTML);
            this.tabControl1.Controls.Add(this.tabASPCOREModel);
            this.tabControl1.Controls.Add(this.tabASPCoreClassModel);
            this.tabControl1.Controls.Add(this.tabASPCoreController);
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
            this.txt_CI_Model_CodeGenerator.AutoIndentCharsPatterns = "\r\n^\\s*\\$[\\w\\.\\[\\]\\\'\\\"]+\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.txt_CI_Model_CodeGenerator.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.txt_CI_Model_CodeGenerator.BackBrush = null;
            this.txt_CI_Model_CodeGenerator.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_CI_Model_CodeGenerator.CharHeight = 18;
            this.txt_CI_Model_CodeGenerator.CharWidth = 10;
            this.txt_CI_Model_CodeGenerator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CI_Model_CodeGenerator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_CI_Model_CodeGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_CI_Model_CodeGenerator.IsReplaceMode = false;
            this.txt_CI_Model_CodeGenerator.Language = FastColoredTextBoxNS.Language.PHP;
            this.txt_CI_Model_CodeGenerator.LeftBracket = '(';
            this.txt_CI_Model_CodeGenerator.LeftBracket2 = '{';
            this.txt_CI_Model_CodeGenerator.Location = new System.Drawing.Point(3, 3);
            this.txt_CI_Model_CodeGenerator.Name = "txt_CI_Model_CodeGenerator";
            this.txt_CI_Model_CodeGenerator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_CI_Model_CodeGenerator.RightBracket = ')';
            this.txt_CI_Model_CodeGenerator.RightBracket2 = '}';
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
            this.txt_JSONEmptyGen.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.txt_JSONEmptyGen.AutoScrollMinSize = new System.Drawing.Size(2, 18);
            this.txt_JSONEmptyGen.BackBrush = null;
            this.txt_JSONEmptyGen.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_JSONEmptyGen.CharHeight = 18;
            this.txt_JSONEmptyGen.CharWidth = 10;
            this.txt_JSONEmptyGen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_JSONEmptyGen.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_JSONEmptyGen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_JSONEmptyGen.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txt_JSONEmptyGen.IsReplaceMode = false;
            this.txt_JSONEmptyGen.Language = FastColoredTextBoxNS.Language.JS;
            this.txt_JSONEmptyGen.LeftBracket = '(';
            this.txt_JSONEmptyGen.LeftBracket2 = '{';
            this.txt_JSONEmptyGen.Location = new System.Drawing.Point(3, 3);
            this.txt_JSONEmptyGen.Name = "txt_JSONEmptyGen";
            this.txt_JSONEmptyGen.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_JSONEmptyGen.RightBracket = ')';
            this.txt_JSONEmptyGen.RightBracket2 = '}';
            this.txt_JSONEmptyGen.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_JSONEmptyGen.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_JSONEmptyGen.ServiceColors")));
            this.txt_JSONEmptyGen.Size = new System.Drawing.Size(837, 421);
            this.txt_JSONEmptyGen.TabIndex = 1;
            this.txt_JSONEmptyGen.Zoom = 100;
            // 
            // tabCIController
            // 
            this.tabCIController.Controls.Add(this.txt_CI_Controler_Generator);
            this.tabCIController.Location = new System.Drawing.Point(4, 25);
            this.tabCIController.Name = "tabCIController";
            this.tabCIController.Size = new System.Drawing.Size(843, 427);
            this.tabCIController.TabIndex = 2;
            this.tabCIController.Text = "CI Controller";
            this.tabCIController.UseVisualStyleBackColor = true;
            // 
            // txt_CI_Controler_Generator
            // 
            this.txt_CI_Controler_Generator.AutoCompleteBracketsList = new char[] {
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
            this.txt_CI_Controler_Generator.AutoIndentCharsPatterns = "\r\n^\\s*\\$[\\w\\.\\[\\]\\\'\\\"]+\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.txt_CI_Controler_Generator.AutoScrollMinSize = new System.Drawing.Size(2, 18);
            this.txt_CI_Controler_Generator.BackBrush = null;
            this.txt_CI_Controler_Generator.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_CI_Controler_Generator.CharHeight = 18;
            this.txt_CI_Controler_Generator.CharWidth = 10;
            this.txt_CI_Controler_Generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CI_Controler_Generator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_CI_Controler_Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_CI_Controler_Generator.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txt_CI_Controler_Generator.IsReplaceMode = false;
            this.txt_CI_Controler_Generator.Language = FastColoredTextBoxNS.Language.PHP;
            this.txt_CI_Controler_Generator.LeftBracket = '(';
            this.txt_CI_Controler_Generator.LeftBracket2 = '{';
            this.txt_CI_Controler_Generator.Location = new System.Drawing.Point(0, 0);
            this.txt_CI_Controler_Generator.Name = "txt_CI_Controler_Generator";
            this.txt_CI_Controler_Generator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_CI_Controler_Generator.RightBracket = ')';
            this.txt_CI_Controler_Generator.RightBracket2 = '}';
            this.txt_CI_Controler_Generator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_CI_Controler_Generator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_CI_Controler_Generator.ServiceColors")));
            this.txt_CI_Controler_Generator.Size = new System.Drawing.Size(843, 427);
            this.txt_CI_Controler_Generator.TabIndex = 0;
            this.txt_CI_Controler_Generator.Zoom = 100;
            // 
            // tabHTML
            // 
            this.tabHTML.Controls.Add(this.txt_HTML_Generator);
            this.tabHTML.Location = new System.Drawing.Point(4, 25);
            this.tabHTML.Name = "tabHTML";
            this.tabHTML.Size = new System.Drawing.Size(843, 427);
            this.tabHTML.TabIndex = 3;
            this.tabHTML.Text = "HTML";
            this.tabHTML.UseVisualStyleBackColor = true;
            // 
            // txt_HTML_Generator
            // 
            this.txt_HTML_Generator.AutoCompleteBracketsList = new char[] {
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
            this.txt_HTML_Generator.AutoIndentCharsPatterns = "";
            this.txt_HTML_Generator.AutoScrollMinSize = new System.Drawing.Size(2, 18);
            this.txt_HTML_Generator.BackBrush = null;
            this.txt_HTML_Generator.CharHeight = 18;
            this.txt_HTML_Generator.CharWidth = 10;
            this.txt_HTML_Generator.CommentPrefix = null;
            this.txt_HTML_Generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HTML_Generator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_HTML_Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_HTML_Generator.IsReplaceMode = false;
            this.txt_HTML_Generator.Language = FastColoredTextBoxNS.Language.HTML;
            this.txt_HTML_Generator.LeftBracket = '<';
            this.txt_HTML_Generator.LeftBracket2 = '(';
            this.txt_HTML_Generator.Location = new System.Drawing.Point(0, 0);
            this.txt_HTML_Generator.Name = "txt_HTML_Generator";
            this.txt_HTML_Generator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_HTML_Generator.RightBracket = '>';
            this.txt_HTML_Generator.RightBracket2 = ')';
            this.txt_HTML_Generator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_HTML_Generator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_HTML_Generator.ServiceColors")));
            this.txt_HTML_Generator.Size = new System.Drawing.Size(843, 427);
            this.txt_HTML_Generator.TabIndex = 1;
            this.txt_HTML_Generator.Zoom = 100;
            // 
            // tabASPCOREModel
            // 
            this.tabASPCOREModel.Controls.Add(this.txt_ASPCore_Model_Generator);
            this.tabASPCOREModel.Location = new System.Drawing.Point(4, 25);
            this.tabASPCOREModel.Name = "tabASPCOREModel";
            this.tabASPCOREModel.Size = new System.Drawing.Size(843, 427);
            this.tabASPCOREModel.TabIndex = 4;
            this.tabASPCOREModel.Text = "ASPCORE Model";
            this.tabASPCOREModel.UseVisualStyleBackColor = true;
            // 
            // txt_ASPCore_Model_Generator
            // 
            this.txt_ASPCore_Model_Generator.AutoCompleteBracketsList = new char[] {
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
            this.txt_ASPCore_Model_Generator.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txt_ASPCore_Model_Generator.AutoScrollMinSize = new System.Drawing.Size(2, 18);
            this.txt_ASPCore_Model_Generator.BackBrush = null;
            this.txt_ASPCore_Model_Generator.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_ASPCore_Model_Generator.CharHeight = 18;
            this.txt_ASPCore_Model_Generator.CharWidth = 10;
            this.txt_ASPCore_Model_Generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ASPCore_Model_Generator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_ASPCore_Model_Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ASPCore_Model_Generator.IsReplaceMode = false;
            this.txt_ASPCore_Model_Generator.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txt_ASPCore_Model_Generator.LeftBracket = '(';
            this.txt_ASPCore_Model_Generator.LeftBracket2 = '{';
            this.txt_ASPCore_Model_Generator.Location = new System.Drawing.Point(0, 0);
            this.txt_ASPCore_Model_Generator.Name = "txt_ASPCore_Model_Generator";
            this.txt_ASPCore_Model_Generator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_ASPCore_Model_Generator.RightBracket = ')';
            this.txt_ASPCore_Model_Generator.RightBracket2 = '}';
            this.txt_ASPCore_Model_Generator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_ASPCore_Model_Generator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_ASPCore_Model_Generator.ServiceColors")));
            this.txt_ASPCore_Model_Generator.Size = new System.Drawing.Size(843, 427);
            this.txt_ASPCore_Model_Generator.TabIndex = 2;
            this.txt_ASPCore_Model_Generator.Zoom = 100;
            // 
            // tabASPCoreClassModel
            // 
            this.tabASPCoreClassModel.Controls.Add(this.txt_ASPCore_ModelClass_Generator);
            this.tabASPCoreClassModel.Location = new System.Drawing.Point(4, 25);
            this.tabASPCoreClassModel.Name = "tabASPCoreClassModel";
            this.tabASPCoreClassModel.Size = new System.Drawing.Size(843, 427);
            this.tabASPCoreClassModel.TabIndex = 5;
            this.tabASPCoreClassModel.Text = "ASPCoreClassModel";
            this.tabASPCoreClassModel.UseVisualStyleBackColor = true;
            // 
            // txt_ASPCore_ModelClass_Generator
            // 
            this.txt_ASPCore_ModelClass_Generator.AutoCompleteBracketsList = new char[] {
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
            this.txt_ASPCore_ModelClass_Generator.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txt_ASPCore_ModelClass_Generator.AutoScrollMinSize = new System.Drawing.Size(2, 18);
            this.txt_ASPCore_ModelClass_Generator.BackBrush = null;
            this.txt_ASPCore_ModelClass_Generator.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_ASPCore_ModelClass_Generator.CharHeight = 18;
            this.txt_ASPCore_ModelClass_Generator.CharWidth = 10;
            this.txt_ASPCore_ModelClass_Generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ASPCore_ModelClass_Generator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_ASPCore_ModelClass_Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ASPCore_ModelClass_Generator.IsReplaceMode = false;
            this.txt_ASPCore_ModelClass_Generator.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txt_ASPCore_ModelClass_Generator.LeftBracket = '(';
            this.txt_ASPCore_ModelClass_Generator.LeftBracket2 = '{';
            this.txt_ASPCore_ModelClass_Generator.Location = new System.Drawing.Point(0, 0);
            this.txt_ASPCore_ModelClass_Generator.Name = "txt_ASPCore_ModelClass_Generator";
            this.txt_ASPCore_ModelClass_Generator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_ASPCore_ModelClass_Generator.RightBracket = ')';
            this.txt_ASPCore_ModelClass_Generator.RightBracket2 = '}';
            this.txt_ASPCore_ModelClass_Generator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_ASPCore_ModelClass_Generator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_ASPCore_ModelClass_Generator.ServiceColors")));
            this.txt_ASPCore_ModelClass_Generator.Size = new System.Drawing.Size(843, 427);
            this.txt_ASPCore_ModelClass_Generator.TabIndex = 3;
            this.txt_ASPCore_ModelClass_Generator.Zoom = 100;
            // 
            // tabASPCoreController
            // 
            this.tabASPCoreController.Controls.Add(this.txt_ASPCore_Controller_Generator);
            this.tabASPCoreController.Location = new System.Drawing.Point(4, 25);
            this.tabASPCoreController.Name = "tabASPCoreController";
            this.tabASPCoreController.Size = new System.Drawing.Size(843, 427);
            this.tabASPCoreController.TabIndex = 6;
            this.tabASPCoreController.Text = "ASPCoreController";
            this.tabASPCoreController.UseVisualStyleBackColor = true;
            // 
            // txt_ASPCore_Controller_Generator
            // 
            this.txt_ASPCore_Controller_Generator.AutoCompleteBracketsList = new char[] {
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
            this.txt_ASPCore_Controller_Generator.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txt_ASPCore_Controller_Generator.AutoScrollMinSize = new System.Drawing.Size(2, 18);
            this.txt_ASPCore_Controller_Generator.BackBrush = null;
            this.txt_ASPCore_Controller_Generator.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_ASPCore_Controller_Generator.CharHeight = 18;
            this.txt_ASPCore_Controller_Generator.CharWidth = 10;
            this.txt_ASPCore_Controller_Generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ASPCore_Controller_Generator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_ASPCore_Controller_Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ASPCore_Controller_Generator.IsReplaceMode = false;
            this.txt_ASPCore_Controller_Generator.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txt_ASPCore_Controller_Generator.LeftBracket = '(';
            this.txt_ASPCore_Controller_Generator.LeftBracket2 = '{';
            this.txt_ASPCore_Controller_Generator.Location = new System.Drawing.Point(0, 0);
            this.txt_ASPCore_Controller_Generator.Name = "txt_ASPCore_Controller_Generator";
            this.txt_ASPCore_Controller_Generator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_ASPCore_Controller_Generator.RightBracket = ')';
            this.txt_ASPCore_Controller_Generator.RightBracket2 = '}';
            this.txt_ASPCore_Controller_Generator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_ASPCore_Controller_Generator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_ASPCore_Controller_Generator.ServiceColors")));
            this.txt_ASPCore_Controller_Generator.Size = new System.Drawing.Size(843, 427);
            this.txt_ASPCore_Controller_Generator.TabIndex = 4;
            this.txt_ASPCore_Controller_Generator.Zoom = 100;
            // 
            // frmCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Code Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpCodeGenerator.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCI_Model.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_CI_Model_CodeGenerator)).EndInit();
            this.tabEmptyJSON.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_JSONEmptyGen)).EndInit();
            this.tabCIController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_CI_Controler_Generator)).EndInit();
            this.tabHTML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_HTML_Generator)).EndInit();
            this.tabASPCOREModel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ASPCore_Model_Generator)).EndInit();
            this.tabASPCoreClassModel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ASPCore_ModelClass_Generator)).EndInit();
            this.tabASPCoreController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ASPCore_Controller_Generator)).EndInit();
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
        private System.Windows.Forms.TabPage tabCIController;
        private FastColoredTextBoxNS.FastColoredTextBox txt_CI_Controler_Generator;
        private System.Windows.Forms.TabPage tabHTML;
        private FastColoredTextBoxNS.FastColoredTextBox txt_HTML_Generator;
        private System.Windows.Forms.TabPage tabASPCOREModel;
        private System.Windows.Forms.TabPage tabASPCoreClassModel;
        private System.Windows.Forms.TabPage tabASPCoreController;
        private FastColoredTextBoxNS.FastColoredTextBox txt_ASPCore_Model_Generator;
        private FastColoredTextBoxNS.FastColoredTextBox txt_ASPCore_ModelClass_Generator;
        private FastColoredTextBoxNS.FastColoredTextBox txt_ASPCore_Controller_Generator;
    }
}