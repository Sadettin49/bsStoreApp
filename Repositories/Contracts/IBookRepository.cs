using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        IQueryable<Book> GetAllBooks(bool trackChanges);
        Book GetOneBookById(int id,bool trackChanges);
        void CreateOneBook(Book entity);
        void UpdateOneBook(Book entity);
        void DeleteOneBook(Book entity);
    }
}
