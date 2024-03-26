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
            this.tabMain = new System.Windows.Forms.TabControl();
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
            this.tab_SimpleModelClass_Generator = new System.Windows.Forms.TabPage();
            this.txt_SimpleModelClass_Generator = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabWFDataGridview = new System.Windows.Forms.TabPage();
            this.txt_WF_Datagridview_Generator = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabBlazorCRUDView = new System.Windows.Forms.TabPage();
            this.txt_BlazorCRUDView_Generator = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabBlazorController = new System.Windows.Forms.TabPage();
            this.txt_BlazorController_Generator = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpCodeGenerator.SuspendLayout();
            this.tabMain.SuspendLayout();
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
            this.tab_SimpleModelClass_Generator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SimpleModelClass_Generator)).BeginInit();
            this.tabWFDataGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WF_Datagridview_Generator)).BeginInit();
            this.tabBlazorCRUDView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BlazorCRUDView_Generator)).BeginInit();
            this.tabBlazorController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BlazorController_Generator)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.grpCodeGenerator, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabMain, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(643, 475);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpCodeGenerator
            // 
            this.grpCodeGenerator.Controls.Add(this.progressBar);
            this.grpCodeGenerator.Controls.Add(this.btnCopy);
            this.grpCodeGenerator.Controls.Add(this.EditCodeGenerator);
            this.grpCodeGenerator.Controls.Add(this.btnGenerateCode);
            this.grpCodeGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCodeGenerator.Location = new System.Drawing.Point(3, 3);
            this.grpCodeGenerator.Name = "grpCodeGenerator";
            this.grpCodeGenerator.Size = new System.Drawing.Size(637, 94);
            this.grpCodeGenerator.TabIndex = 6;
            this.grpCodeGenerator.TabStop = false;
            this.grpCodeGenerator.Text = "Code Generator";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(221, 19);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(242, 19);
            this.progressBar.TabIndex = 4;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCopy.Location = new System.Drawing.Point(534, 18);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(96, 69);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy To Clipboard";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // EditCodeGenerator
            // 
            this.EditCodeGenerator.Location = new System.Drawing.Point(112, 19);
            this.EditCodeGenerator.Name = "EditCodeGenerator";
            this.EditCodeGenerator.Size = new System.Drawing.Size(104, 69);
            this.EditCodeGenerator.TabIndex = 1;
            this.EditCodeGenerator.Text = "Edit Code Generator Settings";
            this.EditCodeGenerator.UseVisualStyleBackColor = true;
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
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabCI_Model);
            this.tabMain.Controls.Add(this.tabEmptyJSON);
            this.tabMain.Controls.Add(this.tabCIController);
            this.tabMain.Controls.Add(this.tabHTML);
            this.tabMain.Controls.Add(this.tabASPCOREModel);
            this.tabMain.Controls.Add(this.tabASPCoreClassModel);
            this.tabMain.Controls.Add(this.tabASPCoreController);
            this.tabMain.Controls.Add(this.tab_SimpleModelClass_Generator);
            this.tabMain.Controls.Add(this.tabWFDataGridview);
            this.tabMain.Controls.Add(this.tabBlazorCRUDView);
            this.tabMain.Controls.Add(this.tabBlazorController);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(2, 102);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(639, 371);
            this.tabMain.TabIndex = 7;
            // 
            // tabCI_Model
            // 
            this.tabCI_Model.Controls.Add(this.txt_CI_Model_CodeGenerator);
            this.tabCI_Model.Location = new System.Drawing.Point(4, 22);
            this.tabCI_Model.Margin = new System.Windows.Forms.Padding(2);
            this.tabCI_Model.Name = "tabCI_Model";
            this.tabCI_Model.Padding = new System.Windows.Forms.Padding(2);
            this.tabCI_Model.Size = new System.Drawing.Size(631, 345);
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
            this.txt_CI_Model_CodeGenerator.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txt_CI_Model_CodeGenerator.BackBrush = null;
            this.txt_CI_Model_CodeGenerator.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_CI_Model_CodeGenerator.CharHeight = 14;
            this.txt_CI_Model_CodeGenerator.CharWidth = 8;
            this.txt_CI_Model_CodeGenerator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CI_Model_CodeGenerator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_CI_Model_CodeGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_CI_Model_CodeGenerator.IsReplaceMode = false;
            this.txt_CI_Model_CodeGenerator.Language = FastColoredTextBoxNS.Language.PHP;
            this.txt_CI_Model_CodeGenerator.LeftBracket = '(';
            this.txt_CI_Model_CodeGenerator.LeftBracket2 = '{';
            this.txt_CI_Model_CodeGenerator.Location = new System.Drawing.Point(2, 2);
            this.txt_CI_Model_CodeGenerator.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CI_Model_CodeGenerator.Name = "txt_CI_Model_CodeGenerator";
            this.txt_CI_Model_CodeGenerator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_CI_Model_CodeGenerator.RightBracket = ')';
            this.txt_CI_Model_CodeGenerator.RightBracket2 = '}';
            this.txt_CI_Model_CodeGenerator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_CI_Model_CodeGenerator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_CI_Model_CodeGenerator.ServiceColors")));
            this.txt_CI_Model_CodeGenerator.Size = new System.Drawing.Size(627, 341);
            this.txt_CI_Model_CodeGenerator.TabIndex = 0;
            this.txt_CI_Model_CodeGenerator.Zoom = 100;
            // 
            // tabEmptyJSON
            // 
            this.tabEmptyJSON.Controls.Add(this.txt_JSONEmptyGen);
            this.tabEmptyJSON.Location = new System.Drawing.Point(4, 22);
            this.tabEmptyJSON.Margin = new System.Windows.Forms.Padding(2);
            this.tabEmptyJSON.Name = "tabEmptyJSON";
            this.tabEmptyJSON.Padding = new System.Windows.Forms.Padding(2);
            this.tabEmptyJSON.Size = new System.Drawing.Size(631, 345);
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
            this.txt_JSONEmptyGen.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.txt_JSONEmptyGen.BackBrush = null;
            this.txt_JSONEmptyGen.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_JSONEmptyGen.CharHeight = 14;
            this.txt_JSONEmptyGen.CharWidth = 8;
            this.txt_JSONEmptyGen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_JSONEmptyGen.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_JSONEmptyGen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_JSONEmptyGen.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txt_JSONEmptyGen.IsReplaceMode = false;
            this.txt_JSONEmptyGen.Language = FastColoredTextBoxNS.Language.JS;
            this.txt_JSONEmptyGen.LeftBracket = '(';
            this.txt_JSONEmptyGen.LeftBracket2 = '{';
            this.txt_JSONEmptyGen.Location = new System.Drawing.Point(2, 2);
            this.txt_JSONEmptyGen.Margin = new System.Windows.Forms.Padding(2);
            this.txt_JSONEmptyGen.Name = "txt_JSONEmptyGen";
            this.txt_JSONEmptyGen.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_JSONEmptyGen.RightBracket = ')';
            this.txt_JSONEmptyGen.RightBracket2 = '}';
            this.txt_JSONEmptyGen.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_JSONEmptyGen.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_JSONEmptyGen.ServiceColors")));
            this.txt_JSONEmptyGen.Size = new System.Drawing.Size(627, 341);
            this.txt_JSONEmptyGen.TabIndex = 1;
            this.txt_JSONEmptyGen.Zoom = 100;
            // 
            // tabCIController
            // 
            this.tabCIController.Controls.Add(this.txt_CI_Controler_Generator);
            this.tabCIController.Location = new System.Drawing.Point(4, 22);
            this.tabCIController.Margin = new System.Windows.Forms.Padding(2);
            this.tabCIController.Name = "tabCIController";
            this.tabCIController.Size = new System.Drawing.Size(631, 345);
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
            this.txt_CI_Controler_Generator.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.txt_CI_Controler_Generator.BackBrush = null;
            this.txt_CI_Controler_Generator.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_CI_Controler_Generator.CharHeight = 14;
            this.txt_CI_Controler_Generator.CharWidth = 8;
            this.txt_CI_Controler_Generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CI_Controler_Generator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_CI_Controler_Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_CI_Controler_Generator.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txt_CI_Controler_Generator.IsReplaceMode = false;
            this.txt_CI_Controler_Generator.Language = FastColoredTextBoxNS.Language.PHP;
            this.txt_CI_Controler_Generator.LeftBracket = '(';
            this.txt_CI_Controler_Generator.LeftBracket2 = '{';
            this.txt_CI_Controler_Generator.Location = new System.Drawing.Point(0, 0);
            this.txt_CI_Controler_Generator.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CI_Controler_Generator.Name = "txt_CI_Controler_Generator";
            this.txt_CI_Controler_Generator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_CI_Controler_Generator.RightBracket = ')';
            this.txt_CI_Controler_Generator.RightBracket2 = '}';
            this.txt_CI_Controler_Generator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_CI_Controler_Generator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_CI_Controler_Generator.ServiceColors")));
            this.txt_CI_Controler_Generator.Size = new System.Drawing.Size(631, 345);
            this.txt_CI_Controler_Generator.TabIndex = 0;
            this.txt_CI_Controler_Generator.Zoom = 100;
            // 
            // tabHTML
            // 
            this.tabHTML.Controls.Add(this.txt_HTML_Generator);
            this.tabHTML.Location = new System.Drawing.Point(4, 22);
            this.tabHTML.Margin = new System.Windows.Forms.Padding(2);
            this.tabHTML.Name = "tabHTML";
            this.tabHTML.Size = new System.Drawing.Size(631, 345);
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
            this.txt_HTML_Generator.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.txt_HTML_Generator.BackBrush = null;
            this.txt_HTML_Generator.CharHeight = 14;
            this.txt_HTML_Generator.CharWidth = 8;
            this.txt_HTML_Generator.CommentPrefix = null;
            this.txt_HTML_Generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HTML_Generator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_HTML_Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_HTML_Generator.IsReplaceMode = false;
            this.txt_HTML_Generator.Language = FastColoredTextBoxNS.Language.HTML;
            this.txt_HTML_Generator.LeftBracket = '<';
            this.txt_HTML_Generator.LeftBracket2 = '(';
            this.txt_HTML_Generator.Location = new System.Drawing.Point(0, 0);
            this.txt_HTML_Generator.Margin = new System.Windows.Forms.Padding(2);
            this.txt_HTML_Generator.Name = "txt_HTML_Generator";
            this.txt_HTML_Generator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_HTML_Generator.RightBracket = '>';
            this.txt_HTML_Generator.RightBracket2 = ')';
            this.txt_HTML_Generator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_HTML_Generator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_HTML_Generator.ServiceColors")));
            this.txt_HTML_Generator.Size = new System.Drawing.Size(631, 345);
            this.txt_HTML_Generator.TabIndex = 1;
            this.txt_HTML_Generator.Zoom = 100;
            // 
            // tabASPCOREModel
            // 
            this.tabASPCOREModel.Controls.Add(this.txt_ASPCore_Model_Generator);
            this.tabASPCOREModel.Location = new System.Drawing.Point(4, 22);
            this.tabASPCOREModel.Margin = new System.Windows.Forms.Padding(2);
            this.tabASPCOREModel.Name = "tabASPCOREModel";
            this.tabASPCOREModel.Size = new System.Drawing.Size(631, 345);
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
            this.txt_ASPCore_Model_Generator.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txt_ASPCore_Model_Generator.BackBrush = null;
            this.txt_ASPCore_Model_Generator.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_ASPCore_Model_Generator.CharHeight = 14;
            this.txt_ASPCore_Model_Generator.CharWidth = 8;
            this.txt_ASPCore_Model_Generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ASPCore_Model_Generator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_ASPCore_Model_Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ASPCore_Model_Generator.IsReplaceMode = false;
            this.txt_ASPCore_Model_Generator.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txt_ASPCore_Model_Generator.LeftBracket = '(';
            this.txt_ASPCore_Model_Generator.LeftBracket2 = '{';
            this.txt_ASPCore_Model_Generator.Location = new System.Drawing.Point(0, 0);
            this.txt_ASPCore_Model_Generator.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ASPCore_Model_Generator.Name = "txt_ASPCore_Model_Generator";
            this.txt_ASPCore_Model_Generator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_ASPCore_Model_Generator.RightBracket = ')';
            this.txt_ASPCore_Model_Generator.RightBracket2 = '}';
            this.txt_ASPCore_Model_Generator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_ASPCore_Model_Generator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_ASPCore_Model_Generator.ServiceColors")));
            this.txt_ASPCore_Model_Generator.Size = new System.Drawing.Size(631, 345);
            this.txt_ASPCore_Model_Generator.TabIndex = 2;
            this.txt_ASPCore_Model_Generator.Zoom = 100;
            // 
            // tabASPCoreClassModel
            // 
            this.tabASPCoreClassModel.Controls.Add(this.txt_ASPCore_ModelClass_Generator);
            this.tabASPCoreClassModel.Location = new System.Drawing.Point(4, 22);
            this.tabASPCoreClassModel.Margin = new System.Windows.Forms.Padding(2);
            this.tabASPCoreClassModel.Name = "tabASPCoreClassModel";
            this.tabASPCoreClassModel.Size = new System.Drawing.Size(631, 345);
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
            this.txt_ASPCore_ModelClass_Generator.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txt_ASPCore_ModelClass_Generator.BackBrush = null;
            this.txt_ASPCore_ModelClass_Generator.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_ASPCore_ModelClass_Generator.CharHeight = 14;
            this.txt_ASPCore_ModelClass_Generator.CharWidth = 8;
            this.txt_ASPCore_ModelClass_Generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ASPCore_ModelClass_Generator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_ASPCore_ModelClass_Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ASPCore_ModelClass_Generator.IsReplaceMode = false;
            this.txt_ASPCore_ModelClass_Generator.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txt_ASPCore_ModelClass_Generator.LeftBracket = '(';
            this.txt_ASPCore_ModelClass_Generator.LeftBracket2 = '{';
            this.txt_ASPCore_ModelClass_Generator.Location = new System.Drawing.Point(0, 0);
            this.txt_ASPCore_ModelClass_Generator.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ASPCore_ModelClass_Generator.Name = "txt_ASPCore_ModelClass_Generator";
            this.txt_ASPCore_ModelClass_Generator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_ASPCore_ModelClass_Generator.RightBracket = ')';
            this.txt_ASPCore_ModelClass_Generator.RightBracket2 = '}';
            this.txt_ASPCore_ModelClass_Generator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_ASPCore_ModelClass_Generator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_ASPCore_ModelClass_Generator.ServiceColors")));
            this.txt_ASPCore_ModelClass_Generator.Size = new System.Drawing.Size(631, 345);
            this.txt_ASPCore_ModelClass_Generator.TabIndex = 3;
            this.txt_ASPCore_ModelClass_Generator.Zoom = 100;
            // 
            // tabASPCoreController
            // 
            this.tabASPCoreController.Controls.Add(this.txt_ASPCore_Controller_Generator);
            this.tabASPCoreController.Location = new System.Drawing.Point(4, 22);
            this.tabASPCoreController.Margin = new System.Windows.Forms.Padding(2);
            this.tabASPCoreController.Name = "tabASPCoreController";
            this.tabASPCoreController.Size = new System.Drawing.Size(631, 345);
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
            this.txt_ASPCore_Controller_Generator.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txt_ASPCore_Controller_Generator.BackBrush = null;
            this.txt_ASPCore_Controller_Generator.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_ASPCore_Controller_Generator.CharHeight = 14;
            this.txt_ASPCore_Controller_Generator.CharWidth = 8;
            this.txt_ASPCore_Controller_Generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ASPCore_Controller_Generator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_ASPCore_Controller_Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ASPCore_Controller_Generator.IsReplaceMode = false;
            this.txt_ASPCore_Controller_Generator.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txt_ASPCore_Controller_Generator.LeftBracket = '(';
            this.txt_ASPCore_Controller_Generator.LeftBracket2 = '{';
            this.txt_ASPCore_Controller_Generator.Location = new System.Drawing.Point(0, 0);
            this.txt_ASPCore_Controller_Generator.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ASPCore_Controller_Generator.Name = "txt_ASPCore_Controller_Generator";
            this.txt_ASPCore_Controller_Generator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_ASPCore_Controller_Generator.RightBracket = ')';
            this.txt_ASPCore_Controller_Generator.RightBracket2 = '}';
            this.txt_ASPCore_Controller_Generator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_ASPCore_Controller_Generator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_ASPCore_Controller_Generator.ServiceColors")));
            this.txt_ASPCore_Controller_Generator.Size = new System.Drawing.Size(631, 345);
            this.txt_ASPCore_Controller_Generator.TabIndex = 4;
            this.txt_ASPCore_Controller_Generator.Zoom = 100;
            // 
            // tab_SimpleModelClass_Generator
            // 
            this.tab_SimpleModelClass_Generator.Controls.Add(this.txt_SimpleModelClass_Generator);
            this.tab_SimpleModelClass_Generator.Location = new System.Drawing.Point(4, 22);
            this.tab_SimpleModelClass_Generator.Name = "tab_SimpleModelClass_Generator";
            this.tab_SimpleModelClass_Generator.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SimpleModelClass_Generator.Size = new System.Drawing.Size(631, 345);
            this.tab_SimpleModelClass_Generator.TabIndex = 7;
            this.tab_SimpleModelClass_Generator.Text = "Simple C# Class";
            this.tab_SimpleModelClass_Generator.UseVisualStyleBackColor = true;
            // 
            // txt_SimpleModelClass_Generator
            // 
            this.txt_SimpleModelClass_Generator.AutoCompleteBracketsList = new char[] {
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
            this.txt_SimpleModelClass_Generator.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txt_SimpleModelClass_Generator.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.txt_SimpleModelClass_Generator.BackBrush = null;
            this.txt_SimpleModelClass_Generator.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_SimpleModelClass_Generator.CharHeight = 14;
            this.txt_SimpleModelClass_Generator.CharWidth = 8;
            this.txt_SimpleModelClass_Generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SimpleModelClass_Generator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_SimpleModelClass_Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SimpleModelClass_Generator.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txt_SimpleModelClass_Generator.IsReplaceMode = false;
            this.txt_SimpleModelClass_Generator.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txt_SimpleModelClass_Generator.LeftBracket = '(';
            this.txt_SimpleModelClass_Generator.LeftBracket2 = '{';
            this.txt_SimpleModelClass_Generator.Location = new System.Drawing.Point(3, 3);
            this.txt_SimpleModelClass_Generator.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SimpleModelClass_Generator.Name = "txt_SimpleModelClass_Generator";
            this.txt_SimpleModelClass_Generator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_SimpleModelClass_Generator.RightBracket = ')';
            this.txt_SimpleModelClass_Generator.RightBracket2 = '}';
            this.txt_SimpleModelClass_Generator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_SimpleModelClass_Generator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_SimpleModelClass_Generator.ServiceColors")));
            this.txt_SimpleModelClass_Generator.Size = new System.Drawing.Size(625, 339);
            this.txt_SimpleModelClass_Generator.TabIndex = 5;
            this.txt_SimpleModelClass_Generator.Zoom = 100;
            // 
            // tabWFDataGridview
            // 
            this.tabWFDataGridview.Controls.Add(this.txt_WF_Datagridview_Generator);
            this.tabWFDataGridview.Location = new System.Drawing.Point(4, 22);
            this.tabWFDataGridview.Name = "tabWFDataGridview";
            this.tabWFDataGridview.Padding = new System.Windows.Forms.Padding(3);
            this.tabWFDataGridview.Size = new System.Drawing.Size(631, 345);
            this.tabWFDataGridview.TabIndex = 8;
            this.tabWFDataGridview.Text = "WF Datagrid view";
            this.tabWFDataGridview.UseVisualStyleBackColor = true;
            // 
            // txt_WF_Datagridview_Generator
            // 
            this.txt_WF_Datagridview_Generator.AutoCompleteBracketsList = new char[] {
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
            this.txt_WF_Datagridview_Generator.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txt_WF_Datagridview_Generator.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txt_WF_Datagridview_Generator.BackBrush = null;
            this.txt_WF_Datagridview_Generator.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_WF_Datagridview_Generator.CharHeight = 14;
            this.txt_WF_Datagridview_Generator.CharWidth = 8;
            this.txt_WF_Datagridview_Generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_WF_Datagridview_Generator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_WF_Datagridview_Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_WF_Datagridview_Generator.IsReplaceMode = false;
            this.txt_WF_Datagridview_Generator.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txt_WF_Datagridview_Generator.LeftBracket = '(';
            this.txt_WF_Datagridview_Generator.LeftBracket2 = '{';
            this.txt_WF_Datagridview_Generator.Location = new System.Drawing.Point(3, 3);
            this.txt_WF_Datagridview_Generator.Margin = new System.Windows.Forms.Padding(2);
            this.txt_WF_Datagridview_Generator.Name = "txt_WF_Datagridview_Generator";
            this.txt_WF_Datagridview_Generator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_WF_Datagridview_Generator.RightBracket = ')';
            this.txt_WF_Datagridview_Generator.RightBracket2 = '}';
            this.txt_WF_Datagridview_Generator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_WF_Datagridview_Generator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_WF_Datagridview_Generator.ServiceColors")));
            this.txt_WF_Datagridview_Generator.Size = new System.Drawing.Size(625, 339);
            this.txt_WF_Datagridview_Generator.TabIndex = 6;
            this.txt_WF_Datagridview_Generator.Zoom = 100;
            // 
            // tabBlazorCRUDView
            // 
            this.tabBlazorCRUDView.Controls.Add(this.txt_BlazorCRUDView_Generator);
            this.tabBlazorCRUDView.Location = new System.Drawing.Point(4, 22);
            this.tabBlazorCRUDView.Name = "tabBlazorCRUDView";
            this.tabBlazorCRUDView.Padding = new System.Windows.Forms.Padding(3);
            this.tabBlazorCRUDView.Size = new System.Drawing.Size(631, 345);
            this.tabBlazorCRUDView.TabIndex = 9;
            this.tabBlazorCRUDView.Text = "BlazorCRUDView";
            this.tabBlazorCRUDView.UseVisualStyleBackColor = true;
            // 
            // txt_BlazorCRUDView_Generator
            // 
            this.txt_BlazorCRUDView_Generator.AutoCompleteBracketsList = new char[] {
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
            this.txt_BlazorCRUDView_Generator.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txt_BlazorCRUDView_Generator.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txt_BlazorCRUDView_Generator.BackBrush = null;
            this.txt_BlazorCRUDView_Generator.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_BlazorCRUDView_Generator.CharHeight = 14;
            this.txt_BlazorCRUDView_Generator.CharWidth = 8;
            this.txt_BlazorCRUDView_Generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_BlazorCRUDView_Generator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_BlazorCRUDView_Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_BlazorCRUDView_Generator.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txt_BlazorCRUDView_Generator.IsReplaceMode = false;
            this.txt_BlazorCRUDView_Generator.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txt_BlazorCRUDView_Generator.LeftBracket = '(';
            this.txt_BlazorCRUDView_Generator.LeftBracket2 = '{';
            this.txt_BlazorCRUDView_Generator.Location = new System.Drawing.Point(3, 3);
            this.txt_BlazorCRUDView_Generator.Margin = new System.Windows.Forms.Padding(2);
            this.txt_BlazorCRUDView_Generator.Name = "txt_BlazorCRUDView_Generator";
            this.txt_BlazorCRUDView_Generator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_BlazorCRUDView_Generator.RightBracket = ')';
            this.txt_BlazorCRUDView_Generator.RightBracket2 = '}';
            this.txt_BlazorCRUDView_Generator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_BlazorCRUDView_Generator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_BlazorCRUDView_Generator.ServiceColors")));
            this.txt_BlazorCRUDView_Generator.Size = new System.Drawing.Size(625, 339);
            this.txt_BlazorCRUDView_Generator.TabIndex = 7;
            this.txt_BlazorCRUDView_Generator.Zoom = 100;
            // 
            // tabBlazorController
            // 
            this.tabBlazorController.Controls.Add(this.txt_BlazorController_Generator);
            this.tabBlazorController.Location = new System.Drawing.Point(4, 22);
            this.tabBlazorController.Name = "tabBlazorController";
            this.tabBlazorController.Padding = new System.Windows.Forms.Padding(3);
            this.tabBlazorController.Size = new System.Drawing.Size(631, 345);
            this.tabBlazorController.TabIndex = 10;
            this.tabBlazorController.Text = "BlazorController";
            this.tabBlazorController.UseVisualStyleBackColor = true;
            // 
            // txt_BlazorController_Generator
            // 
            this.txt_BlazorController_Generator.AutoCompleteBracketsList = new char[] {
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
            this.txt_BlazorController_Generator.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txt_BlazorController_Generator.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txt_BlazorController_Generator.BackBrush = null;
            this.txt_BlazorController_Generator.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txt_BlazorController_Generator.CharHeight = 14;
            this.txt_BlazorController_Generator.CharWidth = 8;
            this.txt_BlazorController_Generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_BlazorController_Generator.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_BlazorController_Generator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_BlazorController_Generator.IsReplaceMode = false;
            this.txt_BlazorController_Generator.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txt_BlazorController_Generator.LeftBracket = '(';
            this.txt_BlazorController_Generator.LeftBracket2 = '{';
            this.txt_BlazorController_Generator.Location = new System.Drawing.Point(3, 3);
            this.txt_BlazorController_Generator.Margin = new System.Windows.Forms.Padding(2);
            this.txt_BlazorController_Generator.Name = "txt_BlazorController_Generator";
            this.txt_BlazorController_Generator.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_BlazorController_Generator.RightBracket = ')';
            this.txt_BlazorController_Generator.RightBracket2 = '}';
            this.txt_BlazorController_Generator.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_BlazorController_Generator.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_BlazorController_Generator.ServiceColors")));
            this.txt_BlazorController_Generator.Size = new System.Drawing.Size(625, 339);
            this.txt_BlazorController_Generator.TabIndex = 8;
            this.txt_BlazorController_Generator.Zoom = 100;
            // 
            // frmCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 475);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Code Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpCodeGenerator.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
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
            this.tab_SimpleModelClass_Generator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SimpleModelClass_Generator)).EndInit();
            this.tabWFDataGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_WF_Datagridview_Generator)).EndInit();
            this.tabBlazorCRUDView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_BlazorCRUDView_Generator)).EndInit();
            this.tabBlazorController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_BlazorController_Generator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpCodeGenerator;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button EditCodeGenerator;
        private System.Windows.Forms.Button btnGenerateCode;
        private System.Windows.Forms.TabControl tabMain;
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
        private System.Windows.Forms.TabPage tab_SimpleModelClass_Generator;
        private FastColoredTextBoxNS.FastColoredTextBox txt_SimpleModelClass_Generator;
        private System.Windows.Forms.TabPage tabWFDataGridview;
        private FastColoredTextBoxNS.FastColoredTextBox txt_WF_Datagridview_Generator;
        private System.Windows.Forms.TabPage tabBlazorCRUDView;
        private FastColoredTextBoxNS.FastColoredTextBox txt_BlazorCRUDView_Generator;
        private System.Windows.Forms.TabPage tabBlazorController;
        private FastColoredTextBoxNS.FastColoredTextBox txt_BlazorController_Generator;
    }
}