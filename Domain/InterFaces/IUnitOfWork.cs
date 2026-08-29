using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InterFaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<Entites.Company> CompanyRepository { get; }
        IGenericRepository<Entites.Category> CategoryRepository { get; }
        IGenericRepository<Entites.Product> ProductRepository { get; }
        IGenericRepository<Entites.ProductImage> ProductImageRepository { get; }
        IGenericRepository<Entites.Customer> CustomerRepository { get; }
        IGenericRepository<Entites.Order> OrderRepository { get; }
        IGenericRepository<Entites.OrderItem> OrderItemRepository { get; }
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        void Save();
    }
}
