﻿using aspCart.Core.Domain.Catalog;
using aspCart.Core.Domain.Sale;
using aspCart.Core.Domain.User;
using aspCart.Web.Areas.Admin.Models.Catalog;
using aspCart.Web.Areas.Admin.Models.Sale;
using aspCart.Web.Models;
using aspCart.Web.Models.ManageViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspCart.Web.Helpers
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        {
            // billing address mappings
            CreateMap<BillingAddress, BillingAddressModel>()
                .ReverseMap();
            CreateMap<BillingAddress, CheckoutModel>()
                .ReverseMap();

            // category mappings
            CreateMap<Category, CategoryListModel>();
            CreateMap<Category, CategoryCreateOrUpdateModel>()
                .ReverseMap();

            // manufacturer mappings
            CreateMap<Manufacturer, ManufacturerListModel>();
            CreateMap<Manufacturer, ManufacturerCreateOrUpdateModel>()
                .ReverseMap();

            // order mapping
            CreateMap<OrderManageModel, Order>();

            // product mappings
            CreateMap<Product, ProductListModel>();
            CreateMap<Product, ProductModel>();
            CreateMap<Product, ProductCreateOrUpdateModel>()
                .ForMember(dest => dest.Images, opt => opt.Ignore())
                .ReverseMap();

            // specifications
            CreateMap<Specification, SpecificationListModel>();
            CreateMap<Specification, SpecificationCreateOrUpdateModel>()
                .ReverseMap();
        }
    }
}
