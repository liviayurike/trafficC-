namespace TrafficClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.portClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipTujuan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.merahON = new System.Windows.Forms.RadioButton();
            this.merahOFF = new System.Windows.Forms.RadioButton();
            this.kuningON = new System.Windows.Forms.RadioButton();
            this.kuningOFF = new System.Windows.Forms.RadioButton();
            this.hijauON = new System.Windows.Forms.RadioButton();
            this.hijauOFF = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomor Port";
            // 
            // portClient
            // 
            this.portClient.Location = new System.Drawing.Point(145, 34);
            this.portClient.Name = "portClient";
            this.portClient.Size = new System.Drawing.Size(136, 26);
            this.portClient.TabIndex = 1;
            this.portClient.Text = "16385";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP Tujuan";
            // 
            // ipTujuan
            // 
            this.ipTujuan.Location = new System.Drawing.Point(145, 74);
            this.ipTujuan.Name = "ipTujuan";
            this.ipTujuan.Size = new System.Drawing.Size(136, 26);
            this.ipTujuan.TabIndex = 3;
            this.ipTujuan.Text = "192.168.0.104";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "OFF";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.merahOFF);
            this.panel1.Controls.Add(this.merahON);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(313, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 57);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kuningOFF);
            this.panel2.Controls.Add(this.kuningON);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(313, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 57);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.hijauOFF);
            this.panel3.Controls.Add(this.hijauON);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(313, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 57);
            this.panel3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Merah";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kuning";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hijau";
            // 
            // merahON
            // 
            this.merahON.AutoSize = true;
            this.merahON.Location = new System.Drawing.Point(104, 15);
            this.merahON.Name = "merahON";
            this.merahON.Size = new System.Drawing.Size(21, 20);
            this.merahON.TabIndex = 1;
            this.merahON.UseVisualStyleBackColor = true;
            this.merahON.CheckedChanged += new System.EventHandler(this.merahON_CheckedChanged);
            // 
            // merahOFF
            // 
            this.merahOFF.AutoSize = true;
            this.merahOFF.Location = new System.Drawing.Point(175, 15);
            this.merahOFF.Name = "merahOFF";
            this.merahOFF.Size = new System.Drawing.Size(21, 20);
            this.merahOFF.TabIndex = 2;
            this.merahOFF.TabStop = true;
            this.merahOFF.UseVisualStyleBackColor = true;
            this.merahOFF.CheckedChanged += new System.EventHandler(this.merahOFF_CheckedChanged);
            // 
            // kuningON
            // 
            this.kuningON.AutoSize = true;
            this.kuningON.Location = new System.Drawing.Point(104, 16);
            this.kuningON.Name = "kuningON";
            this.kuningON.Size = new System.Drawing.Size(21, 20);
            this.kuningON.TabIndex = 1;
            this.kuningON.TabStop = true;
            this.kuningON.UseVisualStyleBackColor = true;
            this.kuningON.CheckedChanged += new System.EventHandler(this.kuningON_CheckedChanged);
            // 
            // kuningOFF
            // 
            this.kuningOFF.AutoSize = true;
            this.kuningOFF.Location = new System.Drawing.Point(175, 18);
            this.kuningOFF.Name = "kuningOFF";
            this.kuningOFF.Size = new System.Drawing.Size(21, 20);
            this.kuningOFF.TabIndex = 2;
            this.kuningOFF.TabStop = true;
            this.kuningOFF.UseVisualStyleBackColor = true;
            this.kuningOFF.CheckedChanged += new System.EventHandler(this.kuningOFF_CheckedChanged);
            // 
            // hijauON
            // 
            this.hijauON.AutoSize = true;
            this.hijauON.Location = new System.Drawing.Point(104, 15);
            this.hijauON.Name = "hijauON";
            this.hijauON.Size = new System.Drawing.Size(21, 20);
            this.hijauON.TabIndex = 1;
            this.hijauON.TabStop = true;
            this.hijauON.UseVisualStyleBackColor = true;
            this.hijauON.CheckedChanged += new System.EventHandler(this.hijauON_CheckedChanged);
            // 
            // hijauOFF
            // 
            this.hijauOFF.AutoSize = true;
            this.hijauOFF.Location = new System.Drawing.Point(175, 17);
            this.hijauOFF.Name = "hijauOFF";
            this.hijauOFF.Size = new System.Drawing.Size(21, 20);
            this.hijauOFF.TabIndex = 2;
            this.hijauOFF.TabStop = true;
            this.hijauOFF.UseVisualStyleBackColor = true;
            this.hijauOFF.CheckedChanged += new System.EventHandler(this.hijauOFF_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 316);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipTujuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portClient);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipTujuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton merahOFF;
        private System.Windows.Forms.RadioButton merahON;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton kuningOFF;
        private System.Windows.Forms.RadioButton kuningON;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton hijauOFF;
        private System.Windows.Forms.RadioButton hijauON;
        private System.Windows.Forms.Label label7;
    }
}

