using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using NuGet.Common;
using NuGet.Versioning;

namespace NuGet.Packaging
{
    public class FallbackPackagePathResolver
    {
        private readonly List<VersionFolderPathResolver> _pathResolvers;

        public FallbackPackagePathResolver(INuGetPathContext pathContext)
            : this(pathContext?.UserPackagesFolder, pathContext?.FallbackPackagesFolders)
        {

        }

        public FallbackPackagePathResolver(string userPackagesFolder, IEnumerable<string> fallbackPackageFolders)
        {
            if (fallbackPackageFolders == null)
            {
                throw new ArgumentNullException(nameof(fallbackPackageFolders));
            }

            if (userPackagesFolder == null)
            {
                throw new ArgumentNullException(nameof(userPackagesFolder));
            }

            var packageFolders = new List<string>();

            // The user's packages folder may not exist, this is expected if the fallback
            // folders contain all packages.
            if (Directory.Exists(userPackagesFolder))
            {
                packageFolders.Add(userPackagesFolder);
            }

            // All fallback folders must exist
            foreach (var path in fallbackPackageFolders)
            {
                if (!Directory.Exists(path))
                {
                    throw new DirectoryNotFoundException(path);
                }

                packageFolders.Add(path);
            }

            // Create path resolvers for each source.
            _pathResolvers = packageFolders.Select(path => new VersionFolderPathResolver(path)).ToList();
        }

        /// <summary>
        /// Returns the root directory of an installed package.
        /// </summary>
        /// <param name="packageId">Package id.</param>
        /// <param name="version">Package version.</param>
        /// <returns>Returns the path if the package exists in any of the folders. Null if the package does not exist.</returns>
        public string GetPackageDirectory(string packageId, string version)
        {
            return GetPackageDirectory(packageId, NuGetVersion.Parse(version));
        }

        /// <summary>
        /// Returns the root directory of an installed package.
        /// </summary>
        /// <param name="packageId">Package id.</param>
        /// <param name="version">Package version.</param>
        /// <returns>Returns the path if the package exists in any of the folders. Null if the package does not exist.</returns>
        public string GetPackageDirectory(string packageId, NuGetVersion version)
        {
            if (string.IsNullOrEmpty(packageId))
            {
                throw new ArgumentException(
                    string.Format(
                    CultureInfo.CurrentCulture,
                    Strings.StringCannotBeNullOrEmpty,
                    nameof(packageId)));
            }

            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            // Check each folder for the package.
            foreach (var resolver in _pathResolvers)
            {
                var hashPath = resolver.GetHashPath(packageId, version);

                if (File.Exists(hashPath))
                {
                    // If the hash exists we can use this path
                    return resolver.GetInstallPath(packageId, version);
                }
            }

            // Not found
            return null;
        }
    }
}
