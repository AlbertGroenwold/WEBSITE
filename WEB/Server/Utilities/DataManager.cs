using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WEB.Server.Utilities
{
    class DataManager
    {

        public DataTable getDBTables(string databaseTable)
        {
            DBManager db = new DBManager();

            DataTable table = db.getDataFromDatabase(databaseTable);

            return table;
        }
    }
}
