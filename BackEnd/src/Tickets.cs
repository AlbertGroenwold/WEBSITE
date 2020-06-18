using BackEnd.Utilities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BackEnd.src
{
    class Tickets
    {
        public string getTicketInfo(string colNameToSearch, string colValueToSearch, string colValueToReturn)
        {
            DataManager dm = new DataManager();

            return dm.getDBInfo("Tickets", colNameToSearch, colValueToSearch, colValueToReturn);

        }
        public string getTaskInfo(string colNameToSearch, string colValueToSearch, string colValueToReturn)
        {
            DataManager dm = new DataManager();

            return dm.getDBInfo("Tasks", colNameToSearch, colValueToSearch, colValueToReturn);

        }

    }
}
