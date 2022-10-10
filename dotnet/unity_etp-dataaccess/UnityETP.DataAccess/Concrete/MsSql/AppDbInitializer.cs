using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityETP.Entity.Commons;
using UnityETP.Entity.Contacts;

namespace UnityETP.DataAccess.Concrete.MsSql
{
    public class AppDbInitializer
    {
        public static void ApplyDbSeedData(ModelBuilder builder)
        {
            builder.Entity<Color>()
                .HasData(
                    new Color { Id = 1, Name = "White", Code = "fff", CreateAt = DateTime.Now },
                    new Color { Id = 2, Name = "Gray-100", Code = "f8f9fa", CreateAt = DateTime.Now },
                    new Color { Id = 3, Name = "Gray-200", Code = "e9ecef", CreateAt = DateTime.Now },
                    new Color { Id = 4, Name = "Gray-300", Code = "dee2e6", CreateAt = DateTime.Now },
                    new Color { Id = 5, Name = "Gray-400", Code = "cfdbe6", CreateAt = DateTime.Now },
                    new Color { Id = 6, Name = "Gray-500", Code = "adb5bd", CreateAt = DateTime.Now },
                    new Color { Id = 7, Name = "Gray-600", Code = "6c757d", CreateAt = DateTime.Now },
                    new Color { Id = 8, Name = "Gray-700", Code = "383e50", CreateAt = DateTime.Now },
                    new Color { Id = 9, Name = "Gray-800", Code = "2f3446", CreateAt = DateTime.Now },
                    new Color { Id = 10, Name = "Gray-900", Code = "1e2231", CreateAt = DateTime.Now },
                    new Color { Id = 11, Name = "Black", Code = "000", CreateAt = DateTime.Now },
                    new Color { Id = 12, Name = "Body", Code = "4f5d77", CreateAt = DateTime.Now },
                    new Color { Id = 13, Name = "Heading", Code = "495057", CreateAt = DateTime.Now },
                    new Color { Id = 14, Name = "Menu", Code = "292f46", CreateAt = DateTime.Now },
                    new Color { Id = 15, Name = "Bg-grey", Code = "f7f8f9", CreateAt = DateTime.Now },
                    new Color { Id = 16, Name = "Ligth", Code = "4d5368", CreateAt = DateTime.Now },
                    new Color { Id = 17, Name = "Dark-Body", Code = "222736", CreateAt = DateTime.Now },
                    new Color { Id = 18, Name = "Brand", Code = "3BB77E", CreateAt = DateTime.Now },
                    new Color { Id = 19, Name = "Brand-Dark", Code = "29A56C", CreateAt = DateTime.Now },
                    new Color { Id = 20, Name = "Blue", Code = "5897fb", CreateAt = DateTime.Now },
                    new Color { Id = 21, Name = "indigo", Code = "782cf1", CreateAt = DateTime.Now },
                    new Color { Id = 22, Name = "purple", Code = "7850c2", CreateAt = DateTime.Now },
                    new Color { Id = 23, Name = "pink", Code = "d63384", CreateAt = DateTime.Now },
                    new Color { Id = 24, Name = "red", Code = "ff3551", CreateAt = DateTime.Now },
                    new Color { Id = 25, Name = "orange", Code = "fd8a14", CreateAt = DateTime.Now },
                    new Color { Id = 26, Name = "yellow", Code = "ffb300", CreateAt = DateTime.Now },
                    new Color { Id = 27, Name = "green", Code = "3ed092", CreateAt = DateTime.Now },
                    new Color { Id = 28, Name = "teal", Code = "19b989", CreateAt = DateTime.Now },
                    new Color { Id = 29, Name = "cyan", Code = "18a1b7", CreateAt = DateTime.Now }
                );

            builder.Entity<Icon>()
                .HasData(
                    new Icon { Id = 1, Name = "Orders", Code = "md-qr_code"},
                    new Icon { Id = 2, Name = "Products", Code = "md-shopping_bag" },
                    new Icon { Id = 3, Name = "Orders-2", Code = "md-shopping_cart" },
                    new Icon { Id = 4, Name = "Sellers", Code = "md-store" },
                    new Icon { Id = 5, Name = "Add", Code = "md-add_box" },
                    new Icon { Id = 6, Name = "Transactions", Code = "md-monetization_on" },
                    new Icon { Id = 7, Name = "Preson", Code = "md-person" },
                    new Icon { Id = 8, Name = "Reviews", Code = "md-comment" },
                    new Icon { Id = 9, Name = "Brands", Code = "md-stars" },
                    new Icon { Id = 10, Name = "Chart", Code = "md-pie_chart" },
                    new Icon { Id = 11, Name = "Tag", Code = "md-local_offer" },
                    new Icon { Id = 12, Name = "Setting", Code = "md-settings" }
                );


            builder.Entity<Country>()
                .HasData(
                    new Country { Id = 1, Name = "Azerbaijan" },
                    new Country { Id = 2, Name = "Turkey" },
                    new Country { Id = 3, Name = "United States" },
                    new Country { Id = 4, Name = "USA" },
                    new Country { Id = 5, Name = "Georgia" },
                    new Country { Id = 6, Name = "Italy" },
                    new Country { Id = 7, Name = "Germany" },
                    new Country { Id = 8, Name = "Ukraine" }
                );


            builder.Entity<City>()
                .HasData(
                    new City { Id = 1, Name = "Baku" },
                    new City { Id = 2, Name = "Washington" },
                    new City { Id = 3, Name = "Ankara" },
                    new City { Id = 4, Name = "London" }
                );

            builder.Entity<Region>()
                .HasData(
                     new Region { Id = 1, Name = "Yasamal" },
                     new Region { Id = 2, Name = "Ahamdli" },
                     new Region { Id = 3, Name = "Khatai" }
                );

            builder.Entity<Entity.Orders.Status>()
                .HasData(
                      new Entity.Orders.Status { Id = 1, Name = "Sealed", ColorId = 27 },
                      new Entity.Orders.Status { Id = 2, Name = "Buy", ColorId = 21 },
                      new Entity.Orders.Status { Id = 3, Name = "Shipping", ColorId = 25 },
                      new Entity.Orders.Status { Id = 4, Name = "Recovery", ColorId = 26 }
                );
            builder.Entity<Entity.Vendors.Orders.Status>()
                .HasData(
                      new Entity.Vendors.Orders.Status { Id = 1, Name = "Sealed", ColorId = 27 },
                      new Entity.Vendors.Orders.Status { Id = 2, Name = "Buy", ColorId = 21 },
                      new Entity.Vendors.Orders.Status { Id = 3, Name = "Shipping", ColorId = 25 },
                      new Entity.Vendors.Orders.Status { Id = 4, Name = "Recovery", ColorId = 26 }
                );
            builder.Entity<Entity.Organizations.Type>()
                .HasData(
                      new Entity.Organizations.Type { Id = 1, Name = "Buy And Seal", ColorId = 27 },
                      new Entity.Organizations.Type { Id = 2, Name = "Only Buy", ColorId = 21 },
                      new Entity.Organizations.Type { Id = 3, Name = "Only Seal", ColorId = 25 },
                      new Entity.Organizations.Type { Id = 4, Name = "Shipping", ColorId = 28 },
                      new Entity.Organizations.Type { Id = 5, Name = "Not Selected Type", ColorId = 3 }
                );

            builder.Entity<Entity.Organizations.Status>()
                .HasData(
                    new Entity.Organizations.Status { Id = 1, Name = "All Time Work", ColorId = 22 },
                    new Entity.Organizations.Status { Id = 2, Name = "Now Work", ColorId = 18 },
                    new Entity.Organizations.Status { Id = 3, Name = "Work Started", ColorId = 20 },
                    new Entity.Organizations.Status { Id = 4, Name = "Work Ended", ColorId = 10 }
                );
            builder.Entity<Entity.Payments.Type>()
                .HasData(
                    new Entity.Payments.Type { Id = 1, Name = "Cash", ColorId = 22, Icon = "" },
                    new Entity.Payments.Type { Id = 2, Name = "Card", ColorId = 29, Icon = "" }
                );
            builder.Entity<Entity.Products.Type>()
                .HasData(
                    new Entity.Products.Type { Id = 1, Name = "Vegetables" },
                    new Entity.Products.Type { Id = 2, Name = "Dairy" },
                    new Entity.Products.Type { Id = 3, Name = "Fruit" },
                    new Entity.Products.Type { Id = 4, Name = "Flour" },
                    new Entity.Products.Type { Id = 5, Name = "Meat" }
                );
            builder.Entity<Entity.Products.Status>()
                .HasData(
                    new Entity.Products.Status { Id = 1, Name = "Hot", ColorId = 23 },
                    new Entity.Products.Status { Id = 2, Name = "Seal", ColorId = 24 },
                    new Entity.Products.Status { Id = 3, Name = "New", ColorId = 18 },
                    new Entity.Products.Status { Id = 4, Name = "Best Seal", ColorId = 20 },
                    new Entity.Products.Status { Id = 5, Name = "Meat", ColorId = 25 }
                );

            builder.Entity<Entity.Products.Tag>()
                .HasData(
                    new Entity.Products.Tag { Id = 1, Name = "Snack" },
                    new Entity.Products.Tag { Id = 2, Name = "Organic" },
                    new Entity.Products.Tag { Id = 3, Name = "Brown" }
                );
            builder.Entity<Entity.Shippings.Status>()
                .HasData(
                    new Entity.Shippings.Status { Id = 1, Name = "Loaded", IconId = 1, ColorId = 18 },
                    new Entity.Shippings.Status { Id = 2, Name = "Send", IconId = 1, ColorId = 20 },
                    new Entity.Shippings.Status { Id = 3, Name = "Arrive", IconId = 1, ColorId = 25 }
                );

            builder.Entity<Entity.Users.Status>()
                .HasData(
                    new Entity.Users.Status { Id = 1, Name = "Active" ,ColorId = 18},
                    new Entity.Users.Status { Id = 2, Name = "New" , ColorId =23 },
                    new Entity.Users.Status { Id = 3, Name = "Brown", ColorId =24 }
                );
        }


    }
}
