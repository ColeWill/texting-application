using Microsoft.AspNetCore.Identity;
using ReminderApi.Models;

namespace ReminderApi.Services
{
  public interface IReminderService
  {
    Task<IEnumerable<Reminder>> GetAllRemindersAsync();
    Task<Reminder?> GetReminderByIdAsync(int id);
    Task<Reminder?> UpdateReminderAsync(int id, UpdateReminderDto updateReminderDto);
    Task<bool> DeleteReminderAsync(int id);
    Task<IEnumerable<Reminder>> GetRemindersByPhoneNumberAsync(string phoneNumber);
  }

  public class ReminderService : IReminderService
  {
    private readonly List<Reminder> _reminders;
    private int _nextId;

    public ReminderService()
    {
      _reminders = new List<Reminder>();
      _nextId = 1;
    }

    public Task<IEnumerable<Reminder>> GetAllRemindersAsync()
    {
      return Task.FromResult(_reminders.AsEnumerable());
    }

    public Task<Reminder?> GetReminderByIdAsync(int id)
    {
      var reminder = _reminders.FirstOrDefault(reminder => reminder.Id == id);
      return Task.FromResult(reminder);
    }

    public Task<Reminder> CreateReminderAsync(CreateReminderDto createReminderDto)
    {
      var reminder = new Reminder
      {
        Id = _nextId++,
        Title = createReminderDto.Title,
        Message = createReminderDto.Message,
        RecipientPhoneNumber = createReminderDto.RecipientPhoneNumber,
        SenderPhoneNumber = createReminderDto.SenderPhoneNumber,
        ScheduledDateTime = createReminderDto.ScheduledDateTime,
        Type = createReminderDto.Type,
        CreatedAt = DateTime.UtcNow,
      };

      _reminders.Add(reminder);
      return Task.FromResult(reminder);
    }

    public Task<Reminder?> UpdateReminderAsync(int id, UpdateReminderDto updateReminderDto)
    {
      var reminder = _reminders.FirstOrDefault(reminder => reminder.Id == id);
      if (reminder == null)
        return Task.FromResult<Reminder?>(null);

      if (!string.IsNullOrEmpty(updateReminderDto.Title))
        reminder.Title = updateReminderDto.Title;

      if (!string.IsNullOrEmpty(updateReminderDto.Message))
        reminder.Message = updateReminderDto.Message;

      if (updateReminderDto.ScheduledDateTime.HasValue)
      {
        reminder.ScheduledDateTime = updateReminderDto.ScheduledDateTime.Value;
      }

      if (updateReminderDto.IsCompleted.HasValue)
        reminder.IsCompleted = updateReminderDto.IsCompleted.Value;

      return Task.FromResult<Reminder?>(reminder);
    }

    public Task<bool> DeleteReminderAsync(int id)
    {
      var reminder = _reminders.FirstOrDefault(r => r.Id == id);
      if (reminder == null)
        return Task.FromResult(false);
      _reminders.Remove(reminder);
      return Task.FromResult(true);
    }

    public Task<IEnumerable<Reminder>> GetRemindersByPhoneNumberAsync(string phoneNumber)
    {
      var reminders = _reminders.Where(r =>
        r.RecipientPhoneNumber == phoneNumber || r.SenderPhoneNumber == phoneNumber
      );
      return Task.FromResult(reminders);
    }
  }
}
