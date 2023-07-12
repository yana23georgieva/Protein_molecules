using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComparingProteinMolecules
{
    internal class ParseInfoFromFile
    {
        private string fileName;
        private List<string> alpha;
        private List<string> beta;
        private List<string> atom;
        private string[] allLines;

        /// <summary>
        /// Get file name.
        /// </summary>
        /// <param name="fileName">Name of the file with needed info.</param>
        public ParseInfoFromFile(string fileName)
        {
            this.FileName = fileName;
            this.allLines = File.ReadAllLines(FileName);
        }

        /// <summary>
        /// Check if file name is not null, empty or white space and set it.
        /// </summary>
        public string FileName
        {
            get { return fileName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("File name must not be empty!");
                }
                fileName = value; 
            }
        }

        public ReadOnlyCollection<string> Alpha
        {
            get { return alpha.AsReadOnly(); }
        }

        public ReadOnlyCollection<string> Beta
        {
            get { return beta.AsReadOnly(); }
        }

        public ReadOnlyCollection<string> Atom
        {
            get { return atom.AsReadOnly(); }
        }

        public string[] GetDifferentChains()
        {
            string[] alphas = allLines.Where(x => x.StartsWith("HELIX")).ToArray();
            string[] betas = allLines.Where(x => x.StartsWith("SHEET")).ToArray();
            List<string> chains = new List<string>();

            foreach (var item in alphas)
            {
                chains.Add(item.Substring(19, 1));
            }

            foreach (var item in betas)
            {
                chains.Add(item.Substring(21, 1));
            }

            return chains.Distinct().ToArray();
        }

        /// <summary>
        /// Read from file needed info.
        /// </summary>
        public void ReadInfo(char chain)
        {
            alpha = allLines.Where(x => x.StartsWith("HELIX") && x.ToCharArray()[19] == chain).ToList();
            beta = allLines.Where(x => x.StartsWith("SHEET") && x.ToCharArray()[21] == chain).ToList();
            atom = allLines.Where(x => x.StartsWith("ATOM") && x.ToCharArray()[21] == chain && x.Split(' ').
            Where(y => y != "").ToArray()[2] == "CA").ToList();
        }
    }
}
