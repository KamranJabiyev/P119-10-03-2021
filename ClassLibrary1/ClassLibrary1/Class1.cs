using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Message
    {
        public string Title { get; set; }
        internal string Text { get; set; }
        protected internal int MessageCount;

        private protected int LikeCount;
    }

    public class Email:Message
    {
        /// <summary>
        /// Message textini ve sayini gosterir
        /// </summary>
        /// <param name="str">String tipinden params</param>
        public void Showtext(string str)
        {
            LikeCount = 100;
            MessageCount = 10;
            Text = "sdgs";
            Console.WriteLine(Text+" "+ MessageCount+" "+LikeCount);
        }
    }

    class Test
    {
        public Test()
        {
            Message message = new Message();
            message.MessageCount = 10;
        }
    }
}
