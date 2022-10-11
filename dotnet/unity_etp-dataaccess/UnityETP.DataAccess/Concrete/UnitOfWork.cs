using UnityETP.DataAccess.Abstract;
using UnityETP.DataAccess.Concrete.MsSql;
using UnityETP.DataAccess.DataHelper;
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

namespace UnityETP.DataAccess.Concrete
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }
        #region Blog
        //
        public IBaseRepostitory<Blog, int> BlogRepostitory 
        {
            get => RepositoryBuilder.Builder(BlogRepostitory, _dbContext);
            set => BlogRepostitory = value;
        }
        public IBaseRepostitory<BlogToTag, int> BlogToTagRepostitory
        {
            get => RepositoryBuilder.Builder(BlogToTagRepostitory, _dbContext);
            set => BlogToTagRepostitory = value;
        }
        public IBaseRepostitory<Entity.Blogs.Category, int> BlogCategoryRepostitory

        {
            get => RepositoryBuilder.Builder(BlogCategoryRepostitory, _dbContext);
            set => BlogCategoryRepostitory = value;
        }
        public IBaseRepostitory<Comment, int> BlogCommentRepostitory { get; set; }
        public IBaseRepostitory<Entity.Blogs.Detail, int> BlogDetailRepostitory { get; set; }
        public IBaseRepostitory<Entity.Blogs.Tag, int> BlogTagRepostitory { get; set; }
        #endregion

        #region Commons
        public IBaseRepostitory<Color, int> ColorRepostitory { get; set; }
        public IBaseRepostitory<Icon, int> IconRepostitory { get; set; }
        public IBaseRepostitory<Slider, int> SliderRepostitory { get; set; }
        public IBaseRepostitory<SucScribe, int> SucScribeRepostitory { get; set; }
        #endregion

        #region Contacts
        public IBaseRepostitory<Address, int> AddressRepostitory { get; set; }
        public IBaseRepostitory<City, int> CityRepostitory { get; set; }
        public IBaseRepostitory<Contact, int> ContactRepostitory { get; set; }
        public IBaseRepostitory<Country, int> CountryRepostitory { get; set; }
        public IBaseRepostitory<OnlineAddress, int> OnlineAddressRepostitory { get; set; }
        public IBaseRepostitory<Phone, int> PhoneRepostitory { get; set; }
        public IBaseRepostitory<Region, int> RegionRepostitory { get; set; }
        #endregion

        #region Option
        public IBaseRepostitory<Option, int> OptionRepostitory { get; set; }
        public IBaseRepostitory<Entity.Options.Item, int> OptionItemRepostitory { get; set; }
        #endregion

        #region Order
        public IBaseRepostitory<Entity.Orders.Order, int> UserOrderRepostitory { get; set; }
        public IBaseRepostitory<Entity.Orders.Detail, int> UserOrderDetailRepostitory { get; set; }
        public IBaseRepostitory<Entity.Orders.Item, int> UserOrderItemRepostitory { get; set; }
        public IBaseRepostitory<Entity.Orders.Status, int> UserOrderStatusRepostitory { get; set; }

        #endregion

        #region Organizations
        public IBaseRepostitory<Organization, int> OrganizationRepostitory { get; set; }
        public IBaseRepostitory<Person, int> OrganizationPersonRepostitory { get; set; }
        public IBaseRepostitory<Position, int> OrganizationPositionRepostitory { get; set; }
        public IBaseRepostitory<Entity.Organizations.Type, int> OrganizationTypeRepostitory { get; set; }
        public IBaseRepostitory<Entity.Organizations.Status, int> OrganizationStatusRepostitory { get; set; }

        #endregion

        #region Payments
        public IBaseRepostitory<Card, int> PaymentCardRepostitory { get; set; }
        public IBaseRepostitory<Payment, int> PaymentRepostitory { get; set; }
        public IBaseRepostitory<Entity.Payments.Type, int> PaymentTypeRepostitory { get; set; }

        #endregion

        #region Products
        public IBaseRepostitory<Brand, int> ProdutBrandRepostitory { get; set; }
        public IBaseRepostitory<Prodcut, int> ProdcutRepostitory { get; set; }
        public IBaseRepostitory<Image, int> ProductImageRepostitory { get; set; }
        public IBaseRepostitory<ProductCreatingLog, int> ProductCreatingLogRepostitory { get; set; }
        public IBaseRepostitory<ProductToTag, int> ProductToTagRepostitory { get; set; }
        public IBaseRepostitory<Review, int> ProductReviewRepostitory { get; set; }
        public IBaseRepostitory<Size, int> ProductSizeRepostitory { get; set; }
        public IBaseRepostitory<Entity.Products.Status, int> ProductStatusRepostitory { get; set; }
        public IBaseRepostitory<Entity.Products.Tag, int> ProductTagRepostitory { get; set; }
        public IBaseRepostitory<Entity.Products.Type, int> ProductTypeRepostitory { get; set; }
        public IBaseRepostitory<Stock, int> ProductStockRepostitory { get; set; }
        public IBaseRepostitory<Entity.Products.Detail, int> ProductDetailRepostitory { get; set; }
        public IBaseRepostitory<Entity.Products.Category, int> ProductCategoryRepostitory { get; set; }
        public IBaseRepostitory<Entity.Products.SubCategory, int> ProductSubCategoryRepostitory { get; set; }
        #endregion

        #region Shippings
        public IBaseRepostitory<Shipping, int> ShippingRepostitory { get; set; }
        public IBaseRepostitory<Entity.Shippings.Status, int> ShippingStatusRepostitory { get; set; }
        #endregion

        #region AppUsers
        public IBaseRepostitory<AppUser, string> AppUserRepostitory { get; set; }
        public IBaseRepostitory<AppRole, string> AppRoleRepostitory { get; set; }
        public IBaseRepostitory<Authorization, int> AuthorizationRepostitory { get; set; }
        public IBaseRepostitory<Entity.Users.Status, int> AppUserStatusRepostitory { get; set; }
        #endregion

        #region Vendors
        public IBaseRepostitory<Vendor, int> VendorRepostitory { get; set; }

        #region Orders
        public IBaseRepostitory<Entity.Vendors.Orders.Order, int> VendorOrderRepostitory { get; set; }
        public IBaseRepostitory<Entity.Vendors.Orders.Detail, int> VendorOrderDetailRepostitory { get; set; }
        public IBaseRepostitory<Entity.Vendors.Orders.Item, int> VendorOrderItemRepostitory { get; set; }
        public IBaseRepostitory<Entity.Vendors.Orders.Status, int> VendorOrderStatusRepostitory { get; set; }

        #endregion

        #endregion
    }
}
