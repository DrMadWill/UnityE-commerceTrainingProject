﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Orders.Payments
{
    public class Type : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public string Name { get; set; }
        [Column] public string Icon { get; set; }

        public int ColorId { get; set; }
    }
}