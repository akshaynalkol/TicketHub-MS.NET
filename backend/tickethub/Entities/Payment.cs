using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Payment : BaseEntity
{
    public double Amount { get; set; }

    public DateOnly PaymentDate { get; set; }

    [MaxLength(25)]
    public string PaymentMethod { get; set; }

    [MaxLength(25)]
    public string PaymentStatus { get; set; }

    [ForeignKey("Booking")]
    public int BookingId { get; set; }
    public Booking Booking { get; set; }
}
