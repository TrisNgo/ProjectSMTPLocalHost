
namespace ProjectSMTPLocalHost
{
    partial class FrmSmtpLocal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSmtpLocal));
            this.lblApp = new System.Windows.Forms.Label();
            this.lblMailFrom = new System.Windows.Forms.Label();
            this.lblFromPasswd = new System.Windows.Forms.Label();
            this.lblMailTo = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtBoxMailFrom = new System.Windows.Forms.TextBox();
            this.txtBoxPwd = new System.Windows.Forms.TextBox();
            this.txtBoxMailTo = new System.Windows.Forms.TextBox();
            this.txtBoxSubject = new System.Windows.Forms.TextBox();
            this.richTBBody = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBoxGetSer = new System.Windows.Forms.RichTextBox();
            this.txtBoxSendSer = new System.Windows.Forms.RichTextBox();
            this.checkBoxShowPwd = new System.Windows.Forms.CheckBox();
            this.txtBoxNameFrom = new System.Windows.Forms.TextBox();
            this.txtBoxNameTo = new System.Windows.Forms.TextBox();
            this.lblNameFrom = new System.Windows.Forms.Label();
            this.lblNameTo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.bttnClrAttach = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxAttachments = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.BackColor = System.Drawing.Color.Transparent;
            this.lblApp.Font = new System.Drawing.Font("Constantia", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.ForeColor = System.Drawing.Color.Orange;
            this.lblApp.Location = new System.Drawing.Point(589, 34);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(709, 68);
            this.lblApp.TabIndex = 9;
            this.lblApp.Text = "Sending local mail app ✉️";
            // 
            // lblMailFrom
            // 
            this.lblMailFrom.AutoSize = true;
            this.lblMailFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblMailFrom.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailFrom.ForeColor = System.Drawing.Color.Lime;
            this.lblMailFrom.Location = new System.Drawing.Point(37, 87);
            this.lblMailFrom.Name = "lblMailFrom";
            this.lblMailFrom.Size = new System.Drawing.Size(85, 29);
            this.lblMailFrom.TabIndex = 2;
            this.lblMailFrom.Text = "Email:";
            // 
            // lblFromPasswd
            // 
            this.lblFromPasswd.AutoSize = true;
            this.lblFromPasswd.BackColor = System.Drawing.Color.Transparent;
            this.lblFromPasswd.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromPasswd.ForeColor = System.Drawing.Color.Lime;
            this.lblFromPasswd.Location = new System.Drawing.Point(474, 48);
            this.lblFromPasswd.Name = "lblFromPasswd";
            this.lblFromPasswd.Size = new System.Drawing.Size(126, 29);
            this.lblFromPasswd.TabIndex = 3;
            this.lblFromPasswd.Text = "Password:";
            // 
            // lblMailTo
            // 
            this.lblMailTo.AutoSize = true;
            this.lblMailTo.BackColor = System.Drawing.Color.Transparent;
            this.lblMailTo.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailTo.ForeColor = System.Drawing.Color.Aqua;
            this.lblMailTo.Location = new System.Drawing.Point(73, 79);
            this.lblMailTo.Name = "lblMailTo";
            this.lblMailTo.Size = new System.Drawing.Size(85, 29);
            this.lblMailTo.TabIndex = 4;
            this.lblMailTo.Text = "Email:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.Yellow;
            this.lblSubject.Location = new System.Drawing.Point(484, 385);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(105, 29);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject:";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.BackColor = System.Drawing.Color.Transparent;
            this.lblBody.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.ForeColor = System.Drawing.Color.Yellow;
            this.lblBody.Location = new System.Drawing.Point(512, 431);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(77, 29);
            this.lblBody.TabIndex = 6;
            this.lblBody.Text = "Body:";
            // 
            // txtBoxMailFrom
            // 
            this.txtBoxMailFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMailFrom.Location = new System.Drawing.Point(129, 87);
            this.txtBoxMailFrom.Name = "txtBoxMailFrom";
            this.txtBoxMailFrom.Size = new System.Drawing.Size(315, 29);
            this.txtBoxMailFrom.TabIndex = 1;
            // 
            // txtBoxPwd
            // 
            this.txtBoxPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPwd.Location = new System.Drawing.Point(601, 49);
            this.txtBoxPwd.Name = "txtBoxPwd";
            this.txtBoxPwd.Size = new System.Drawing.Size(227, 29);
            this.txtBoxPwd.TabIndex = 2;
            this.txtBoxPwd.UseSystemPasswordChar = true;
            // 
            // txtBoxMailTo
            // 
            this.txtBoxMailTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMailTo.Location = new System.Drawing.Point(165, 79);
            this.txtBoxMailTo.Name = "txtBoxMailTo";
            this.txtBoxMailTo.Size = new System.Drawing.Size(315, 29);
            this.txtBoxMailTo.TabIndex = 4;
            // 
            // txtBoxSubject
            // 
            this.txtBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSubject.Location = new System.Drawing.Point(601, 385);
            this.txtBoxSubject.Name = "txtBoxSubject";
            this.txtBoxSubject.Size = new System.Drawing.Size(752, 29);
            this.txtBoxSubject.TabIndex = 5;
            // 
            // richTBBody
            // 
            this.richTBBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTBBody.Location = new System.Drawing.Point(601, 432);
            this.richTBBody.Name = "richTBBody";
            this.richTBBody.Size = new System.Drawing.Size(752, 297);
            this.richTBBody.TabIndex = 6;
            this.richTBBody.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSend.Font = new System.Drawing.Font("Constantia", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Yellow;
            this.btnSend.Location = new System.Drawing.Point(780, 748);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(480, 90);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "SEND ✔";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBoxGetSer
            // 
            this.txtBoxGetSer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBoxGetSer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxGetSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGetSer.Location = new System.Drawing.Point(21, 54);
            this.txtBoxGetSer.Name = "txtBoxGetSer";
            this.txtBoxGetSer.ReadOnly = true;
            this.txtBoxGetSer.Size = new System.Drawing.Size(412, 360);
            this.txtBoxGetSer.TabIndex = 15;
            this.txtBoxGetSer.Text = "";
            this.txtBoxGetSer.WordWrap = false;
            // 
            // txtBoxSendSer
            // 
            this.txtBoxSendSer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBoxSendSer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSendSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSendSer.Location = new System.Drawing.Point(23, 452);
            this.txtBoxSendSer.Name = "txtBoxSendSer";
            this.txtBoxSendSer.ReadOnly = true;
            this.txtBoxSendSer.Size = new System.Drawing.Size(410, 360);
            this.txtBoxSendSer.TabIndex = 16;
            this.txtBoxSendSer.Text = "";
            this.txtBoxSendSer.WordWrap = false;
            // 
            // checkBoxShowPwd
            // 
            this.checkBoxShowPwd.AutoSize = true;
            this.checkBoxShowPwd.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPwd.Location = new System.Drawing.Point(689, 87);
            this.checkBoxShowPwd.Name = "checkBoxShowPwd";
            this.checkBoxShowPwd.Size = new System.Drawing.Size(144, 23);
            this.checkBoxShowPwd.TabIndex = 8;
            this.checkBoxShowPwd.Text = "Show password";
            this.checkBoxShowPwd.UseVisualStyleBackColor = true;
            this.checkBoxShowPwd.CheckedChanged += new System.EventHandler(this.checkBoxShowPwd_CheckedChanged);
            // 
            // txtBoxNameFrom
            // 
            this.txtBoxNameFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNameFrom.Location = new System.Drawing.Point(129, 49);
            this.txtBoxNameFrom.Name = "txtBoxNameFrom";
            this.txtBoxNameFrom.Size = new System.Drawing.Size(315, 29);
            this.txtBoxNameFrom.TabIndex = 0;
            // 
            // txtBoxNameTo
            // 
            this.txtBoxNameTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNameTo.Location = new System.Drawing.Point(165, 44);
            this.txtBoxNameTo.Name = "txtBoxNameTo";
            this.txtBoxNameTo.Size = new System.Drawing.Size(315, 29);
            this.txtBoxNameTo.TabIndex = 3;
            // 
            // lblNameFrom
            // 
            this.lblNameFrom.AutoSize = true;
            this.lblNameFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblNameFrom.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFrom.ForeColor = System.Drawing.Color.Lime;
            this.lblNameFrom.Location = new System.Drawing.Point(37, 48);
            this.lblNameFrom.Name = "lblNameFrom";
            this.lblNameFrom.Size = new System.Drawing.Size(86, 29);
            this.lblNameFrom.TabIndex = 22;
            this.lblNameFrom.Text = "Name:";
            // 
            // lblNameTo
            // 
            this.lblNameTo.AutoSize = true;
            this.lblNameTo.BackColor = System.Drawing.Color.Transparent;
            this.lblNameTo.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTo.ForeColor = System.Drawing.Color.Aqua;
            this.lblNameTo.Location = new System.Drawing.Point(73, 43);
            this.lblNameTo.Name = "lblNameTo";
            this.lblNameTo.Size = new System.Drawing.Size(86, 29);
            this.lblNameTo.TabIndex = 23;
            this.lblNameTo.Text = "Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "----Select Server----",
            "Mdaemon",
            "Hmail Server",
            "Self-build Server"});
            this.comboBox1.Location = new System.Drawing.Point(601, 748);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 27);
            this.comboBox1.TabIndex = 27;
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAttach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAttach.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAttach.Location = new System.Drawing.Point(995, 268);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(120, 36);
            this.btnAttach.TabIndex = 24;
            this.btnAttach.Text = "Attach file";
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // bttnClrAttach
            // 
            this.bttnClrAttach.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bttnClrAttach.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClrAttach.Location = new System.Drawing.Point(995, 316);
            this.bttnClrAttach.Name = "bttnClrAttach";
            this.bttnClrAttach.Size = new System.Drawing.Size(120, 36);
            this.bttnClrAttach.TabIndex = 26;
            this.bttnClrAttach.Text = "Clear files";
            this.bttnClrAttach.UseVisualStyleBackColor = false;
            this.bttnClrAttach.Click += new System.EventHandler(this.bttnClrAttach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblNameFrom);
            this.groupBox1.Controls.Add(this.txtBoxNameFrom);
            this.groupBox1.Controls.Add(this.checkBoxShowPwd);
            this.groupBox1.Controls.Add(this.txtBoxPwd);
            this.groupBox1.Controls.Add(this.txtBoxMailFrom);
            this.groupBox1.Controls.Add(this.lblFromPasswd);
            this.groupBox1.Controls.Add(this.lblMailFrom);
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(447, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 133);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sender:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblNameTo);
            this.groupBox2.Controls.Add(this.txtBoxNameTo);
            this.groupBox2.Controls.Add(this.txtBoxMailTo);
            this.groupBox2.Controls.Add(this.lblMailTo);
            this.groupBox2.Font = new System.Drawing.Font("Constantia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox2.Location = new System.Drawing.Point(447, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 121);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receive:";
            // 
            // txtBoxAttachments
            // 
            this.txtBoxAttachments.Location = new System.Drawing.Point(11, 24);
            this.txtBoxAttachments.Name = "txtBoxAttachments";
            this.txtBoxAttachments.ReadOnly = true;
            this.txtBoxAttachments.Size = new System.Drawing.Size(202, 73);
            this.txtBoxAttachments.TabIndex = 30;
            this.txtBoxAttachments.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtBoxAttachments);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox3.Location = new System.Drawing.Point(1136, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 111);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Attachments";
            // 
            // FrmSmtpLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1383, 864);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bttnClrAttach);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.txtBoxSendSer);
            this.Controls.Add(this.txtBoxGetSer);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.richTBBody);
            this.Controls.Add(this.txtBoxSubject);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSmtpLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sending local mail app [by \"Nhóm 8\" lớp NT106.L21.ATCL]";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblMailFrom;
        private System.Windows.Forms.Label lblFromPasswd;
        private System.Windows.Forms.Label lblMailTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtBoxMailFrom;
        private System.Windows.Forms.TextBox txtBoxPwd;
        private System.Windows.Forms.TextBox txtBoxMailTo;
        private System.Windows.Forms.TextBox txtBoxSubject;
        private System.Windows.Forms.RichTextBox richTBBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox txtBoxGetSer;
        private System.Windows.Forms.RichTextBox txtBoxSendSer;
        private System.Windows.Forms.CheckBox checkBoxShowPwd;
        private System.Windows.Forms.TextBox txtBoxNameFrom;
        private System.Windows.Forms.TextBox txtBoxNameTo;
        private System.Windows.Forms.Label lblNameFrom;
        private System.Windows.Forms.Label lblNameTo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button bttnClrAttach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtBoxAttachments;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

