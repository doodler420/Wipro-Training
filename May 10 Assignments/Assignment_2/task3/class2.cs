using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SocialMedia
    {
        public virtual void Post()
        {
            Console.WriteLine("Posting on social media");
        }
    }

    class FacebookPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Posting on Facebook");
        }
    }

    class TwitterPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Posting on Twitter");
        }
    }

    class InstagramPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Posting on Instagram");
        }
    }
}
