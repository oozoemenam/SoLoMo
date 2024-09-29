using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SoLoMo.Models;


public class Address
{
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    public string Street { get; set; } = string.Empty;
    
    [Required]
    public string City { get; set; } = string.Empty;
    
    [Required]
    public string State { get; set; } = string.Empty;
    
    [Required]
    public string ZipCode { get; set; } = string.Empty;
    
    [Required]
    public string Country { get; set; } = string.Empty;
    
    
    public Guid ContactId { get; set; }
    
    [JsonIgnore]
    [ForeignKey("Contact")]
    public Contact Contact { get; set; } = new();
}