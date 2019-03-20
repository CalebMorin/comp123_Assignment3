using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Runtime;

/* Names: Michael Tran & Caleb Morin
 * Course: COMP123-008
 * Professor: Aderson Oliveira
 * Date: March 20th, 2019
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
            string tweetString = "This is a part of the tweet:" + messagePart;
            return tweetString;
        }
        //This takes a tweet, divides it into 4 and creates a new tweet
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
