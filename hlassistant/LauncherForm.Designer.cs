namespace hlassistant
{
    partial class LauncherForm
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
            this.cscbx = new System.Windows.Forms.RadioButton();
            this.hlcbx = new System.Windows.Forms.RadioButton();
            this.ofcbx = new System.Windows.Forms.RadioButton();
            this.agcbx = new System.Windows.Forms.RadioButton();
            this.bscbx = new System.Windows.Forms.RadioButton();
            this.dccbx = new System.Windows.Forms.RadioButton();
            this.resolution = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.c_nofbo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cscbx
            // 
            this.cscbx.AutoSize = true;
            this.cscbx.Location = new System.Drawing.Point(12, 82);
            this.cscbx.Name = "cscbx";
            this.cscbx.Size = new System.Drawing.Size(92, 17);
            this.cscbx.TabIndex = 0;
            this.cscbx.TabStop = true;
            this.cscbx.Text = "Counter-Strike";
            this.cscbx.UseVisualStyleBackColor = true;
            // 
            // hlcbx
            // 
            this.hlcbx.AutoSize = true;
            this.hlcbx.Location = new System.Drawing.Point(12, 59);
            this.hlcbx.Name = "hlcbx";
            this.hlcbx.Size = new System.Drawing.Size(64, 17);
            this.hlcbx.TabIndex = 0;
            this.hlcbx.TabStop = true;
            this.hlcbx.Text = "Half-Life";
            this.hlcbx.UseVisualStyleBackColor = true;
            this.hlcbx.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // ofcbx
            // 
            this.ofcbx.AutoSize = true;
            this.ofcbx.Location = new System.Drawing.Point(136, 59);
            this.ofcbx.Name = "ofcbx";
            this.ofcbx.Size = new System.Drawing.Size(100, 17);
            this.ofcbx.TabIndex = 1;
            this.ofcbx.TabStop = true;
            this.ofcbx.Text = "Opposing Force";
            this.ofcbx.UseVisualStyleBackColor = true;
            // 
            // agcbx
            // 
            this.agcbx.AutoSize = true;
            this.agcbx.Location = new System.Drawing.Point(12, 105);
            this.agcbx.Name = "agcbx";
            this.agcbx.Size = new System.Drawing.Size(109, 17);
            this.agcbx.TabIndex = 2;
            this.agcbx.TabStop = true;
            this.agcbx.Text = "Adrenaline Gamer";
            this.agcbx.UseVisualStyleBackColor = true;
            // 
            // bscbx
            // 
            this.bscbx.AutoSize = true;
            this.bscbx.Location = new System.Drawing.Point(136, 82);
            this.bscbx.Name = "bscbx";
            this.bscbx.Size = new System.Drawing.Size(70, 17);
            this.bscbx.TabIndex = 3;
            this.bscbx.TabStop = true;
            this.bscbx.Text = "Blue Shift";
            this.bscbx.UseVisualStyleBackColor = true;
            // 
            // dccbx
            // 
            this.dccbx.AutoSize = true;
            this.dccbx.Location = new System.Drawing.Point(136, 105);
            this.dccbx.Name = "dccbx";
            this.dccbx.Size = new System.Drawing.Size(103, 17);
            this.dccbx.TabIndex = 4;
            this.dccbx.TabStop = true;
            this.dccbx.Text = "Decay (n/o port)";
            this.dccbx.UseVisualStyleBackColor = true;
            this.dccbx.Visible = false;
            this.dccbx.CheckedChanged += new System.EventHandler(this.Dccbx_CheckedChanged);
            // 
            // resolution
            // 
            this.resolution.FormattingEnabled = true;
            this.resolution.Items.AddRange(new object[] {
            "640x480",
            "800x600"});
            this.resolution.Location = new System.Drawing.Point(298, 59);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(142, 21);
            this.resolution.TabIndex = 5;
            this.resolution.Tag = "";
            this.resolution.Text = "Не выбрано";
            this.resolution.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Разрешение экрана:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Half-Life Assistant by 0x00101";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Конфиги:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(298, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Tag = "";
            this.comboBox1.Text = "Не выбрано";
            // 
            // c_nofbo
            // 
            this.c_nofbo.AutoSize = true;
            this.c_nofbo.Location = new System.Drawing.Point(460, 59);
            this.c_nofbo.Name = "c_nofbo";
            this.c_nofbo.Size = new System.Drawing.Size(56, 17);
            this.c_nofbo.TabIndex = 10;
            this.c_nofbo.Text = "-nofbo";
            this.c_nofbo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Сохранить настройки";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "Запустить и сохранить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(543, 210);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c_nofbo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resolution);
            this.Controls.Add(this.dccbx);
            this.Controls.Add(this.bscbx);
            this.Controls.Add(this.agcbx);
            this.Controls.Add(this.ofcbx);
            this.Controls.Add(this.hlcbx);
            this.Controls.Add(this.cscbx);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LauncherForm";
            this.Text = "Half-Life Assistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton cscbx;
        private System.Windows.Forms.RadioButton hlcbx;
        private System.Windows.Forms.RadioButton ofcbx;
        private System.Windows.Forms.RadioButton agcbx;
        private System.Windows.Forms.RadioButton bscbx;
        private System.Windows.Forms.RadioButton dccbx;
        private System.Windows.Forms.ComboBox resolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox c_nofbo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}