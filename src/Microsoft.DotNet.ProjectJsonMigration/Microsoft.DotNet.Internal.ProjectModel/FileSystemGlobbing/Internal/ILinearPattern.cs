// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace Microsoft.DotNet.Internal.ProjectModel.FileSystemGlobbing.Internal
{
    internal interface ILinearPattern : IPattern
    {
        IList<IPathSegment> Segments { get; }
    }
}