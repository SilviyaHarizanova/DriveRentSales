using DriveRentSales.Models.Entities;

namespace DriveRentSales.Services
{
    public class CarServices
    {
        public bool IsCarFree(VehicleRent car, DateOnly start, DateOnly end)
        {
            if (car.RentalBookingList.Last().PeriodEnd >= start && car.RentalBookingList.Last() != null)
            { return false; }
            return true;
        }

        public decimal PriceForTheRenting(VehicleRent car, RentalBooking booking)
        {
            decimal days = booking.PeriodEnd.DayNumber - booking.PeriodStart.DayNumber;
            return car.DayRentPrice * days;
        }
    }
}
