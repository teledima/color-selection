
namespace WindowsFormsApp1
{
    partial class FormColorSelection
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.color_selection = new ColorControlLIb.ColorSelectionControl();
            this.SuspendLayout();
            // 
            // color_selection
            // 
            this.color_selection.Location = new System.Drawing.Point(12, 12);
            this.color_selection.Name = "color_selection";
            this.color_selection.Size = new System.Drawing.Size(337, 124);
            this.color_selection.TabIndex = 1;
            // 
            // FormColorSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 158);
            this.Controls.Add(this.color_selection);
            this.Name = "FormColorSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор цвета";
            this.ResumeLayout(false);

        }

        #endregion
        private ColorControlLIb.ColorSelectionControl color_selection;
    }
}

