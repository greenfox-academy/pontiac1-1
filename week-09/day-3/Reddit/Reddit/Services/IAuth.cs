﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public interface IAuth
    {
        string Login(string name);
        void Logout();
    }
}
