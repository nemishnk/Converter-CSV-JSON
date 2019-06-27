using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Coreconverter;
namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string Json ="{'Result':[{'IsEnabled': true,'Id': 10015,'Name': 'Reena'},{'IsEnabled': true,'Id': 10016,'Name': 'Anil Singh'},{'IsEnabled': false,'Id': 10017,'Name': 'Aradhya','__metadata': { 'Id': 14013 }}]}";
            string FilePath = "H:\\Vis 17\\Testfile";
            Converter converter = new Converter();
            DataTable dataTable = new DataTable();
           dataTable=converter.GetDataTableFromJsonString(Json);
            //converter.CreateCSVFile(dataTable,FilePath);
            converter.CreateXMLFromJSON(Json, FilePath);
        }

    }
}
