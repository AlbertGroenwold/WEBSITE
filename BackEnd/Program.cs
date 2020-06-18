using BackEnd.src;
using System;

namespace BackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Iteration it = new Iteration();
            Team team = new Team();
            Tickets ticket = new Tickets();



            string ticketName = ticket.getTicketInfo("TicketID", "TicketIDTest2", "TicketName");

            string ticketid = ticket.getTicketInfo("TicketName", "TicketNameTest1", "TicketID");

            string iterationName = it.getIterationInfo("IterationID", "IterationIDTest2", "IterationName");

            string iterationID = it.getIterationInfo("IterationName", "IterationNameTest1", "IterationID");

            string userName = team.getUserInfo("UserID", "UserIDTest2", "UserName");

            string teamName = team.getTeamInfo("TeamID", "TeamID4Test", "TeamName");

            string taskName = ticket.getTaskInfo("TaskID", "TaskIDTest3", "TaskName");
        }
    }
}
