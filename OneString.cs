using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    public class OneString
    {
        public List<ValueColumn> Values { get; } = new List<ValueColumn>();

        public void AddValue(ValueColumn valueColumn)
        {
            Values.Add(valueColumn);
        }
    }
}
