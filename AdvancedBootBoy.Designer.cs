
namespace msconfuck
{
    partial class AdvancedBootBoy
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
            this.ProcessorBoys = new System.Windows.Forms.CheckBox();
            this.BigProcessyBoys = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DebuggyBoy = new System.Windows.Forms.CheckBox();
            this.MaxMemCheck = new System.Windows.Forms.CheckBox();
            this.MemoryMaxBoy = new System.Windows.Forms.NumericUpDown();
            this.DebugBoys = new System.Windows.Forms.GroupBox();
            this.CancelBoy = new System.Windows.Forms.Button();
            this.OkayBuddy = new System.Windows.Forms.Button();
            this.DebugPortBoys = new System.Windows.Forms.ComboBox();
            this.DebugCheckPort = new System.Windows.Forms.CheckBox();
            this.BaudBoys = new System.Windows.Forms.ComboBox();
            this.BaudBoy = new System.Windows.Forms.CheckBox();
            this.ChannelThingy = new System.Windows.Forms.NumericUpDown();
            this.ChannelCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.USBBoy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryMaxBoy)).BeginInit();
            this.DebugBoys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThingy)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessorBoys
            // 
            this.ProcessorBoys.AutoSize = true;
            this.ProcessorBoys.Location = new System.Drawing.Point(12, 12);
            this.ProcessorBoys.Name = "ProcessorBoys";
            this.ProcessorBoys.Size = new System.Drawing.Size(132, 17);
            this.ProcessorBoys.TabIndex = 0;
            this.ProcessorBoys.Text = "Number of processors:";
            this.ProcessorBoys.UseVisualStyleBackColor = true;
            this.ProcessorBoys.CheckedChanged += new System.EventHandler(this.ProcessorBoys_CheckedChanged);
            // 
            // BigProcessyBoys
            // 
            this.BigProcessyBoys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BigProcessyBoys.Enabled = false;
            this.BigProcessyBoys.FormattingEnabled = true;
            this.BigProcessyBoys.Location = new System.Drawing.Point(13, 34);
            this.BigProcessyBoys.Name = "BigProcessyBoys";
            this.BigProcessyBoys.Size = new System.Drawing.Size(121, 21);
            this.BigProcessyBoys.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "PCI Lock";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DebuggyBoy
            // 
            this.DebuggyBoy.AutoSize = true;
            this.DebuggyBoy.Location = new System.Drawing.Point(12, 96);
            this.DebuggyBoy.Name = "DebuggyBoy";
            this.DebuggyBoy.Size = new System.Drawing.Size(58, 17);
            this.DebuggyBoy.TabIndex = 3;
            this.DebuggyBoy.Text = "Debug";
            this.DebuggyBoy.UseVisualStyleBackColor = true;
            this.DebuggyBoy.CheckedChanged += new System.EventHandler(this.DebuggyBoy_CheckedChanged);
            // 
            // MaxMemCheck
            // 
            this.MaxMemCheck.AutoSize = true;
            this.MaxMemCheck.Location = new System.Drawing.Point(216, 12);
            this.MaxMemCheck.Name = "MaxMemCheck";
            this.MaxMemCheck.Size = new System.Drawing.Size(112, 17);
            this.MaxMemCheck.TabIndex = 4;
            this.MaxMemCheck.Text = "Maximum memory:";
            this.MaxMemCheck.UseVisualStyleBackColor = true;
            this.MaxMemCheck.CheckedChanged += new System.EventHandler(this.MaxMemCheck_CheckedChanged);
            // 
            // MemoryMaxBoy
            // 
            this.MemoryMaxBoy.Enabled = false;
            this.MemoryMaxBoy.Location = new System.Drawing.Point(214, 33);
            this.MemoryMaxBoy.Name = "MemoryMaxBoy";
            this.MemoryMaxBoy.Size = new System.Drawing.Size(120, 20);
            this.MemoryMaxBoy.TabIndex = 5;
            // 
            // DebugBoys
            // 
            this.DebugBoys.Controls.Add(this.USBBoy);
            this.DebugBoys.Controls.Add(this.label1);
            this.DebugBoys.Controls.Add(this.ChannelThingy);
            this.DebugBoys.Controls.Add(this.ChannelCheck);
            this.DebugBoys.Controls.Add(this.BaudBoys);
            this.DebugBoys.Controls.Add(this.BaudBoy);
            this.DebugBoys.Controls.Add(this.DebugPortBoys);
            this.DebugBoys.Controls.Add(this.DebugCheckPort);
            this.DebugBoys.Enabled = false;
            this.DebugBoys.Location = new System.Drawing.Point(13, 134);
            this.DebugBoys.Name = "DebugBoys";
            this.DebugBoys.Size = new System.Drawing.Size(344, 181);
            this.DebugBoys.TabIndex = 6;
            this.DebugBoys.TabStop = false;
            this.DebugBoys.Text = "Global debug settings";
            // 
            // CancelBoy
            // 
            this.CancelBoy.Location = new System.Drawing.Point(282, 321);
            this.CancelBoy.Name = "CancelBoy";
            this.CancelBoy.Size = new System.Drawing.Size(75, 23);
            this.CancelBoy.TabIndex = 7;
            this.CancelBoy.Text = "Cancel";
            this.CancelBoy.UseVisualStyleBackColor = true;
            this.CancelBoy.Click += new System.EventHandler(this.CancelBoy_Click);
            // 
            // OkayBuddy
            // 
            this.OkayBuddy.Location = new System.Drawing.Point(201, 321);
            this.OkayBuddy.Name = "OkayBuddy";
            this.OkayBuddy.Size = new System.Drawing.Size(75, 23);
            this.OkayBuddy.TabIndex = 8;
            this.OkayBuddy.Text = "OK";
            this.OkayBuddy.UseVisualStyleBackColor = true;
            this.OkayBuddy.Click += new System.EventHandler(this.OkayBuddy_Click);
            // 
            // DebugPortBoys
            // 
            this.DebugPortBoys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DebugPortBoys.Enabled = false;
            this.DebugPortBoys.FormattingEnabled = true;
            this.DebugPortBoys.Items.AddRange(new object[] {
            "COM1:",
            "COM2:",
            "COM3:",
            "COM4:",
            "1394",
            "USB"});
            this.DebugPortBoys.Location = new System.Drawing.Point(9, 43);
            this.DebugPortBoys.Name = "DebugPortBoys";
            this.DebugPortBoys.Size = new System.Drawing.Size(121, 21);
            this.DebugPortBoys.TabIndex = 10;
            this.DebugPortBoys.SelectedIndexChanged += new System.EventHandler(this.DebugPortBoys_SelectedIndexChanged);
            // 
            // DebugCheckPort
            // 
            this.DebugCheckPort.AutoSize = true;
            this.DebugCheckPort.Location = new System.Drawing.Point(8, 21);
            this.DebugCheckPort.Name = "DebugCheckPort";
            this.DebugCheckPort.Size = new System.Drawing.Size(82, 17);
            this.DebugCheckPort.TabIndex = 9;
            this.DebugCheckPort.Text = "Debug port:";
            this.DebugCheckPort.UseVisualStyleBackColor = true;
            this.DebugCheckPort.CheckedChanged += new System.EventHandler(this.DebugCheckPort_CheckedChanged);
            // 
            // BaudBoys
            // 
            this.BaudBoys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudBoys.Enabled = false;
            this.BaudBoys.FormattingEnabled = true;
            this.BaudBoys.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudBoys.Location = new System.Drawing.Point(201, 43);
            this.BaudBoys.Name = "BaudBoys";
            this.BaudBoys.Size = new System.Drawing.Size(121, 21);
            this.BaudBoys.TabIndex = 12;
            // 
            // BaudBoy
            // 
            this.BaudBoy.AutoSize = true;
            this.BaudBoy.Location = new System.Drawing.Point(202, 21);
            this.BaudBoy.Name = "BaudBoy";
            this.BaudBoy.Size = new System.Drawing.Size(75, 17);
            this.BaudBoy.TabIndex = 11;
            this.BaudBoy.Text = "Baud rate:";
            this.BaudBoy.UseVisualStyleBackColor = true;
            this.BaudBoy.CheckedChanged += new System.EventHandler(this.BaudBoy_CheckedChanged);
            // 
            // ChannelThingy
            // 
            this.ChannelThingy.Enabled = false;
            this.ChannelThingy.Location = new System.Drawing.Point(8, 100);
            this.ChannelThingy.Name = "ChannelThingy";
            this.ChannelThingy.Size = new System.Drawing.Size(120, 20);
            this.ChannelThingy.TabIndex = 10;
            // 
            // ChannelCheck
            // 
            this.ChannelCheck.AutoSize = true;
            this.ChannelCheck.Location = new System.Drawing.Point(10, 79);
            this.ChannelCheck.Name = "ChannelCheck";
            this.ChannelCheck.Size = new System.Drawing.Size(68, 17);
            this.ChannelCheck.TabIndex = 9;
            this.ChannelCheck.Text = "Channel:";
            this.ChannelCheck.UseVisualStyleBackColor = true;
            this.ChannelCheck.CheckedChanged += new System.EventHandler(this.ChannelCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "USB target name:";
            // 
            // USBBoy
            // 
            this.USBBoy.Location = new System.Drawing.Point(10, 153);
            this.USBBoy.Name = "USBBoy";
            this.USBBoy.Size = new System.Drawing.Size(106, 20);
            this.USBBoy.TabIndex = 14;
            // 
            // AdvancedBootBoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 355);
            this.Controls.Add(this.OkayBuddy);
            this.Controls.Add(this.CancelBoy);
            this.Controls.Add(this.DebugBoys);
            this.Controls.Add(this.MemoryMaxBoy);
            this.Controls.Add(this.MaxMemCheck);
            this.Controls.Add(this.DebuggyBoy);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BigProcessyBoys);
            this.Controls.Add(this.ProcessorBoys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvancedBootBoy";
            this.ShowIcon = false;
            this.Text = "BOOT Advanced Options";
            this.Load += new System.EventHandler(this.AdvancedBootBoy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemoryMaxBoy)).EndInit();
            this.DebugBoys.ResumeLayout(false);
            this.DebugBoys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelThingy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ProcessorBoys;
        private System.Windows.Forms.ComboBox BigProcessyBoys;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox DebuggyBoy;
        private System.Windows.Forms.CheckBox MaxMemCheck;
        private System.Windows.Forms.NumericUpDown MemoryMaxBoy;
        private System.Windows.Forms.GroupBox DebugBoys;
        private System.Windows.Forms.Button CancelBoy;
        private System.Windows.Forms.Button OkayBuddy;
        private System.Windows.Forms.ComboBox DebugPortBoys;
        private System.Windows.Forms.CheckBox DebugCheckPort;
        private System.Windows.Forms.ComboBox BaudBoys;
        private System.Windows.Forms.CheckBox BaudBoy;
        private System.Windows.Forms.NumericUpDown ChannelThingy;
        private System.Windows.Forms.CheckBox ChannelCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox USBBoy;
    }
}