// See https://aka.ms/new-console-template for more information
using Unity_ETP.Business.Concrete;
using UnityETP.DataAccess.Abstract;
using UnityETP.DataAccess.Concrete;
using UnityETP.DataAccess.Concrete.MsSql;
using UnityETP.Entity.Blogs;


Console.WriteLine("Hello, World!");

AppDbContext dbContext = new AppDbContext();

IUnitOfWork unitOfWork = new UnitOfWork(dbContext);

var category = new Category
{
    Name = "Travel"
};

await unitOfWork.Set<Category,int>().AddAsync(category);
await unitOfWork.Commit();

