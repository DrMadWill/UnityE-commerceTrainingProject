// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using Unity_ETP.Business.Concrete;
using UnityETP.DataAccess.Abstract;
using UnityETP.DataAccess.Concrete;
using UnityETP.DataAccess.Concrete.MsSql;
using UnityETP.Entity.Blogs;


//Console.WriteLine("Hello, World!");

//AppDbContext dbContext = new AppDbContext();

//IUnitOfWork unitOfWork = new UnitOfWork(dbContext);

//var category = new Category
//{
//    Name = "Travel"
//};

//await unitOfWork.Set<Category, int>(unitOfWork).AddAsync(category);
//await unitOfWork.Commit();

Brand brand = new Brand();
brand.Id = 1;
//brand.Name = "Sddd";
brand.GetPropMethod();
brand.GetPropMethod();

class Brand
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void GetPropMethod()
    {


        var result = this.GetType().GetProperty("Name").GetValue(this, null);
        if (result == null)
        {
            string res = "gggggg1";
            this.GetType().GetProperty("Name").SetValue(this, res);
            result = res;
        }
        Console.WriteLine(result);
    }

}


