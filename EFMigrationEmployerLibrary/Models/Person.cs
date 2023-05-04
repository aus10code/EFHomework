namespace EFMigrationEmployerLibrary.Models;

using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }
    public List<Address> Addresses { get; set; } = new();
    public List<Employer> Employers { get; set; } = new();
}
