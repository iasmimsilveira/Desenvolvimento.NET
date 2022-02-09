using MyCooking.Core.Models.Common;
using System.Collections.Generic;

namespace MyCooking.Core.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }
    }
}