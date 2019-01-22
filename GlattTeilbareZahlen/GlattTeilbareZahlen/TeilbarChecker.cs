using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlattTeilbareZahlen
{
    public class TeilbarChecker
    {
        public bool CheckTeilbarkeit(int quotient, int divisor)
        {
            return quotient%divisor == 0;
        }
    }
}
