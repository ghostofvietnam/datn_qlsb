using N.Model.Entities;
using N.Service.Dto;
using N.Service.FieldService.Dto;

namespace N.Service.BookingService.Dto
{
    public class BookingDto : Booking
    {
        public AppUserDto? User { get; set; }
        public Field? Field { get; set; }
    }
}
