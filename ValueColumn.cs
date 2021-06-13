using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    public class ValueColumn
    {
        public string NameColumn { get; }
        public string Value { get; }
        public ValueColumn(string nameColumn, string value)
        {
            NameColumn = nameColumn;
            Value = value;
        }
    }
}
