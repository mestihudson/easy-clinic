﻿using System;
using System.Collections.Generic;
using Clinic.Infrastructure.Querying;

namespace Clinic.Infrastructure.Domain
{
    public interface IReadOnlyRepository<T, TId> where T : IAggregateRoot 
    {
        T FindBy(TId id);
        IEnumerable<T> FindAll();        
        IEnumerable<T> FindBy(Query query);
        IEnumerable<T> FindBy(Query query, int index, int count);
    }
}
