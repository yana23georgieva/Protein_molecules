using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ComparingProteinMolecules
{
    internal class Graf
    {
        private ReadOnlyCollection<string> alpha;
        private ReadOnlyCollection<string> beta;
        private ReadOnlyCollection<string> atom;
        private double[,] nodes;
        //private Dictionary<string, List<double>> nodesDict;

        /// <summary>
        /// Get data needed for creating the graf
        /// </summary>
        /// <param name="alpha">alpha spirals - helix</param>
        /// <param name="beta">beta pleated sheet</param>
        /// <param name="atom">amino acids</param>
        public Graf(ReadOnlyCollection<string> alpha, ReadOnlyCollection<string> beta, ReadOnlyCollection<string> atom)
        {
            this.alpha = alpha;
            this.beta = beta;
            this.atom = atom;
            this.nodes = new double[this.Count, this.Count];
        }

        public double[,] GrafNodes
        {
            get { return nodes; }
        }

        /// <summary>
        /// Number of elements in the graf
        /// </summary>
        public int Count => alpha.Count + beta.Count;

        /// <summary>
        /// Number of first elements(alpha) in the graf.
        /// </summary>
        public int CountAlpha => alpha.Count;

        /// <summary>
        /// Function to create graf using minimal distance between nodes
        /// </summary>
        public void CreateGraf(char mode)
        {
            int j = 0;

            for (int i = 0; i < this.Count; i++)
            {
                for (j = 0; j < this.Count; j++)
                {
                    int minFirst = 0, maxFirst = 0, minSecond = 0, maxSecond = 0;
                    if (i == j)
                    {
                        nodes[i, j] = 0;
                        continue;
                    }
                    else if (i < alpha.Count && j < alpha.Count)
                    {
                        minFirst = int.Parse(this.alpha[i].Substring(21, 4));
                        maxFirst = int.Parse(this.alpha[i].Substring(33, 4));
                        minSecond = int.Parse(this.alpha[j].Substring(21, 4));
                        maxSecond = int.Parse(this.alpha[j].Substring(33, 4));
                    }
                    else if (i < alpha.Count && j >= alpha.Count)
                    {
                        minFirst = int.Parse(this.alpha[i].Substring(21, 4));
                        maxFirst = int.Parse(this.alpha[i].Substring(33, 4));
                        minSecond = int.Parse(this.beta[j - alpha.Count].Substring(22, 4));
                        maxSecond = int.Parse(this.beta[j - alpha.Count].Substring(33, 4));
                    }
                    else if (i >= alpha.Count && j < alpha.Count)
                    {
                        minFirst = int.Parse(this.beta[i - alpha.Count].Substring(22, 4));
                        maxFirst = int.Parse(this.beta[i - alpha.Count].Substring(33, 4));
                        minSecond = int.Parse(this.alpha[j].Substring(21, 4));
                        maxSecond = int.Parse(this.alpha[j].Substring(33, 4));
                    }
                    else if (i >= alpha.Count && j >= alpha.Count)
                    {
                        minFirst = int.Parse(this.beta[i - alpha.Count].Substring(22, 4));
                        maxFirst = int.Parse(this.beta[i - alpha.Count].Substring(33, 4));
                        minSecond = int.Parse(this.beta[j - alpha.Count].Substring(22, 4));
                        maxSecond = int.Parse(this.beta[j - alpha.Count].Substring(33, 4));
                    }
                    nodes[i, j] = CalcDistance(minFirst, maxFirst, minSecond, maxSecond, mode);
                }
            }

        }

        /// <summary>
        /// Find minimal distance between two nodes
        /// </summary>
        /// <param name="first">First node</param>
        /// <param name="second">Second node</param>
        /// <returns>Minimal distance</returns>
        private double CalcDistance(int minFirst, int maxFirst, int minSecond, int maxSecond, char mode)
        {
            double result = double.PositiveInfinity;
            if (mode == '>')
            {
                result = double.NegativeInfinity;
            }

            for (int i = minFirst; i <= maxFirst; i++)
            {
                string currentFirst = this.atom.First(x => int.Parse(x.Substring(22, 4)) == i);

                for (int j = minSecond; j <= maxSecond; j++)
                {
                    string currentSecond = this.atom.First(x => int.Parse(x.Substring(22, 4)) == j);
                    double currentDistance = CalculateDistance(double.Parse(currentFirst.Substring(30, 8)), 
                        double.Parse(currentFirst.Substring(38, 8)), double.Parse(currentFirst.Substring(46, 8)),
                        double.Parse(currentSecond.Substring(30, 8)), double.Parse(currentSecond.Substring(38, 8)), 
                        double.Parse(currentSecond.Substring(46, 8)));

                    if (mode == '<' && currentDistance < result)
                    {
                        result = currentDistance;
                    }
                    else if (mode == '>' && currentDistance > result)
                    {
                        result = currentDistance;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Formula for calculating the distance between two points.
        /// </summary>
        /// <param name="x1">x for first point</param>
        /// <param name="y1">y for first point</param>
        /// <param name="z1">z for first point</param>
        /// <param name="x2">x for second point</param>
        /// <param name="y2">y for second point</param>
        /// <param name="z2">z for second point</param>
        /// <returns></returns>
        private double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
        }
    
        public string PrintGraf()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                if (i < this.CountAlpha)
                {
                    sb.Append("Alpha ");
                }
                else
                {
                    sb.Append("Beta ");
                }
                for (int j = 0; j < this.Count; j++)
                {
                    sb.Append($"{String.Format("{0:0.00000}", nodes[i, j])} ");
                }
                sb.AppendLine();
            }

            return sb.ToString().Trim();
        }
    }
}
