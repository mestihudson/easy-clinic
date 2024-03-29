﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.HR
{
    public class LeaveTypeMapper : ClassMap<Clinic.Model.HR.LeaveType>
    {
        //private const string schema = "Actions";
        public LeaveTypeMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.LeaveTypeId);
             Map(x => x.Name)
            .Length(100)
            .Not.Nullable();

        }
    }

}