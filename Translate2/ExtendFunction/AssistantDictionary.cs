using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translate2.ExtendFunction;

public class MyDictionary
{
    private FuzzyMatchingTool fuzzyMatcher;
    private Dictionary<string, string> dictionary = new Dictionary<string, string>();
    private string keyOfDictionary = null;
    public MyDictionary()
    {
        LoadDictionary("../TermDictionary/dictionary");
    }
    private void LoadDictionary(string filePath)
    {
        try
        {
            int lineCount = 0;
            foreach(var line in File.ReadAllLines(filePath))
            {
                lineCount = (lineCount + 1) % 2;
                if(lineCount == 0) //释义
                {
                    dictionary[keyOfDictionary] = line.Trim();
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
        string resultString = SearchDictionary(target);
        if(resultString == null)
        {
            return "找不到目标词汇，请检查拼写";
        }
        if (resultString == target)
            return dictionary[target];
        else
            return "你是否想找\n" + dictionary[resultString];
    }

    private string SearchDictionary(string target)
    {
        if(dictionary.ContainsKey(target))
        {
            return target;
        }
        else
        {
            return fuzzyMatcher.FuzzyMatching(dictionary, target);
        }
    }
}