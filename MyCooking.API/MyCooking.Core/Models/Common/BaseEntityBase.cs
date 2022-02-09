namespace MyCooking.Core.Models.Common
{
    public abstract class BaseEntityBase
    {
        [System.ComponentModel.DataAnnotations.Key]
        private int Id { get; set; }
    }
}