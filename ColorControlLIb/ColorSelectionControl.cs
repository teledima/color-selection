using System;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;

namespace ColorControlLIb
{
    public partial class ColorSelectionControl: UserControl
    {
        public ColorSelectionControl()
        {
            InitializeComponent();
            radioButton_dec.Checked = true;
        }

        private void radioButton_hex_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                foreach (ColorTextBox item in flowLayoutPanelTexBox.Controls)
                {
                    item.context.SetMask(new HexMask());
                    item.ParseText();
                }
            }
        }

        private void radioButton_dec_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                foreach (ColorTextBox item in flowLayoutPanelTexBox.Controls)
                {
                    item.context.SetMask(new DecMask());
                    item.ParseText();
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            colorRec.Color = Color.FromArgb(textBoxR.GetDecimal(), textBoxG.GetDecimal(), textBoxB.GetDecimal());
        }
    }
}
