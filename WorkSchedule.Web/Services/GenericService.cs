using System;
using System.Linq;
using WorkSchedule.Web.Models;

namespace WorkSchedule.Web.Services
{
    public abstract class GenericService
    {
        public PageResult<T> GetPage<T>(IQueryable<T> query,
                                         int page, int pageSize) where T : class
        {
            var result = new PageResult<T>();
            result.CurrentPage = page;
            result.PageSize = pageSize;
            result.RowCount = query.Count();


            var pageCount = (double)result.RowCount / pageSize;
            result.PageCount = (int)Math.Ceiling(pageCount);

            var skip = page == 0 ? 0 : (page - 1) * pageSize;
            result.Results = query.Skip(skip).Take(pageSize).ToList();

            return result;
        }
    }
}
