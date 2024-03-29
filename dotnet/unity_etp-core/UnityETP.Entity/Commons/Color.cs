﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Contacts;
using UnityETP.Entity.Options;
using UnityETP.Entity.Products;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Commons
{
    /// <summary>
    /// Color
    /// </summary>
    [Table("Colors")]
    public class Color : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: Limit.ColorCodeLength, MinimumLength = Limit.ColorCodeLength)]
        [Column(TypeName = Validations.Type.Char)] public string Code { get; set; }

        // Relation
        public IList<Orders.Status> UserOrderStatuses { get; set; }
        public IList<Vendors.Orders.Status> VendorOrderStatuses { get; set; }
        public IList<Organizations.Status> OrganizationStatuses { get; set; }
        public IList<Products.Status> ProductStatuses { get; set; }
        public IList<Users.Status> UserStatuses { get; set; }
        public IList<Shippings.Status> ShippingStatus { get; set; }

        public IList<Option> Options { get; set; }
        public IList<OnlineAddress> OnlineAddresses { get; set; }
        public IList<Payments.Type> PaymentTypes { get; set; }
        public IList<Organizations.Type> OrganizationTypes { get; set; }
        public IList<Brand> Brands { get; set; }
    }
}