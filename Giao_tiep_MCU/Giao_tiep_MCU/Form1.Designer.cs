namespace Giao_tiep_MCU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTextData = new System.Windows.Forms.TextBox();
            this.txtNumberData = new System.Windows.Forms.TextBox();
            this.Serial_port = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btNgat = new System.Windows.Forms.Button();
            this.btKetnoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.btn_led_1 = new System.Windows.Forms.Button();
            this.btn_led_2 = new System.Windows.Forms.Button();
            this.btn_led_3 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTextData
            // 
            this.txtTextData.Location = new System.Drawing.Point(341, 27);
            this.txtTextData.Multiline = true;
            this.txtTextData.Name = "txtTextData";
            this.txtTextData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextData.Size = new System.Drawing.Size(465, 130);
            this.txtTextData.TabIndex = 0;
            // 
            // txtNumberData
            // 
            this.txtNumberData.Location = new System.Drawing.Point(341, 187);
            this.txtNumberData.Multiline = true;
            this.txtNumberData.Name = "txtNumberData";
            this.txtNumberData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNumberData.Size = new System.Drawing.Size(465, 130);
            this.txtNumberData.TabIndex = 1;
            this.txtNumberData.TextChanged += new System.EventHandler(this.txtNumberData_TextChanged);
            // 
            // Serial_port
            // 
            this.Serial_port.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.Serial_port_PinChanged);
            this.Serial_port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Serial_port_DataReceived);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(849, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btNgat);
            this.groupBox2.Controls.Add(this.btKetnoi);
            this.groupBox2.Location = new System.Drawing.Point(18, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 122);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(20, 70);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(117, 29);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btNgat
            // 
            this.btNgat.Location = new System.Drawing.Point(166, 27);
            this.btNgat.Name = "btNgat";
            this.btNgat.Size = new System.Drawing.Size(117, 29);
            this.btNgat.TabIndex = 0;
            this.btNgat.Text = "Ngắt";
            this.btNgat.UseVisualStyleBackColor = true;
            this.btNgat.Click += new System.EventHandler(this.btNgat_Click);
            // 
            // btKetnoi
            // 
            this.btKetnoi.Location = new System.Drawing.Point(19, 27);
            this.btKetnoi.Name = "btKetnoi";
            this.btKetnoi.Size = new System.Drawing.Size(117, 29);
            this.btKetnoi.TabIndex = 0;
            this.btKetnoi.Text = "Kết nối";
            this.btKetnoi.UseVisualStyleBackColor = true;
            this.btKetnoi.Click += new System.EventHandler(this.btKetnoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbStop);
            this.groupBox1.Controls.Add(this.cbParity);
            this.groupBox1.Controls.Add(this.cbData);
            this.groupBox1.Controls.Add(this.cbRate);
            this.groupBox1.Controls.Add(this.cbCom);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 265);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng điều khiển";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stop bit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data bit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // cbStop
            // 
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Location = new System.Drawing.Point(101, 223);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(187, 24);
            this.cbStop.TabIndex = 0;
            this.cbStop.SelectedIndexChanged += new System.EventHandler(this.cbStop_SelectedIndexChanged);
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(101, 180);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(187, 24);
            this.cbParity.TabIndex = 0;
            this.cbParity.SelectedIndexChanged += new System.EventHandler(this.cbParity_SelectedIndexChanged);
            // 
            // cbData
            // 
            this.cbData.FormattingEnabled = true;
            this.cbData.Location = new System.Drawing.Point(101, 135);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(187, 24);
            this.cbData.TabIndex = 0;
            this.cbData.SelectedIndexChanged += new System.EventHandler(this.cbData_SelectedIndexChanged);
            // 
            // cbRate
            // 
            this.cbRate.FormattingEnabled = true;
            this.cbRate.Location = new System.Drawing.Point(101, 90);
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(187, 24);
            this.cbRate.TabIndex = 0;
            this.cbRate.SelectedIndexChanged += new System.EventHandler(this.cbRate_SelectedIndexChanged);
            // 
            // cbCom
            // 
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(101, 47);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(187, 24);
            this.cbCom.TabIndex = 0;
            this.cbCom.SelectedIndexChanged += new System.EventHandler(this.cbCom_SelectedIndexChanged);
            // 
            // btn_led_1
            // 
            this.btn_led_1.Location = new System.Drawing.Point(341, 342);
            this.btn_led_1.Name = "btn_led_1";
            this.btn_led_1.Size = new System.Drawing.Size(139, 46);
            this.btn_led_1.TabIndex = 6;
            this.btn_led_1.Text = "LED 1";
            this.btn_led_1.UseVisualStyleBackColor = true;
            this.btn_led_1.Click += new System.EventHandler(this.btn_led_1_Click);
            // 
            // btn_led_2
            // 
            this.btn_led_2.Location = new System.Drawing.Point(502, 342);
            this.btn_led_2.Name = "btn_led_2";
            this.btn_led_2.Size = new System.Drawing.Size(139, 46);
            this.btn_led_2.TabIndex = 6;
            this.btn_led_2.Text = "LED 2";
            this.btn_led_2.UseVisualStyleBackColor = true;
            this.btn_led_2.Click += new System.EventHandler(this.btn_led_2_Click);
            // 
            // btn_led_3
            // 
            this.btn_led_3.Location = new System.Drawing.Point(667, 342);
            this.btn_led_3.Name = "btn_led_3";
            this.btn_led_3.Size = new System.Drawing.Size(139, 46);
            this.btn_led_3.TabIndex = 6;
            this.btn_led_3.Text = "LED 3";
            this.btn_led_3.UseVisualStyleBackColor = true;
            this.btn_led_3.Click += new System.EventHandler(this.btn_led_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 447);
            this.Controls.Add(this.btn_led_3);
            this.Controls.Add(this.btn_led_2);
            this.Controls.Add(this.btn_led_1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumberData);
            this.Controls.Add(this.txtTextData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextData;
        private System.Windows.Forms.TextBox txtNumberData;
        private System.IO.Ports.SerialPort Serial_port;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btNgat;
        private System.Windows.Forms.Button btKetnoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.ComboBox cbRate;
        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.Button btn_led_1;
        private System.Windows.Forms.Button btn_led_2;
        private System.Windows.Forms.Button btn_led_3;
    }
}

