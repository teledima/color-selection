using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
