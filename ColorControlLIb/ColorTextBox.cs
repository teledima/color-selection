using System;
using System.Windows.Forms;

namespace ColorControlLIb
{
    public partial class ColorTextBox : TextBox
    {
        public ColorTextBox()
        {
            InitializeComponent();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                string newText = Text + e.KeyChar;
                if (!context.CheckMask(newText))
                {
                    e.Handled = true;
                    return;
                }
            }
            old_text = Text;
            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (!context.CheckMask(Text))
            {
                Text = old_text;
                return;
            }
            base.OnTextChanged(e);
        }

        public int GetDecimal()
        {
            return context.GetDecimal(Text);
        }
    }
}
