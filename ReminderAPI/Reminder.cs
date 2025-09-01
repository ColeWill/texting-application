using Microsoft.Extensions.Primitives;

namespace ReminderApi.Models
{
  public class ReminderApi
  {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public string RecipientPhoneNumber { get; set; } = string.Empty;
    public string SenderPhoneNumber { get; set; } = string.Empty;
    public DateTime ScheduledDateTime { get; set; } = DateTime.UtcNow;
    public bool IsCompleted { get; set; } = false;
    public ReminderType Type { get; set; }
  }

  public enum ReminderType
  {
    SelfReminder = 0,
    OtherReminder = 1,
  }

  public class CreateReminderDto
  {
    public string Title { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public string RecipientPhoneNumber { get; set; } = string.Empty;
    public string SenderPhoneNumber { get; set; } = string.Empty;
    public DateTime SchedultedDateTime { get; set; }
    public ReminderType Type { get; set; }
  }

  public class UpdateReminderDto
  {
    public string? Title { get; set; }
    public string? Message { get; set; }
    public DateTime? ScheduledDateTime { get; set; }
    public bool? IsCompleted { get; set; }
  }
}
