using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorControlLIb
{
    public interface IMask
    {
        bool IsValid(string text);
        object ParseText(string text);

        int getDecimalNumber(string text);
    }
}
