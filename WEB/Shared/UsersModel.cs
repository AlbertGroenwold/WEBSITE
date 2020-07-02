using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WEB.Shared
{
    public class UsersModel
    {
        [Required] public string UserName {get;set;}
        [Key] public string UserID {get;set;}
        [Required] public string TeamID {get;set;}
    }
}
