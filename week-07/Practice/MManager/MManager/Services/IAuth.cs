﻿using MManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MManager.Services
{
    public interface IAuth
    {
        string Register(string user, string pass, string repass, double balance, double id);
        string Authenticate(string user, string pass);
        void LogOut();
        void ConnectAccount(long id);
    }
}
