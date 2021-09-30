namespace ColorControlLIb
{
     partial class ColorTextBox
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string old_text;
        private Context context;
        public IMask Mask { 
            get { 
                return context.Mask;
            } 
            set { 
                context.Mask = value; 
                Text = string.Format("{0}", context.ParseText(Text)); 
            } 
        }

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
            this.context = new Context();
            this.SuspendLayout();
            // 
            // ColorTextBox
            //
            this.Name = "ColorTextBox";
            this.Size = new System.Drawing.Size(150, 16);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
