using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BePro.Website.Public.Helpers
{
    public class PagedList<T> : List<T>
    {

        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPages { get; private set; }

        public static PagedList<T> Create(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var result = new PagedList<T>();

            result.PageIndex = pageIndex;
            result.PageSize = pageSize;
            result.TotalCount = source.Count();
            result.TotalPages = (int)Math.Ceiling(result.TotalCount / (double)result.PageSize);

            result.AddRange(source.Skip(result.PageIndex * result.PageSize).Take(result.PageSize));

            return result;
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 0);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex + 1 < TotalPages);
            }
        }
    }
}