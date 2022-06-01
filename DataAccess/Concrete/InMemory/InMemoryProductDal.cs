using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{ ProductId=1, CategoryId=1, ProductName="bardak",UnitsInStock=15, UnitPrice=15},
            new Product{ ProductId=2, CategoryId=1, ProductName="kamera",UnitsInStock=3, UnitPrice=500},
            new Product{ ProductId=3, CategoryId=2, ProductName="telefon",UnitsInStock=2, UnitPrice=1500},
            new Product{ ProductId=4, CategoryId=2, ProductName="klavye",UnitsInStock=65, UnitPrice=150},
            new Product{ ProductId=5, CategoryId=1, ProductName="mouse",UnitsInStock=150, UnitPrice=85}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            
            Product productToDelete = _products.SingleOrDefault(p=> p.ProductId==product.ProductId);  
            //singleordefault tek tek dolaşmaya yarıyoru foreachden daha kısa olduğpu için kullanıyoruz. (linq)
            //her p için p nin id si benim parametreyle gödnerdiğim ürünün id sine eşitse onun referansını buna eşitle

            _products.Remove(productToDelete);
        }

        public Product Get()
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            //where koşulu içindeki şarta uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür.
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //gönderdiğim ürün id sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
