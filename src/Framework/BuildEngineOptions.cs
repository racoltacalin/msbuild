// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Build.Framework
{
    /// <summary>
    /// Encapsulates additional options on IBuildEngine for consumption by tasks.
    /// This class can be extended without revising the IBuildEngineN interface.
    /// </summary>
    public class BuildEngineOptions
    {
        public bool LogTaskInputs { get; set; }
    }
}
