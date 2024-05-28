using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using N.Api.ViewModels;
using N.Model.Entities;
using N.Service.InviteService;
using N.Service.InviteService.Dto;
using N.Service.Common;
using N.Service.Dto;

namespace N.Controllers
{
    [Route("api/[controller]")]
    public class InviteController : NController
    {
        private readonly IInviteService _inviteService;
        private readonly IMapper _mapper;
        private readonly ILogger<InviteController> _logger;


        public InviteController(
            IInviteService inviteService,
            IMapper mapper,
            ILogger<InviteController> logger
            )
        {
            this._inviteService = inviteService;
            this._mapper = mapper;
            _logger = logger;
        }

        [HttpPost("Create")]
        public async Task<DataResponse<Invite>> Create([FromBody] InviteCreateVM model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var entity = new Invite()
                    {

                    };

                    await _inviteService.Create(entity);
                    return new DataResponse<Invite>() { Data = entity, Success = true };
                }
                catch (Exception ex)
                {
                    return DataResponse<Invite>.False("Error", new string[] { ex.Message });
                }
            }
            return DataResponse<Invite>.False("Some properties are not valid", ModelStateError);
        }

        [HttpPost("Edit")]
        public async Task<DataResponse<Invite>> Edit([FromBody] InviteEditVM model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var entity = _inviteService.GetById(model.Id);
                    if (entity == null)
                        return DataResponse<Invite>.False("Invite not found");

                    await _inviteService.Update(entity);
                    return new DataResponse<Invite>() { Data = entity, Success = true };
                }
                catch (Exception ex)
                {
                    DataResponse<Invite>.False(ex.Message);
                }
            }
            return DataResponse<Invite>.False("Some properties are not valid", ModelStateError);
        }
        [HttpGet("Get/{id}")]
        public DataResponse<InviteDto> Get(Guid id)
        {
            return _inviteService.GetDto(id);
        }

        [HttpPost("GetData")]
        public DataResponse<PagedList<InviteDto>> GetData([FromBody] InviteSearch search)
        {
            return _inviteService.GetData(search);
        }

        [HttpPost("Accept")]
        public async Task<DataResponse<Invite>> Accept([FromBody] AcceptVM model)
        {
            var entity = _inviteService.GetById(model.Id);
            try
            {
                entity.Accepted = model.Accept;
                await _inviteService.Update(entity);
                return new DataResponse<Invite>()
                {
                    Data = entity,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                return DataResponse<Invite>.False(ex.Message);
            }

        }


    }
}