﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Data
{
	public class PagedList<T> : List<T>
	{
		private int CurrentPage { get; }
		private int TotalPages { get; }
		private int PageSize { get; }
		private int TotalCount { get; }

		private PagedList(IEnumerable<T> items, int count, int pageNumber, int pageSize)
		{
			TotalCount = count;
			PageSize = pageSize;
			CurrentPage = pageNumber;
			TotalPages = (int)Math.Ceiling(count / (double)pageSize);

			AddRange(items);
		}

		public static async Task<PagedList<T>> ToPagedList(IQueryable<T> source, int pageNumber, int pageSize)
		{
			var count = await source.CountAsync();

			var items = await source.Skip((pageNumber) * pageSize).Take(pageSize).ToListAsync();

			return new PagedList<T>(items, count, pageNumber, pageSize);
		}
	}
}
