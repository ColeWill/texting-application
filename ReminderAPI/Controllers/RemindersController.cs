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

    // GET: api/reminders
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Reminder>>> GetReminders()
    {
      var reminders = await _reminderService.GetAllRemindersAsync();
      return Ok(reminders);
    }

    // GET: api/reminders/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Reminder>> GetReminder(int id)
    {
      var reminder = await _reminderService.GetReminderByIdAsync(id);

      if (reminder == null)
      {
        return NotFound($"Reminder with ID {id} not found.");
      }

      return Ok(reminder);
    }

    // POST: api/reminders
    [HttpPost]
    public async Task<ActionResult<Reminder>> CreateReminder(CreateReminderDto createReminderDto)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      // Basic validation
      if (string.IsNullOrWhiteSpace(createReminderDto.Message))
      {
        return BadRequest("Message is required.");
      }

      if (string.IsNullOrWhiteSpace(createReminderDto.RecipientPhoneNumber))
      {
        return BadRequest("Recipient phone number is required.");
      }

      if (createReminderDto.ScheduledDateTime <= DateTime.UtcNow)
      {
        return BadRequest("Scheduled date and time must be in the future.");
      }

      try
      {
        var reminder = await _reminderService.CreateReminderAsync(createReminderDto);
        return CreatedAtAction(nameof(GetReminder), new { id = reminder.Id }, reminder);
      }
      catch (Exception ex)
      {
        return StatusCode(500, $"An error occurred while creating the reminder: {ex.Message}");
      }
    }
  }
}
