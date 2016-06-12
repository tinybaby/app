using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evals.App.Infrastructure.Data
{
    public interface IPageable : IEnumerable
    {        
        int PageIndex { get; set; }
       
        int PageSize { get; set; }
        
        int TotalCount { get; set; }
       
        int PageNumber { get; set; }
      
        int TotalPages { get; }
       
        bool HasPreviousPage { get; }
        
        bool HasNextPage { get; }
       
        int FirstItemIndex { get; }
       
        int LastItemIndex { get; }
        
        bool IsFirstPage { get; }
        
        bool IsLastPage { get; }
    }


    /// <summary>
    /// Paged list interface
    /// </summary>
    public interface IPagedList<T> : IPageable, IList<T>
    {
        // codehint: sm-delete (members of IPageable now)
    }
}
