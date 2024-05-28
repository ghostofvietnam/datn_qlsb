using N.Service.Common;

namespace N.Service.InviteService.Dto
{
    public class InviteSearch : SearchBase
    {
        public Guid? UserId { get; set; }
        public bool? Accept { get; set; }
    }
}
