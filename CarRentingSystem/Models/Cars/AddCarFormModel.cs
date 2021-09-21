
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentingSystem.Models.Cars
{
    using static Data.DataConstants;

    public class AddCarFormModel
    {
        [Required]
        [StringLength(CarBrandMaxLength, MinimumLength = CarBrandMinLength)]
        public string Brand { get; init; }

        [Required]
        [StringLength(CarModelMaxLength, MinimumLength = CarModelMinLength, ErrorMessage = "Min: {1}")]
        public string Model { get; init; }

        [Required]
        [StringLength(
            int.MaxValue, 
            MinimumLength = CarDescriptionMinLength,
            ErrorMessage = "The fieled Descrip must be string with min length {2}")]
        public string Description { get; init; }

        [Display(Name = "Image")]
        [Required]
        [Url]
        public string ImageUrl { get; init; }

        [Range(CarYearMinValue, CarYearMaxValue)]
        public int Year { get; init; }

        [Display(Name = "Category")]
        public int CategoryId { get; init; }

        public IEnumerable<CarCategoryViewModel> Categories { get; set; }
    }
}
