﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Data
{
	public class PagedList<IEntity> : List<IEntity>
	{
		private int CurrentPage { get; }
		private int TotalPages { get; }
		private int PageSize { get; }
		private int TotalCount { get; }

		private PagedList(IEnumerable<IEntity> items, int count, int pageNumber, int pageSize)
		{
			TotalCount = count;
			PageSize = pageSize;
			CurrentPage = pageNumber;
			TotalPages = (int)Math.Ceiling(count / (double)pageSize);

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
