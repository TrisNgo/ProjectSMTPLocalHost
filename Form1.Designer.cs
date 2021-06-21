
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
            this.lblSender = new System.Windows.Forms.Label();
            this.lblRec = new System.Windows.Forms.Label();
            this.lblNameFrom = new System.Windows.Forms.Label();
            this.lblNameTo = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lblAttach = new System.Windows.Forms.Label();
            this.bttnClrAttach = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApp.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.Location = new System.Drawing.Point(615, 33);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(560, 61);
            this.lblApp.TabIndex = 9;
            this.lblApp.Text = "Sending Local Mail App";
            // 
            // lblMailFrom
            // 
            this.lblMailFrom.AutoSize = true;
            this.lblMailFrom.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailFrom.Location = new System.Drawing.Point(512, 163);
            this.lblMailFrom.Name = "lblMailFrom";
            this.lblMailFrom.Size = new System.Drawing.Size(69, 26);
            this.lblMailFrom.TabIndex = 2;
            this.lblMailFrom.Text = "Email:";
            // 
            // lblFromPasswd
            // 
            this.lblFromPasswd.AutoSize = true;
            this.lblFromPasswd.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromPasswd.Location = new System.Drawing.Point(908, 125);
            this.lblFromPasswd.Name = "lblFromPasswd";
            this.lblFromPasswd.Size = new System.Drawing.Size(102, 26);
            this.lblFromPasswd.TabIndex = 3;
            this.lblFromPasswd.Text = "Password:";
            // 
            // lblMailTo
            // 
            this.lblMailTo.AutoSize = true;
            this.lblMailTo.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailTo.Location = new System.Drawing.Point(512, 247);
            this.lblMailTo.Name = "lblMailTo";
            this.lblMailTo.Size = new System.Drawing.Size(69, 26);
            this.lblMailTo.TabIndex = 4;
            this.lblMailTo.Text = "Email:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(496, 295);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(85, 26);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject:";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.Location = new System.Drawing.Point(496, 347);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(63, 26);
            this.lblBody.TabIndex = 6;
            this.lblBody.Text = "Body:";
            // 
            // txtBoxMailFrom
            // 
            this.txtBoxMailFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMailFrom.Location = new System.Drawing.Point(587, 160);
            this.txtBoxMailFrom.Name = "txtBoxMailFrom";
            this.txtBoxMailFrom.Size = new System.Drawing.Size(315, 29);
            this.txtBoxMailFrom.TabIndex = 1;
            // 
            // txtBoxPwd
            // 
            this.txtBoxPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPwd.Location = new System.Drawing.Point(1016, 125);
            this.txtBoxPwd.Name = "txtBoxPwd";
            this.txtBoxPwd.Size = new System.Drawing.Size(227, 29);
            this.txtBoxPwd.TabIndex = 2;
            this.txtBoxPwd.UseSystemPasswordChar = true;
            // 
            // txtBoxMailTo
            // 
            this.txtBoxMailTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMailTo.Location = new System.Drawing.Point(587, 244);
            this.txtBoxMailTo.Name = "txtBoxMailTo";
            this.txtBoxMailTo.Size = new System.Drawing.Size(315, 29);
            this.txtBoxMailTo.TabIndex = 4;
            // 
            // txtBoxSubject
            // 
            this.txtBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSubject.Location = new System.Drawing.Point(587, 295);
            this.txtBoxSubject.Name = "txtBoxSubject";
            this.txtBoxSubject.Size = new System.Drawing.Size(670, 29);
            this.txtBoxSubject.TabIndex = 5;
            // 
            // richTBBody
            // 
            this.richTBBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTBBody.Location = new System.Drawing.Point(587, 347);
            this.richTBBody.Name = "richTBBody";
            this.richTBBody.Size = new System.Drawing.Size(670, 297);
            this.richTBBody.TabIndex = 6;
            this.richTBBody.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(1016, 797);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(217, 48);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBoxGetSer
            // 
            this.txtBoxGetSer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBoxGetSer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxGetSer.Location = new System.Drawing.Point(36, 33);
            this.txtBoxGetSer.Name = "txtBoxGetSer";
            this.txtBoxGetSer.ReadOnly = true;
            this.txtBoxGetSer.Size = new System.Drawing.Size(412, 308);
            this.txtBoxGetSer.TabIndex = 15;
            this.txtBoxGetSer.Text = "";
            this.txtBoxGetSer.WordWrap = false;
            // 
            // txtBoxSendSer
            // 
            this.txtBoxSendSer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBoxSendSer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSendSer.Location = new System.Drawing.Point(38, 376);
            this.txtBoxSendSer.Name = "txtBoxSendSer";
            this.txtBoxSendSer.ReadOnly = true;
            this.txtBoxSendSer.Size = new System.Drawing.Size(410, 308);
            this.txtBoxSendSer.TabIndex = 16;
            this.txtBoxSendSer.Text = "";
            this.txtBoxSendSer.WordWrap = false;
            // 
            // checkBoxShowPwd
            // 
            this.checkBoxShowPwd.AutoSize = true;
            this.checkBoxShowPwd.Location = new System.Drawing.Point(1142, 160);
            this.checkBoxShowPwd.Name = "checkBoxShowPwd";
            this.checkBoxShowPwd.Size = new System.Drawing.Size(101, 17);
            this.checkBoxShowPwd.TabIndex = 8;
            this.checkBoxShowPwd.Text = "Show password";
            this.checkBoxShowPwd.UseVisualStyleBackColor = true;
            this.checkBoxShowPwd.CheckedChanged += new System.EventHandler(this.checkBoxShowPwd_CheckedChanged);
            // 
            // txtBoxNameFrom
            // 
            this.txtBoxNameFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNameFrom.Location = new System.Drawing.Point(587, 122);
            this.txtBoxNameFrom.Name = "txtBoxNameFrom";
            this.txtBoxNameFrom.Size = new System.Drawing.Size(315, 29);
            this.txtBoxNameFrom.TabIndex = 0;
            // 
            // txtBoxNameTo
            // 
            this.txtBoxNameTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNameTo.Location = new System.Drawing.Point(587, 210);
            this.txtBoxNameTo.Name = "txtBoxNameTo";
            this.txtBoxNameTo.Size = new System.Drawing.Size(315, 29);
            this.txtBoxNameTo.TabIndex = 3;
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSender.Location = new System.Drawing.Point(454, 89);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(80, 26);
            this.lblSender.TabIndex = 20;
            this.lblSender.Text = "Sender:";
            // 
            // lblRec
            // 
            this.lblRec.AutoSize = true;
            this.lblRec.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRec.Location = new System.Drawing.Point(452, 189);
            this.lblRec.Name = "lblRec";
            this.lblRec.Size = new System.Drawing.Size(93, 26);
            this.lblRec.TabIndex = 21;
            this.lblRec.Text = "Receiver:";
            // 
            // lblNameFrom
            // 
            this.lblNameFrom.AutoSize = true;
            this.lblNameFrom.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFrom.Location = new System.Drawing.Point(512, 124);
            this.lblNameFrom.Name = "lblNameFrom";
            this.lblNameFrom.Size = new System.Drawing.Size(71, 26);
            this.lblNameFrom.TabIndex = 22;
            this.lblNameFrom.Text = "Name:";
            // 
            // lblNameTo
            // 
            this.lblNameTo.AutoSize = true;
            this.lblNameTo.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTo.Location = new System.Drawing.Point(512, 212);
            this.lblNameTo.Name = "lblNameTo";
            this.lblNameTo.Size = new System.Drawing.Size(71, 26);
            this.lblNameTo.TabIndex = 23;
            this.lblNameTo.Text = "Name:";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(588, 660);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(120, 36);
            this.btnAttach.TabIndex = 24;
            this.btnAttach.Text = "Attach file";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // lblAttach
            // 
            this.lblAttach.AutoSize = true;
            this.lblAttach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttach.Location = new System.Drawing.Point(724, 670);
            this.lblAttach.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblAttach.Name = "lblAttach";
            this.lblAttach.Size = new System.Drawing.Size(84, 16);
            this.lblAttach.TabIndex = 25;
            this.lblAttach.Text = "Attachments:";
            // 
            // bttnClrAttach
            // 
            this.bttnClrAttach.Location = new System.Drawing.Point(587, 702);
            this.bttnClrAttach.Name = "bttnClrAttach";
            this.bttnClrAttach.Size = new System.Drawing.Size(120, 36);
            this.bttnClrAttach.TabIndex = 26;
            this.bttnClrAttach.Text = "Clear files";
            this.bttnClrAttach.UseVisualStyleBackColor = true;
            this.bttnClrAttach.Click += new System.EventHandler(this.bttnClrAttach_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mdaemon",
            "Hmail Server",
            "Self-build Server"});
            this.comboBox1.Location = new System.Drawing.Point(587, 773);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 28);
            this.comboBox1.TabIndex = 27;
            // 
            // FrmSmtpLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 857);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bttnClrAttach);
            this.Controls.Add(this.lblAttach);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.lblNameTo);
            this.Controls.Add(this.lblNameFrom);
            this.Controls.Add(this.lblRec);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.txtBoxNameTo);
            this.Controls.Add(this.txtBoxNameFrom);
            this.Controls.Add(this.checkBoxShowPwd);
            this.Controls.Add(this.txtBoxSendSer);
            this.Controls.Add(this.txtBoxGetSer);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.richTBBody);
            this.Controls.Add(this.txtBoxSubject);
            this.Controls.Add(this.txtBoxMailTo);
            this.Controls.Add(this.txtBoxPwd);
            this.Controls.Add(this.txtBoxMailFrom);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblMailTo);
            this.Controls.Add(this.lblFromPasswd);
            this.Controls.Add(this.lblMailFrom);
            this.Controls.Add(this.lblApp);
            this.Name = "FrmSmtpLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblRec;
        private System.Windows.Forms.Label lblNameFrom;
        private System.Windows.Forms.Label lblNameTo;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label lblAttach;
        private System.Windows.Forms.Button bttnClrAttach;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

