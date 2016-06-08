using System.Collections.Generic;

namespace NuGet.Common
{
    /// <summary>
    /// Common NuGet paths. These values may be overridden in NuGet.Config or by 
    /// environment variables, resolving the paths here requires NuGet.Configuration.
    /// </summary>
    public interface INuGetPathContext
    {
        /// <summary>
        /// User packages folder directory.
        /// </summary>
        string UserPackagesFolder { get; }

        /// <summary>
        /// Fallback packages folder locations.
        /// </summary>
        IReadOnlyList<string> FallbackPackagesFolders { get; }

        /// <summary>
        /// Http file cache.
        /// </summary>
        string HttpCache { get; }
    }
}
