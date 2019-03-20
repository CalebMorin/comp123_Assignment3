using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweeting;
using System.IO;
using static System.Console;
using System.Web.Script.Serialization;

namespace Program
{
    class Program
    {
        //This is where we TEST our program
        static void Main(string[] args)
        {
            TweetManager.ConvertToJson();
            ReadKey();
        }
    }
    class TweetManager
    {
        //I managed to get the Tweet[] array here without the red underline
        private static Tweet[] tweets;
        private static string fileName;

        static TweetManager()
        {
            FileStream fileStream = new FileStream("D:/Centennial/COMP123/Group001_COMP123_Assignment3/tweets.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);           
            tweets = new Tweet[29];
            string line = streamReader.ReadLine();
            while(line != null)
            {
                for(int i=0; i<tweets.Length; i++)
                {
                    tweets[i] = Tweet.Parse(line);
                }
                line = streamReader.ReadLine();
            }
        }
        //Displays all tweets
        public static void ShowAll()
        {
            fileName = @"tweets.txt";
            foreach (string line in File.ReadAllLines("D:/Centennial/COMP123/Group001_COMP123_Assignment3/tweets.txt"))
            {
                WriteLine(line);
            }
        }
        //Displays all the tweets with the same tag
        public static void ShowAll(string hashtag)
        {
            fileName = @"tweets.txt";
            foreach (string line in File.ReadAllLines("D:/Centennial/COMP123/Group001_COMP123_Assignment3/tweets.txt"))
            {
                if (line.Contains(hashtag))
                    WriteLine(line);
            }
        }
        //Serialize the array of tweets and saves them to a file called tweets.json
        public static void ConvertToJson()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            FileStream fileStream = new FileStream("D:/Centennial/COMP123/Group001_COMP123_Assignment3/tweets.json", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            List<string> allTweets = new List<string>();

            foreach (string line in File.ReadAllLines("D:/Centennial/COMP123/Group001_COMP123_Assignment3/tweets.txt"))
            {
                allTweets.Add(line);
            }

            streamWriter.Write(serializer.Serialize(allTweets));

            streamWriter.Close();
            fileStream.Close();
        }
    }
}
