using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("theaters")]
public class Theater : BaseEntity
{
    [MaxLength(25)]
    //[Index(IsUnique = true)]
    public string Name { get; set; }

    [MaxLength(25)]
    public string Location { get; set; }
}
