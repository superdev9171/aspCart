﻿using aspCart.Core.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspCart.Core.Interface.Services.Catalog
{
    public interface IProductService
    {
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>List of product entities</returns>
        IList<Product> GetAllProducts();

        /// <summary>
        /// Get product usind id
        /// </summary>
        /// <param name="id">Product id</param>
        /// <returns>Product entity</returns>
        Product GetProductById(Guid id);

        /// <summary>
        /// Get product using seo
        /// </summary>
        /// <param name="seo">Product SEO</param>
        /// <returns>Product entity</returns>
        Product GetProductBySeo(string seo);

        /// <summary>
        /// Insert product
        /// </summary>
        /// <param name="product">Product entity</param>
        void InsertProduct(Product product);

        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="product">Product entity</param>
        void UpdateProduct(Product product);

        /// <summary>
        /// Delete products
        /// </summary>
        /// <param name="ids">Ids of product to delete</param>
        void DeleteProducts(IList<Guid> ids);

        /// <summary>
        /// Get product context table
        /// </summary>
        /// <returns></returns>
        IQueryable<Product> Table();
    }
}
