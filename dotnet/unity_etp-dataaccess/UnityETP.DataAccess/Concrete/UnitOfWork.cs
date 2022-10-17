using Microsoft.EntityFrameworkCore;
using UnityETP.DataAccess.Abstract;
using UnityETP.DataAccess.Concrete.MsSql;
using UnityETP.DataAccess.Concrete.Repositories;
using UnityETP.DataAccess.DataHelper;
using UnityETP.Entity;
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

        public IBaseRepostitory<TEntity, TPrimary> Set<TEntity, TPrimary>()
            where TEntity : class,IBaseEntity<TPrimary>
        {
            var et = typeof(TEntity);
            var ut = typeof(UnitOfWork);
            var searchProp = ut.GetProperties().FirstOrDefault(x => x.PropertyType.FullName.Contains(et.FullName));
            var result = GetType().GetProperty(searchProp.Name).GetValue(this,null);
            return (EfGenericRepository<TEntity, TPrimary>)result;
        }


        #region Blog
        //
        private IBaseRepostitory<Blog, int> _BlogRepostitory;
        public IBaseRepostitory<Blog, int> BlogRepostitory 
        {
            get => RepositoryBuilder.Builder(_BlogRepostitory, _dbContext);
            set => _BlogRepostitory = value;
        }
        private IBaseRepostitory<BlogToTag, int> _BlogToTagRepostitory;
        public IBaseRepostitory<BlogToTag, int> BlogToTagRepostitory
        {
            get => RepositoryBuilder.Builder(_BlogToTagRepostitory, _dbContext);
            set => _BlogToTagRepostitory = value;
        }

        private IBaseRepostitory<Entity.Blogs.Category, int> _BlogCategoryRepostitory;
        public IBaseRepostitory<Entity.Blogs.Category, int> BlogCategoryRepostitory
        {
            get  => RepositoryBuilder.Builder(_BlogCategoryRepostitory, _dbContext); 
            set => _BlogCategoryRepostitory = value;
        }
        private IBaseRepostitory<Entity.Blogs.Comment, int> _BlogCommentRepostitory;
        public IBaseRepostitory<Comment, int> BlogCommentRepostitory
        {
            get => RepositoryBuilder.Builder(_BlogCommentRepostitory, _dbContext);
            set => _BlogCommentRepostitory = value;
        }

        private IBaseRepostitory<Entity.Blogs.Detail, int> _BlogDetailRepostitory;
        public IBaseRepostitory<Entity.Blogs.Detail, int> BlogDetailRepostitory
        {
            get => RepositoryBuilder.Builder(_BlogDetailRepostitory, _dbContext);
            set => _BlogDetailRepostitory = value;
        }
        private IBaseRepostitory<Entity.Blogs.Tag, int> _BlogTagRepostitory;
        public IBaseRepostitory<Entity.Blogs.Tag, int> BlogTagRepostitory
        {
            get => RepositoryBuilder.Builder(_BlogTagRepostitory, _dbContext);
            set => _BlogTagRepostitory = value;
        }
        #endregion

        #region Commons
        private IBaseRepostitory<Color, int> _ColorRepostitory;
        public IBaseRepostitory<Color, int> ColorRepostitory
        {
            get => RepositoryBuilder.Builder(_ColorRepostitory, _dbContext);
            set => _ColorRepostitory = value;
        }
        private IBaseRepostitory<Icon, int> _IconRepostitory;
        public IBaseRepostitory<Icon, int> IconRepostitory
        {
            get => RepositoryBuilder.Builder(_IconRepostitory, _dbContext);
            set => _IconRepostitory = value;
        }
        private IBaseRepostitory<Slider, int> _SliderRepostitory;
        public IBaseRepostitory<Slider, int> SliderRepostitory
        {
            get => RepositoryBuilder.Builder(_SliderRepostitory, _dbContext);
            set => _SliderRepostitory = value;
        }

        private IBaseRepostitory<SucScribe, int> _SucScribeRepostitory;
        public IBaseRepostitory<SucScribe, int> SucScribeRepostitory
        {
            get => RepositoryBuilder.Builder(_SucScribeRepostitory, _dbContext);
            set => _SucScribeRepostitory = value;
        }
        #endregion

        #region Contacts
        private IBaseRepostitory<Address, int> _AddressRepostitory;
        public IBaseRepostitory<Address, int> AddressRepostitory
        {
            get => RepositoryBuilder.Builder(_AddressRepostitory, _dbContext);
            set => _AddressRepostitory = value;
        }

        private IBaseRepostitory<City, int> _CityRepostitory;
        public IBaseRepostitory<City, int> CityRepostitory
        {
            get => RepositoryBuilder.Builder(_CityRepostitory, _dbContext);
            set => _CityRepostitory = value;
        }
        private IBaseRepostitory<Contact, int> _ContactRepostitory;
        public IBaseRepostitory<Contact, int> ContactRepostitory
        {
            get => RepositoryBuilder.Builder(_ContactRepostitory, _dbContext);
            set => _ContactRepostitory = value;
        }
        private IBaseRepostitory<Country, int> _CountryRepostitory;
        public IBaseRepostitory<Country, int> CountryRepostitory
        {
            get => RepositoryBuilder.Builder(_CountryRepostitory, _dbContext);
            set => _CountryRepostitory = value;
        }
        private IBaseRepostitory<OnlineAddress, int> _OnlineAddressRepostitory;
        public IBaseRepostitory<OnlineAddress, int> OnlineAddressRepostitory
        {
            get => RepositoryBuilder.Builder(_OnlineAddressRepostitory, _dbContext);
            set => _OnlineAddressRepostitory = value;
        }

        private IBaseRepostitory<Phone, int> _PhoneRepostitory;
        public IBaseRepostitory<Phone, int> PhoneRepostitory
        {
            get => RepositoryBuilder.Builder(_PhoneRepostitory, _dbContext);
            set => _PhoneRepostitory = value;
        }
        private IBaseRepostitory<Region, int> _RegionRepostitory;
        public IBaseRepostitory<Region, int> RegionRepostitory
        {
            get => RepositoryBuilder.Builder(_RegionRepostitory, _dbContext);
            set => _RegionRepostitory = value;
        }
        #endregion

        #region Option
        private IBaseRepostitory<Option, int> _OptionRepostitory;
        public IBaseRepostitory<Option, int> OptionRepostitory
        {
            get => RepositoryBuilder.Builder(_OptionRepostitory, _dbContext);
            set => _OptionRepostitory = value;
        }
        private IBaseRepostitory<Entity.Options.Item, int> _OptionItemRepostitory;
        public IBaseRepostitory<Entity.Options.Item, int> OptionItemRepostitory
        {
            get => RepositoryBuilder.Builder(_OptionItemRepostitory, _dbContext);
            set => _OptionItemRepostitory = value;
        }
        #endregion

        #region Order
        private IBaseRepostitory<Entity.Orders.Order, int> _UserOrderRepostitory;
        public IBaseRepostitory<Entity.Orders.Order, int> UserOrderRepostitory
        {
            get => RepositoryBuilder.Builder(_UserOrderRepostitory, _dbContext);
            set => _UserOrderRepostitory = value;
        }
        private IBaseRepostitory<Entity.Orders.Detail, int> _UserOrderDetailRepostitory;
        public IBaseRepostitory<Entity.Orders.Detail, int> UserOrderDetailRepostitory
        {
            get => RepositoryBuilder.Builder(_UserOrderDetailRepostitory, _dbContext);
            set => _UserOrderDetailRepostitory = value;
        }
        private IBaseRepostitory<Entity.Orders.Item, int> _UserOrderItemRepostitory;
        public IBaseRepostitory<Entity.Orders.Item, int> UserOrderItemRepostitory
        {
            get => RepositoryBuilder.Builder(_UserOrderItemRepostitory, _dbContext);
            set => _UserOrderItemRepostitory = value;
        }
        private IBaseRepostitory<Entity.Orders.Status, int> _UserOrderStatusRepostitory;
        public IBaseRepostitory<Entity.Orders.Status, int> UserOrderStatusRepostitory
        {
            get => RepositoryBuilder.Builder(_UserOrderStatusRepostitory, _dbContext);
            set => _UserOrderStatusRepostitory = value;
        }

        #endregion

        #region Organizations
        private IBaseRepostitory<Organization, int> _OrganizationRepostitory;
        public IBaseRepostitory<Organization, int> OrganizationRepostitory
        {
            get => RepositoryBuilder.Builder(_OrganizationRepostitory, _dbContext);
            set => _OrganizationRepostitory = value;
        }
        private IBaseRepostitory<Person, int> _OrganizationPersonRepostitory;
        public IBaseRepostitory<Person, int> OrganizationPersonRepostitory
        {
            get => RepositoryBuilder.Builder(_OrganizationPersonRepostitory, _dbContext);
            set => _OrganizationPersonRepostitory = value;
        }
        private IBaseRepostitory<Position, int> _OrganizationPositionRepostitory;
        public IBaseRepostitory<Position, int> OrganizationPositionRepostitory
        {
            get => RepositoryBuilder.Builder(_OrganizationPositionRepostitory, _dbContext);
            set => _OrganizationPositionRepostitory = value;
        }
        private IBaseRepostitory<Entity.Organizations.Type, int> _OrganizationTypeRepostitory;
        public IBaseRepostitory<Entity.Organizations.Type, int> OrganizationTypeRepostitory
        {
            get => RepositoryBuilder.Builder(_OrganizationTypeRepostitory, _dbContext);
            set => _OrganizationTypeRepostitory = value;
        }
        private IBaseRepostitory<Entity.Organizations.Status, int> _OrganizationStatusRepostitory;
        public IBaseRepostitory<Entity.Organizations.Status, int> OrganizationStatusRepostitory
        {
            get => RepositoryBuilder.Builder(_OrganizationStatusRepostitory, _dbContext);
            set => _OrganizationStatusRepostitory = value;
        }

        #endregion

        #region Payments
        private IBaseRepostitory<Card, int> _PaymentCardRepostitory;
        public IBaseRepostitory<Card, int> PaymentCardRepostitory
        {
            get => RepositoryBuilder.Builder(_PaymentCardRepostitory, _dbContext);
            set => _PaymentCardRepostitory = value;
        }
        private IBaseRepostitory<Payment, int> _PaymentRepostitory;
        public IBaseRepostitory<Payment, int> PaymentRepostitory
        {
            get => RepositoryBuilder.Builder(PaymentRepostitory, _dbContext);
            set => PaymentRepostitory = value;
        }
        private IBaseRepostitory<Entity.Payments.Type, int> _PaymentTypeRepostitory;
        public IBaseRepostitory<Entity.Payments.Type, int> PaymentTypeRepostitory
        {
            get => RepositoryBuilder.Builder(PaymentTypeRepostitory, _dbContext);
            set => PaymentTypeRepostitory = value;
        }

        #endregion

        #region Products
        private IBaseRepostitory<Brand, int> _ProdutBrandRepostitory;
        public IBaseRepostitory<Brand, int> ProdutBrandRepostitory
        {
            get => RepositoryBuilder.Builder(_ProdutBrandRepostitory, _dbContext);
            set => _ProdutBrandRepostitory = value;
        }
        private IBaseRepostitory<Prodcut, int> _ProdcutRepostitory;
        public IBaseRepostitory<Prodcut, int> ProdcutRepostitory
        {
            get => RepositoryBuilder.Builder(_ProdcutRepostitory, _dbContext);
            set => _ProdcutRepostitory = value;
        }
        private IBaseRepostitory<Image, int> _ProductImageRepostitory;
        public IBaseRepostitory<Image, int> ProductImageRepostitory
        {
            get => RepositoryBuilder.Builder(_ProductImageRepostitory, _dbContext);
            set => _ProductImageRepostitory = value;
        }
        private IBaseRepostitory<ProductCreatingLog, int> _ProductCreatingLogRepostitory;
        public IBaseRepostitory<ProductCreatingLog, int> ProductCreatingLogRepostitory
        {
            get => RepositoryBuilder.Builder(_ProductCreatingLogRepostitory, _dbContext);
            set => _ProductCreatingLogRepostitory = value;
        }
        private IBaseRepostitory<ProductToTag, int> _ProductToTagRepostitory;
        public IBaseRepostitory<ProductToTag, int> ProductToTagRepostitory
        {
            get => RepositoryBuilder.Builder(_ProductToTagRepostitory, _dbContext);
            set => _ProductToTagRepostitory = value;
        }
        private IBaseRepostitory<Review, int> _ProductReviewRepostitory;
        public IBaseRepostitory<Review, int> ProductReviewRepostitory
        {
            get => RepositoryBuilder.Builder(_ProductReviewRepostitory, _dbContext);
            set => _ProductReviewRepostitory = value;
        }
        private IBaseRepostitory<Size, int> _ProductSizeRepostitory;
        public IBaseRepostitory<Size, int> ProductSizeRepostitory
        {
            get => RepositoryBuilder.Builder(_ProductSizeRepostitory, _dbContext);
            set => _ProductSizeRepostitory = value;
        }
        private IBaseRepostitory<Entity.Products.Status, int> _ProductStatusRepostitory;
        public IBaseRepostitory<Entity.Products.Status, int> ProductStatusRepostitory
        {
            get => RepositoryBuilder.Builder(_ProductStatusRepostitory, _dbContext);
            set => _ProductStatusRepostitory = value;
        }
        private IBaseRepostitory<Entity.Products.Tag, int> _ProductTagRepostitory;
        public IBaseRepostitory<Entity.Products.Tag, int> ProductTagRepostitory
        {
            get => RepositoryBuilder.Builder(_ProductTagRepostitory, _dbContext);
            set => _ProductTagRepostitory = value;
        }
        private IBaseRepostitory<Entity.Products.Type, int> _ProductTypeRepostitory;
        public IBaseRepostitory<Entity.Products.Type, int> ProductTypeRepostitory
        {
            get => RepositoryBuilder.Builder(_ProductTypeRepostitory, _dbContext);
            set => _ProductTypeRepostitory = value;
        }
        private IBaseRepostitory<Stock, int> _ProductStockRepostitory;
        public IBaseRepostitory<Stock, int> ProductStockRepostitory
        {
            get => RepositoryBuilder.Builder(_ProductStockRepostitory, _dbContext);
            set => _ProductStockRepostitory = value;
        }
        private IBaseRepostitory<Entity.Products.Detail, int> _ProductDetailRepostitory;
        public IBaseRepostitory<Entity.Products.Detail, int> ProductDetailRepostitory
        {
            get => RepositoryBuilder.Builder(_ProductDetailRepostitory, _dbContext);
            set => _ProductDetailRepostitory = value;
        }
        private IBaseRepostitory<Entity.Products.Category, int> _ProductCategoryRepostitory;
        public IBaseRepostitory<Entity.Products.Category, int> ProductCategoryRepostitory
        {
            get => RepositoryBuilder.Builder(_ProductCategoryRepostitory, _dbContext);
            set => _ProductCategoryRepostitory = value;
        }
        private IBaseRepostitory<Entity.Products.SubCategory, int> _ProductSubCategoryRepostitory;
        public IBaseRepostitory<Entity.Products.SubCategory, int> ProductSubCategoryRepostitory
        {
            get => RepositoryBuilder.Builder(_ProductSubCategoryRepostitory, _dbContext);
            set => _ProductSubCategoryRepostitory = value;
        }
        #endregion

        #region Shippings
        private IBaseRepostitory<Shipping, int> _ShippingRepostitory;
        public IBaseRepostitory<Shipping, int> ShippingRepostitory
        {
            get => RepositoryBuilder.Builder(_ShippingRepostitory, _dbContext);
            set => _ShippingRepostitory = value;
        }
        private IBaseRepostitory<Entity.Shippings.Status, int> _ShippingStatusRepostitory;
        public IBaseRepostitory<Entity.Shippings.Status, int> ShippingStatusRepostitory
        {
            get => RepositoryBuilder.Builder(_ShippingStatusRepostitory, _dbContext);
            set => _ShippingStatusRepostitory = value;
        }
        #endregion

        #region AppUsers
        private IBaseRepostitory<AppUser, string> _AppUserRepostitory;
        public IBaseRepostitory<AppUser, string> AppUserRepostitory
        {
            get => RepositoryBuilder.Builder(_AppUserRepostitory, _dbContext);
            set => _AppUserRepostitory = value;
        }
        private IBaseRepostitory<AppRole, string> _AppRoleRepostitory;
        public IBaseRepostitory<AppRole, string> AppRoleRepostitory
        {
            get => RepositoryBuilder.Builder(_AppRoleRepostitory, _dbContext);
            set => _AppRoleRepostitory = value;
        }
        private IBaseRepostitory<Authorization, int> _AuthorizationRepostitory;
        public IBaseRepostitory<Authorization, int> AuthorizationRepostitory
        {
            get => RepositoryBuilder.Builder(_AuthorizationRepostitory, _dbContext);
            set => _AuthorizationRepostitory = value;
        }
        private IBaseRepostitory<Entity.Users.Status, int> _AppUserStatusRepostitory;
        public IBaseRepostitory<Entity.Users.Status, int> AppUserStatusRepostitory
        {
            get => RepositoryBuilder.Builder(_AppUserStatusRepostitory, _dbContext);
            set => _AppUserStatusRepostitory = value;
        }
        #endregion

        #region Vendors
        private IBaseRepostitory<Vendor, int> _VendorRepostitory;
        public IBaseRepostitory<Vendor, int> VendorRepostitory
        {
            get => RepositoryBuilder.Builder(_VendorRepostitory, _dbContext);
            set => _VendorRepostitory = value;
        }

        #region Orders
        private IBaseRepostitory<Entity.Vendors.Orders.Order, int> _VendorOrderRepostitory;
        public IBaseRepostitory<Entity.Vendors.Orders.Order, int> VendorOrderRepostitory
        {
            get => RepositoryBuilder.Builder(_VendorOrderRepostitory, _dbContext);
            set => _VendorOrderRepostitory = value;
        }
        private IBaseRepostitory<Entity.Vendors.Orders.Detail, int> _VendorOrderDetailRepostitory;
        public IBaseRepostitory<Entity.Vendors.Orders.Detail, int> VendorOrderDetailRepostitory
        {
            get => RepositoryBuilder.Builder(_VendorOrderDetailRepostitory, _dbContext);
            set => _VendorOrderDetailRepostitory = value;
        }
        private IBaseRepostitory<Entity.Vendors.Orders.Item, int> _VendorOrderItemRepostitory;
        public IBaseRepostitory<Entity.Vendors.Orders.Item, int> VendorOrderItemRepostitory
        {
            get => RepositoryBuilder.Builder(_VendorOrderItemRepostitory, _dbContext);
            set => _VendorOrderItemRepostitory = value;
        }
        private IBaseRepostitory<Entity.Vendors.Orders.Status, int> _VendorOrderStatusRepostitory;
        public IBaseRepostitory<Entity.Vendors.Orders.Status, int> VendorOrderStatusRepostitory
        {
            get => RepositoryBuilder.Builder(_VendorOrderStatusRepostitory, _dbContext);
            set => _VendorOrderStatusRepostitory = value;
        }

        #endregion

        #endregion
    }
}
