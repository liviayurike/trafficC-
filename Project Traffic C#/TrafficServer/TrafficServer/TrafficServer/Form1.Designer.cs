namespace TrafficServer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.portServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.btnListen = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomor Port";
            // 
            // portServer
            // 
            this.portServer.Location = new System.Drawing.Point(140, 37);
            this.portServer.Name = "portServer";
            this.portServer.Size = new System.Drawing.Size(133, 26);
            this.portServer.TabIndex = 1;
            this.portServer.Text = "16385";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP Address";
            // 
            // ipServer
            // 
            this.ipServer.Location = new System.Drawing.Point(140, 89);
            this.ipServer.Name = "ipServer";
            this.ipServer.Size = new System.Drawing.Size(133, 26);
            this.ipServer.TabIndex = 3;
            this.ipServer.Text = "192.168.0.104";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Merah";
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelRed.Location = new System.Drawing.Point(405, 37);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(200, 100);
            this.panelRed.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kuning";
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelYellow.Location = new System.Drawing.Point(405, 156);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(200, 100);
            this.panelYellow.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hijau";
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelGreen.Location = new System.Drawing.Point(405, 275);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(200, 100);
            this.panelGreen.TabIndex = 9;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(140, 142);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 38);
            this.btnListen.TabIndex = 11;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(57, 249);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(158, 26);
            this.txtStatus.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timerServer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 430);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelYellow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portServer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Timer timer1;
    }
}

