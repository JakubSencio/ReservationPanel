namespace ASP.NET_3___4.Models
{
    public interface IDateTimeProvider
    {
        DateTime GetDateTime();
    }

    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}