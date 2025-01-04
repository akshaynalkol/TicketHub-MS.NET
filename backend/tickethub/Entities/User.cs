using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

[Table("users")]
public class User : BaseEntity
{
    [MaxLength(25)]
    public string Name { get; set; }

    [MaxLength(25)]
    //[Index(IsUnique = true)]
    public string Email { get; set; }

    [MaxLength(25)]
    //[Index(IsUnique = true)]
    public string Phone { get; set; }

    public DateOnly Dob { get; set; }

    public Gender Gender { get; set; }

    public MaritalStatus MaritalStatus { get; set; }

    [JsonIgnore]
    [MaxLength(50)]
    public string Password { get; set; }
}
