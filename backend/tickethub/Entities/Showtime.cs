using System;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Showtimes")]
public class Showtime : BaseEntity
{
    public DateOnly Date { get; set; }

    public TimeOnly Time { get; set; }

    public int AvailableSeats { get; set; }

    [ForeignKey("Movie")]
    public long MovieId { get; set; }
    public Movie Movie { get; set; }

    [ForeignKey("Theater")]
    public long TheaterId { get; set; }
    public Theater Theater { get; set; }
}
