namespace WaterBar.SharedKernel;
public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}

