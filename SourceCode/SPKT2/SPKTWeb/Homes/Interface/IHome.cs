﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SPKTCore.Core.Domain;

namespace SPKTWeb.Homes.Interface
{
    public interface IHome
    {
        void DisplayCurrentAccount(Account account);
    }
}