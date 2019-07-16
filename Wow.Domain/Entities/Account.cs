using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wow.Domain.Entities
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }
        public string HolderAccountName { get; set; }
        public string AccountNumber { get; set; }
        public double ValueBalance { get; set; }
        public double ValueLimit { get; set; }
        public bool Blocked { get; set; }
    }
}