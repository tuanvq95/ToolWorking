
using ToolWorking.Extension;

namespace ToolWorking.Views
{
    partial class Json
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Json));
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.panelCenterTreeFolder = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnCopyResult = new System.Windows.Forms.Button();
            this.btnClearResult = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelCenterPath = new System.Windows.Forms.Panel();
            this.lblNumCount = new System.Windows.Forms.Label();
            this.lblNumBefore = new System.Windows.Forms.Label();
            this.lblNumAfter = new System.Windows.Forms.Label();
            this.txtResultPathFile = new System.Windows.Forms.RichTextBox();
            this.txtListFile = new System.Windows.Forms.RichTextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCount = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.rbModePath = new System.Windows.Forms.RadioButton();
            this.rbModeTree = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCenterTreeFolder.SuspendLayout();
            this.panelCenterPath.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListTree
            // 
            this.imageListTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTree.ImageStream")));
            this.imageListTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTree.Images.SetKeyName(0, "icon-folder-2-16x16.png");
            this.imageListTree.Images.SetKeyName(1, "icon-file-16x16.png");
            // 
            // panelCenterTreeFolder
            // 
            this.panelCenterTreeFolder.Controls.Add(this.txtResult);
            this.panelCenterTreeFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenterTreeFolder.Location = new System.Drawing.Point(0, 68);
            this.panelCenterTreeFolder.Name = "panelCenterTreeFolder";
            this.panelCenterTreeFolder.Size = new System.Drawing.Size(660, 345);
            this.panelCenterTreeFolder.TabIndex = 13;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtResult.Location = new System.Drawing.Point(9, 222);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(642, 111);
            this.txtResult.TabIndex = 7;
            this.txtResult.Text = "";
            // 
            // btnCopyResult
            // 
            this.btnCopyResult.Enabled = false;
            this.btnCopyResult.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCopyResult.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyResult.Image")));
            this.btnCopyResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyResult.Location = new System.Drawing.Point(498, 0);
            this.btnCopyResult.Name = "btnCopyResult";
            this.btnCopyResult.Size = new System.Drawing.Size(75, 27);
            this.btnCopyResult.TabIndex = 8;
            this.btnCopyResult.Text = "    Copy";
            this.btnCopyResult.UseVisualStyleBackColor = true;
            // 
            // btnClearResult
            // 
            this.btnClearResult.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnClearResult.Image = ((System.Drawing.Image)(resources.GetObject("btnClearResult.Image")));
            this.btnClearResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearResult.Location = new System.Drawing.Point(577, 0);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(75, 27);
            this.btnClearResult.TabIndex = 9;
            this.btnClearResult.Text = "    Clear";
            this.btnClearResult.UseVisualStyleBackColor = true;
            // 
            // panelCenterPath
            // 
            this.panelCenterPath.Controls.Add(this.lblNumCount);
            this.panelCenterPath.Controls.Add(this.lblNumBefore);
            this.panelCenterPath.Controls.Add(this.lblNumAfter);
            this.panelCenterPath.Controls.Add(this.txtResultPathFile);
            this.panelCenterPath.Controls.Add(this.txtListFile);
            this.panelCenterPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenterPath.Location = new System.Drawing.Point(0, 68);
            this.panelCenterPath.Name = "panelCenterPath";
            this.panelCenterPath.Size = new System.Drawing.Size(660, 345);
            this.panelCenterPath.TabIndex = 14;
            // 
            // lblNumCount
            // 
            this.lblNumCount.AutoSize = true;
            this.lblNumCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNumCount.Location = new System.Drawing.Point(467, 198);
            this.lblNumCount.Name = "lblNumCount";
            this.lblNumCount.Size = new System.Drawing.Size(150, 15);
            this.lblNumCount.TabIndex = 25;
            this.lblNumCount.Text = "Total file in folder Backup: ";
            this.lblNumCount.Visible = false;
            // 
            // lblNumBefore
            // 
            this.lblNumBefore.AutoSize = true;
            this.lblNumBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNumBefore.Location = new System.Drawing.Point(13, 198);
            this.lblNumBefore.Name = "lblNumBefore";
            this.lblNumBefore.Size = new System.Drawing.Size(148, 15);
            this.lblNumBefore.TabIndex = 24;
            this.lblNumBefore.Text = "Line number before input:";
            this.lblNumBefore.Visible = false;
            // 
            // lblNumAfter
            // 
            this.lblNumAfter.AutoSize = true;
            this.lblNumAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNumAfter.Location = new System.Drawing.Point(217, 198);
            this.lblNumAfter.Name = "lblNumAfter";
            this.lblNumAfter.Size = new System.Drawing.Size(154, 15);
            this.lblNumAfter.TabIndex = 23;
            this.lblNumAfter.Text = "Line number after change: ";
            this.lblNumAfter.Visible = false;
            // 
            // txtResultPathFile
            // 
            this.txtResultPathFile.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtResultPathFile.Location = new System.Drawing.Point(9, 222);
            this.txtResultPathFile.Name = "txtResultPathFile";
            this.txtResultPathFile.ReadOnly = true;
            this.txtResultPathFile.Size = new System.Drawing.Size(642, 111);
            this.txtResultPathFile.TabIndex = 22;
            this.txtResultPathFile.Text = "";
            // 
            // txtListFile
            // 
            this.txtListFile.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListFile.Location = new System.Drawing.Point(9, 4);
            this.txtListFile.Name = "txtListFile";
            this.txtListFile.Size = new System.Drawing.Size(642, 185);
            this.txtListFile.TabIndex = 21;
            this.txtListFile.Text = "";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnCount);
            this.panelBottom.Controls.Add(this.btnCopyResult);
            this.panelBottom.Controls.Add(this.btnClearResult);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 413);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(660, 32);
            this.panelBottom.TabIndex = 15;
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCount.Image = ((System.Drawing.Image)(resources.GetObject("btnCount.Image")));
            this.btnCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCount.Location = new System.Drawing.Point(419, 0);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 27);
            this.btnCount.TabIndex = 21;
            this.btnCount.Text = "    Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Visible = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.rbModePath);
            this.panelTop.Controls.Add(this.rbModeTree);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(660, 68);
            this.panelTop.TabIndex = 12;
            // 
            // rbModePath
            // 
            this.rbModePath.AutoSize = true;
            this.rbModePath.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rbModePath.Location = new System.Drawing.Point(122, 8);
            this.rbModePath.Name = "rbModePath";
            this.rbModePath.Size = new System.Drawing.Size(107, 21);
            this.rbModePath.TabIndex = 15;
            this.rbModePath.TabStop = true;
            this.rbModePath.Text = "JSON Object";
            this.rbModePath.UseVisualStyleBackColor = true;
            // 
            // rbModeTree
            // 
            this.rbModeTree.AutoSize = true;
            this.rbModeTree.Checked = true;
            this.rbModeTree.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rbModeTree.Location = new System.Drawing.Point(51, 8);
            this.rbModeTree.Name = "rbModeTree";
            this.rbModeTree.Size = new System.Drawing.Size(71, 21);
            this.rbModeTree.TabIndex = 14;
            this.rbModeTree.TabStop = true;
            this.rbModeTree.Text = "Key List";
            this.rbModeTree.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(6, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mode";
            // 
            // Json
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 445);
            this.Controls.Add(this.panelCenterTreeFolder);
            this.Controls.Add(this.panelCenterPath);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Json";
            this.Text = "LinkFolder";
            this.panelCenterTreeFolder.ResumeLayout(false);
            this.panelCenterPath.ResumeLayout(false);
            this.panelCenterPath.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.Panel panelCenterTreeFolder;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnCopyResult;
        private System.Windows.Forms.Button btnClearResult;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panelCenterPath;
        private System.Windows.Forms.Label lblNumCount;
        private System.Windows.Forms.Label lblNumBefore;
        private System.Windows.Forms.Label lblNumAfter;
        private System.Windows.Forms.RichTextBox txtResultPathFile;
        private System.Windows.Forms.RichTextBox txtListFile;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.RadioButton rbModePath;
        private System.Windows.Forms.RadioButton rbModeTree;
        private System.Windows.Forms.Label label4;
    }
}