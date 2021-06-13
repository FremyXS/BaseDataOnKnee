using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    public static class Save
    {
        private static List<string> InfoList { get; set; } = new List<string>();
        public static void SaveInfo()
        {
            GetTable();

            File.WriteAllLines("tables.txt", InfoList.ToArray());
        }
        private static void GetTable()
        {
            foreach (var table in Program.TablesList)
            {
                GetInfo(table);
                InfoList.Add(new string('=', 10));
            }
            foreach(var table in Program.TablesList)
            {
                GetString(table);
            }
        }
        private static void GetInfo(Table table)
        {
            InfoList.Add(table.Name);

            InfoList.Add(new string('-', 10));

            foreach (var column in table.ColumnsList)
            {
                var reference = GetReference(column);
                InfoList.Add(column.Name + ":" + column.Type.ToString() + reference);
            }
        }
        private static string GetReference(Column column)
        {
            if (column.Reference != null)
            {
                foreach (var i in column.Reference)
                {
                    return "[" + i.Key + ":" + i.Value + "]";
                }
            }
            return "";
        }
        private static void GetString(Table table)
        {
            InfoList.Add(table.Name);
            InfoList.Add(new string('-', 10));

            foreach (var stringOne in table.ValuesList)
            {

                InfoList.Add(GetValue(stringOne));
            }
        }
        private static string GetValue(OneString oneString)
        {
            string allValues = "";

            foreach(var value in oneString.Values)
            {
                allValues += value.Value + ";";
            }

            return allValues;
        }

        
    }
}
