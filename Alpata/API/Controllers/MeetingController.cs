using Alpata.API.Business.Interfaces;
using Alpata.Entity;
using Alpata.Model.Meeting;
using Microsoft.AspNetCore.Mvc;

namespace Alpata.API.Controllers;

[ApiController]
[Route("meeting")]
public class MeetingController : Controller
{
    private readonly IMeetingService _meetingService;

    public MeetingController(IMeetingService meetingService)
    {
        _meetingService = meetingService;
    }

    [HttpPost("create")]
    [ProducesDefaultResponseType(typeof(Meeting))]
    public Meeting Create([FromForm] SaveMeetingRequestDto CreateMeetingRequestDto)
    {
        return _meetingService.Create(CreateMeetingRequestDto);
    }

    [HttpGet("get/{meetingId}")]
    [ProducesDefaultResponseType(typeof(Meeting))]
    public Meeting Get(int meetingId)
    {
        return _meetingService.Get(meetingId);
    }

    [HttpGet("getAll/{userId}")]
    [ProducesDefaultResponseType(typeof(Meeting))]
    public IEnumerable<Meeting> GetAll(int userId)
    {
        return _meetingService.GetAll(userId);
    }

    [HttpDelete("delete")]
    [ProducesDefaultResponseType(typeof(Meeting))]
    public Meeting Delete([FromBody] int meetingId)
    {
        return _meetingService.Delete(meetingId);
    }

    [HttpPost("update")]
    [ProducesDefaultResponseType(typeof(Meeting))]
    public Meeting Update([FromForm] SaveMeetingRequestDto updateMeetingRequestDto)
    {
        return _meetingService.Update(updateMeetingRequestDto);
    }
}
