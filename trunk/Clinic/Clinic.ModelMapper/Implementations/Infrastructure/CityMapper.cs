﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.Infrastructure
{
    public class CityMapper : ClassMap<Clinic.Model.Infrastructure.City>
    {
        //private const string schema = "Actions";
        public CityMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.CityId);
            Map(x => x.Name)
                .WithLengthOf(100)
                .Not.Nullable();
            References(x => x.Province)
                //.LazyLoad()
               .Nullable();
           

        }
    }

}



