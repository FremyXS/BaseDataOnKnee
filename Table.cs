using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    public class Table
    {
        public string Name { get; }
        public List<Column> ColumnsList { get; } = new List<Column>();

        public List<OneString> ValuesList { get; } = new List<OneString>(); 
        public Table(string name)
        {
            Name = name;
        }
        public void GetNewColum(string nameColumn, string typeColumn, Dictionary<string, string> reference)
        {
            ColumnsList.Add(new Column(nameColumn, typeColumn, reference));
        }
        public void AddValue(OneString oneString)
        {
            ValuesList.Add(oneString);
        }
    }
}
