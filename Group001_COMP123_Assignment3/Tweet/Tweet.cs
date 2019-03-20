using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Runtime;

/* Okay, so I was looking over your version and at the assignment, and I think he wants us to have the Tweet class and TweetManager class separated, where the TweetManager class
 * is with the Program class. Hopefully I was able to put it in a way to make it easy for you to read. (Formatting is not my forte)
 * So far, I've only reorganized the classes so that it fits the assignment requirements, I'm still working on the other parts. Ill push this for now though.
 */
namespace Tweeting
{
    public class Tweet
    {
        private int currentID = 1;

        public int Id { get; set; }//Tweet ID
        public string From { get; set; }//Tweet Sender
        public string To { get; set; }//Tweet Recipient
        public string Message { get; set; }//Tweet Message
        public string Hashtag { get; set; }//Tweet Tags

        //Constructor that assigns the parameters to the properties
        public Tweet(string from, string to, string message, string hashtag)
        {            
            From = from;
            To = to;
            Message = message;
            Hashtag = hashtag;
            Id = currentID;
            currentID++;
        }
        //Overrides the original ToString() method to create our own
        public override string ToString()
        {
            string messagePart = Message.Substring(0, Message.Length);
            string tweetString = String.Format("{0,-2}{1,-8}{2,-8}{3,-8}");
            return tweetString;
        }
        //
        public static Tweet Parse(string line)
        {
            Tweet newTweet = new Tweet("", "", "", "");
            string[] testTweet;

            try
            {
                testTweet = line.Split(new char[] { '\t' });
                newTweet = new Tweet(from: testTweet[0], to: testTweet[1], message: testTweet[2], hashtag: testTweet[3]);
                return newTweet;
                
            }
            catch (IndexOutOfRangeException)
            {
                newTweet.From = "Invalid";
                newTweet.To = "Invalid";
                newTweet.Message = "Invalid";
                newTweet.Hashtag = "Invalid";
            }
            return newTweet;
        }
    }
}
