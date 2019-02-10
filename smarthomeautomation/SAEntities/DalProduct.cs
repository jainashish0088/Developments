using SAPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class DalProduct
    {
        public List<SAPO.ProductsPro> SelectProductList(SAPO.GetProduct getProduct)
        {
            SAContext objSAContext = new SAContext();
            List<SAPO.ProductsPro> lstProductsPro = new List<ProductsPro>();
            var lstProduct = new List<Product>();

            var products = objSAContext.Products.Include("ProductGalleries");
            if (!string.IsNullOrWhiteSpace(getProduct.CategoryName) && !string.IsNullOrWhiteSpace(getProduct.BrandName))
                lstProduct = products.Where(c => c.Brand.Name.ToLower().Contains(getProduct.BrandName.ToLower()) && c.Categories.Any(xcat => xcat.Name.ToLower().Contains(getProduct.CategoryName.ToLower())) && c.IsActive == true && c.IsDeleted == false).ToList();
            else if (!string.IsNullOrWhiteSpace(getProduct.CategoryName))
                lstProduct = products.Where(c => c.Categories.Any(xcat => xcat.Name.ToLower().Contains(getProduct.CategoryName.ToLower())) && c.IsActive == true && c.IsDeleted == false).ToList();
            else if (!string.IsNullOrWhiteSpace(getProduct.BrandName))
                lstProduct = products.Where(c => c.Brand.Name.ToLower().Contains(getProduct.BrandName.ToLower()) && c.IsActive == true && c.IsDeleted == false).ToList();
            else if (getProduct.BrandIds.Count > 0)
                lstProduct = products.Where(c => getProduct.BrandIds.Select(br => br.Id).Contains(c.Brand.Id) && c.IsActive == true && c.IsDeleted == false).ToList();
            else
                lstProduct = products.Where(c => c.IsActive == true && c.IsDeleted == false).ToList();
            foreach (var product in lstProduct)
            {
                SAPO.ProductsPro _product = new ProductsPro();
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
                lstProductsPro.Add(_product);
            }
            return lstProductsPro;
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
