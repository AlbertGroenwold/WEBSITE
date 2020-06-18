using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BackEnd.Utilities
{
    class DataManager
    {

        public string getDBInfo(string databaseTable,string colNameToSearch, string colValueToSearch, string colValueToReturn)
        {
            DBManager db = new DBManager();

            DataTable table = db.getDataFromDatabase(databaseTable);

            string value = (from DataRow r in table.Rows
                            where r[colNameToSearch].ToString().Equals(colValueToSearch)
                            select r[colValueToReturn].ToString()).FirstOrDefault();

            return value;
        }
    }
}
