using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    /*create a class that implements the IProductRepository interface and gets its data using Entity
Framework Core. I added a class file called EFProductRepository.cs to the Models folder and used it to
define the repository class*/
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext context;

        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }

}

/*the repository
implementation just maps the Products property defined by the IProductRepository interface onto the
Products property defined by the ApplicationDbContext class. The Products property in the context class
returns a DbSet<Product> object, which implements the IQueryable<T> interface and makes it easy to
implement the IProductRepository interface when using Entity Framework Core.
 */
