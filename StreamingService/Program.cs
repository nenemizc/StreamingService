namespace StreamingService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video("Skibidi toilet", 20);
            Video ep1 = new Video("Smiling friends ep1", 20);
            Video ep2 = new Video("Smiling friends ep2", 22);
            Video ep3 = new Video("Smiling friends ep3", 18);

            Movie movie = new Movie(video);
            Series series = new Series("Smiling friends", new List<Video> { ep1, ep2, ep3 });

            StreamingPlatform platform = new StreamingPlatform();
            platform.AddContent(movie);
            platform.AddContent(series);

            IContent longest = platform.GetLongestContent();

            if (longest != null)
            {
                Console.WriteLine($"A leghosszabb tartalom: {longest.GetTitle()} ({longest.GetLength()} perc)");
            }
        }
    }
}
