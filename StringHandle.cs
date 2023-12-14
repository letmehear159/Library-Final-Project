using Library_Final_Project;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TF_IDF
{
    internal class StringHandle
    {
        public static Dictionary<int, string> ListOfDocumentHasKeywords(Dictionary<int, string> document, string keywords)
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            string[] keyword = keywords.Split(' ');
            foreach (var doc in document)
            {
                foreach (var key in keyword)
                {
                    if (doc.Value.Contains(key))
                    {
                        result.Add(doc.Key, doc.Value);
                        break;
                    }
                }
            }
            return result;
        }
        public int Weight { get; set; }
        public static int NumberOfWordInDocument(string doc, string wordToCount)
        {
            Regex regex = new Regex("\\b" + Regex.Escape(wordToCount) + "\\b", RegexOptions.IgnoreCase);
            return regex.Matches(doc).Count;
        }
        public static string DeletePunctuation(string str)
        {
            char rep = (char)8211;
            string annotation = ".?,(){}[]\";:\r\n\t";
            str = str.ToLower();
            for (int i = 0; i < annotation.Length; i++)
            {
                string c = annotation[i] + "";
                str = str.Replace(c, "");
            }
            str = str.Replace(rep + " ", "");
            str = str.Replace("- ", "");
            str = str.Trim();
            return str;
        }
        public static string IgnoreStopWord(string str)
        {
            string filePath = "D:\\Visual Studio\\WindownForm\\Library Final Project\\Single Stop Word.TXT";
            StreamReader reader = new StreamReader(filePath);
            string singleStopWord = reader.ReadToEnd();
            singleStopWord = singleStopWord.Replace("\r\n", " ");
            //Read from file
            reader.Close();
            filePath = "D:\\Visual Studio\\WindownForm\\Library Final Project\\Double Stop Word.TXT";
            reader = new StreamReader(filePath);
            string doubleStopWordContent = reader.ReadToEnd();
            //Read from file
            string[] doubleStopWord = doubleStopWordContent.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            //Turn to list string splitted by line
            reader.Close();
            string[] text = str.Split();
            var ignoreSingle = (
                from word in text
                where singleStopWord.Contains(word) == false
                select word
               ).ToList();
            //Delete single stop word and turn to list
            str = string.Join(" ", ignoreSingle);
            //join list to a string 
            foreach (var s in doubleStopWord)
            {
                str.Replace(" " + s, "");
            }
            //Delete double stop word
            return str;
        }
        public static string StandardString(string str)
        {
            str = DeletePunctuation(str);
            str = IgnoreStopWord(str);
            return str;
        }
        public static Dictionary<string, float> FindIDF(string keywords, Dictionary<int, string> doc)
        {
            string[] text = keywords.Split();
            Dictionary<string, float> dict = new Dictionary<string, float>();
            foreach (var s in text)
            {
                int docAppearTimes = 0;
                //Reckon the number of document contain keywords.
                foreach (var content in doc)
                {
                    if (content.Value.Contains(s))
                    {
                        docAppearTimes++;
                    }
                }

                if (docAppearTimes > 0)
                {
                    if (!dict.ContainsKey(s))
                    {
                        float c = doc.Count / ((float)docAppearTimes);
                        c = (float)Math.Log(c);
                        dict.Add(s, c);
                    }

                }
                //If the aperrancetimes>0 then divide normally.
                else
                {
                    if (!dict.ContainsKey(s))
                        dict.Add(s, 0f);
                }
                // value =0

            }
            return dict;
        }
        public static int WordCountInAString(string str)
        {
            int count = 0;
            foreach (var s in str.Split())
            {
                count++;
            }
            return count;

        }
        public static float FindTF(string keywords, string doc)
        {
            if (!doc.Contains(keywords))
                return 0;
            int num = NumberOfWordInDocument(doc, keywords);
            //Number of keyword in document
            int total = WordCountInAString(doc);
            //Number of word in document
            float f = (float)num / total;
            return f;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="keywords"></param> Key word we input in
        /// <param name="document"></param> List of all summary of all book
        /// <returns></returns>
        public static Dictionary<int, Dictionary<string, float>> FindTF(string keywords, Dictionary<int, string> document)
        {
            string[] text = keywords.Split();
            //Split the keywords

            Dictionary<int, Dictionary<string, float>> d = new Dictionary<int, Dictionary<string, float>>();
            //Used to stored id book and each of book has dictionary of keyword and it's respective tf
            foreach (var doc in document)
            {
                Dictionary<string, float> clone = new Dictionary<string, float>();
                //Contain each keyword with respective tf
                foreach (var s in text)
                {
                    if (clone.ContainsKey(s))   //if dictionary has this key then stop to add the other same 
                        continue;
                    float f = FindTF(s, doc.Value);
                    //Find tf of specific keyword 

                    clone.Add(s, f);
                    //add it to dictionary 

                }
                d.Add(doc.Key, clone);
                //A list of dictionary with list of keyword and their respective tf
            }
            return d;
        }
        public static Dictionary<int, float> CompleteTF_IDF(string keywords, Dictionary<int, Dictionary<string, float>> TF, Dictionary<string, float> IDF)
        {
            Dictionary<int, float> result = new Dictionary<int, float>();
            Dictionary<int, Dictionary<string, float>> cloneTF = new Dictionary<int, Dictionary<string, float>>();
            foreach (var doc in TF)
            {
                Dictionary<string, float> cloneChildDoc = new Dictionary<string, float>();
                foreach (var childDoc in doc.Value)
                {
                    //doc.Value[childDoc.Key] = childDoc.Value * IDF[childDoc.Key];
                    float value = childDoc.Value * IDF[childDoc.Key];
                    cloneChildDoc.Add(childDoc.Key, value);
                }
                cloneTF.Add(doc.Key, cloneChildDoc);
                //Each of float value in TF contain tf of each keyword will be multipled with IDF into complete tf-idf.
            }
            // Now we have complete tf-idf of each keyword, then we need to find the total weight of each document
            foreach (var d in cloneTF)
            // int,dictonary :1
            {
                float total = 0;
                foreach (var sd in d.Value)
                // each of string, float
                {
                    total += sd.Value;
                    //Plus all tf-idf of keywords.
                }
                if (total != 0)
                    result.Add(d.Key, total);

            }
            return result;

        }
        public static List<int> SearchByContentSummary(LibraryEntities _db, string keywords)
        {
            Dictionary<int, string> doc = new Dictionary<int, string>();
            //Dictionnary of 50 content summary book with ISBN and it's content(Currently empty)

            var books = (
                from book in _db.Books
                where book.Show == true
                select new
                {
                    ISBN = book.ISBN,
                    comment = book.ContentSummary.ContentBook
                }).ToList();
            //Select book from database which is showed(not be hiden in the library)

            foreach (var book in books)
            {
                string handledContent = StandardString(book.comment);
                //Delete punctuation and stopwords of each book's content summary
                doc.Add(book.ISBN, handledContent);
                //Add each book's ISBN and content summary to dictionary
            }
            keywords = DeletePunctuation(keywords);
            //Delete punctuation and lower the keywords

            Dictionary<int, string> hasKeywords = ListOfDocumentHasKeywords(doc, keywords);
            //List of book has one or more keyword in the content summary

            Dictionary<string, float> idf = FindIDF(keywords, doc);
            //Find the IDF of each keyword

            Dictionary<int, Dictionary<string, float>> tf = FindTF(keywords, hasKeywords);
            //Find the TF of each keyword

            Dictionary<int, float> completeTF_IDF = CompleteTF_IDF(keywords, tf, idf);
            //Mutilple each tf-idf then sum of all keyword's tf-idf and get the final weight of each book

            var sorted = completeTF_IDF.OrderByDescending(q => q.Value);
            //Sort the booklist descending

            List<int> searchResult = new List<int>();
            foreach (var book in sorted)
            {
                searchResult.Add(book.Key);
            }
            //Create a list store desceding ISBN of book

            return searchResult;
            //return this list
        }

        public static List<int> SearchByTitle(LibraryEntities _db, string keywords)
        {
            Dictionary<int, string> doc = new Dictionary<int, string>();
            //Dictionnary of 50 content summary book with ISBN and it's content(Currently empty)

            var books = (
                from book in _db.Books
                where book.Show == true
                select new
                {
                    ISBN = book.ISBN,
                    Title = book.Title,
                }).ToList();
            //Select book from database which is showed(not be hiden in the library)

            foreach (var book in books)
            {
                string handledTitle = DeletePunctuation(book.Title);
                //Delete punctuation and redundant space of each book's title
                doc.Add(book.ISBN, handledTitle);
                //Add each book's ISBN and title to dictionary
            }
            keywords = DeletePunctuation(keywords);
            //Delete punctuation and lower the keywords

            Dictionary<int, string> hasKeywords = ListOfDocumentHasKeywords(doc, keywords);
            //List of book has one or more keyword in the title

            Dictionary<string, float> idf = FindIDF(keywords, doc);
            //Find the IDF of each keyword

            Dictionary<int, Dictionary<string, float>> tf = FindTF(keywords, hasKeywords);
            //Find the TF of each keyword

            Dictionary<int, float> completeTF_IDF = CompleteTF_IDF(keywords, tf, idf);
            //Mutilple each tf-idf then sum of all keyword's tf-idf and get the final weight of each book

            var sorted = completeTF_IDF.OrderByDescending(q => q.Value);
            //Sort the booklist descending

            List<int> searchResult = new List<int>();
            foreach (var book in sorted)
            {
                searchResult.Add(book.Key);
            }
            //Create a list store desceding ISBN of book

            return searchResult;
            //return this list
        }
    }
}
