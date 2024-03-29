﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Infrastructure.CookieStorage
{
    public interface ICookieStorageService
    {
        void Save(string key, string value, DateTime expires);
        string Retrieve(string key);
    }
}
