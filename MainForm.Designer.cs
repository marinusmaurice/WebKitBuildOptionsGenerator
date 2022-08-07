
namespace WebkitBuildOptionsGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvFeatures = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colDescription = new System.Windows.Forms.ColumnHeader();
            this.lvBuild = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.chkExplicitNo = new System.Windows.Forms.CheckBox();
            this.btnGenerateCmdLnOpt = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.txtOuput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadOptionsFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvFeatures
            // 
            this.lvFeatures.CheckBoxes = true;
            this.lvFeatures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDescription});
            this.lvFeatures.HideSelection = false;
            this.lvFeatures.Location = new System.Drawing.Point(12, 185);
            this.lvFeatures.Name = "lvFeatures";
            this.lvFeatures.Size = new System.Drawing.Size(601, 253);
            this.lvFeatures.TabIndex = 2;
            this.lvFeatures.UseCompatibleStateImageBehavior = false;
            this.lvFeatures.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 120;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            // 
            // lvBuild
            // 
            this.lvBuild.CheckBoxes = true;
            this.lvBuild.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvBuild.HideSelection = false;
            this.lvBuild.Location = new System.Drawing.Point(12, 27);
            this.lvBuild.Name = "lvBuild";
            this.lvBuild.Size = new System.Drawing.Size(767, 152);
            this.lvBuild.TabIndex = 3;
            this.lvBuild.UseCompatibleStateImageBehavior = false;
            this.lvBuild.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            // 
            // chkExplicitNo
            // 
            this.chkExplicitNo.AutoSize = true;
            this.chkExplicitNo.Location = new System.Drawing.Point(643, 185);
            this.chkExplicitNo.Name = "chkExplicitNo";
            this.chkExplicitNo.Size = new System.Drawing.Size(136, 19);
            this.chkExplicitNo.TabIndex = 4;
            this.chkExplicitNo.Text = "Generate \'No\' option";
            this.chkExplicitNo.UseVisualStyleBackColor = true;
            // 
            // btnGenerateCmdLnOpt
            // 
            this.btnGenerateCmdLnOpt.Location = new System.Drawing.Point(643, 399);
            this.btnGenerateCmdLnOpt.Name = "btnGenerateCmdLnOpt";
            this.btnGenerateCmdLnOpt.Size = new System.Drawing.Size(136, 39);
            this.btnGenerateCmdLnOpt.TabIndex = 5;
            this.btnGenerateCmdLnOpt.Text = "Generate command line options";
            this.btnGenerateCmdLnOpt.UseVisualStyleBackColor = true;
            this.btnGenerateCmdLnOpt.Click += new System.EventHandler(this.btnGenerateCmdLnOpt_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(643, 217);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(93, 23);
            this.btnSelectAll.TabIndex = 6;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(644, 246);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(92, 23);
            this.btnSelectNone.TabIndex = 7;
            this.btnSelectNone.Text = "Select None";
            this.btnSelectNone.UseVisualStyleBackColor = true;
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(643, 275);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(93, 23);
            this.btnInvert.TabIndex = 8;
            this.btnInvert.Text = "Invert";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // txtOuput
            // 
            this.txtOuput.Location = new System.Drawing.Point(12, 459);
            this.txtOuput.Multiline = true;
            this.txtOuput.Name = "txtOuput";
            this.txtOuput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOuput.Size = new System.Drawing.Size(767, 100);
            this.txtOuput.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadOptionsFromFileToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadOptionsFromFileToolStripMenuItem
            // 
            this.loadOptionsFromFileToolStripMenuItem.Name = "loadOptionsFromFileToolStripMenuItem";
            this.loadOptionsFromFileToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.loadOptionsFromFileToolStripMenuItem.Text = "&Load Options From File";
            this.loadOptionsFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadOptionsFromFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 571);
            this.Controls.Add(this.txtOuput);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btnSelectNone);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnGenerateCmdLnOpt);
            this.Controls.Add(this.chkExplicitNo);
            this.Controls.Add(this.lvBuild);
            this.Controls.Add(this.lvFeatures);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvFeatures;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ListView lvBuild;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox chkExplicitNo;
        private System.Windows.Forms.Button btnGenerateCmdLnOpt;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.TextBox txtOuput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadOptionsFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}
