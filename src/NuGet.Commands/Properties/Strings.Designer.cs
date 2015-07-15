// <auto-generated />
namespace NuGet.Commands
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Strings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("NuGet.Commands.Strings", typeof(Strings).GetTypeInfo().Assembly);

        /// <summary>
        /// Checking compatibility of packages on {0}.
        /// </summary>
        internal static string Log_CheckingCompatibility
        {
            get { return GetString("Log_CheckingCompatibility"); }
        }

        /// <summary>
        /// Checking compatibility of packages on {0}.
        /// </summary>
        internal static string FormatLog_CheckingCompatibility(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_CheckingCompatibility"), p0);
        }

        /// <summary>
        /// Checking compatibility for {0} {1} with {2}.
        /// </summary>
        internal static string Log_CheckingPackageCompatibility
        {
            get { return GetString("Log_CheckingPackageCompatibility"); }
        }

        /// <summary>
        /// Checking compatibility for {0} {1} with {2}.
        /// </summary>
        internal static string FormatLog_CheckingPackageCompatibility(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_CheckingPackageCompatibility"), p0, p1, p2);
        }

        /// <summary>
        /// Failed to resolve conflicts for {0}.
        /// </summary>
        internal static string Log_FailedToResolveConflicts
        {
            get { return GetString("Log_FailedToResolveConflicts"); }
        }

        /// <summary>
        /// Failed to resolve conflicts for {0}.
        /// </summary>
        internal static string FormatLog_FailedToResolveConflicts(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_FailedToResolveConflicts"), p0);
        }

        /// <summary>
        /// Generating MSBuild file {0}.
        /// </summary>
        internal static string Log_GeneratingMsBuildFile
        {
            get { return GetString("Log_GeneratingMsBuildFile"); }
        }

        /// <summary>
        /// Generating MSBuild file {0}.
        /// </summary>
        internal static string FormatLog_GeneratingMsBuildFile(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_GeneratingMsBuildFile"), p0);
        }

        /// <summary>
        /// Installing {0} {1}.
        /// </summary>
        internal static string Log_InstallingPackage
        {
            get { return GetString("Log_InstallingPackage"); }
        }

        /// <summary>
        /// Installing {0} {1}.
        /// </summary>
        internal static string FormatLog_InstallingPackage(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_InstallingPackage"), p0, p1);
        }

        /// <summary>
        /// Merging in runtimes defined in {0}.
        /// </summary>
        internal static string Log_MergingRuntimes
        {
            get { return GetString("Log_MergingRuntimes"); }
        }

        /// <summary>
        /// Merging in runtimes defined in {0}.
        /// </summary>
        internal static string FormatLog_MergingRuntimes(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_MergingRuntimes"), p0);
        }

        /// <summary>
        /// {0} {1} provides a compile-time reference assembly for {2} on {3}, but there is no compatible run-time assembly.
        /// </summary>
        internal static string Log_MissingImplementationFx
        {
            get { return GetString("Log_MissingImplementationFx"); }
        }

        /// <summary>
        /// {0} {1} provides a compile-time reference assembly for {2} on {3}, but there is no compatible run-time assembly.
        /// </summary>
        internal static string FormatLog_MissingImplementationFx(object p0, object p1, object p2, object p3)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_MissingImplementationFx"), p0, p1, p2, p3);
        }

        /// <summary>
        /// {0} {1} provides a compile-time reference assembly for {2} on {3}, but there is no run-time assembly compatible with {4}.
        /// </summary>
        internal static string Log_MissingImplementationFxRuntime
        {
            get { return GetString("Log_MissingImplementationFxRuntime"); }
        }

        /// <summary>
        /// {0} {1} provides a compile-time reference assembly for {2} on {3}, but there is no run-time assembly compatible with {4}.
        /// </summary>
        internal static string FormatLog_MissingImplementationFxRuntime(object p0, object p1, object p2, object p3, object p4)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_MissingImplementationFxRuntime"), p0, p1, p2, p3, p4);
        }

        /// <summary>
        /// {0} {1} is not compatible with {2}.
        /// </summary>
        internal static string Log_PackageNotCompatibleWithFx
        {
            get { return GetString("Log_PackageNotCompatibleWithFx"); }
        }

        /// <summary>
        /// {0} {1} is not compatible with {2}.
        /// </summary>
        internal static string FormatLog_PackageNotCompatibleWithFx(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_PackageNotCompatibleWithFx"), p0, p1, p2);
        }

        /// <summary>
        /// All packages are compatible with {0}.
        /// </summary>
        internal static string Log_PackagesAreCompatible
        {
            get { return GetString("Log_PackagesAreCompatible"); }
        }

        /// <summary>
        /// All packages are compatible with {0}.
        /// </summary>
        internal static string FormatLog_PackagesAreCompatible(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_PackagesAreCompatible"), p0);
        }

        /// <summary>
        /// Some packages are not compatible with {0}.
        /// </summary>
        internal static string Log_PackagesIncompatible
        {
            get { return GetString("Log_PackagesIncompatible"); }
        }

        /// <summary>
        /// Some packages are not compatible with {0}.
        /// </summary>
        internal static string FormatLog_PackagesIncompatible(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_PackagesIncompatible"), p0);
        }

        /// <summary>
        /// The project does not specify any target frameworks.
        /// </summary>
        internal static string Log_ProjectDoesNotSpecifyTargetFrameworks
        {
            get { return GetString("Log_ProjectDoesNotSpecifyTargetFrameworks"); }
        }

        /// <summary>
        /// The project does not specify any target frameworks.
        /// </summary>
        internal static string FormatLog_ProjectDoesNotSpecifyTargetFrameworks()
        {
            return GetString("Log_ProjectDoesNotSpecifyTargetFrameworks");
        }

        /// <summary>
        /// Resolving conflicts for {0}...
        /// </summary>
        internal static string Log_ResolvingConflicts
        {
            get { return GetString("Log_ResolvingConflicts"); }
        }

        /// <summary>
        /// Resolving conflicts for {0}...
        /// </summary>
        internal static string FormatLog_ResolvingConflicts(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_ResolvingConflicts"), p0);
        }

        /// <summary>
        /// Restoring packages for {0}...
        /// </summary>
        internal static string Log_RestoringPackages
        {
            get { return GetString("Log_RestoringPackages"); }
        }

        /// <summary>
        /// Restoring packages for {0}...
        /// </summary>
        internal static string FormatLog_RestoringPackages(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_RestoringPackages"), p0);
        }

        /// <summary>
        /// Restoring packages for {0} to determine compatibility...
        /// </summary>
        internal static string Log_RestoringPackagesForCompat
        {
            get { return GetString("Log_RestoringPackagesForCompat"); }
        }

        /// <summary>
        /// Restoring packages for {0} to determine compatibility...
        /// </summary>
        internal static string FormatLog_RestoringPackagesForCompat(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_RestoringPackagesForCompat"), p0);
        }

        /// <summary>
        /// Scanning packages for runtime.json files...
        /// </summary>
        internal static string Log_ScanningForRuntimeJson
        {
            get { return GetString("Log_ScanningForRuntimeJson"); }
        }

        /// <summary>
        /// Scanning packages for runtime.json files...
        /// </summary>
        internal static string FormatLog_ScanningForRuntimeJson()
        {
            return GetString("Log_ScanningForRuntimeJson");
        }

        /// <summary>
        /// Skipping runtime dependency walk, no runtimes defined in project.json.
        /// </summary>
        internal static string Log_SkippingRuntimeWalk
        {
            get { return GetString("Log_SkippingRuntimeWalk"); }
        }

        /// <summary>
        /// Skipping runtime dependency walk, no runtimes defined in project.json.
        /// </summary>
        internal static string FormatLog_SkippingRuntimeWalk()
        {
            return GetString("Log_SkippingRuntimeWalk");
        }

        /// <summary>
        /// Unable to resolve {0} {1} for {2}.
        /// </summary>
        internal static string Log_UnresolvedDependency
        {
            get { return GetString("Log_UnresolvedDependency"); }
        }

        /// <summary>
        /// Unable to resolve {0} {1} for {2}.
        /// </summary>
        internal static string FormatLog_UnresolvedDependency(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_UnresolvedDependency"), p0, p1, p2);
        }

        /// <summary>
        /// Unknown Compatibility Profile: {0}
        /// </summary>
        internal static string Log_UnknownCompatibilityProfile
        {
            get { return GetString("Log_UnknownCompatibilityProfile"); }
        }

        /// <summary>
        /// Unknown Compatibility Profile: {0}
        /// </summary>
        internal static string FormatLog_UnknownCompatibilityProfile(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_UnknownCompatibilityProfile"), p0);
        }

        /// <summary>
        /// Using source {0}.
        /// </summary>
        internal static string Log_UsingSource
        {
            get { return GetString("Log_UsingSource"); }
        }

        /// <summary>
        /// Using source {0}.
        /// </summary>
        internal static string FormatLog_UsingSource(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_UsingSource"), p0);
        }

        /// <summary>
        /// Packages containing MSBuild targets and props files cannot be fully installed in projects targeting multiple frameworks. The MSBuild targets and props files have been ignored.
        /// </summary>
        internal static string MSBuildWarning_MultiTarget
        {
            get { return GetString("MSBuildWarning_MultiTarget"); }
        }

        /// <summary>
        /// Packages containing MSBuild targets and props files cannot be fully installed in projects targeting multiple frameworks. The MSBuild targets and props files have been ignored.
        /// </summary>
        internal static string FormatMSBuildWarning_MultiTarget()
        {
            return GetString("MSBuildWarning_MultiTarget");
        }

        /// <summary>
        /// Unable to satisfy conflicting requests for '{0}': {1}
        /// </summary>
        internal static string Log_ResolverConflict
        {
            get { return GetString("Log_ResolverConflict"); }
        }

        /// <summary>
        /// Unable to satisfy conflicting requests for '{0}': {1}
        /// </summary>
        internal static string FormatLog_ResolverConflict(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_ResolverConflict"), p0, p1);
        }

        /// <summary>
        /// {0} (via {1})
        /// </summary>
        internal static string ResolverRequest_ToStringFormat
        {
            get { return GetString("ResolverRequest_ToStringFormat"); }
        }

        /// <summary>
        /// {0} (via {1})
        /// </summary>
        internal static string FormatResolverRequest_ToStringFormat(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ResolverRequest_ToStringFormat"), p0, p1);
        }

        /// <summary>
        /// {0} {1} is specified in the Lock File target for {2} but is not present in the top-level Libraries list.
        /// </summary>
        internal static string Log_LockFileMissingLibraryForTargetLibrary
        {
            get { return GetString("Log_LockFileMissingLibraryForTargetLibrary"); }
        }

        /// <summary>
        /// {0} {1} is specified in the Lock File target for {2} but is not present in the top-level Libraries list.
        /// </summary>
        internal static string FormatLog_LockFileMissingLibraryForTargetLibrary(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_LockFileMissingLibraryForTargetLibrary"), p0, p1, p2);
        }

        /// <summary>
        /// The lock file is out-of-date relative to the project file. Regenerating the lock file and re-locking.
        /// </summary>
        internal static string Log_LockFileOutOfDate
        {
            get { return GetString("Log_LockFileOutOfDate"); }
        }

        /// <summary>
        /// The lock file is out-of-date relative to the project file. Regenerating the lock file and re-locking.
        /// </summary>
        internal static string FormatLog_LockFileOutOfDate()
        {
            return GetString("Log_LockFileOutOfDate");
        }

        /// <summary>
        /// Dependency specified was {0} {1} but ended up with {2} {3}.
        /// </summary>
        internal static string Log_DependencyBumpedUp
        {
            get { return GetString("Log_DependencyBumpedUp"); }
        }

        /// <summary>
        /// Dependency specified was {0} {1} but ended up with {2} {3}.
        /// </summary>
        internal static string FormatLog_DependencyBumpedUp(object p0, object p1, object p2, object p3)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_DependencyBumpedUp"), p0, p1, p2, p3);
        }

        /// <summary>
        /// Package '{0}' was restored using '{1}' instead the project target framework '{2}'. This may cause compatibility problems.
        /// </summary>
        internal static string Log_ImportsFallbackWarning
        {
            get { return GetString("Log_ImportsFallbackWarning"); }
        }

        /// <summary>
        /// Package '{0}' was restored using '{1}' instead the project target framework '{2}'. This may cause compatibility problems.
        /// </summary>
        internal static string FormatLog_ImportsFallbackWarning(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_ImportsFallbackWarning"), p0, p1, p2);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
