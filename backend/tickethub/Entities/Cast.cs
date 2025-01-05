using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("casts")]
public class Cast : BaseEntity
{
    public long CastId { get; set; }

    public string Name { get; set; }

    public string ProfilePath { get; set; }

    [ForeignKey("MovieCast")]
    public int MovieCastId { get; set; }
    public MovieCast MovieCast { get; set; }
}
