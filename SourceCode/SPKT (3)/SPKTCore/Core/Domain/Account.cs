﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPKTCore.Core.DataAccess.Impl;

namespace SPKTCore.Core.Domain
{
    public partial class Account
    {
        private List<Permission> _permissions = new List<Permission>();
        public List<Permission> Permissions
        {
            get { return _permissions; }
        }

        public void AddPermission(Permission permission)
        {
            _permissions.Add(permission);
        }

        public bool HasPermission(string Name)
        {
            foreach (Permission p in _permissions)
            {
                if (p.Name == Name)
                    return true;
            }
            return false;
        }
    }
}
