using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SoLoMo.Enums;

namespace SoLoMo.Models;

[Table("Invoices")]
public class Invoice
{
    [Column("Id")]
    [Key]
    public Guid Id { get; set; }
    
    [Column(name: "InvoiceNumber", TypeName = "varchar(32)")]
    [Required]
    public string InvoiceNumber { get; set; } = string.Empty;
    
    [Column(name: "ContactName")]
    [Required]
    [MaxLength(32)]
    public string ContactName { get; set; } = string.Empty;
    
    [Column(name: "Description")]
    [MaxLength(256)]
    public string? Description { get; set; }
    
    [Column("Amount")]
    [Precision(18, 2)]
    public decimal Amount { get; set; }
    
    [Column(name: "InvoiceDate", TypeName = "datetimeoffset")]
    public DateTimeOffset InvoiceDate { get; set; }
    
    [Column(name: "DueDate", TypeName = "datetimeoffset")]
    public DateTimeOffset DueDate { get; set; }
    
    [Column(name: "Status", TypeName = "varchar(16)")]
    public InvoiceStatus Status { get; set; }

    public List<InvoiceItem> InvoiceItems { get; set; } = new();
}