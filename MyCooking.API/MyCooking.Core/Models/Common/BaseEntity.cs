using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCooking.Core.Models.Common
{
    public abstract class BaseEntity
    {
        [Key]
        private int Id { get; set; }
    }
}
