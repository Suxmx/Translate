using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FuzzySharp;
using System.Windows.Forms;

public class MyDictionary
{
    private Dictionary<string, string> dictionary = new Dictionary<string, string>();
    private string keyOfDictionary = null;
    public MyDictionary()
    {
        loadDictionary("TermDictionary.txt");
    }
    private void loadDictionary(string filePath)
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
}