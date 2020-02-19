using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsClasses
{
    class VariableLengthParamList
    {
        public int Sum(string unnecessaryString, params int[] values)
        {
            int sum = 0;
            foreach (var item in values)
            {
                sum += item;
            }
            return sum;
        }
    }
}
