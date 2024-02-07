namespace Labolatorium3.Models
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
    }

    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime Now => DateTime.UtcNow; 
    }
}

