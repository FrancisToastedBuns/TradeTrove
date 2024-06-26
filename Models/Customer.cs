using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradeTrove.Models;

public class Customer
{
    public int ID { get; set; }
    [RegularExpression("^[a-zA-Z0-9]")]   
    public string UserName {get; set;} = string.Empty;
    
    [Required(ErrorMessage="Please Enter a Email Address")]
    [Display(Name = "Email Address")]
    public string EmailAddress {get; set;} = string.Empty;

    [Required(ErrorMessage = "Date is required!")]
    public DateTime? DOB { get; set; }
    
    [Required(ErrorMessage="Password is required!")]
    [Compare("ConfirmPassword")]
    [StringLength(25, ErrorMessage = "Please limit your password to 25 characters")]

    public string Password { get; set; } = string.Empty;

    [Required(ErrorMessage = "Password is required!")]
    [Display(Name = "Confirm Password")]
    [NotMapped]
    public string ConfirmPassword { get; set; } = string.Empty;
}