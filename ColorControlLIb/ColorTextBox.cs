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
            base.OnKeyPress(e);
        }

        public int GetDecimal()
        {
            return context.GetDecimal(Text);
        }

        public void SetMask(IMask mask)
        {
            context.SetMask(mask);
            Text = string.Format("{0}", context.ParseText(Text));
        }
    }
}
