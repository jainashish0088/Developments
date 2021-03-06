﻿using SAPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class DalBrands
    {
        public List<SAPO.Brands> SelectBrandList(SAPO.BrandInput getBrand)
        {
            SAContext objSAContext = new SAContext();
            List<SAPO.Brands> lstbrand = new List<Brands>();
            var brands = objSAContext.Brands.Where(b => b.IsActive == true && b.IsDeleted == false).ToList();
            foreach (var brand in brands)
            {
                SAPO.Brands _brand = new Brands();
                _brand.Id = brand.Id;
                _brand.Name = brand.Name;
                _brand.IsActive = brand.IsActive;
                _brand.Desc = brand.Desc;
                _brand.LargeImg = brand.LargeImg;
                _brand.SmallImg = brand.SmallImg;
                _brand.CreatedDate = brand.CreatedDate;
                lstbrand.Add(_brand);
            }
            return lstbrand;
        }

        public SAPO.ProductsPro SelectProductDetail(string productName)
        {
            SAContext objSAContext = new SAContext();
            SAPO.ProductsPro _product = new ProductsPro();
            var product = objSAContext.Products.Include("ProductGalleries").Where(x => x.ProductName.ToLower() == productName).SingleOrDefault();
            if (product != null)
            {
                _product.Id = product.Id;
                _product.Discount = product.Discount;
                _product.IsActive = product.IsActive;
                _product.MRP = product.MRP;
                _product.ProductCode = product.ProductCode;
                _product.ProductDesc = product.ProductDesc;
                _product.ProductName = product.ProductName;
                _product.ProductShortDesc = product.ProductShortDesc;
                _product.Quantity = product.Quantity;
                _product.ReturnDuration = product.ReturnDuration;
                _product.SellingPrice = product.SellingPrice;
                _product.Tax = product.Tax;

                foreach (var pic in product.ProductGalleries)
                {
                    if (pic.IsActive)
                    {
                        SAPO.ProductGallery productGallery = new SAPO.ProductGallery();
                        productGallery.GalleryDesc = pic.GalleryDesc;
                        productGallery.GalleryImg = pic.GalleryImg;
                        productGallery.GalleryName = pic.GalleryName;
                        productGallery.ShowOnListing = pic.ShowOnListing;
                        productGallery.IsActive = pic.IsActive;
                        _product.ProductGalleries.Add(productGallery);
                    }
                }
            }
            return _product;
        }

        public void AddProduct(ProductsPro detail)
        {
            SAContext objSAContext = new SAContext();
            List<Product> lstProduct = new List<Product>();
            //var products = objSAContext.;
        }

    }
}
