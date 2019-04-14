namespace VMSim
{
    partial class Form1
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
            this.lbxPT = new System.Windows.Forms.ListBox();
            this.lbxTLB = new System.Windows.Forms.ListBox();
            this.btnLoadPA = new System.Windows.Forms.Button();
            this.cbxAllAdresses = new System.Windows.Forms.ComboBox();
            this.lblVPN = new System.Windows.Forms.Label();
            this.lblOffset = new System.Windows.Forms.Label();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.lblVirtualAddress = new System.Windows.Forms.Label();
            this.lblPhysicalAddress = new System.Windows.Forms.Label();
            this.txtPhysicalAddress = new System.Windows.Forms.TextBox();
            this.txtVirtualAddress = new System.Windows.Forms.TextBox();
            this.lblTLBTable = new System.Windows.Forms.Label();
            this.lblPageTable = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxPT
            // 
            this.lbxPT.FormattingEnabled = true;
            this.lbxPT.Location = new System.Drawing.Point(490, 28);
            this.lbxPT.Name = "lbxPT";
            this.lbxPT.Size = new System.Drawing.Size(216, 407);
            this.lbxPT.TabIndex = 0;
            // 
            // lbxTLB
            // 
            this.lbxTLB.FormattingEnabled = true;
            this.lbxTLB.Location = new System.Drawing.Point(268, 28);
            this.lbxTLB.Name = "lbxTLB";
            this.lbxTLB.Size = new System.Drawing.Size(216, 407);
            this.lbxTLB.TabIndex = 0;
            // 
            // btnLoadPA
            // 
            this.btnLoadPA.Location = new System.Drawing.Point(15, 65);
            this.btnLoadPA.Name = "btnLoadPA";
            this.btnLoadPA.Size = new System.Drawing.Size(113, 47);
            this.btnLoadPA.TabIndex = 1;
            this.btnLoadPA.Text = "Load Physical Address";
            this.btnLoadPA.UseVisualStyleBackColor = true;
            this.btnLoadPA.Click += new System.EventHandler(this.GetPhysicalPageNumber);
            // 
            // cbxAllAdresses
            // 
            this.cbxAllAdresses.FormattingEnabled = true;
            this.cbxAllAdresses.Location = new System.Drawing.Point(15, 28);
            this.cbxAllAdresses.Name = "cbxAllAdresses";
            this.cbxAllAdresses.Size = new System.Drawing.Size(134, 21);
            this.cbxAllAdresses.TabIndex = 2;
            // 
            // lblVPN
            // 
            this.lblVPN.AutoSize = true;
            this.lblVPN.Location = new System.Drawing.Point(12, 12);
            this.lblVPN.Name = "lblVPN";
            this.lblVPN.Size = new System.Drawing.Size(140, 13);
            this.lblVPN.TabIndex = 3;
            this.lblVPN.Text = "Select Virtual Page Number:";
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(163, 12);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(64, 13);
            this.lblOffset.TabIndex = 3;
            this.lblOffset.Text = "Enter offset:";
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(166, 29);
            this.txtOffset.MaxLength = 3;
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(61, 20);
            this.txtOffset.TabIndex = 4;
            // 
            // lblVirtualAddress
            // 
            this.lblVirtualAddress.AutoSize = true;
            this.lblVirtualAddress.Location = new System.Drawing.Point(12, 170);
            this.lblVirtualAddress.Name = "lblVirtualAddress";
            this.lblVirtualAddress.Size = new System.Drawing.Size(77, 13);
            this.lblVirtualAddress.TabIndex = 5;
            this.lblVirtualAddress.Text = "Virtual Address";
            // 
            // lblPhysicalAddress
            // 
            this.lblPhysicalAddress.AutoSize = true;
            this.lblPhysicalAddress.Location = new System.Drawing.Point(12, 209);
            this.lblPhysicalAddress.Name = "lblPhysicalAddress";
            this.lblPhysicalAddress.Size = new System.Drawing.Size(87, 13);
            this.lblPhysicalAddress.TabIndex = 5;
            this.lblPhysicalAddress.Text = "Physical Address";
            // 
            // txtPhysicalAddress
            // 
            this.txtPhysicalAddress.Location = new System.Drawing.Point(15, 225);
            this.txtPhysicalAddress.Name = "txtPhysicalAddress";
            this.txtPhysicalAddress.Size = new System.Drawing.Size(237, 20);
            this.txtPhysicalAddress.TabIndex = 6;
            // 
            // txtVirtualAddress
            // 
            this.txtVirtualAddress.Location = new System.Drawing.Point(15, 186);
            this.txtVirtualAddress.Name = "txtVirtualAddress";
            this.txtVirtualAddress.Size = new System.Drawing.Size(237, 20);
            this.txtVirtualAddress.TabIndex = 6;
            // 
            // lblTLBTable
            // 
            this.lblTLBTable.AutoSize = true;
            this.lblTLBTable.Location = new System.Drawing.Point(265, 12);
            this.lblTLBTable.Name = "lblTLBTable";
            this.lblTLBTable.Size = new System.Drawing.Size(57, 13);
            this.lblTLBTable.TabIndex = 7;
            this.lblTLBTable.Text = "TLB Table";
            // 
            // lblPageTable
            // 
            this.lblPageTable.AutoSize = true;
            this.lblPageTable.Location = new System.Drawing.Point(487, 12);
            this.lblPageTable.Name = "lblPageTable";
            this.lblPageTable.Size = new System.Drawing.Size(62, 13);
            this.lblPageTable.TabIndex = 7;
            this.lblPageTable.Text = "Page Table";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 142);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPageTable);
            this.Controls.Add(this.lblTLBTable);
            this.Controls.Add(this.txtVirtualAddress);
            this.Controls.Add(this.txtPhysicalAddress);
            this.Controls.Add(this.lblPhysicalAddress);
            this.Controls.Add(this.lblVirtualAddress);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.lblOffset);
            this.Controls.Add(this.lblVPN);
            this.Controls.Add(this.cbxAllAdresses);
            this.Controls.Add(this.btnLoadPA);
            this.Controls.Add(this.lbxTLB);
            this.Controls.Add(this.lbxPT);
            this.Name = "Form1";
            this.Text = "Virtual Memory Sim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPT;
        private System.Windows.Forms.ListBox lbxTLB;
        private System.Windows.Forms.Button btnLoadPA;
        private System.Windows.Forms.ComboBox cbxAllAdresses;
        private System.Windows.Forms.Label lblVPN;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Label lblVirtualAddress;
        private System.Windows.Forms.Label lblPhysicalAddress;
        private System.Windows.Forms.TextBox txtPhysicalAddress;
        private System.Windows.Forms.TextBox txtVirtualAddress;
        private System.Windows.Forms.Label lblTLBTable;
        private System.Windows.Forms.Label lblPageTable;
        private System.Windows.Forms.Label lblResult;
    }
}

