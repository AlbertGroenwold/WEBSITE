using BackEnd.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.src
{
    class Iteration
    {

        public string getIterationInfo(string colNameToSearch, string colValueToSearch, string colValueToReturn)
        {
            DataManager dm = new DataManager();

            return dm.getDBInfo("Iteration", colNameToSearch, colValueToSearch, colValueToReturn);

        }

    }
}
