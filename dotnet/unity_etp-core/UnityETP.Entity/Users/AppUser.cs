using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Blogs;
using UnityETP.Entity.Orders;
using UnityETP.Entity.Products;
using UnityETP.Entity.Validations;

namespace UnityETP.Entity.Users
{
    /// <summary>
    /// Application Users Table
    /// </summary>
    public class AppUser : IdentityUser, IBaseEntity<string>
    {
        [RegularExpression(RegEx.Email, ErrorMessage = "Email format not valid.")]
        [Column] public override string Email { get; set; }
        [Required]
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string Name { get; set; }
        [Required]
        [StringLength(Limit.NameMaxLength, MinimumLength = Limit.NameMinLength)]
        [Column] public string SureName { get; set; }

        [StringLength(Limit.ImageMaxLength)]
        [Column] public string Image { get; set; }
        [Column] public decimal Amount { get; set; }
        [Column] public bool IsSucScribe { get; set; }
        [Column(TypeName = Validations.Type.Byte)] public byte Age { get; set; }

        [Column] public DateTime CreateAt { get; set; } = DateTime.Now;
        [Column] public DateTime? UpdateAt { get; set; }
        [Column] public bool IsBlock { get; set; } = false;
        [Column] public bool IsDelete { get; set; } = false;
        
        // Relation
        public Status UserStatus { get; set; }
        public int UserStatusId { get; set; }
        public IList<Blog> Blogs { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<Order> UserOrders { get; set; }
        public IList<Review> Reviews { get; set; }
        public IList<ProductCreatingLog> ProductCreatingLogs { get; set; }

    }
}