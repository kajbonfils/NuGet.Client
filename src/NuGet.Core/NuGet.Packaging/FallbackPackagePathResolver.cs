using NuGet.Packaging.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NuGet.Packaging
{
    public class FallbackPackagePathResolver
    {
        private readonly List<string> _packageFolders;

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

            _packageFolders = new List<string>();
            var uniquePaths = new HashSet<string>(StringComparer.Ordinal);

            uniquePaths.Add(userPackagesFolder);
            _packageFolders.Add(userPackagesFolder);


            _packageFolders.AddRange(fallbackPackageFolders);

            // Ensure all paths are absolute
            foreach (var path in _packageFolders)
            {
                if (!Path.IsPathRooted(path))
                {
                    var message = string.Format(
                        CultureInfo.CurrentCulture,
                        Strings.AbsolutePathRequired,
                        path);

                    throw new PackagingException(message);
                }
            }

            _packageFolders = packageFolders.ToList();
        }
    }
}
