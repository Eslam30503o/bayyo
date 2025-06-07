﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications.FacultyYearSemisterSpecParamsSpecifications
{
    public class FacultyYearSemisterSpecParams
    {
        public string? sort { get; set; }

        private const int MaxPageSize = 10;
        private int pageSize;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value > MaxPageSize ? MaxPageSize : value; }
        }
        public int PageIndex { get; set; } = 1;
        public string? Search { get; set; }

    }
}
