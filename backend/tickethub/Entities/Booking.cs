using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Bookings")]
public class Booking : BaseEntity
{
    public DateTime BookingDate { get; set; }

    public int SeatNo { get; set; }

    [MaxLength(25)]
    public string PaymentStatus { get; set; }

    [ForeignKey("Showtime")]
    public int ShowtimeId { get; set; }
    public Showtime Showtime { get; set; }

    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }
}
