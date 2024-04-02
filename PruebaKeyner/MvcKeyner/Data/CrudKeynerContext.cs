using Microsoft.EntityFrameworkCore;
using MvcKeyner.Models;

namespace MvcKeyner.Data{
    public class CrudKeynerContext :DbContext{

        public CrudKeynerContext(DbContextOptions<CrudKeynerContext> options): base(options){
            
        }

        public DbSet<User>Users {get;set;}


    }
}