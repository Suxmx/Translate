using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FuzzySharp;
using FuzzySharp.SimilarityRatio;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Translate2.ExtendFunction
{
    public class FuzzyMatchingTool
    {
        const int threshold = 85;
        

        public class StringSimilarity
        {
            // 计算两个字符串的编辑距离（Levenshtein距离）
            public int ComputeEditDistance(string s1, string s2)
            {
                int len1 = s1.Length;
                int len2 = s2.Length;
                int[,] dp = new int[len1 + 1, len2 + 1];

                // 初始化边界条件
                for (int i = 0; i <= len1; i++)
                {
                    dp[i, 0] = i;
                }
                for (int j = 0; j <= len2; j++)
                {
                    dp[0, j] = j;
                }

                // 动态规划计算编辑距离
                for (int i = 1; i <= len1; i++)
                {
                    for (int j = 1; j <= len2; j++)
                    {
                        int cost = (s1[i - 1] == s2[j - 1]) ? 0 : 1;
                        dp[i, j] = Math.Min(Math.Min(dp[i - 1, j] + 1, dp[i, j - 1] + 1), dp[i - 1, j - 1] + cost);
                    }
                }

                return dp[len1, len2];
            }


            // 基于编辑距离计算字符串相似度（0.0到1.0之间）
            public double ComputeSimilarity(string s1, string s2)
            {
                int editDistance = ComputeEditDistance(s1, s2);
                int maxLen = Math.Max(s1.Length, s2.Length);

                if (maxLen == 0)
                {
                    return 1.0; // 两个空字符串被认为是完全相似
                }

                return 1.0 - (double)editDistance / maxLen;
            }
        }

            internal string FuzzyMatching(Dictionary<string, string> dictionary, string target, ref int costTime)
        {
            int startTime = Environment.TickCount;
            int maxRatio = 0;
            string resultString = null;
            foreach(var keyValue in dictionary.Keys)
            {
                int ratio = Fuzz.Ratio(keyValue.ToLower(), target.ToLower());
                if(ratio > maxRatio)
                {
                    maxRatio = ratio;
                    resultString = keyValue;
                }
            }
            int endTime = Environment.TickCount;
            costTime = endTime - startTime;
            if(maxRatio < threshold)
                return null;
            else
                return resultString;
        }
    }
}
