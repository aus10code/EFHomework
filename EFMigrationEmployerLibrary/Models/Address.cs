namespace EFMigrationEmployerLibrary.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Address
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string City { get; set; }
    [Required]
    [MaxLength(50)]
    public string State { get; set; }
    [Required]
    [MaxLength(30)]
    [Column(TypeName = "varchar(30")]
    public string ZipCode { get; set; }
}
