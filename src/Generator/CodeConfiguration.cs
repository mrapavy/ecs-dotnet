using System.IO;

namespace Generator
{
    public static class CodeConfiguration
    {
        private static string _root;

        private static string Root
        {
            get
            {
                if (_root != null) return _root;

                var directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());

                var runningAsDnx =
                    directoryInfo.Name == "Generator" &&
                    directoryInfo.Parent != null &&
                    directoryInfo.Parent.Name == "ECS";

                _root = runningAsDnx ? "" : @"..\";
                return _root;
            }
        }

        public static string SpecificationFolder { get; } = $@"{Root}Specification\";
        public static string ViewFolder { get; } = $@"{Root}Generator\Views\";
        
        public static string GeneratedFolder { get; } = $@"{Root}ECSDotnet\";
    }
}