

using Domain.Entites;
using Domain.InterFaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infrastructure.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AppDBcontext _context;
        private IDbContextTransaction _transaction;

        public UnitOfWork(AppDBcontext context)
        { 
            _context = context;
            CompanyRepository = new GenericRepository<Company>(_context);
            CategoryRepository = new GenericRepository<Category>(_context);
            ProductRepository = new GenericRepository<Product>(_context);
            ProductImageRepository = new GenericRepository<ProductImage>(_context);
            CustomerRepository = new GenericRepository<Customer>(_context);
            OrderRepository = new GenericRepository<Order>(_context);
            OrderItemRepository = new GenericRepository<OrderItem>(_context);
        }

        public IGenericRepository<Company> CompanyRepository { get;}

        public IGenericRepository<Category> CategoryRepository { get;}

        public IGenericRepository<Product> ProductRepository { get;}

        public IGenericRepository<ProductImage> ProductImageRepository { get;}

        public IGenericRepository<Customer> CustomerRepository { get;}

        public IGenericRepository<Order> OrderRepository { get;}

        public IGenericRepository<OrderItem> OrderItemRepository { get;}

        public void BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _transaction?.Commit();
            _transaction?.Dispose();
            _transaction = null;
        }

        public void RollbackTransaction()
        {
            _transaction?.Rollback();
            _transaction?.Dispose();
            _transaction = null;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
