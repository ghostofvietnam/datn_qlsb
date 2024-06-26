using N.Model.Entities;
using N.Repository.TeamRepository;
using N.Service.Common.Service;
using N.Service.TeamService.Dto;
using N.Service.Common;
using N.Service.Dto;
using N.Repository.BookingRepository;
using N.Repository.NDirectoryRepository;

namespace N.Service.TeamService
{
    public class TeamService : Service<Team>, ITeamService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IFieldRepository _fieldRepository;
        private readonly IUserRepository _userRepository;

        public TeamService(
            IBookingRepository bookingRepository,
            IFieldRepository fieldRepository,
            IUserRepository userRepository,
            ITeamRepository teamRepository
            ) : base(teamRepository)
        {
            this._bookingRepository = bookingRepository;
            this._fieldRepository = fieldRepository;
            this._userRepository = userRepository;
        }

        public DataResponse<PagedList<TeamDto>> GetData(TeamSearch search)
        {
            try
            {
                var query = from q in GetQueryable()
                            select new TeamDto()
                            {
                                Id = q.Id,
                                UserId = q.UserId,
                                Description = q.Description,
                                Name = q.Name,
                                Phone = q.Phone,
                                Age = q.Age,
                                Level = q.Level,
                            };

                if (search != null)
                {
                    
                }

                var result = PagedList<TeamDto>.Create(query, search);
                return new DataResponse<PagedList<TeamDto>>()
                {
                    Data = result,
                    Message = "Success"
                };

            }
            catch (Exception ex)
            {
                return DataResponse<PagedList<TeamDto>>.False(ex.Message);
            }

        }

        public DataResponse<TeamDto> GetDto(Guid? id)
        {
            var query = from q in GetQueryable()
                        select new TeamDto()
                        {
                            Id = q.Id,
                            UserId = q.UserId,
                            Description = q.Description,
                            Name = q.Name,
                            Phone = q.Phone,
                            Age = q.Age,
                            Level = q.Level,
                        };

            return new DataResponse<TeamDto>()
            {
                Success = true,
                Data = query.FirstOrDefault(),
            };
        }
    }
}
