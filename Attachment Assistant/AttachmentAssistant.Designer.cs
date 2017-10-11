namespace Attachment_Assistant
{
    partial class frmMain
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Leave Application");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("EMPLOYEE", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeDocType = new System.Windows.Forms.TreeView();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdditionalInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAttachmentName = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.cbNoDate = new System.Windows.Forms.CheckBox();
            this.clbSuffixes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // treeDocType
            // 
            this.treeDocType.BackColor = System.Drawing.Color.White;
            this.treeDocType.Location = new System.Drawing.Point(12, 12);
            this.treeDocType.Name = "treeDocType";
            treeNode5.Name = "nodeLeaveApp";
            treeNode5.Tag = "EmpLeaveApp";
            treeNode5.Text = "Leave Application";
            treeNode6.Name = "nodeEmployee";
            treeNode6.Text = "EMPLOYEE";
            this.treeDocType.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeDocType.Size = new System.Drawing.Size(279, 203);
            this.treeDocType.TabIndex = 0;
            this.treeDocType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDocType_AfterSelect);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(297, 33);
            this.datePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(233, 20);
            this.datePicker.TabIndex = 1;
            this.datePicker.Value = new System.DateTime(2017, 10, 11, 0, 0, 0, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Additional Information";
            // 
            // txtAdditionalInfo
            // 
            this.txtAdditionalInfo.Location = new System.Drawing.Point(297, 77);
            this.txtAdditionalInfo.Name = "txtAdditionalInfo";
            this.txtAdditionalInfo.Size = new System.Drawing.Size(300, 20);
            this.txtAdditionalInfo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Suffixes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Attachment Name";
            // 
            // txtAttachmentName
            // 
            this.txtAttachmentName.Location = new System.Drawing.Point(12, 236);
            this.txtAttachmentName.Name = "txtAttachmentName";
            this.txtAttachmentName.Size = new System.Drawing.Size(487, 20);
            this.txtAttachmentName.TabIndex = 8;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(506, 222);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(91, 34);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // cbNoDate
            // 
            this.cbNoDate.AutoSize = true;
            this.cbNoDate.Location = new System.Drawing.Point(536, 36);
            this.cbNoDate.Name = "cbNoDate";
            this.cbNoDate.Size = new System.Drawing.Size(66, 17);
            this.cbNoDate.TabIndex = 10;
            this.cbNoDate.Text = "No Date";
            this.cbNoDate.UseVisualStyleBackColor = true;
            this.cbNoDate.CheckedChanged += new System.EventHandler(this.cbNoDate_CheckedChanged);
            // 
            // clbSuffixes
            // 
            this.clbSuffixes.FormattingEnabled = true;
            this.clbSuffixes.Items.AddRange(new object[] {
            "Med Cert",
            "Dr Cert",
            "Other"});
            this.clbSuffixes.Location = new System.Drawing.Point(297, 120);
            this.clbSuffixes.Name = "clbSuffixes";
            this.clbSuffixes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.clbSuffixes.Size = new System.Drawing.Size(300, 95);
            this.clbSuffixes.TabIndex = 11;
            this.clbSuffixes.SelectedIndexChanged += new System.EventHandler(this.clbSuffixes_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(609, 270);
            this.Controls.Add(this.clbSuffixes);
            this.Controls.Add(this.cbNoDate);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtAttachmentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdditionalInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.treeDocType);
            this.Name = "frmMain";
            this.Text = "Attachment Assistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeDocType;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdditionalInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAttachmentName;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.CheckBox cbNoDate;
        private System.Windows.Forms.ListBox clbSuffixes;
    }
}

