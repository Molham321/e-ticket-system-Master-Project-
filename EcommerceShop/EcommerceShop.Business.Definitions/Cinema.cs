using EcommerceShop.Business.Definitions.Base;
using System.ComponentModel.DataAnnotations;

namespace EcommerceShop.Business.Definitions
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]

        public string Name { get; set; }

        [Display(Name = "Description")]

        public string Description { get; set; }

        // Relationships
        public List<Movie> Movies { get; set; }
    }
}
