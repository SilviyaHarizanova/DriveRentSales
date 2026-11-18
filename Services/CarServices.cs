using DriveRentSales.Models.Entities;

namespace DriveRentSales.Services
{
    public class CarServices
    {
        public bool IsCarFree(VehicleRent car, DateOnly start, DateOnly end)
        {
            foreach (var booking in car.RentalBookingList)
            {
                if (booking.PeriodStart <= end && booking.PeriodEnd >= start)
                {
                    return false;
                }
            }
            return true;
        }

        public decimal PriceForTheRenting(VehicleRent car, RentalBooking booking)
        {
            decimal days = booking.PeriodEnd.DayNumber - booking.PeriodStart.DayNumber;
            return car.DayRentPrice * days;
        }
    }
}
