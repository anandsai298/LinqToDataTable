// See https://aka.ms/new-console-template for more information
using System;
using System.Data;

namespace Linq_To_DataTable;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LINQ To DATATABLE");
        DataTable dataTable = new DataTable();
        dataTable.Columns.Add("ID");
        dataTable.Columns.Add("ProductName");
        dataTable.Rows.Add("1", "MI");
        dataTable.Rows.Add("2", "REALME");
        dataTable.Rows.Add("3", "VU");
        Display(dataTable);
    }
    static void Display(DataTable dataTable)
    {
        var result=from product in dataTable.AsEnumerable() select product.Field<string>("ProductName");
        Console.WriteLine(result);
        foreach(var data in result)
        {
            Console.WriteLine(data);
        }
    }
}

