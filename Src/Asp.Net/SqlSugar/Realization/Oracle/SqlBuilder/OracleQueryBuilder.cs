﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugar
{
    public class OracleQueryBuilder : QueryBuilder
    {
        public override string SqlTemplate
        {
            get
            {
                return "SELECT {0}{{$:OrderByString:$}} FROM {1}{2}{3}{4}";
            }
        }
    }
}
