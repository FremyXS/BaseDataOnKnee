using System;
using System.Collections.Generic;
using System.IO;

namespace Lab15
{
    public enum Types
    {
        Int, Bool, String
    }
    public enum Reference
    {
        Has, HasNot
    }
    class Program
    {
        public static List<Table> TablesList { get; } = new List<Table>();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество таблиц");
            int countTables = int.Parse(Console.ReadLine());

            for(var i = 0; i< countTables; i++)
            {
                SetInfo();
            }

            Save.SaveInfo();
        }
        private static void SetInfo()
        {
            Console.WriteLine("Введите название таблицы");
            string nameTabl = Console.ReadLine();

            var table = new Table(nameTabl);

            Console.WriteLine("Введите количество столбцов");
            int countColumns = int.Parse(Console.ReadLine());

            for(var i = 0; i < countColumns; i++)
            {
                Console.WriteLine("Введите имя столбца");
                string nameColumn = Console.ReadLine();
                Console.WriteLine("Введите тип столбца");
                string typeColumn = Console.ReadLine();

                var referenceColumn = GetReference();

                table.GetNewColum(nameColumn, typeColumn, referenceColumn);
            }

            SetValues(ref table);

            TablesList.Add(table);

        }
        private static Dictionary<string, string> GetReference()
        {
            Console.WriteLine("Есть связь?");
            Console.WriteLine("0 - нет, 1 - да ");

            Reference choice = Console.ReadLine() == "1" ? Reference.Has : Reference.HasNot; 

            if(choice == Reference.Has)
            {
                Console.WriteLine("Введите имя таблицы");
                string nameColumn = Console.ReadLine();
                Console.WriteLine("Введите имя столбца");
                string typeColumn = Console.ReadLine();

                return new Dictionary<string, string> { { nameColumn, typeColumn } };
            }

            return null;
        }
        private static void SetValues(ref Table table)
        {
            Console.WriteLine("Введите количество строк");
            int countStrings = int.Parse(Console.ReadLine());

            for(var i = 0; i<countStrings; i++)
            {
                table.AddValue( GetColumn(table.ColumnsList));
            }
        }
        private static OneString GetColumn(List<Column> columnList)
        {
            var stringValues = new OneString();
            for(var i = 0; i < columnList.Count; i++)
            {
                Console.WriteLine($"Введите значение столбца{columnList[i].Name}");
                string value = Console.ReadLine();

                stringValues.AddValue(new ValueColumn(columnList[i].Name, value));
            }

            return stringValues;
        }
    }
    
    
    
}
