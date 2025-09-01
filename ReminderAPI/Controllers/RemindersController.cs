using Microsoft.AspNetCore.Mvc;
using ReminderApi.Models;
using ReminderApi.Services;

namespace ReminderApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class RemindersController : ControllerBase
  {
    private readonly IReminderService _reminderService;

    public RemindersController(IReminderService reminderService)
    {
      _reminderService = reminderService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Reminder>>> GetReminders()
    {
      var reminders = await _reminderService.GetAllRemindersAsync();
      return Ok(reminders);
    }
  }
}
