using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace Group1_comp123_Assignment3
{
    class Tweet
    {
        //So I think the point of this program is to make an object for every tweet in the file
        //aderson sent us, save them in a json and read the json file back.
        //easy peasy

        private static int currentId = 1;

        public int Id { get; set; }//Represents the unique identification of the tweet
        public string From { get; set; }//represents the originator of the tweet
        public string To { get; set; }//represents the intended recipient of the tweet
        public string Message { get; set; }//represents the actual message in the tweet
        public string Hashtag { get; set; }//represents the hashtags used in the tweet

        public Tweet(string from, string to, string message, string hashtag)
        {
            //1.7 a.
            From = from;
            To = to;
            Message = message;
            Hashtag = hashtag;
            //1.7 b:
            Id = currentId;
            //1.7 c:
            currentId++;
        }
        public override string ToString()
        {
            string messagePart = Message.Substring(0, Message.Length);
            string tweetString = String.Format("{0,-2}{1,-8}{2,-8}{3,-8}");
            return tweetString;
        }
        public static Tweet Parse(string line)
        {
            //1.9 a:
            Tweet testTweet = new Tweet("", "", "", "");
            string[] tweet;
            try
            {
                tweet = line.Split(new char[] { '\t' });
                testTweet = new Tweet(from: tweet[0], to: tweet[1], message: tweet[2], hashtag: tweet[3]);
                return testTweet;
            }
            catch(IndexOutOfRangeException error)
            {
                testTweet.From = "Invalid";
                testTweet.To = "Invalid";
                testTweet.Message = "Invalid";
                testTweet.Hashtag = "Invalid";
            }
            return testTweet;
        }
    }
    class TweetManager
    {
        private static Tweet[] tweets;
        private static string fileName;

        static TweetManager()
        {
            FileStream fileStream = new FileStream(fileName);//Honestly not sure why this is wrong. I checked like 3 documentations.
            StreamReader streamReader = new StreamReader(fileStream);
            string i = streamReader.ReadLine();
            tweets = new Tweet[5];
            while (i != null)
            {
                for(int j=0; j< tweets.Length; j++)
                {
                    tweets[j] = Tweet.Parse(i);
                }
                i = streamReader.ReadLine();
            }
            streamReader.Close();
            fileStream.Close();
        }
        public static void ShowAll()
        {
            //2.4 a: (This is like the only block I got with no problems.)
            string filename = @"C:\Users\alpha\source\repos\Tweets";
            WriteLine("{0}", filename);
        }
        public static void ShowAll(string hashtag)
        {
            //2.5
            //Get the seperated file information from 2.3 or 1.9 or something
            WriteLine("{0}"/*All the tweets with a hashtag matching the argument*/);
        }
        public static void ConvertToJson()
        {
            FileStream outFile = new
                FileStream("tweets.json", FileMode.Create);
            //The rest of this fuckin block
            //i'm so goddamn tired
            //fuck it im pushing this
        }
    }
}
