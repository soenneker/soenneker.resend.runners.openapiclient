﻿using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Resend.Runners.OpenApiClient.Utils.Abstract;

public interface IOpenApiFixer
{
    ValueTask Fix(string sourceFilePath, string targetFilePath, CancellationToken cancellationToken = default);
}
