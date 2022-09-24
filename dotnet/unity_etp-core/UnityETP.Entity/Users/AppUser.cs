﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using UnityETP.Entity.Blogs;
using UnityETP.Entity.Orders;
using UnityETP.Entity.Products;

namespace UnityETP.Entity.Users
{
    /// <summary>
    /// Application Users Table
    /// </summary>
    public class AppUser : IdentityUser, IBaseEntity<string>
    {
        [Column] public string Name { get; set; }
        [Column] public string SureName { get; set; }
        [Column] public string Image { get; set; }
        [Column] public decimal Amount { get; set; }
        [Column] public bool IsSucScribe { get; set; }
        [Column(TypeName = "tinyint")] public byte Age { get; set; }

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