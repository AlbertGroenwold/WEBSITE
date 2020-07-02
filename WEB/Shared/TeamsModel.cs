using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WEB.Shared
{
    public class TeamsModel
    {

        [Required] public string TeamName { get; set; }
        [Key] public string TeamID { get; set; }
        [Required] public int Admin { get; set; }
        [Required] public int Developer { get; set; }
        [Required] public int Tester { get; set; }

    }
}
