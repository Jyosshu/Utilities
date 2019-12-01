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

        static DirectoryInfo _inputDirectory = null;
        public static DirectoryInfo InputDirectory
        {
            get => _inputDirectory;
            set
            {
                _inputDirectory = value;
                if (!_inputDirectory.Exists)
                {
                    throw new FileNotFoundException($"{_inputDirectory} was not found.");
                }
            }
        }

        public static FileInfo GetFileInfo(string file, bool deleteIfExists)
        {
            var fileInfo = new FileInfo(OutputDirectory.FullName + Path.DirectorySeparatorChar + file);
            if(deleteIfExists && fileInfo.Exists)
            {
                fileInfo.Delete();
            }
            return fileInfo;
        }

        internal static DirectoryInfo GetDirectoryInfo(string directory)
        {
            var directoryInfo = new DirectoryInfo(_outputDirectory.FullName + Path.DirectorySeparatorChar + directory);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            return directoryInfo;
        }
    }
}
