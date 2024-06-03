using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translate2.ExtendFunction;

namespace Translate2.AssistantDictionary
{
    public class MyDictionary
    {
        private FuzzyMatchingTool fuzzyMatcher;
        private Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private string keyOfDictionary = string.Empty;
        public MyDictionary()
        {
            // string currentDirectory = Directory.GetCurrentDirectory();
            // MessageBox.Show("Current Directory: " + currentDirectory);

            fuzzyMatcher = new FuzzyMatchingTool();
            LoadDictionary("../../termDictionary/dictionary.txt");
        }
        private void LoadDictionary(string filePath)
        {
            try
            {
                // 词典读取逻辑，待修改
                int lineCount = 0;
                foreach (var line in File.ReadAllLines(filePath))
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;
                    lineCount = (lineCount + 1) % 2;
                    if (lineCount == 0) //释义
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
            catch (Exception ex)
            {
                MessageBox.Show($"failed loading dictionary: {ex.Message}", "Error");
            }
            // MessageBox.Show($"the size is : {dictionary.Count}");
        }

        public string UseTheDictionary(string target)
        {
            int costTime = 0;
            string resultString = SearchDictionary(target, ref costTime);
            if (resultString == target)
            {
                return dictionary[target];
            }
            else if (resultString != target)
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
            if (dictionary.ContainsKey(target))
            {
                return target;
            }
            else
            {
                return fuzzyMatcher.FuzzyMatching(dictionary, target, ref costTime);
            }
        }
    }
    public class DataReader
    {
        private string _filePath;
        private string _stringContent;

        public DataReader()
        {
        }

        public DataReader(string filePath)
        {
            _filePath = filePath;
        }

        public DataReader FromFile(string filePath)
        {
            _filePath = filePath;
            return this;
        }

        public DataReader FromString(string content)
        {
            _stringContent = content;
            return this;
        }

        public void ReadString()
        {
            if (string.IsNullOrEmpty(_stringContent))
            {
                Console.WriteLine("No string content to read.");
                return;
            }

            Console.WriteLine("Reading from string:");
            using (StringReader reader = new StringReader(_stringContent))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public void ReadFile()
        {
            if (string.IsNullOrEmpty(_filePath))
            {
                Console.WriteLine("No file path specified.");
                return;
            }

            Console.WriteLine("Reading from file:");
            try
            {
                using (StreamReader reader = new StreamReader(_filePath, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File not found: {e.Message}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An I/O error occurred: {e.Message}");
            }
        }

        public void GenerateTestFile()
        {
            if (string.IsNullOrEmpty(_filePath))
            {
                Console.WriteLine("No file path specified for generating test file.");
                return;
            }

            using (StreamWriter writer = new StreamWriter(_filePath, false, Encoding.UTF8))
            {
                writer.WriteLine("This is a test file.");
                writer.WriteLine("It contains multiple lines of text.");
                writer.WriteLine("Each line will be read and displayed on the console.");
                writer.WriteLine("This is the end of the file.");
            }
        }

        public void ProcessData(string data)
        {
            Console.WriteLine("Processing data:");
            string[] words = data.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        public string ReadFileToString()
        {
            if (string.IsNullOrEmpty(_filePath))
            {
                Console.WriteLine("No file path specified.");
                return string.Empty;
            }

            try
            {
                using (StreamReader reader = new StreamReader(_filePath, Encoding.UTF8))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
                return string.Empty;
            }
        }

        public void ReadAndProcessFile()
        {
            string content = ReadFileToString();
            if (!string.IsNullOrEmpty(content))
            {
                ProcessData(content);
            }
        }
    }
}