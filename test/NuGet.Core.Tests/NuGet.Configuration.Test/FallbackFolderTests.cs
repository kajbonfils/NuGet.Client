using System.IO;
using System.Linq;
using NuGet.Test.Utility;
using Xunit;

namespace NuGet.Configuration.Test
{
    public class FallbackFolderTests
    {
        [Fact]
        public void GetFallbackPackagesFolders_DefaultHasNoFallbackFolders()
        {
            // Arrange & Act
            var paths = SettingsUtility.GetFallbackPackagesFolders(new NullSettings());

            // Assert
            Assert.Equal(0, paths.Count);
        }

        [Fact]
        public void GetFallbackPackagesFolders_SingleFolderFromNuGetConfig()
        {
            // Arrange
            var config = @"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
    <fallbackPackageFolders>
        <add key=""shared"" value=""C:\Temp\NuGet"" />
    </fallbackPackageFolders>
</configuration>";

            var nugetConfigPath = "NuGet.Config";
            using (var mockBaseDirectory = TestFileSystemUtility.CreateRandomTestFolder())
            {
                ConfigurationFileTestUtility.CreateConfigurationFile(nugetConfigPath, mockBaseDirectory, config);
                Settings settings = new Settings(mockBaseDirectory);

                // Act
                var paths = SettingsUtility.GetFallbackPackagesFolders(settings);

                // Assert
                Assert.Equal(@"C:\Temp\NuGet", paths.Single());
            }
        }

        [Fact]
        public void GetFallbackPackagesFolders_RelativePath()
        {
            // Arrange
            var config = @"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
    <fallbackPackageFolders>
        <add key=""shared"" value=""../test"" />
    </fallbackPackageFolders>
</configuration>";

            var nugetConfigPath = "NuGet.Config";
            using (var mockBaseDirectory = TestFileSystemUtility.CreateRandomTestFolder())
            {
                var subFolder = Path.Combine(mockBaseDirectory, "sub");
                var testFolder = Path.Combine(mockBaseDirectory, "test");


                ConfigurationFileTestUtility.CreateConfigurationFile(nugetConfigPath, subFolder, config);
                Settings settings = new Settings(subFolder);

                // Act
                var paths = SettingsUtility.GetFallbackPackagesFolders(settings);

                // Assert
                Assert.Equal(testFolder, paths.Single());
            }
        }

        [Fact]
        public void GetFallbackPackagesFolders_RelativePathChild()
        {
            // Arrange
            var config = @"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
    <fallbackPackageFolders>
        <add key=""shared"" value=""test"" />
    </fallbackPackageFolders>
</configuration>";

            var nugetConfigPath = "NuGet.Config";
            using (var mockBaseDirectory = TestFileSystemUtility.CreateRandomTestFolder())
            {
                var testFolder = Path.Combine(mockBaseDirectory, "test");


                ConfigurationFileTestUtility.CreateConfigurationFile(nugetConfigPath, mockBaseDirectory, config);
                Settings settings = new Settings(mockBaseDirectory);

                // Act
                var paths = SettingsUtility.GetFallbackPackagesFolders(settings);

                // Assert
                Assert.Equal(testFolder, paths.Single());
            }
        }

        [Fact]
        public void GetFallbackPackagesFolders_MultipleFoldersFromNuGetConfig()
        {
            // Arrange
            var config = @"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
    <fallbackPackageFolders>
        <add key=""d"" value=""C:\Temp\d"" />
        <add key=""b"" value=""C:\Temp\b"" />
        <add key=""c"" value=""C:\Temp\c"" />
    </fallbackPackageFolders>
</configuration>";

            var nugetConfigPath = "NuGet.Config";
            using (var mockBaseDirectory = TestFileSystemUtility.CreateRandomTestFolder())
            {
                ConfigurationFileTestUtility.CreateConfigurationFile(nugetConfigPath, mockBaseDirectory, config);
                Settings settings = new Settings(mockBaseDirectory);

                // Act
                var paths = SettingsUtility.GetFallbackPackagesFolders(settings).ToArray();

                // Assert
                Assert.Equal(3, paths.Length);
                Assert.Equal("d", Path.GetFileName(paths[0]));
                Assert.Equal("b", Path.GetFileName(paths[1]));
                Assert.Equal("c", Path.GetFileName(paths[2]));
            }
        }

