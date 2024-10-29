namespace StorePhoinBackened.Repository.Serves;

using StorePhoinBackened.Models;
using System.Collections.Generic;
using System.Linq;

public class ProductRepository
{
    private readonly List<Product> _products = new List<Product>();

    public IEnumerable<Product> GetAllProducts()
    {
        return _products;
    }

    public  Product GetProductById(int id)
    {
        return  _products.FirstOrDefault(p => p.Id == id) !;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void UpdateProduct(Product product)
    {
        var existingProduct = GetProductById(product.Id);
        if (existingProduct != null)
        {
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.QuantityInStock = product.QuantityInStock;
        }
    }

    public void DeleteProduct(int id)
    {
        var product = GetProductById(id);
        if (product != null)
        {
            _products.Remove(product);
        }
    }
}
