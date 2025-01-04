using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

[Table("movie_casts")]
public class MovieCast : BaseEntity
{
    public string Director { get; set; }

    public string Writer { get; set; }

    public ICollection<Cast> Casts { get; set; } = new List<Cast>();
}
