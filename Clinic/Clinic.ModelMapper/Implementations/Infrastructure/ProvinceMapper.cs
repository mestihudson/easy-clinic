﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;



namespace Clinic.Repository.NHibernate.Mapping.Infrastructure
{
    public class ProvinceMapper : ClassMap<Clinic.Model.Infrastructure.Province>
    {
        //private const string schema = "Actions";
        public ProvinceMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ProvinceId);
            Map(x => x.Code)
                .Length(30)
                .Not.Nullable();
            Map(x => x.Name)
                .Length(100)
                .Not.Nullable();
            References(x => x.Country)
               .Nullable();
        }
    }

}

