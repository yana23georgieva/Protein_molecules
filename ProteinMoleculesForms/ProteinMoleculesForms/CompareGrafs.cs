using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingProteinMolecules
{
    internal class CompareGrafs
    {
        private Graf first;
        private Graf second;
        private double diffMin;
        private List<string> permutations;
        private string bestFound;

        public CompareGrafs(Graf first, Graf second) 
        {
            this.first = first;
            this.second = second;
            this.diffMin = double.MaxValue;
            this.bestFound = string.Empty;
            this.permutations = new List<string>();
        }

        public double MinDiff => diffMin;
        
        public string BestFound => bestFound;

        public double CompareValue => (diffMin == double.MaxValue)?0:CountElements() / this.MinDiff;

        private void GeneratePermutations(string start, string result)
        {
            if (start.Length == 0)
            {
                permutations.Add(result);
                return;
            }

            for (int i = 0; i < start.Length; i++)
            {
                char element = start[i];
                String left_substr = start.Substring(0, i);
                String right_substr = start.Substring(i + 1);
                String rest = left_substr + right_substr;
                GeneratePermutations(rest, result + element);
            }
        }

        private int CountElements()
        {
            return Math.Min(first.CountAlpha, second.CountAlpha) +
                Math.Min((first.Count - first.CountAlpha), (second.Count - second.CountAlpha));
        }

        public void Compare()
        {
            int firstCountBeta = first.Count - first.CountAlpha;
            int secondCountBeta = second.Count - second.CountAlpha;

            if (first.CountAlpha >= second.CountAlpha && firstCountBeta >= secondCountBeta)
            {
                CalculateBestDiff(second, first, second, first);
            }
            else if (first.CountAlpha >= second.CountAlpha && firstCountBeta < secondCountBeta)
            {
                CalculateBestDiff(second, first, first, second);
            }
            else if (first.CountAlpha < second.CountAlpha && firstCountBeta >= secondCountBeta)
            {
                CalculateBestDiff(first, second, second, first);
            }
            else if (first.CountAlpha < second.CountAlpha && firstCountBeta < secondCountBeta)
            {
                CalculateBestDiff(first, second, first, second);
            }
        }

        private void GetPermutations(int start, int end)
        {
            string nodes = string.Empty;

            if (start == end)
            {
                return;
            }

            for (int i = start; i < end; i++)
            {
                nodes += i;
            }

            GeneratePermutations(nodes, string.Empty);
        }

        private void CalculateBestDiff(Graf firstAlpha, Graf secondAlpha, Graf firstBeta, Graf secondBeta)
        {
            //more alpha or equal
            GetPermutations(0, secondAlpha.CountAlpha);
            string[] permutationsAlpha = new string[permutations.Count];
            permutations.CopyTo(permutationsAlpha);
            permutations.Clear();

            //more beta or equal
            GetPermutations(secondBeta.CountAlpha, secondBeta.Count);
            string[] permutationsBeta = new string[permutations.Count];
            permutations.CopyTo(permutationsBeta);
            permutations.Clear();

            int j = (permutationsAlpha.Length > 0 && permutationsBeta.Length == 0)?-1:0;

            for (int i = 0; i < permutationsAlpha.Length || j < permutationsBeta.Length; i++)
            {
                for (; j < permutationsBeta.Length; j++)
                {
                    double sumDiff = 0;
                    bool isAny = false;
                    int[] current;

                    if (permutationsAlpha.Length > 0)
                    {
                        current = permutationsAlpha[i].ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
                        int lastAlpha = current.LastOrDefault();

                        for (int index = 0; index < firstAlpha.CountAlpha - 1; index++)
                        {
                            double currentDiff = Math.Abs(firstAlpha.GrafNodes[index, index + 1] -
                                secondAlpha.GrafNodes[current[index], current[index + 1]]);
                            sumDiff += currentDiff;
                            isAny = true;
                        }

                        if (permutationsBeta.Length > 0)
                        {
                            current = permutationsBeta[j].ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();

                            if (lastAlpha != 0 && current.Length > 0 && firstBeta.CountAlpha < firstBeta.Count)
                            {
                                double diiffAB = Math.Abs(firstBeta.GrafNodes[firstAlpha.CountAlpha - 1, firstAlpha.CountAlpha] -
                                        secondBeta.GrafNodes[lastAlpha, current[0]]);
                                sumDiff += diiffAB;
                                isAny = true;
                            }
                        }
                    }

                    if (permutationsBeta.Length > 0)
                    {
                        current = permutationsBeta[j].ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();

                        for (int index = firstBeta.CountAlpha, indxB = 0; index < firstBeta.Count - 1; index++, indxB++)
                        {
                            double currentDiff = Math.Abs(firstBeta.GrafNodes[index, index + 1] -
                                secondBeta.GrafNodes[current[indxB], current[indxB + 1]]);
                            sumDiff += currentDiff;
                            isAny = true;
                        }
                    }

                    if (sumDiff < diffMin && isAny)
                    {
                        diffMin = sumDiff;
                        bestFound = permutationsAlpha.ElementAtOrDefault(i) + permutationsBeta.ElementAtOrDefault(j);
                    }
                }
            }
        }
    }
}
