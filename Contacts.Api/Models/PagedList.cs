using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Api.Models
{
	public class PagedList<IEntity> : List<IEntity>
	{
		private int _currentPage, _totalPages, _pageSize, _totalCount;

		private PagedList(IEnumerable<IEntity> items, int count, int pageNumber, int pageSize)
		{
			_totalCount = count;
			_pageSize = pageSize;
			_currentPage = pageNumber;
			_totalPages = (int)Math.Ceiling(count / (double)pageSize);

			AddRange(items);
		}

		public static async Task<PagedList<IEntity>> ToPagedList(IQueryable<IEntity> source, int pageNumber, int pageSize)
		{
			var count = await source.CountAsync();

			var items = await source.Skip((pageNumber) * pageSize).Take(pageSize).ToListAsync();

			return new PagedList<IEntity>(items, count, pageNumber, pageSize);
		}
	}
}
