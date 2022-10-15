using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UnityETP.Entity.Blogs;
using UnityETP.Entity.Commons;
using UnityETP.Entity.Contacts;
using UnityETP.Entity.Options;
using UnityETP.Entity.Organizations;
using UnityETP.Entity.Payments;
using UnityETP.Entity.Products;
using UnityETP.Entity.Shippings;
using UnityETP.Entity.Users;
using UnityETP.Entity.Vendors;

namespace UnityETP.DataAccess.Concrete.MsSql
{
    public class AppDbContext : IdentityDbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //{
        //}

        #region Sql Function
        //ALTER FUNCTION IsUniqBlogToTagCONSTRAINT(@BlogId int, @TagId int)
        //RETURNS BIT
        //AS
        //BEGIN
        // DECLARE @CountSetected INT
        // SELECT @CountSetected = COUNT(*) FROM[dbo].[BlogToTags]
        //        WHERE BlogId = @BlogId AND TagId = @TagId
        // IF(@CountSetected > 0)

        //    BEGIN
        //        RETURN 1

        //    END
        // RETURN 0
        //END
        #endregion


        #region DbSet (Tables)

        #region Blogs

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogToTag> BlogToTags { get; set; }
        public DbSet<Entity.Blogs.Category> BlogCategories { get; set; }
        public DbSet<Comment> BlogComments { get; set; }
        public DbSet<Entity.Blogs.Detail> BlogDetails { get; set; }
        public DbSet<Entity.Blogs.Tag> BlogTags { get; set; }

        #endregion

        #region Commons

        public DbSet<Color> Colors { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SucScribe> SucScribes { get; set; }


        #endregion

        #region Contacts

        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<OnlineAddress> OnlineAddresses { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Region> Regions { get; set; }


        #endregion

        #region Options
        public DbSet<Entity.Options.Item> OptionItem { get; set; }
        public DbSet<Option> Options { get; set; }
        #endregion

        #region Orders

        public DbSet<Entity.Orders.Order> UserOrders { get; set; }
        public DbSet<Entity.Orders.Detail> UserOrderDetails { get; set; }
        public DbSet<Entity.Orders.Item> UserOrderItems { get; set; }
        public DbSet<Entity.Orders.Status> UserOrderStatus { get; set; }
        #endregion

        #region Organizations
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Person> OrganizationPeople { get; set; }
        public DbSet<Position> OrganizationPositions { get; set; }
        public DbSet<Entity.Organizations.Status> OrganizationStatuses { get; set; }
        public DbSet<Entity.Organizations.Type> OrganizationTypes { get; set; }
        #endregion

        #region Payments
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Card> PaymentCards { get; set; }
        public DbSet<Entity.Payments.Type> PaymentTypes { get; set; }

        #endregion

        #region Products
        public DbSet<Prodcut> Prodcuts { get; set; }
        public DbSet<Brand> ProductBrands { get; set; }
        public DbSet<Entity.Products.Category> ProductCategories { get; set; }
        public DbSet<Entity.Products.Detail> ProductDetails { get; set; }
        public DbSet<Image> ProductImages { get; set; }
        public DbSet<ProductCreatingLog> ProductCreatingLogs { get; set; }
        public DbSet<ProductToTag> ProductToTags { get; set; }
        public DbSet<Review> ProductReviews { get; set; }
        public DbSet<Size> ProductSizes { get; set; }
        public DbSet<Entity.Products.Status> ProductStatuses { get; set; }
        public DbSet<Stock> ProductStocks { get; set; }
        public DbSet<SubCategory> ProductSubCategories { get; set; }
        public DbSet<Entity.Products.Tag> ProductTags { get; set; }
        public DbSet<Entity.Products.Type> ProductTypes { get; set; }

        #endregion

        #region Shippings
        public DbSet<Shipping> Shippings { get; set; }
        public DbSet<Entity.Shippings.Status> ShippingStatuses { get; set; }
        #endregion

        #region Users
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Authorization> UserAuthorizations { get; set; }
        public DbSet<Entity.Users.Status> UserStatuses { get; set; }
        #endregion

        #region Vendors
        public DbSet<Vendor> Vendors { get; set; }

        #region Orders
        public DbSet<Entity.Vendors.Orders.Order> VendorOrders { get; set; }
        public DbSet<Entity.Vendors.Orders.Detail> VendorOrderDetails { get; set; }
        public DbSet<Entity.Vendors.Orders.Item> VendorOrderItems { get; set; }
        public DbSet<Entity.Vendors.Orders.Status> VendorOrderStatus { get; set; }
        #endregion

        #endregion

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=Will;Initial Catalog=Unity_Ecommerce;Integrated Security=SSPI;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Relation
            /// <summary>
            /// One To Many => #OM  
            /// One To One => #OO
            /// Many To Many => #MM
            /// </summary>

            #region Blog
            // Blog To Category #OM
            builder.Entity<Blog>()
                .HasOne(b => b.Category)
                .WithMany(c => c.Blogs)
                .HasForeignKey(dr => dr.CategoryId);

            // Blog To User #OM
            builder.Entity<Blog>()
                .HasOne(b => b.User)
                .WithMany(u => u.Blogs)
                .HasForeignKey(dr => dr.UserId);
            // Blog To  Detail #OO
            builder.Entity<Blog>()
                .HasOne(b => b.Detail)
                .WithOne(d => d.Blog)
                .HasForeignKey<Entity.Blogs.Detail>(dr => dr.Id);

            // BlogToTag To Blog #MM
            builder.Entity<BlogToTag>()
                .HasOne(bt => bt.Blog)
                .WithMany(b => b.BlogToTags)
                .HasForeignKey(dr => dr.BlogId);
            // BlogToTag To Tag #MM
            builder.Entity<BlogToTag>()
                .HasOne(bt => bt.Tag)
                .WithMany(b => b.BlogToTags)
                .HasForeignKey(dr => dr.TagId);


            // Comment To Blog #OM
            builder.Entity<Comment>()
                .HasOne(c => c.Blog)
                .WithMany(b => b.Comments)
                .HasForeignKey(dr => dr.BlogId);

            // Comment To User #OM
            builder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(b => b.Comments)
                .HasForeignKey(dr => dr.UserId);

            #endregion

            #region UserOrders

            builder.Entity<Entity.Orders.Order>()
                .HasOne(x => x.Detail)
                .WithOne(x => x.UserOrder)
                .HasForeignKey<Entity.Orders.Detail>(dr => dr.Id);

            #endregion

            builder.Entity<Prodcut>()
                .HasOne(x => x.Detail)
                .WithOne(x => x.Prodcut)
                .HasForeignKey<Entity.Products.Detail>(dr => dr.Id);

            builder.Entity<Organization>()
                .HasOne(x => x.Vendor)
                .WithOne(x => x.Organization)
                .HasForeignKey<Vendor>(dr => dr.Id);


            builder.Entity<Entity.Vendors.Orders.Order>()
                .HasOne(x => x.Detail)
                .WithOne(x => x.VendorOrder)
                .HasForeignKey<Entity.Vendors.Orders.Detail>(dr => dr.Id);

            #endregion

            AppDbInitializer.ApplyDbSeedData(builder);
        }
    }
}