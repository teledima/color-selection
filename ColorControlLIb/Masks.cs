using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ColorControlLIb
{
    class DecMask : IMask
    {
        public int getDecimalNumber(string text)
        {
            if (text.Length > 0)
                return int.Parse(text);
            return 0;
        }

        public bool IsValid(string text)
        {
            if (int.TryParse(text, out int num))
                return num >= 0 && num <= 255;
            else
                return false;
        }

        public object ParseText(string text)
        {
            if (text.Length > 0)
                return int.Parse(text, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            return null;
        }
    }


    class HexMask : IMask
    {
        public int getDecimalNumber(string text)
        {
            if (text.Length > 0)
                return int.Parse(text, NumberStyles.HexNumber);
            return 0;
        }

        public bool IsValid(string text)
        {
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
            if (int.TryParse(text, NumberStyles.HexNumber, cultureInfo, out int num))
                return num >= 0 && num <= 255;
            else
                return false;
            throw new NotImplementedException();
        }

        public object ParseText(string text)
        {
            if (text.Length > 0)
                return string.Format("{0:X}", int.Parse(text));
            return null;
        }
    }
}
