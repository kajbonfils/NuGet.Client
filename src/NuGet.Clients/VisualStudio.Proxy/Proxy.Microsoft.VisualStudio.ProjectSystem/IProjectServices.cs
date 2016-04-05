﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using NuGet.VisualStudio.Proxy;

namespace Proxy.Microsoft.VisualStudio.ProjectSystem
{
    [InnerType(typeof(global::Microsoft.VisualStudio.ProjectSystem.IProjectServices))]
    public interface IProjectServices : IVsProxy
    {
        IProjectLockService ProjectLockService { get; }
        IThreadHandling ThreadingPolicy { get; }
        //IProjectFaultHandlerService FaultHandler { get; }
        //IProjectReloader ProjectReloader { get; }
        //VisualStudio.Composition.ExportProvider ExportProvider { get; }
    }
}
