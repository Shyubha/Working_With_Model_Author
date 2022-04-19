using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Working_With_Model_Author.Models
{
    public class Author
    {
        [Key]
        [ScaffoldColumn(false)]
        [DisplayName("id")]
        public int Id { get; set; }


        [DisplayName("Name")]
        [MinLength(2)]
        [MaxLength(15)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
      

        [DisplayName("MobileNo")]
        [MinLength(7)]
        [MaxLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage ="Mobile no is required")]
        public int MobileNo { get; set; }


    }
}
