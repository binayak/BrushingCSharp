namespace BrushingOffCSharp
{
    using System;
    using System.IO;

    /// <summary>
    /// The practical recursion example.
    /// Here we are printing out the names of the files and directories sat in a hierarchy.
    /// e.g.
    /// Directory1
    /// - File1
    /// - File2
    /// - Directory2
    ///   - File 3
    ///   - File 4
    ///   - Directory 3
    ///     - File 5
    ///     - File 6
    ///     - Directory 4
    ///       - File 7
    ///       - File 8 
    /// </summary>
    public class PracticleRecursionExample
    {
        /// <summary>
        /// The main for practical recursion example.
        /// </summary>
        public static void MainForPracticleRecursionExample()
        {
            FindFiles("C:\\testFiles");
        }

        /// <summary>
        /// The find files.
        /// </summary>
        /// <param name="path">
        /// The path.
        /// </param>
        public static void FindFiles(string path)
        {
            foreach (string filename in Directory.GetFiles(path))
            {
                Console.WriteLine(filename);
            }

            foreach (string directory in Directory.GetDirectories(path))
            {

                Console.WriteLine("The name of the directory is: {0}",directory);
                FindFiles(directory); // Functiona calling itself inorder to look for files and directories inside.
                
            }
        }
    }
}
