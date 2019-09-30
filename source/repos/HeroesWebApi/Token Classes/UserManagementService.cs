using HeroesWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesWebApi.Token_Classes
{
    public class UserManagementService : IUserManagementService
    {
        public bool IsValidUser(string userNmae, string password)
        {
            //!!!!! do not leave this as it will validate everything as true!!

            return true;
        }
    }
}
