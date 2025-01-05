using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("created_on")]
    public DateTime CreatedOn { get; set; } = DateTime.Now;

    [Column("updated_on")]
    public DateTime UpdatedOn { get; set; } = DateTime.Now;
}
