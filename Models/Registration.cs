using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Registration
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Name is required")]
    public string FullName { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Phone number is required")]
    [Phone(ErrorMessage = "Invalid phone number")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be 10 digits")]
    public string PhoneNumber { get; set; } = string.Empty;
    
    public string CollegeOrganization { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Event selection is required")]
    [Range(1, int.MaxValue, ErrorMessage = "Please select an event")]
    public int EventId { get; set; }
    
    [Required(ErrorMessage = "Ticket count is required")]
    [Range(1, 10, ErrorMessage = "Ticket count must be between 1 and 10")]
    public int NumberOfTickets { get; set; } = 1;
    
    public DateTime DateOfRegistration { get; set; } = DateTime.Now;
}
