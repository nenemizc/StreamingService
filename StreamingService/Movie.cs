using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingService
{
    public class Movie : IContent
    {
        private Video video;

        public Movie(Video video)
        {
            this.video = video;
        }

        public string GetTitle()
        {
            return video.Title;
        }

        public int GetLength()
        {
            return video.Length;
        }
    }
}
