using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

[Table("users")]
public class User : BaseEntity
{
    [MaxLength(25)]
    public string Name { get; set; }

    [MaxLength(25)]
    [EmailAddress(ErrorMessage ="Email is incorrect")]
    //[Index(IsUnique = true)]
    public string Email { get; set; }

    [MaxLength(25)]
    //[Index(IsUnique = true)]
    public string Phone { get; set; }

    public DateOnly Dob { get; set; }

    [MaxLength(25)]
    public string Gender { get; set; }

    [MaxLength(25)]
    public string MaritalStatus { get; set; }

    [MaxLength(50)]
    public string Password { get; set; }
}
