using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FuzzySharp;
using FuzzySharp.SimilarityRatio;

namespace Translate2.ExtendFunction
{
    public class FuzzyMatchingTool
    {
        const int threshold = 90;
        internal string FuzzyMatching(Dictionary<string, string> dictionary, string target)
        {
            foreach(var keyValue in dictionary.Keys)
            {
                int ratio = Fuzz.Ratio(keyValue, target);
                if(ratio >= threshold)
                {
                    return keyValue;
                }
            }
            return null;
        }
    }
}
