﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Infrastructure.Authentication
{
    public interface IFormsAuthentication
    {
       void SetAuthenticationToken(string token);
       string GetAuthenticationToken();
       void SignOut();
    }                

}
