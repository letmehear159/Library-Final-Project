﻿using Library_Final_Project;
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
            return str;
        }
        public static string IgnoreStopWord(string str)
        {
            string filePath = "D:/Single Stop Word.TXT";
            StreamReader reader = new StreamReader(filePath);
            string singleStopWord = reader.ReadToEnd();
            singleStopWord = singleStopWord.Replace("\r\n", " ");
            //Read from file
            reader.Close();
            filePath = "D:/Double Stop Word.TXT";
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
                //Đếm số văn bản chứa keywords
                foreach (var content in doc)
                {
                    if (content.Value.Contains(s))
                    {
                        docAppearTimes++;
                    }
                }

                if (docAppearTimes > 0)
                {
                    float c = doc.Count / ((float)docAppearTimes);
                    c = (float)Math.Log(c);
                    dict.Add(s, c);
                }
                //Nếu số lần xuất hiện lớn hơn 0 thì chia như thường 
                else
                {
                    dict.Add(s, 0f);
                }
                //Cho value =0

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
        /// <param name="keywords"></param> Key word chúng ta nhập vào
        /// <param name="document"></param> Tuyển tập tất cả nội dung của các sách
        /// <returns></returns>
        public static Dictionary<int, Dictionary<string, float>> FindTF(string keywords, Dictionary<int, string> document)
        {
            string[] text = keywords.Split();
            //Tách các keywords

            Dictionary<int, Dictionary<string, float>> d = new Dictionary<int, Dictionary<string, float>>();
            //dùng để chứa mỗi id sách và mỗi sách có chứa dictionary về mỗi keyword với tf riêng của nó
            foreach (var doc in document)
            {
                Dictionary<string, float> clone = new Dictionary<string, float>();
                //Chứa mỗi keyword với tf riêng của nó
                foreach (var s in text)
                {
                    float f = FindTF(s, doc.Value);
                    //Tìm tf của keyword cụ thể
                    clone.Add(s, f);
                    //Thêm nó vào dictionary
                }
                d.Add(doc.Key, clone);
                //Tuyển tập dictionary với tập hợp các keyword với tf riêng của nó
            }
            return d;
        }
        public static Dictionary<int, float> CompleteTF_IDF(string keywords, Dictionary<int, Dictionary<string, float>> TF, Dictionary<string, float> IDF)
        {
            Dictionary<int, float> result = new Dictionary<int, float>();
            foreach (var d in TF)
            {
                foreach (var sd in d.Value)
                {
                    d.Value[sd.Key] = sd.Value * IDF[sd.Key];
                }
                //Mỗi cái float trong TF chứa tf của mỗi keyword sẽ được nhân với IDF lúc đó sẽ ra tf-idf hoàn thiện
            }
            // bây giờ là đã có tf-idf hoàn thiện của mỗi keyword, việc quan trọng là với mỗi document thì phải tìm ra tích các trọng số của các từ 
            foreach (var d in TF)
            // int,dictonary :1
            {
                float total = 1;
                bool check = false;
                foreach (var sd in d.Value)
                // mỗi thằng string, float trong đó
                {
                    if (sd.Value != 0)
                    {
                        check = true;
                        total *= sd.Value;
                        //Nhân tất cả tf idf của các keyword lại (điều kiện là phải khác 0)
                    }
                }
                if (check) //if there exists any keyword's tf-idf!=0
                    result.Add(d.Key, total);
                else
                {
                    result.Add(d.Key, 0);
                }
            }
            return result;

        }
        public static List<int> CompleteTF_IDF(LibraryEntities _db, string keywords)
        {
            Dictionary<int, string> doc = new Dictionary<int, string>();
            var books = (
                from book in _db.Books
                where book.Show == true
                select new
                {
                    ISBN = book.ISBN,
                    comment = book.ContentSummary.ContentBook
                }).ToList();
            foreach (var book in books)
            {
                string handledContent = StandardString(book.comment);
                doc.Add(book.ISBN, handledContent);
            }
            keywords = DeletePunctuation(keywords);
            Dictionary<int, string> hasKeywords = ListOfDocumentHasKeywords(doc, keywords);
            Dictionary<string, float> idf = FindIDF(keywords, doc);
            Dictionary<int, Dictionary<string, float>> tf = FindTF(keywords, hasKeywords);
            Dictionary<int, float> completeTF_IDF = CompleteTF_IDF(keywords, tf, idf);
            var sorted = completeTF_IDF.OrderByDescending(q => q.Value);
            List<int> searchResult = new List<int>();
            foreach (var book in completeTF_IDF)
            {
                searchResult.Add(book.Key);
            }
            return searchResult;
        }
    }
}
