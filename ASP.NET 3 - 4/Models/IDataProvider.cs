namespace ASP.NET_3___4.Models
{
    public interface IDateTimeProvider
    {
        DateTime CurrentDateTime { get; }
    }

    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime CurrentDateTime => DateTime.Now;
    }
}
