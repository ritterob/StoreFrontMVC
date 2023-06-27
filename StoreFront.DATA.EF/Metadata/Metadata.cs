using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF.Models {

    public class CategoryMetadata {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [StringLength(50)]
        [Display(Name = "Category")]
        public string CategoryName { get; set; } = null!;
    }

    public class ManufacturerMetadata {
        [Required(ErrorMessage = "Manufacturer is required")]
        [StringLength(50)]
        [Display(Name = "Manufacturer")]
        public string ManufacturerName { get; set; } = null!;

        [StringLength(150)]
        [Display(Name = "Address")]
        public string? ManufacturerAddress { get; set; }

        [StringLength(50)]
        [Display(Name = "City")]
        public string? ManufacturerCity { get; set; }

        [StringLength(2)]
        [Display(Name = "State")]
        public string? ManufacturerState { get; set; }

        [StringLength(5)]
        [Display(Name = "Zipcode")]
        [DataType(DataType.PostalCode)]
        public string? ManufacturerZip { get; set; }

        [StringLength(24)]
        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        public string? ManufacturerPhone { get; set; }

    }

    public class OrderMetadata {

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        [Display(Name = "Order total")]
        [DataType(DataType.Currency)]
        public decimal? OrderTotal { get; set; }

        public string CustomerId { get; set; } = null!;

        public string EmployeeId { get; set; } = null!;

    }

    public class ProductMetadata {

        [Required(ErrorMessage = "Product is required")]
        [StringLength(50)]
        [Display(Name = "Product")]
        public string ProductName { get; set; } = null!;

        [StringLength(500)]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string? ProductDescription { get; set; }

        [StringLength(75)]
        [Display(Name = "Product image")]
        public string? ProductPhoto { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        [Display(Name = "Product price")]
        [DataType(DataType.Currency)]
        public decimal? ProductPrice { get; set; }

        [Display(Name = "Quantity")]
        public int? ProductQuantity { get; set; }

        [Display(Name = "In stock?")]
        public bool ProductInStock { get; set; }

        [Display(Name = "Category")]
        public int? CategoryID { get; set; }

        [Display(Name = "Manufacturer")]
        public int? ManufacturerID { get; set; }

    }

    public class UserMetadata {

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Address is required")]
        [StringLength(150)]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = "City is required")]
        [StringLength(50)]
        public string City { get; set; } = null!;

        [Required(ErrorMessage = "State is required")]
        [StringLength)(2)]
        public string State { get; set } = null!;

        [Required(ErrorMessage = "Zip code is required")]
        [StringLength(5)]
        [Display(Name = "Zip code")]
        [DataType(DataType.PostalCode)]
        public string UserZip { get; set; } = null!;

        [StringLength(24)]
        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        public string? UserPhone { get; set; }

        [StringLength(150)]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string? UserEmail { get; set; }

    }
}
