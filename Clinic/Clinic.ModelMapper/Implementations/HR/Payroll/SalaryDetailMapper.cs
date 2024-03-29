﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.Infrastructure;
using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.HR.Payroll
{
    public class SalaryDetailMapper : ClassMap<Clinic.Model.HR.SalaryDetail>
    {
        //private const string schema = "Actions";
        public SalaryDetailMapper()
        {
            //  SchemaIs(schema);
            References(x => x.SalaryGrade)
              .Nullable();
            References(x => x.Currency)
                .Nullable();
            Map(x => x.MinValue)
               .Nullable();
            Map(x => x.MaxValue)
               .Nullable();
            Map(x => x.StepValue)
               .Nullable();
        }
    }

}

