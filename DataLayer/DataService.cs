using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class DataService : IDataService
    {
        private readonly NorthwindContext _db;
        public DataService()
        {
            this._db = new NorthwindContext();
        }

        public Category AddNewCategory(string name, string description)
        {
            _db.Categories.Add(new Category() { Name = name, Description = description });
            _db.SaveChanges();
            
            return _db.Categories.Where(x => x.Name == name).FirstOrDefault()!;
        }

        public bool DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategories()
        {
            return _db.Categories.ToList();
        }

        public List<Order> GetAllOrders()
        {
            return _db.Orders.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
           return _db.Categories.Where(x => x.CategoryId == categoryId).FirstOrDefault()!;
        }

        public List<OrderDetails> GetDetailsForSpecificProductId(string productId)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(int id)
        {
            return _db.Orders.Where(x => x.Id == id).FirstOrDefault()!;
        }

        public List<Order> GetOrderByShippingName(string shippingName)
        {
            return _db.Orders.Where(x => x.ShipName == shippingName).ToList();
        }

        public OrderDetails GetOrderDetailsByOrderId(int orderId)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int productId)
        {
            return _db.Products.Where(x => x.Id == productId).FirstOrDefault()!;
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return _db.Products.Where(x => x.CategoryId == categoryId).ToList();
        }

        public List<Product> GetProductsThatContainSubstring(string substring)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(int id, string name, string description)
        {

            throw new NotImplementedException();
        }
    }
}
