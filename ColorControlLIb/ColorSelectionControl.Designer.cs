namespace ColorControlLIb
{
    partial class ColorSelectionControl
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton_dec = new System.Windows.Forms.RadioButton();
            this.radioButton_hex = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanelTexBox = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxR = new ColorControlLIb.ColorTextBox();
            this.textBoxG = new ColorControlLIb.ColorTextBox();
            this.textBoxB = new ColorControlLIb.ColorTextBox();
            this.colorRec = new ColorControlLIb.ColorRectangleControl();
            this.flowLayoutPanelTexBox.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_dec
            // 
            this.radioButton_dec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_dec.AutoSize = true;
            this.radioButton_dec.Location = new System.Drawing.Point(3, 3);
            this.radioButton_dec.Name = "radioButton_dec";
            this.radioButton_dec.Size = new System.Drawing.Size(45, 17);
            this.radioButton_dec.TabIndex = 3;
            this.radioButton_dec.Text = "Dec";
            this.radioButton_dec.UseVisualStyleBackColor = true;
            this.radioButton_dec.CheckedChanged += new System.EventHandler(this.radioButton_dec_CheckedChanged);
            // 
            // radioButton_hex
            // 
            this.radioButton_hex.AutoSize = true;
            this.radioButton_hex.Location = new System.Drawing.Point(54, 3);
            this.radioButton_hex.Name = "radioButton_hex";
            this.radioButton_hex.Size = new System.Drawing.Size(44, 17);
            this.radioButton_hex.TabIndex = 4;
            this.radioButton_hex.Text = "Hex";
            this.radioButton_hex.UseVisualStyleBackColor = true;
            this.radioButton_hex.CheckedChanged += new System.EventHandler(this.radioButton_hex_CheckedChanged);
            // 
            // flowLayoutPanelTexBox
            // 
            this.flowLayoutPanelTexBox.AutoSize = true;
            this.flowLayoutPanelTexBox.Controls.Add(this.textBoxR);
            this.flowLayoutPanelTexBox.Controls.Add(this.textBoxG);
            this.flowLayoutPanelTexBox.Controls.Add(this.textBoxB);
            this.flowLayoutPanelTexBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelTexBox.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelTexBox.Name = "flowLayoutPanelTexBox";
            this.flowLayoutPanelTexBox.Size = new System.Drawing.Size(106, 78);
            this.flowLayoutPanelTexBox.TabIndex = 5;
            this.flowLayoutPanelTexBox.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.radioButton_dec);
            this.flowLayoutPanel2.Controls.Add(this.radioButton_hex);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 93);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(101, 23);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(196, 119);
            this.flowLayoutPanel3.TabIndex = 7;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanelTexBox);
            this.flowLayoutPanel4.Controls.Add(this.colorRec);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(190, 84);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(3, 3);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 20);
            this.textBoxR.TabIndex = 0;
            this.textBoxR.WordWrap = false;
            this.textBoxR.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(3, 29);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(100, 20);
            this.textBoxG.TabIndex = 2;
            this.textBoxG.WordWrap = false;
            this.textBoxG.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(3, 55);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 1;
            this.textBoxB.WordWrap = false;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // colorRec
            // 
            this.colorRec.BackColor = System.Drawing.Color.Red;
            this.colorRec.Color = System.Drawing.Color.Empty;
            this.colorRec.Location = new System.Drawing.Point(115, 3);
            this.colorRec.Name = "colorRec";
            this.colorRec.Size = new System.Drawing.Size(72, 78);
            this.colorRec.TabIndex = 0;
            // 
            // ColorSelectionControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanel3);
            this.Name = "ColorSelectionControl";
            this.Size = new System.Drawing.Size(207, 130);
            this.flowLayoutPanelTexBox.ResumeLayout(false);
            this.flowLayoutPanelTexBox.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorTextBox textBoxR;
        private ColorTextBox textBoxB;
        private ColorTextBox textBoxG;
        private System.Windows.Forms.RadioButton radioButton_dec;
        private System.Windows.Forms.RadioButton radioButton_hex;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTexBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private ColorRectangleControl colorRec;
    }
}
