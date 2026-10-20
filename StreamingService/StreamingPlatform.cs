using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingService
{
    public class StreamingPlatform
    {
        private List<IContent> contents;

        public StreamingPlatform()
        {
            contents = new List<IContent>();
        }

        public void AddContent(IContent content)
        {
            contents.Add(content);
        }

        public IContent GetLongestContent()
        {
            if (contents.Count == 0)
            {
                return null;
            }

            IContent longest = contents[0];
            foreach (var content in contents)
            {
                if (content.GetLength() > longest.GetLength())
                {
                    longest = content;
                }
            }

            return longest;
        }
    }
}
