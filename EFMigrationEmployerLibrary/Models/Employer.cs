namespace EFMigrationEmployerLibrary.Models;

using System.ComponentModel.DataAnnotations;

public class Employer
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
}
