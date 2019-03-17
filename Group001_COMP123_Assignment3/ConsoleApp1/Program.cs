using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweet;
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

        }
    }
    class TweetManager
    {
        //I managed to get the Tweet[] array here without the red underline
        private static Tweet.Tweet[] tweets;
        private static string fileName;

        static TweetManager()
        {

        }
        //Displays all tweets
        public static void ShowAll()
        {

        }
        //Displays all the tweets with the same tag
        public static void ShowAll(string hashtag)
        {

        }
        //Serialize the array of tweets and saves them to a file called tweets.json
        public static void ConvertToJson()
        {

        }
    }
}
