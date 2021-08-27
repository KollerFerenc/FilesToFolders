using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using CommandDotNet;
using System.IO;
using System.Threading;

namespace FilesToFolders
{
    public class FileSorter
    {
        public CancellationToken CancellationToken { get; init; } = new CancellationToken();

        public FileSorter()
        {
            
        }

        public FileSorter(CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
        }

        [Command(
            Name = "sort",
            Description = "Sort files with the same name into folders.")]
        public void Sort(
            [Operand(
                Description = "Directory to sort.")]
            string pathToDirectory,
            [Option(
                LongName = "searchPattern",
                ShortName = "p",
                Description = "Search pattern (e.g.: *.txt|*.pdf)")]
            string searchPattern = "*.*",
            [Option(
                LongName = "trimText",
                Description = "Text to trim.")]
            string trimText = "",
            [Option(
                LongName = "trimDirection",
                Description="Trim from the left.")]
            TrimDirection trimDirection = TrimDirection.Left)
        {
            List<string> fileNames = new(16);
            
            foreach (string f in GetFiles(pathToDirectory, searchPattern.Split('|'), SearchOption.TopDirectoryOnly)
                .TakeWhile(x => !CancellationToken.IsCancellationRequested))
            {
                try
                {
                    fileNames.Add(Path.GetFullPath(f));
                }
                catch (Exception)
                {

                }
            }
            
            foreach (string f in fileNames
                .TakeWhile(x => !CancellationToken.IsCancellationRequested))
            {
                try
                {
                    Directory.CreateDirectory(Path.Combine(pathToDirectory, TrimText(f, trimText, trimDirection)));
                }
                catch (Exception)
                {
                    Log.Error($"Could not create directory for { f }.");
                    fileNames.Remove(f);
                }
            }
            
            foreach (string f in fileNames
                .TakeWhile(x => !CancellationToken.IsCancellationRequested))
            {
                try
                {
                    File.Move(f, Path.Combine(pathToDirectory, TrimText(f, trimText, trimDirection), Path.GetFileName(f)));
                }
                catch (Exception)
                {
                    Log.Error($"Could not move { f }.");
                }
            }
        }


        private static string TrimText(string input, string separator, TrimDirection trim)
        {
            try
            {
                input = Path.GetFileNameWithoutExtension(input);

                if (string.IsNullOrWhiteSpace(separator) || string.IsNullOrEmpty(separator))
                {
                    return input;
                }
                else if (input.Contains(separator))
                {
                    switch (trim)
                    {
                        case TrimDirection.Right:
                            return input.Substring(0, input.IndexOf(separator));
                        case TrimDirection.Left:
                            return input.Substring(input.IndexOf(separator) + 1);
                        default:
                            goto case TrimDirection.Right;
                    }
                }
                else
                {
                    return input;
                }
            }
            catch (Exception)
            {
                return Path.GetFileNameWithoutExtension(input);
            }
        }

        private static string[] GetFiles(string path, IEnumerable<string> searchPatterns, SearchOption searchOption)
        {
            if (searchPatterns.Contains("*.*"))
            {
                return Directory.GetFiles(path, "*.*", searchOption);
            }

            List<string> output = new(16);

            foreach (var pattern in searchPatterns)
            {
                var temp = Directory.GetFiles(path, pattern, searchOption);

                if (temp.Length > 0)
                {
                    output.AddRange(temp);
                }
            }

            return output.ToArray();
        }
    }

    public enum TrimDirection
    {
        Right = 0,
        Left = 1
    }
}
