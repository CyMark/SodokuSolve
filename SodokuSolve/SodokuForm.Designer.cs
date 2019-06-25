﻿namespace SodokuSolve
{
    partial class SodokuForm
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
            this.quitButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.noticeBox = new System.Windows.Forms.RichTextBox();
            this.labelNotice = new System.Windows.Forms.Label();
            this.noticeMain = new System.Windows.Forms.Label();
            this.cleareSelectButton = new System.Windows.Forms.Button();
            this.selectionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxShowMoves = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonClearGrid = new System.Windows.Forms.Button();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.buttonDemo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAutoComplete = new System.Windows.Forms.Button();
            this.buttonAutoMulti = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUndo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxConfig.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(26, 579);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(407, 24);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 520);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBox1_PreviewKeyDown);
            // 
            // noticeBox
            // 
            this.noticeBox.Location = new System.Drawing.Point(538, 487);
            this.noticeBox.Name = "noticeBox";
            this.noticeBox.Size = new System.Drawing.Size(360, 96);
            this.noticeBox.TabIndex = 3;
            this.noticeBox.Text = "";
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.Location = new System.Drawing.Point(535, 471);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(43, 13);
            this.labelNotice.TabIndex = 4;
            this.labelNotice.Text = "Notices";
            // 
            // noticeMain
            // 
            this.noticeMain.AutoSize = true;
            this.noticeMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeMain.ForeColor = System.Drawing.Color.OrangeRed;
            this.noticeMain.Location = new System.Drawing.Point(123, 25);
            this.noticeMain.Name = "noticeMain";
            this.noticeMain.Size = new System.Drawing.Size(72, 18);
            this.noticeMain.TabIndex = 5;
            this.noticeMain.Text = "Welcome";
            // 
            // cleareSelectButton
            // 
            this.cleareSelectButton.Location = new System.Drawing.Point(790, 34);
            this.cleareSelectButton.Name = "cleareSelectButton";
            this.cleareSelectButton.Size = new System.Drawing.Size(75, 23);
            this.cleareSelectButton.TabIndex = 6;
            this.cleareSelectButton.Text = "Clear Select";
            this.cleareSelectButton.UseVisualStyleBackColor = true;
            this.cleareSelectButton.Click += new System.EventHandler(this.cleareSelectButton_Click);
            // 
            // selectionTextBox
            // 
            this.selectionTextBox.Location = new System.Drawing.Point(615, 67);
            this.selectionTextBox.Name = "selectionTextBox";
            this.selectionTextBox.Size = new System.Drawing.Size(30, 20);
            this.selectionTextBox.TabIndex = 7;
            this.selectionTextBox.TextChanged += new System.EventHandler(this.selectionTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Change Selection";
            // 
            // checkBoxShowMoves
            // 
            this.checkBoxShowMoves.AutoSize = true;
            this.checkBoxShowMoves.Location = new System.Drawing.Point(615, 38);
            this.checkBoxShowMoves.Name = "checkBoxShowMoves";
            this.checkBoxShowMoves.Size = new System.Drawing.Size(126, 17);
            this.checkBoxShowMoves.TabIndex = 9;
            this.checkBoxShowMoves.Text = "View Possible Moves";
            this.checkBoxShowMoves.UseVisualStyleBackColor = true;
            this.checkBoxShowMoves.CheckedChanged += new System.EventHandler(this.checkBoxShowMoves_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(694, 382);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Input Fixed Values";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonClearGrid
            // 
            this.buttonClearGrid.Location = new System.Drawing.Point(694, 351);
            this.buttonClearGrid.Name = "buttonClearGrid";
            this.buttonClearGrid.Size = new System.Drawing.Size(75, 23);
            this.buttonClearGrid.TabIndex = 11;
            this.buttonClearGrid.Text = "Clear All";
            this.buttonClearGrid.UseVisualStyleBackColor = true;
            this.buttonClearGrid.Click += new System.EventHandler(this.buttonClearGrid_Click);
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.buttonDemo);
            this.groupBoxConfig.Location = new System.Drawing.Point(655, 322);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(243, 131);
            this.groupBoxConfig.TabIndex = 12;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Configure";
            // 
            // buttonDemo
            // 
            this.buttonDemo.Location = new System.Drawing.Point(135, 29);
            this.buttonDemo.Name = "buttonDemo";
            this.buttonDemo.Size = new System.Drawing.Size(75, 23);
            this.buttonDemo.TabIndex = 0;
            this.buttonDemo.Text = "Load Demo";
            this.buttonDemo.UseVisualStyleBackColor = true;
            this.buttonDemo.Click += new System.EventHandler(this.buttonDemo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Double click on grid an use box to enter number";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // buttonAutoComplete
            // 
            this.buttonAutoComplete.Location = new System.Drawing.Point(760, 101);
            this.buttonAutoComplete.Name = "buttonAutoComplete";
            this.buttonAutoComplete.Size = new System.Drawing.Size(124, 23);
            this.buttonAutoComplete.TabIndex = 15;
            this.buttonAutoComplete.Text = "Auto Complete Single";
            this.buttonAutoComplete.UseVisualStyleBackColor = true;
            this.buttonAutoComplete.Click += new System.EventHandler(this.buttonAutoComplete_Click);
            // 
            // buttonAutoMulti
            // 
            this.buttonAutoMulti.Location = new System.Drawing.Point(760, 131);
            this.buttonAutoMulti.Name = "buttonAutoMulti";
            this.buttonAutoMulti.Size = new System.Drawing.Size(124, 23);
            this.buttonAutoMulti.TabIndex = 16;
            this.buttonAutoMulti.Text = "Auto Complete Multi";
            this.buttonAutoMulti.UseVisualStyleBackColor = true;
            this.buttonAutoMulti.Click += new System.EventHandler(this.buttonAutoMulti_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sweep Board once for sure moves ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sweep Board for sure moves  until none found";
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(521, 24);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(75, 23);
            this.buttonUndo.TabIndex = 19;
            this.buttonUndo.Text = "Undo Move";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // SodokuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 609);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAutoMulti);
            this.Controls.Add(this.buttonAutoComplete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClearGrid);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBoxShowMoves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectionTextBox);
            this.Controls.Add(this.cleareSelectButton);
            this.Controls.Add(this.noticeMain);
            this.Controls.Add(this.labelNotice);
            this.Controls.Add(this.noticeBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.groupBoxConfig);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SodokuForm";
            this.Text = "SodokuSolve";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SodokuForm_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SodokuForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxConfig.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox noticeBox;
        private System.Windows.Forms.Label labelNotice;
        private System.Windows.Forms.Label noticeMain;
        private System.Windows.Forms.Button cleareSelectButton;
        private System.Windows.Forms.TextBox selectionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxShowMoves;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonClearGrid;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.Button buttonDemo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button buttonAutoComplete;
        private System.Windows.Forms.Button buttonAutoMulti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUndo;
    }
}

