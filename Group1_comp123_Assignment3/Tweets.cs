using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1_comp123_Assignment3
{
    class Tweets
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

        }
        public override string ToString()
        {

        }
        public static Tweet Parse(string line)
        {
            
        }
    }
    class TweetManager
    {
        private static Tweet[] tweets;
        private static string fileName;

        static TweetManager()
        {
            
        }
        public static void ShowAll()
        {

        }
        public static void ShowAll(string hashtag)
        {

        }
        public static void ConvertToJson()
        {

        }
    }
}
