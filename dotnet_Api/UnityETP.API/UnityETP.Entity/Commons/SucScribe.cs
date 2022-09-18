﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnityETP.Entity.Commons
{
    /// <summary>
    /// SucScribes For Not Registered.
    /// </summary>
    [Table("SucScribes")]
    public class SucScribe : BaseEntity<int>
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Column] public string Email { get; set; }
    }
}