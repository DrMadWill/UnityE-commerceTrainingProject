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
        public IBaseRepostitory<Comment, int> BlogCommentRepostitory
        {
            get => RepositoryBuilder.Builder(BlogCommentRepostitory, _dbContext);
            set => BlogCommentRepostitory = value;
        }
        public IBaseRepostitory<Entity.Blogs.Detail, int> BlogDetailRepostitory
        {
            get => RepositoryBuilder.Builder(BlogDetailRepostitory, _dbContext);
            set => BlogDetailRepostitory = value;
        }
        public IBaseRepostitory<Entity.Blogs.Tag, int> BlogTagRepostitory
        {
            get => RepositoryBuilder.Builder(BlogTagRepostitory, _dbContext);
            set => BlogTagRepostitory = value;
        }
        #endregion

        #region Commons
        public IBaseRepostitory<Color, int> ColorRepostitory
        {
            get => RepositoryBuilder.Builder(ColorRepostitory, _dbContext);
            set => ColorRepostitory = value;
        }
        public IBaseRepostitory<Icon, int> IconRepostitory
        {
            get => RepositoryBuilder.Builder(IconRepostitory, _dbContext);
            set => IconRepostitory = value;
        }
        public IBaseRepostitory<Slider, int> SliderRepostitory
        {
            get => RepositoryBuilder.Builder(SliderRepostitory, _dbContext);
            set => SliderRepostitory = value;
        }
        public IBaseRepostitory<SucScribe, int> SucScribeRepostitory
        {
            get => RepositoryBuilder.Builder(SucScribeRepostitory, _dbContext);
            set => SucScribeRepostitory = value;
        }
        #endregion

        #region Contacts
        public IBaseRepostitory<Address, int> AddressRepostitory
        {
            get => RepositoryBuilder.Builder(AddressRepostitory, _dbContext);
            set => AddressRepostitory = value;
        }
        public IBaseRepostitory<City, int> CityRepostitory
        {
            get => RepositoryBuilder.Builder(CityRepostitory, _dbContext);
            set => CityRepostitory = value;
        }
        public IBaseRepostitory<Contact, int> ContactRepostitory
        {
            get => RepositoryBuilder.Builder(ContactRepostitory, _dbContext);
            set => ContactRepostitory = value;
        }
        public IBaseRepostitory<Country, int> CountryRepostitory
        {
            get => RepositoryBuilder.Builder(CountryRepostitory, _dbContext);
            set => CountryRepostitory = value;
        }
        public IBaseRepostitory<OnlineAddress, int> OnlineAddressRepostitory
        {
            get => RepositoryBuilder.Builder(OnlineAddressRepostitory, _dbContext);
            set => OnlineAddressRepostitory = value;
        }
        public IBaseRepostitory<Phone, int> PhoneRepostitory
        {
            get => RepositoryBuilder.Builder(PhoneRepostitory, _dbContext);
            set => PhoneRepostitory = value;
        }
        public IBaseRepostitory<Region, int> RegionRepostitory
        {
            get => RepositoryBuilder.Builder(RegionRepostitory, _dbContext);
            set => RegionRepostitory = value;
        }
        #endregion

        #region Option
        public IBaseRepostitory<Option, int> OptionRepostitory
        {
            get => RepositoryBuilder.Builder(OptionRepostitory, _dbContext);
            set => OptionRepostitory = value;
        }
        public IBaseRepostitory<Entity.Options.Item, int> OptionItemRepostitory
        {
            get => RepositoryBuilder.Builder(OptionItemRepostitory, _dbContext);
            set => OptionItemRepostitory = value;
        }
        #endregion

        #region Order
        public IBaseRepostitory<Entity.Orders.Order, int> UserOrderRepostitory
        {
            get => RepositoryBuilder.Builder(UserOrderRepostitory, _dbContext);
            set => UserOrderRepostitory = value;
        }
        public IBaseRepostitory<Entity.Orders.Detail, int> UserOrderDetailRepostitory
        {
            get => RepositoryBuilder.Builder(UserOrderDetailRepostitory, _dbContext);
            set => UserOrderDetailRepostitory = value;
        }
        public IBaseRepostitory<Entity.Orders.Item, int> UserOrderItemRepostitory
        {
            get => RepositoryBuilder.Builder(UserOrderItemRepostitory, _dbContext);
            set => UserOrderItemRepostitory = value;
        }
        public IBaseRepostitory<Entity.Orders.Status, int> UserOrderStatusRepostitory
        {
            get => RepositoryBuilder.Builder(UserOrderStatusRepostitory, _dbContext);
            set => UserOrderStatusRepostitory = value;
        }

        #endregion

        #region Organizations
        public IBaseRepostitory<Organization, int> OrganizationRepostitory
        {
            get => RepositoryBuilder.Builder(OrganizationRepostitory, _dbContext);
            set => OrganizationRepostitory = value;
        }
        public IBaseRepostitory<Person, int> OrganizationPersonRepostitory
        {
            get => RepositoryBuilder.Builder(OrganizationPersonRepostitory, _dbContext);
            set => OrganizationPersonRepostitory = value;
        }
        public IBaseRepostitory<Position, int> OrganizationPositionRepostitory
        {
            get => RepositoryBuilder.Builder(OrganizationPositionRepostitory, _dbContext);
            set => OrganizationPositionRepostitory = value;
        }
        public IBaseRepostitory<Entity.Organizations.Type, int> OrganizationTypeRepostitory
        {
            get => RepositoryBuilder.Builder(OrganizationTypeRepostitory, _dbContext);
            set => OrganizationTypeRepostitory = value;
        }
        public IBaseRepostitory<Entity.Organizations.Status, int> OrganizationStatusRepostitory
        {
            get => RepositoryBuilder.Builder(OrganizationStatusRepostitory, _dbContext);
            set => OrganizationStatusRepostitory = value;
        }

        #endregion

        #region Payments
        public IBaseRepostitory<Card, int> PaymentCardRepostitory
        {
            get => RepositoryBuilder.Builder(PaymentCardRepostitory, _dbContext);
            set => PaymentCardRepostitory = value;
        }
        public IBaseRepostitory<Payment, int> PaymentRepostitory
        {
            get => RepositoryBuilder.Builder(PaymentRepostitory, _dbContext);
            set => PaymentRepostitory = value;
        }
        public IBaseRepostitory<Entity.Payments.Type, int> PaymentTypeRepostitory
        {
            get => RepositoryBuilder.Builder(PaymentTypeRepostitory, _dbContext);
            set => PaymentTypeRepostitory = value;
        }

        #endregion

        #region Products
        public IBaseRepostitory<Brand, int> ProdutBrandRepostitory
        {
            get => RepositoryBuilder.Builder(ProdutBrandRepostitory, _dbContext);
            set => ProdutBrandRepostitory = value;
        }
        public IBaseRepostitory<Prodcut, int> ProdcutRepostitory
        {
            get => RepositoryBuilder.Builder(ProdcutRepostitory, _dbContext);
            set => ProdcutRepostitory = value;
        }
        public IBaseRepostitory<Image, int> ProductImageRepostitory
        {
            get => RepositoryBuilder.Builder(ProductImageRepostitory, _dbContext);
            set => ProductImageRepostitory = value;
        }
        public IBaseRepostitory<ProductCreatingLog, int> ProductCreatingLogRepostitory
        {
            get => RepositoryBuilder.Builder(ProductCreatingLogRepostitory, _dbContext);
            set => ProductCreatingLogRepostitory = value;
        }
        public IBaseRepostitory<ProductToTag, int> ProductToTagRepostitory
        {
            get => RepositoryBuilder.Builder(ProductToTagRepostitory, _dbContext);
            set => ProductToTagRepostitory = value;
        }
        public IBaseRepostitory<Review, int> ProductReviewRepostitory
        {
            get => RepositoryBuilder.Builder(ProductReviewRepostitory, _dbContext);
            set => ProductReviewRepostitory = value;
        }
        public IBaseRepostitory<Size, int> ProductSizeRepostitory
        {
            get => RepositoryBuilder.Builder(ProductSizeRepostitory, _dbContext);
            set => ProductSizeRepostitory = value;
        }
        public IBaseRepostitory<Entity.Products.Status, int> ProductStatusRepostitory
        {
            get => RepositoryBuilder.Builder(ProductStatusRepostitory, _dbContext);
            set => ProductStatusRepostitory = value;
        }
        public IBaseRepostitory<Entity.Products.Tag, int> ProductTagRepostitory
        {
            get => RepositoryBuilder.Builder(ProductTagRepostitory, _dbContext);
            set => ProductTagRepostitory = value;
        }
        public IBaseRepostitory<Entity.Products.Type, int> ProductTypeRepostitory
        {
            get => RepositoryBuilder.Builder(ProductTypeRepostitory, _dbContext);
            set => ProductTypeRepostitory = value;
        }
        public IBaseRepostitory<Stock, int> ProductStockRepostitory
        {
            get => RepositoryBuilder.Builder(ProductStockRepostitory, _dbContext);
            set => ProductStockRepostitory = value;
        }
        public IBaseRepostitory<Entity.Products.Detail, int> ProductDetailRepostitory
        {
            get => RepositoryBuilder.Builder(ProductDetailRepostitory, _dbContext);
            set => ProductDetailRepostitory = value;
        }
        public IBaseRepostitory<Entity.Products.Category, int> ProductCategoryRepostitory
        {
            get => RepositoryBuilder.Builder(ProductCategoryRepostitory, _dbContext);
            set => ProductCategoryRepostitory = value;
        }
        public IBaseRepostitory<Entity.Products.SubCategory, int> ProductSubCategoryRepostitory
        {
            get => RepositoryBuilder.Builder(ProductSubCategoryRepostitory, _dbContext);
            set => ProductSubCategoryRepostitory = value;
        }
        #endregion

        #region Shippings
        public IBaseRepostitory<Shipping, int> ShippingRepostitory
        {
            get => RepositoryBuilder.Builder(ShippingRepostitory, _dbContext);
            set => ShippingRepostitory = value;
        }
        public IBaseRepostitory<Entity.Shippings.Status, int> ShippingStatusRepostitory
        {
            get => RepositoryBuilder.Builder(ShippingStatusRepostitory, _dbContext);
            set => ShippingStatusRepostitory = value;
        }
        #endregion

        #region AppUsers
        public IBaseRepostitory<AppUser, string> AppUserRepostitory
        {
            get => RepositoryBuilder.Builder(AppUserRepostitory, _dbContext);
            set => AppUserRepostitory = value;
        }
        public IBaseRepostitory<AppRole, string> AppRoleRepostitory
        {
            get => RepositoryBuilder.Builder(AppRoleRepostitory, _dbContext);
            set => AppRoleRepostitory = value;
        }
        public IBaseRepostitory<Authorization, int> AuthorizationRepostitory
        {
            get => RepositoryBuilder.Builder(AuthorizationRepostitory, _dbContext);
            set => AuthorizationRepostitory = value;
        }
        public IBaseRepostitory<Entity.Users.Status, int> AppUserStatusRepostitory
        {
            get => RepositoryBuilder.Builder(AppUserStatusRepostitory, _dbContext);
            set => AppUserStatusRepostitory = value;
        }
        #endregion

        #region Vendors
        public IBaseRepostitory<Vendor, int> VendorRepostitory
        {
            get => RepositoryBuilder.Builder(VendorRepostitory, _dbContext);
            set => VendorRepostitory = value;
        }

        #region Orders
        public IBaseRepostitory<Entity.Vendors.Orders.Order, int> VendorOrderRepostitory
        {
            get => RepositoryBuilder.Builder(VendorOrderRepostitory, _dbContext);
            set => VendorOrderRepostitory = value;
        }
        public IBaseRepostitory<Entity.Vendors.Orders.Detail, int> VendorOrderDetailRepostitory
        {
            get => RepositoryBuilder.Builder(VendorOrderDetailRepostitory, _dbContext);
            set => VendorOrderDetailRepostitory = value;
        }
        public IBaseRepostitory<Entity.Vendors.Orders.Item, int> VendorOrderItemRepostitory
        {
            get => RepositoryBuilder.Builder(VendorOrderItemRepostitory, _dbContext);
            set => VendorOrderItemRepostitory = value;
        }
        public IBaseRepostitory<Entity.Vendors.Orders.Status, int> VendorOrderStatusRepostitory
        {
            get => RepositoryBuilder.Builder(VendorOrderStatusRepostitory, _dbContext);
            set => VendorOrderStatusRepostitory = value;
        }

        #endregion

        #endregion
    }
}
