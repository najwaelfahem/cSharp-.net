#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefDishes.Models;

public class Chef {
    [Key]
    public int ChefID {get; set;}
    [Required(ErrorMessage = "First Name is required")]
    public string FirstName {get; set;}
    [Required(ErrorMessage = "Last Name is required")]
    public string LastName {get; set;}
    // [Required(ErrorMessage = "Date of birth is required")]
    // [DataType(DataType.Date)]
    [Required]
    public DateTime DateOfBirth {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public DateTime UpdatedAt {get; set;} = DateTime.Now;
    public List<Dish> ChefDishes {get; set;} = new List<Dish>();

    public int GetAge() {
        return DateTime.Now.Year - DateOfBirth.Year;
    }
}