using Soenneker.Tests.HostedUnit;

namespace Soenneker.Resend.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ResendRunnerUtilTests : HostedUnitTest
{
    public ResendRunnerUtilTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