        [Fact]
        public void GetFallbackPackagesFolders_MultipleFoldersFromMultipleNuGetConfigs()
        {
            // Arrange
            var configA = @"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
    <fallbackPackageFolders>
        <add key=""a"" value=""C:\Temp\a"" />
        <add key=""b"" value=""C:\Temp\b"" />
    </fallbackPackageFolders>
</configuration>";

            var configB = @"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
    <fallbackPackageFolders>
        <add key=""c"" value=""C:\Temp\c"" />
        <add key=""d"" value=""C:\Temp\d"" />
    </fallbackPackageFolders>
</configuration>";

            var configC = @"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
    <fallbackPackageFolders>
        <add key=""x"" value=""C:\Temp\x"" />
        <add key=""y"" value=""C:\Temp\y"" />
    </fallbackPackageFolders>
</configuration>";

            var nugetConfigPath = "NuGet.Config";
            using (var machineWide = TestFileSystemUtility.CreateRandomTestFolder())
            using (var mockBaseDirectory = TestFileSystemUtility.CreateRandomTestFolder())
            {
                var subFolder = Path.Combine(mockBaseDirectory, "sub");

                ConfigurationFileTestUtility.CreateConfigurationFile(nugetConfigPath, subFolder, configA);
                ConfigurationFileTestUtility.CreateConfigurationFile(nugetConfigPath, mockBaseDirectory, configB);
                ConfigurationFileTestUtility.CreateConfigurationFile(nugetConfigPath, machineWide, configC);

                var machineWiderFolderSettings = new Settings(machineWide);
                var machineWideSettings = new TestMachineWideSettings(machineWiderFolderSettings);

                var settings = Settings.LoadDefaultSettings(
                    subFolder,
                    configFileName: null,
                    machineWideSettings: machineWideSettings);

                // Act
                var paths = SettingsUtility.GetFallbackPackagesFolders(settings).ToArray();

                // Assert
                Assert.Equal(6, paths.Length);
                Assert.Equal("a", Path.GetFileName(paths[0]));
                Assert.Equal("b", Path.GetFileName(paths[1]));
                Assert.Equal("c", Path.GetFileName(paths[2]));
                Assert.Equal("d", Path.GetFileName(paths[3]));
                Assert.Equal("x", Path.GetFileName(paths[4]));
                Assert.Equal("y", Path.GetFileName(paths[5]));
            }
        }

        [Fact]
        public void GetFallbackPackagesFolders_ClearTag()
        {
            // Arrange
            var configA = @"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
    <fallbackPackageFolders>
        <clear />
        <add key=""a"" value=""C:\Temp\a"" />
        <add key=""b"" value=""C:\Temp\b"" />
    </fallbackPackageFolders>
</configuration>";

            var configB = @"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
    <fallbackPackageFolders>
        <add key=""c"" value=""C:\Temp\c"" />
        <add key=""d"" value=""C:\Temp\d"" />
    </fallbackPackageFolders>
</configuration>";

            var configC = @"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
    <fallbackPackageFolders>
        <add key=""x"" value=""C:\Temp\x"" />
        <add key=""y"" value=""C:\Temp\y"" />
    </fallbackPackageFolders>
</configuration>";

            var nugetConfigPath = "NuGet.Config";
            using (var machineWide = TestFileSystemUtility.CreateRandomTestFolder())
            using (var mockBaseDirectory = TestFileSystemUtility.CreateRandomTestFolder())
            {
                var subFolder = Path.Combine(mockBaseDirectory, "sub");

                ConfigurationFileTestUtility.CreateConfigurationFile(nugetConfigPath, subFolder, configA);
                ConfigurationFileTestUtility.CreateConfigurationFile(nugetConfigPath, mockBaseDirectory, configB);
                ConfigurationFileTestUtility.CreateConfigurationFile(nugetConfigPath, machineWide, configC);

                var machineWiderFolderSettings = new Settings(machineWide);
                var machineWideSettings = new TestMachineWideSettings(machineWiderFolderSettings);

                var settings = Settings.LoadDefaultSettings(
                    subFolder,
                    configFileName: null,
                    machineWideSettings: machineWideSettings);

                // Act
                var paths = SettingsUtility.GetFallbackPackagesFolders(settings).ToArray();

                // Assert
                Assert.Equal(2, paths.Length);
                Assert.Equal("a", Path.GetFileName(paths[0]));
                Assert.Equal("b", Path.GetFileName(paths[1]));
            }
        }
    }
}
