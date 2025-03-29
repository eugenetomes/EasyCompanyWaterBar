using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Reflection;
using System.Windows.Input;
using WaterBar.Domain.Errors;
using WaterBar.Infrastructure.Time;
using WaterBar.Persistence.Constants;

namespace WaterBar.ArchitectureTests;

public abstract class BaseTest
{
    protected static readonly Assembly DomainAssembly = typeof(DomainErrors).Assembly;
    protected static readonly Assembly ApplicationAssembly = typeof(ICommand).Assembly;
    protected static readonly Assembly InfrastructureAssembly = typeof(DateTimeProvider).Assembly;
    protected static readonly Assembly PersistenceAssembly = typeof(TableConstants).Assembly;
    protected static readonly Assembly PresentationAssembly = typeof(Program).Assembly;
}