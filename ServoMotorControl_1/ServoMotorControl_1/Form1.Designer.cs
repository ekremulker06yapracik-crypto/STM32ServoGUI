namespace ServoMotorControl_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBar_degree = new System.Windows.Forms.TrackBar();
            this.comboBox_portlist = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_servoposition = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_degree = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_open = new System.Windows.Forms.Button();
            this.textBox_degree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_degree)).BeginInit();
            this.groupBox_servoposition.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar_degree
            // 
            this.trackBar_degree.Location = new System.Drawing.Point(78, 88);
            this.trackBar_degree.Maximum = 180;
            this.trackBar_degree.Name = "trackBar_degree";
            this.trackBar_degree.Size = new System.Drawing.Size(402, 56);
            this.trackBar_degree.TabIndex = 0;
            this.trackBar_degree.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // comboBox_portlist
            // 
            this.comboBox_portlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_portlist.FormattingEnabled = true;
            this.comboBox_portlist.Location = new System.Drawing.Point(42, 21);
            this.comboBox_portlist.Name = "comboBox_portlist";
            this.comboBox_portlist.Size = new System.Drawing.Size(121, 24);
            this.comboBox_portlist.TabIndex = 1;
            this.comboBox_portlist.DropDown += new System.EventHandler(this.comboBox_portlist_DropDown);
            // 
            // groupBox_servoposition
            // 
            this.groupBox_servoposition.Controls.Add(this.button_send);
            this.groupBox_servoposition.Controls.Add(this.label2);
            this.groupBox_servoposition.Controls.Add(this.textBox_degree);
            this.groupBox_servoposition.Controls.Add(this.label3);
            this.groupBox_servoposition.Controls.Add(this.label_degree);
            this.groupBox_servoposition.Controls.Add(this.label1);
            this.groupBox_servoposition.Controls.Add(this.trackBar_degree);
            this.groupBox_servoposition.Location = new System.Drawing.Point(12, 12);
            this.groupBox_servoposition.Name = "groupBox_servoposition";
            this.groupBox_servoposition.Size = new System.Drawing.Size(557, 244);
            this.groupBox_servoposition.TabIndex = 2;
            this.groupBox_servoposition.TabStop = false;
            this.groupBox_servoposition.Text = "ServoPosition";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "0°";
            // 
            // label_degree
            // 
            this.label_degree.AutoSize = true;
            this.label_degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_degree.Location = new System.Drawing.Point(255, 69);
            this.label_degree.Name = "label_degree";
            this.label_degree.Size = new System.Drawing.Size(87, 20);
            this.label_degree.TabIndex = 2;
            this.label_degree.Text = "Degree =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(486, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "180°";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button_open);
            this.groupBox2.Controls.Add(this.comboBox_portlist);
            this.groupBox2.Location = new System.Drawing.Point(575, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 226);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM PORT";
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(52, 66);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(102, 39);
            this.button_open.TabIndex = 2;
            this.button_open.Text = "OPEN";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // textBox_degree
            // 
            this.textBox_degree.Location = new System.Drawing.Point(164, 159);
            this.textBox_degree.Name = "textBox_degree";
            this.textBox_degree.Size = new System.Drawing.Size(153, 22);
            this.textBox_degree.TabIndex = 4;
            this.textBox_degree.TextChanged += new System.EventHandler(this.textBox_degree_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type a Value :";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(323, 154);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(86, 33);
            this.button_send.TabIndex = 6;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "CLOSE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 389);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_servoposition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_degree)).EndInit();
            this.groupBox_servoposition.ResumeLayout(false);
            this.groupBox_servoposition.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar_degree;
        private System.Windows.Forms.ComboBox comboBox_portlist;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox_servoposition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_degree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_degree;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

