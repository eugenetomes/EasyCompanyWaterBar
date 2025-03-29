using WaterBar.SharedKernel;

namespace WaterBar.Infrastructure.Time;
internal sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
