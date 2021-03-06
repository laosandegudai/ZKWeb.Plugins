﻿using System;
using System.Collections.Generic;
using System.Linq;
using ZKWeb.Localize;
using ZKWeb.Plugins.Common.Base.src.UIComponents.BaseTable;
using ZKWeb.Plugins.Common.Base.src.UIComponents.StaticTable;
using ZKWeb.Plugins.Common.Base.src.UIComponents.StaticTable.Bases;
using ZKWeb.Plugins.Shopping.Product.src.Components.ProductStates.Interfaces;
using ZKWeb.Plugins.Shopping.Product.src.Domain.Enums;
using ZKWeb.Plugins.Shopping.Product.src.Domain.Extensions;
using ZKWeb.Plugins.Shopping.Product.src.Domain.Services;
using ZKWebStandard.Extensions;

namespace ZKWeb.Plugins.Shopping.Product.src.UIComponents.StaticTableHandlers {
	using Product = Domain.Entities.Product;

	/// <summary>
	/// 前台商品列表使用的商品表格的回调
	/// </summary>
	public class ProductTableHandler : StaticTableHandlerBase<Product, Guid> {
		/// <summary>
		/// 过滤数据
		/// </summary>
		public override void OnQuery(
			StaticTableSearchRequest request, ref IQueryable<Product> query) {
			// 按分类
			var classId = request.Conditions.GetOrDefault<Guid?>("class");
			if (classId != null) {
				query = query.Where(q => q.Classes.Any(c => c.Id == classId));
			}
			// 按标签
			var tagId = request.Conditions.GetOrDefault<Guid?>("tag");
			if (tagId != null) {
				query = query.Where(q => q.Tags.Any(t => t.Id == tagId));
			}
			// 按价格范围（这里不考虑货币）
			var priceRange = request.Conditions.GetOrDefault<string>("price_range");
			if (!string.IsNullOrEmpty(priceRange) && priceRange.Contains('~')) {
				var priceBounds = priceRange.Split('~'); ;
				var lowerBound = priceBounds[0].ConvertOrDefault<decimal>();
				var upperBound = priceBounds[1].ConvertOrDefault<decimal>();
				query = query.Where(q => q.MatchedDatas.Any(d => d.Price != null && d.Price >= lowerBound));
				if (upperBound > 0) {
					query = query.Where(q => q.MatchedDatas.Any(d => d.Price != null && d.Price <= upperBound));
				}
			}
			// 按关键词
			if (!string.IsNullOrEmpty(request.Keyword)) {
				query = query.Where(q => q.Name.Contains(request.Keyword));
			}
			// 只显示未删除且允许显示的商品
			var visibleStates = Application.Ioc.ResolveMany<IProductState>()
				.Where(s => s is IAmVisibleToThePublic)
				.Select(s => s.State).ToList();
			query = query.Where(q => !q.Deleted && visibleStates.Contains(q.State));
		}

		/// <summary>
		/// 排序数据
		/// </summary>
		public override void OnSort(
			StaticTableSearchRequest request, ref IQueryable<Product> query) {
			var order = request.Conditions.GetOrDefault<string>("order");
			if (order == "best_sales") {
				// 最佳销量
				// 商品插件中不处理这个排序，有需要请使用其他插件处理
				query = query.OrderByDescending(q => q.Id);
			} else if (order == "lower_price") {
				// 更低价格
				query = query.Select(
					q => new { q, minPrice = q.MatchedDatas.Where(m => m.Price != null).Min(m => m.Price) })
					.Where(q => q.minPrice != null).OrderBy(q => q.minPrice).Select(q => q.q);
			} else if (order == "higher_price") {
				// 更高价格
				query = query.Select(
					q => new { q, maxPrice = q.MatchedDatas.Where(m => m.Price != null).Max(m => m.Price) })
					.Where(q => q.maxPrice != null).OrderByDescending(q => q.maxPrice).Select(q => q.q);
			} else if (order == "newest_on_sale") {
				// 最新上架
				query = query.OrderByDescending(q => q.UpdateTime);
			} else {
				// 默认排序，先按显示顺序再按更新时间
				query = query.OrderBy(q => q.DisplayOrder).ThenByDescending(q => q.UpdateTime);
			}
		}

		/// <summary>
		/// 选择数据
		/// </summary>
		public override void OnSelect(
			StaticTableSearchRequest request, IList<EntityToTableRow<Product>> pairs) {
			var albumManager = Application.Ioc.Resolve<ProductAlbumManager>();
			foreach (var pair in pairs) {
				var seller = pair.Entity.Seller;
				pair.Row["Id"] = pair.Entity.Id;
				pair.Row["Name"] = new T(pair.Entity.Name);
				pair.Row["MainAlbumThumbnail"] = (
					albumManager.GetAlbumImageWebPath(pair.Entity.Id, null, ProductAlbumImageType.Thumbnail));
				pair.Row["Price"] = pair.Entity.MatchedDatas.GetPriceString();
				pair.Row["Seller"] = seller == null ? null : seller.Username;
			}
		}
	}
}
