using Unity_ETP.Business.Abstract;
using Unity_ETP.Business.Concrete;
using Unity_ETP.Business.Concrete.Blogs;
using UnityETP.DataAccess.Abstract;
using UnityETP.DataAccess.Concrete;
using UnityETP.DataAccess.Concrete.MsSql;
using UnityETP.Entity.Blogs;

namespace UnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            AppDbContext appDbContext = new AppDbContext();
            IUnitOfWork unitOfWork = new UnitOfWork(appDbContext);
            BaseSerice<Category, int> categoryService = new BaseSerice<Category, int>(unitOfWork);

            var category = new Category
            {
                Name = "Travel",
            };

            // var result = blogService.AddAsync();

            categoryService.AddAsync(category).Wait();
           
            Assert.Pass();
            
        }

        [Test]
        public async Task Test1()
        {
           
        }
    }
}