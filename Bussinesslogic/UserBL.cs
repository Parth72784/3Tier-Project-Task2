﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BussinessObject;
using DataAccess;

namespace Bussinesslogic
{
   public class UserBL
    {
        public int SaveUserregisrationBL(UserBO objUserBL) // passing Bussiness object Here  
        {
            try
            {
                UserDA objUserda = new UserDA(); // Creating object of Dataccess  
                return objUserda.AddUserDetails(objUserBL); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}  

