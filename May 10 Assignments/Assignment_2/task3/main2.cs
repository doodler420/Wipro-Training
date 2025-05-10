using System;

namespace ConsoleApp2{
    class Program3
    {
        static void Main(string[] args)
        {
            SocialMedia sm = new SocialMedia();
            SocialMedia fb = new FacebookPost();
            SocialMedia tw = new TwitterPost();
            SocialMedia ig = new InstagramPost();
            sm.Post();
            fb.Post();
            tw.Post();
            ig.Post();
        }
    }
}
