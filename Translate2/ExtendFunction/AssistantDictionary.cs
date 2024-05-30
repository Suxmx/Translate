using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translate2.ExtendFunction;

public class MyDictionary
{
    private FuzzyMatchingTool fuzzyMatcher;
    private Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
    private string keyOfDictionary = string.Empty;
    public MyDictionary()
    {
        fuzzyMatcher = new FuzzyMatchingTool();
        LoadDictionary("../../termDictionary/dictionary.txt");
    }
    private void LoadDictionary(string filePath)
    {
        try
        {
            int lineCount = 0;
            foreach(var line in File.ReadAllLines(filePath))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;
                lineCount = (lineCount + 1) % 2;
                if(lineCount == 0) //释义
                {
                    if (dictionary.ContainsKey(keyOfDictionary))
                        dictionary[keyOfDictionary] += "\r\n" + line.Trim();
                    else
                    {
                        dictionary[keyOfDictionary] = line.Trim();
                    }
                }
                else //词条 
                {
                    keyOfDictionary = line.Trim();
                }
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show($"failed loading dictionary: {ex.Message}", "Error");
        }
    }

    public string useTheDictionary(string target)
    {
        int costTime = 0;
        string resultString = SearchDictionary(target, ref costTime);
        if (resultString == target)
        {
            return dictionary[target];
        }
        else if(resultString != target)
        {
            if (resultString != null)
            {
                resultString = "你是否想找\r\n" + resultString + "\r\n" + dictionary[resultString] + $"\r\n模糊匹配用时：{costTime}ms";
                return resultString;
            }
            else
                return $"对不起，找不到该单词\r\n 匹配用时：{costTime}ms";
        }
        return null;
    }

    private string SearchDictionary(string target, ref int costTime)
    {
        if(dictionary.ContainsKey(target))
        {
            return target;
        }
        else
        {
            return fuzzyMatcher.FuzzyMatching(dictionary, target, ref costTime);
        }
    }
}