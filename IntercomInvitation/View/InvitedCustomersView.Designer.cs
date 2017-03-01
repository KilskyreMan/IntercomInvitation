namespace IntercomInvitation.View
{
    partial class InvitedCustomersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvitedCustomersView));
            this.DoneBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.intercomLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.findFileBtn = new System.Windows.Forms.Button();
            this.customerJsonFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DoneBtn
            // 
            this.DoneBtn.Location = new System.Drawing.Point(310, 324);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(75, 23);
            this.DoneBtn.TabIndex = 1;
            this.DoneBtn.Text = "&Done";
            this.DoneBtn.UseVisualStyleBackColor = true;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "The following customers live within 100Km of ";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "customers.json";
            this.openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog.Title = "Select customer (json) file";
            // 
            // intercomLink
            // 
            this.intercomLink.AutoSize = true;
            this.intercomLink.Location = new System.Drawing.Point(231, 77);
            this.intercomLink.Name = "intercomLink";
            this.intercomLink.Size = new System.Drawing.Size(48, 13);
            this.intercomLink.TabIndex = 2;
            this.intercomLink.TabStop = true;
            this.intercomLink.Text = "Intercom";
            this.intercomLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.intercomLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "and should be invited:";
            // 
            // findFileBtn
            // 
            this.findFileBtn.Location = new System.Drawing.Point(22, 36);
            this.findFileBtn.Name = "findFileBtn";
            this.findFileBtn.Size = new System.Drawing.Size(31, 20);
            this.findFileBtn.TabIndex = 0;
            this.findFileBtn.Text = "...";
            this.findFileBtn.UseVisualStyleBackColor = true;
            this.findFileBtn.Click += new System.EventHandler(this.findFileBtn_Click);
            // 
            // customerJsonFile
            // 
            this.customerJsonFile.BackColor = System.Drawing.Color.White;
            this.customerJsonFile.Location = new System.Drawing.Point(59, 36);
            this.customerJsonFile.Name = "customerJsonFile";
            this.customerJsonFile.ReadOnly = true;
            this.customerJsonFile.Size = new System.Drawing.Size(326, 20);
            this.customerJsonFile.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select potential customers from:";
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.Location = new System.Drawing.Point(22, 99);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(363, 212);
            this.customerList.TabIndex = 7;
            // 
            // InvitedCustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 362);
            this.Controls.Add(this.customerList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerJsonFile);
            this.Controls.Add(this.findFileBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intercomLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoneBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvitedCustomersView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers invited for Food & Drinks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.LinkLabel intercomLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findFileBtn;
        private System.Windows.Forms.TextBox customerJsonFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox customerList;
    }
}