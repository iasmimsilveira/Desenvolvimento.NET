using MyCooking.Core.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyCooking.Core.Models
{
    class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
