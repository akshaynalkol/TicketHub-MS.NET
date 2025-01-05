using System;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Showtimes")]
public class Showtime : BaseEntity
{
    public DateOnly Date { get; set; }

    public TimeOnly Time { get; set; }

    public int AvailableSeats { get; set; }

    [ForeignKey("Movie")]
    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    [ForeignKey("Theater")]
    public int TheaterId { get; set; }
    public Theater Theater { get; set; }
}
