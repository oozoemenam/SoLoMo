using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace SoLoMo.Models;

[Table("InvoiceItems")]
public class InvoiceItem
{
    [Key]
    [Column(nameof(InvoiceItem.Id))]
    public Guid Id { get; set; }
    
    [Column(nameof(InvoiceItem.Name))]
    [MaxLength(64)]
    [Required]
    public string Name { get; set; } = string.Empty;
    
    [Column(nameof(InvoiceItem.Description))]
    [MaxLength(256)]
    public string? Description { get; set; }
    
    [Column(nameof(InvoiceItem.UnitPrice))]
    [Precision(8, 2)]
    public decimal UnitPrice { get; set; }
    
    [Column(nameof(InvoiceItem.Quantity))]
    [Precision(8, 2)]
    public decimal Quantity { get; set; }
    
    [Column(nameof(InvoiceItem.Amount))]
    [Precision(18, 2)]
    public decimal Amount { get; set; }
    
    [Column(nameof(InvoiceItem.InvoiceId))]
    public Guid InvoiceId { get; set; }
    
    [JsonIgnore]
    [DeleteBehavior(DeleteBehavior.ClientCascade)]
    public Invoice? Invoice { get; set; }
}