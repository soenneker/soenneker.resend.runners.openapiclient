using Soenneker.Resend.Runners.OpenApiClient.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Resend.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class ResendRunnerUtilTests : FixturedUnitTest
{
    private readonly IResendRunnerUtil _openapirunner;

    public ResendRunnerUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _openapirunner = Resolve<IResendRunnerUtil>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
