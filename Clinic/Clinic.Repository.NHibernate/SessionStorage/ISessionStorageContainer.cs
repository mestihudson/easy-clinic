﻿using NHibernate;

namespace Clinic.Repository.NHibernate.SessionStorage
{
    public interface ISessionStorageContainer
    {
        ISession GetCurrentSession();
        void Store(ISession session);
    }

}
