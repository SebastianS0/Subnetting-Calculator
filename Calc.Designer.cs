namespace SubnettingCalc
{
    partial class Frm_Calc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Calc));
            this.txt_ipin = new System.Windows.Forms.TextBox();
            this.lbl_InputIP = new System.Windows.Forms.Label();
            this.txt_subin = new System.Windows.Forms.TextBox();
            this.lbl_InputSub = new System.Windows.Forms.Label();
            this.lbl_IpBin = new System.Windows.Forms.Label();
            this.lbl_Subbin = new System.Windows.Forms.Label();
            this.lbl_SubIDhead = new System.Windows.Forms.Label();
            this.lbl_SubID = new System.Windows.Forms.Label();
            this.lbl_HRngHead = new System.Windows.Forms.Label();
            this.lbl_SubRng = new System.Windows.Forms.Label();
            this.rB_CidrY = new System.Windows.Forms.RadioButton();
            this.rB_CidrN = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_NetClassHead = new System.Windows.Forms.Label();
            this.lbl_NetClass = new System.Windows.Forms.Label();
            this.lbl_subdec = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ipin
            // 
            this.txt_ipin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ipin.Location = new System.Drawing.Point(28, 45);
            this.txt_ipin.Name = "txt_ipin";
            this.txt_ipin.Size = new System.Drawing.Size(148, 29);
            this.txt_ipin.TabIndex = 0;
            this.txt_ipin.TextChanged += new System.EventHandler(this.txt_ipin_TextChanged);
            // 
            // lbl_InputIP
            // 
            this.lbl_InputIP.AutoSize = true;
            this.lbl_InputIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InputIP.Location = new System.Drawing.Point(28, 13);
            this.lbl_InputIP.Name = "lbl_InputIP";
            this.lbl_InputIP.Size = new System.Drawing.Size(99, 25);
            this.lbl_InputIP.TabIndex = 1;
            this.lbl_InputIP.Text = "Input IP:";
            // 
            // txt_subin
            // 
            this.txt_subin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subin.Location = new System.Drawing.Point(418, 45);
            this.txt_subin.Name = "txt_subin";
            this.txt_subin.Size = new System.Drawing.Size(150, 29);
            this.txt_subin.TabIndex = 2;
            this.txt_subin.TextChanged += new System.EventHandler(this.txt_subin_TextChanged);
            // 
            // lbl_InputSub
            // 
            this.lbl_InputSub.AutoSize = true;
            this.lbl_InputSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InputSub.Location = new System.Drawing.Point(392, 9);
            this.lbl_InputSub.Name = "lbl_InputSub";
            this.lbl_InputSub.Size = new System.Drawing.Size(215, 25);
            this.lbl_InputSub.TabIndex = 3;
            this.lbl_InputSub.Text = "Input Subnet Mask:";
            // 
            // lbl_IpBin
            // 
            this.lbl_IpBin.AutoSize = true;
            this.lbl_IpBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_IpBin.Location = new System.Drawing.Point(29, 94);
            this.lbl_IpBin.Name = "lbl_IpBin";
            this.lbl_IpBin.Size = new System.Drawing.Size(20, 24);
            this.lbl_IpBin.TabIndex = 4;
            this.lbl_IpBin.Text = "0";
            // 
            // lbl_Subbin
            // 
            this.lbl_Subbin.AutoSize = true;
            this.lbl_Subbin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_Subbin.Location = new System.Drawing.Point(414, 94);
            this.lbl_Subbin.Name = "lbl_Subbin";
            this.lbl_Subbin.Size = new System.Drawing.Size(20, 24);
            this.lbl_Subbin.TabIndex = 5;
            this.lbl_Subbin.Text = "0";
            // 
            // lbl_SubIDhead
            // 
            this.lbl_SubIDhead.AutoSize = true;
            this.lbl_SubIDhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubIDhead.Location = new System.Drawing.Point(28, 170);
            this.lbl_SubIDhead.Name = "lbl_SubIDhead";
            this.lbl_SubIDhead.Size = new System.Drawing.Size(122, 25);
            this.lbl_SubIDhead.TabIndex = 7;
            this.lbl_SubIDhead.Text = "Subnet ID:";
            // 
            // lbl_SubID
            // 
            this.lbl_SubID.AutoSize = true;
            this.lbl_SubID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_SubID.Location = new System.Drawing.Point(29, 206);
            this.lbl_SubID.Name = "lbl_SubID";
            this.lbl_SubID.Size = new System.Drawing.Size(20, 24);
            this.lbl_SubID.TabIndex = 8;
            this.lbl_SubID.Text = "0";
            // 
            // lbl_HRngHead
            // 
            this.lbl_HRngHead.AutoSize = true;
            this.lbl_HRngHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HRngHead.Location = new System.Drawing.Point(28, 253);
            this.lbl_HRngHead.Name = "lbl_HRngHead";
            this.lbl_HRngHead.Size = new System.Drawing.Size(235, 25);
            this.lbl_HRngHead.TabIndex = 9;
            this.lbl_HRngHead.Text = "Host Address Range:";
            // 
            // lbl_SubRng
            // 
            this.lbl_SubRng.AutoSize = true;
            this.lbl_SubRng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_SubRng.Location = new System.Drawing.Point(29, 294);
            this.lbl_SubRng.Name = "lbl_SubRng";
            this.lbl_SubRng.Size = new System.Drawing.Size(20, 24);
            this.lbl_SubRng.TabIndex = 10;
            this.lbl_SubRng.Text = "0";
            // 
            // rB_CidrY
            // 
            this.rB_CidrY.AutoSize = true;
            this.rB_CidrY.Location = new System.Drawing.Point(512, 153);
            this.rB_CidrY.Name = "rB_CidrY";
            this.rB_CidrY.Size = new System.Drawing.Size(36, 17);
            this.rB_CidrY.TabIndex = 11;
            this.rB_CidrY.Text = "Ja";
            this.rB_CidrY.UseVisualStyleBackColor = true;
            // 
            // rB_CidrN
            // 
            this.rB_CidrN.AutoSize = true;
            this.rB_CidrN.Checked = true;
            this.rB_CidrN.Location = new System.Drawing.Point(512, 177);
            this.rB_CidrN.Name = "rB_CidrN";
            this.rB_CidrN.Size = new System.Drawing.Size(47, 17);
            this.rB_CidrN.TabIndex = 12;
            this.rB_CidrN.TabStop = true;
            this.rB_CidrN.Text = "Nein";
            this.rB_CidrN.UseVisualStyleBackColor = true;
            this.rB_CidrN.CheckedChanged += new System.EventHandler(this.rB_CidrN_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "CIDR:";
            // 
            // lbl_NetClassHead
            // 
            this.lbl_NetClassHead.AutoSize = true;
            this.lbl_NetClassHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NetClassHead.Location = new System.Drawing.Point(28, 335);
            this.lbl_NetClassHead.Name = "lbl_NetClassHead";
            this.lbl_NetClassHead.Size = new System.Drawing.Size(170, 25);
            this.lbl_NetClassHead.TabIndex = 14;
            this.lbl_NetClassHead.Text = "Network Class:";
            // 
            // lbl_NetClass
            // 
            this.lbl_NetClass.AutoSize = true;
            this.lbl_NetClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_NetClass.Location = new System.Drawing.Point(29, 378);
            this.lbl_NetClass.Name = "lbl_NetClass";
            this.lbl_NetClass.Size = new System.Drawing.Size(23, 24);
            this.lbl_NetClass.TabIndex = 15;
            this.lbl_NetClass.Text = "A";
            // 
            // lbl_subdec
            // 
            this.lbl_subdec.AutoSize = true;
            this.lbl_subdec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_subdec.Location = new System.Drawing.Point(508, 48);
            this.lbl_subdec.Name = "lbl_subdec";
            this.lbl_subdec.Size = new System.Drawing.Size(20, 24);
            this.lbl_subdec.TabIndex = 17;
            this.lbl_subdec.Text = "0";
            this.lbl_subdec.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Anzahl an Netze";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hosts pro Netz";
            // 
            // Frm_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_subdec);
            this.Controls.Add(this.lbl_NetClass);
            this.Controls.Add(this.lbl_NetClassHead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rB_CidrN);
            this.Controls.Add(this.rB_CidrY);
            this.Controls.Add(this.lbl_SubRng);
            this.Controls.Add(this.lbl_HRngHead);
            this.Controls.Add(this.lbl_SubID);
            this.Controls.Add(this.lbl_SubIDhead);
            this.Controls.Add(this.lbl_Subbin);
            this.Controls.Add(this.lbl_IpBin);
            this.Controls.Add(this.lbl_InputSub);
            this.Controls.Add(this.txt_subin);
            this.Controls.Add(this.lbl_InputIP);
            this.Controls.Add(this.txt_ipin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Calc";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subnetting Calculator";
            this.Load += new System.EventHandler(this.Frm_Calc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ipin;
        private System.Windows.Forms.Label lbl_InputIP;
        private System.Windows.Forms.TextBox txt_subin;
        private System.Windows.Forms.Label lbl_InputSub;
        private System.Windows.Forms.Label lbl_IpBin;
        private System.Windows.Forms.Label lbl_Subbin;
        private System.Windows.Forms.Label lbl_SubIDhead;
        private System.Windows.Forms.Label lbl_SubID;
        private System.Windows.Forms.Label lbl_HRngHead;
        private System.Windows.Forms.Label lbl_SubRng;
        private System.Windows.Forms.RadioButton rB_CidrY;
        private System.Windows.Forms.RadioButton rB_CidrN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_NetClassHead;
        private System.Windows.Forms.Label lbl_NetClass;
        private System.Windows.Forms.Label lbl_subdec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

