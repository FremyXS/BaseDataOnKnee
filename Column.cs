using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    public class Column
    {
        public string Name { get; }
        public Types Type { get; }
        public Dictionary<string, string> Reference { get; }

        public Column(string name, string type, Dictionary<string, string> reference)
        {
            Name = name;

            switch (type)
            {
                case "int":
                    Type = Types.Int;
                    break;
                case "string":
                    Type = Types.String;
                    break;
                case "bool":
                    Type = Types.Bool;
                    break;
                default:
                    throw new Exception("Нет такого типа");
            }

            Reference = reference;
        }
    }
}
