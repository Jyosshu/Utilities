using System;
using System.IO;

namespace Utilities
{
    public class Utilities
    {
        static DirectoryInfo _outputDirectory = null;
        public static DirectoryInfo OutputDirectory
        {
            get => _outputDirectory;
            set
            {
                _outputDirectory = value;
                if (!_outputDirectory.Exists)
                {
                    _outputDirectory.Create();
                }
            }
        }
    }
}
