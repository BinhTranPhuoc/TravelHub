using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelHub.Models.Paging
{
    public class PagingModel
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public string SortItem { get; set; }

        public string SortDirection { get; set; }

        public int TotalRow { get; set; }

        public int PageBegin { get; set; }

        public int PageEnd { get; set; }

        public int CmnEvent { get; set; }

        public int CmnStatus { get; set; }

    }
}