using System.Drawing;
using System.Windows.Forms;

namespace ColorControlLIb
{
    public partial class ColorRectangleControl : Control
    {
        public ColorRectangleControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.DrawRectangle(new Pen(Color.White), this.DisplayRectangle);
            this.BackColor = this.Color;
        }
    }
}
