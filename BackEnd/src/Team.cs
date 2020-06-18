using BackEnd.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.src
{
    class Team
    {

        public string getTeamInfo(string colNameToSearch, string colValueToSearch, string colValueToReturn)
        {
            DataManager dm = new DataManager();

            return dm.getDBInfo("Teams", colNameToSearch, colValueToSearch, colValueToReturn);

        }
        public string getUserInfo(string colNameToSearch, string colValueToSearch, string colValueToReturn)
        {
            DataManager dm = new DataManager();

            return dm.getDBInfo("Users", colNameToSearch, colValueToSearch, colValueToReturn);

        }

    }
}
