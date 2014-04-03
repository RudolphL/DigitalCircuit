namespace Digital_Circuit
{
    partial class FormDigitalCircuit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDigitalCircuit));
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.rbRemove = new System.Windows.Forms.RadioButton();
            this.rbConnection = new System.Windows.Forms.RadioButton();
            this.rbOutput = new System.Windows.Forms.RadioButton();
            this.rbNot = new System.Windows.Forms.RadioButton();
            this.rbOr = new System.Windows.Forms.RadioButton();
            this.rbAnd = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.btCleargrid = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripSplitButton();
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.gbTools.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.rbRemove);
            this.gbTools.Controls.Add(this.rbConnection);
            this.gbTools.Controls.Add(this.rbOutput);
            this.gbTools.Controls.Add(this.rbNot);
            this.gbTools.Controls.Add(this.rbOr);
            this.gbTools.Controls.Add(this.rbAnd);
            this.gbTools.Controls.Add(this.rb1);
            this.gbTools.Controls.Add(this.rb0);
            this.gbTools.Location = new System.Drawing.Point(12, 67);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(210, 611);
            this.gbTools.TabIndex = 12;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Tools";
            // 
            // rbRemove
            // 
            this.rbRemove.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRemove.Location = new System.Drawing.Point(21, 530);
            this.rbRemove.Name = "rbRemove";
            this.rbRemove.Size = new System.Drawing.Size(168, 65);
            this.rbRemove.TabIndex = 17;
            this.rbRemove.TabStop = true;
            this.rbRemove.Text = "REMOVE";
            this.rbRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRemove.UseVisualStyleBackColor = true;
            // 
            // rbConnection
            // 
            this.rbConnection.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConnection.Location = new System.Drawing.Point(21, 459);
            this.rbConnection.Name = "rbConnection";
            this.rbConnection.Size = new System.Drawing.Size(168, 65);
            this.rbConnection.TabIndex = 16;
            this.rbConnection.TabStop = true;
            this.rbConnection.Text = "CONNECTION";
            this.rbConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbConnection.UseVisualStyleBackColor = true;
            // 
            // rbOutput
            // 
            this.rbOutput.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutput.Location = new System.Drawing.Point(21, 388);
            this.rbOutput.Name = "rbOutput";
            this.rbOutput.Size = new System.Drawing.Size(168, 65);
            this.rbOutput.TabIndex = 15;
            this.rbOutput.TabStop = true;
            this.rbOutput.Text = "OUTPUT";
            this.rbOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbOutput.UseVisualStyleBackColor = true;
            // 
            // rbNot
            // 
            this.rbNot.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNot.Location = new System.Drawing.Point(21, 317);
            this.rbNot.Name = "rbNot";
            this.rbNot.Size = new System.Drawing.Size(168, 65);
            this.rbNot.TabIndex = 14;
            this.rbNot.TabStop = true;
            this.rbNot.Text = "NOT";
            this.rbNot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNot.UseVisualStyleBackColor = true;
            // 
            // rbOr
            // 
            this.rbOr.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOr.Location = new System.Drawing.Point(21, 246);
            this.rbOr.Name = "rbOr";
            this.rbOr.Size = new System.Drawing.Size(168, 65);
            this.rbOr.TabIndex = 13;
            this.rbOr.TabStop = true;
            this.rbOr.Text = "OR";
            this.rbOr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbOr.UseVisualStyleBackColor = true;
            // 
            // rbAnd
            // 
            this.rbAnd.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnd.Location = new System.Drawing.Point(21, 175);
            this.rbAnd.Name = "rbAnd";
            this.rbAnd.Size = new System.Drawing.Size(168, 65);
            this.rbAnd.TabIndex = 12;
            this.rbAnd.TabStop = true;
            this.rbAnd.Text = "AND";
            this.rbAnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAnd.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(21, 104);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(168, 65);
            this.rb1.TabIndex = 11;
            this.rb1.TabStop = true;
            this.rb1.Text = "INPUT 1";
            this.rb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb0
            // 
            this.rb0.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb0.Location = new System.Drawing.Point(21, 33);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(168, 65);
            this.rb0.TabIndex = 0;
            this.rb0.TabStop = true;
            this.rb0.Text = "INPUT 0";
            this.rb0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb0.UseVisualStyleBackColor = true;
            // 
            // btCleargrid
            // 
            this.btCleargrid.BackColor = System.Drawing.SystemColors.Control;
            this.btCleargrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCleargrid.Location = new System.Drawing.Point(33, 776);
            this.btCleargrid.Name = "btCleargrid";
            this.btCleargrid.Size = new System.Drawing.Size(168, 65);
            this.btCleargrid.TabIndex = 5;
            this.btCleargrid.Text = "CLEAR GRID";
            this.btCleargrid.UseVisualStyleBackColor = false;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(1482, 35);
            this.toolStrip.TabIndex = 15;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 32);
            this.toolStripButton1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(132, 32);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 32);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripButton});
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(85, 32);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // aboutToolStripButton
            // 
            this.aboutToolStripButton.Name = "aboutToolStripButton";
            this.aboutToolStripButton.Size = new System.Drawing.Size(139, 32);
            this.aboutToolStripButton.Text = "About";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(258, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 763);
            this.panel1.TabIndex = 16;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "andgate.png");
            this.imageList.Images.SetKeyName(1, "notgate.png");
            this.imageList.Images.SetKeyName(2, "orgate.png");
            this.imageList.Images.SetKeyName(3, "sinkoff.png");
            this.imageList.Images.SetKeyName(4, "sinkon.png");
            this.imageList.Images.SetKeyName(5, "sourceoff.png");
            this.imageList.Images.SetKeyName(6, "sourceon.png");
            // 
            // FormDigitalCircuit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.btCleargrid);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDigitalCircuit";
            this.Text = "Digital Circuit";
            this.gbTools.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.Button btCleargrid;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSplitButton helpToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripButton;
        private System.Windows.Forms.RadioButton rbRemove;
        private System.Windows.Forms.RadioButton rbConnection;
        private System.Windows.Forms.RadioButton rbOutput;
        private System.Windows.Forms.RadioButton rbNot;
        private System.Windows.Forms.RadioButton rbOr;
        private System.Windows.Forms.RadioButton rbAnd;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb0;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ImageList imageList;
    }
}

