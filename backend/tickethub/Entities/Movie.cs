using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("movies")]
public class Movie : BaseEntity
{
    public long MovieId { get; set; }

    [Required]
    [Column(TypeName = "text")]
    //[Index(IsUnique = true)]
    public string Title { get; set; }

    [Column(TypeName = "text")]
    public string Overview { get; set; }

    public double VoteAverage { get; set; }

    public int VoteCount { get; set; }

    public string ReleaseDate { get; set; }

    public string BackdropPath { get; set; }

    public string PosterPath { get; set; }

    [MaxLength(30)]
    public string Status { get; set; }

    [Column(TypeName = "text")]
    public string Tagline { get; set; }

    public int Revenue { get; set; }

    public int Runtime { get; set; }

    [MaxLength(30)]
    public string Type { get; set; }

    [ForeignKey("MovieCast")]
    public int MovieCastId { get; set; }
    public MovieCast MovieCasts { get; set; }
}
