using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SoLoMo.Models;

public class Contact
{
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    public string FirstName { get; set; } = string.Empty;
    
    [Required]
    public string LastName { get; set; } = string.Empty;
    
    public string? Title { get; set; }
    
    [Required]
    public string Email { get; set; } = string.Empty;
    
    [Required]
    public string Phone { get; set; } = string.Empty;
    
    public Address? Address { get; set; }
}
