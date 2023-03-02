namespace StreamingApi.Model
{
    public class Album
    {
        public int Views { get; set; }

        public string Name { get; set; }

        public string Cover { get; set; }

        public string Interpret { get; set; }

        public string Genres { get; set; }

        /// <summary>
        /// List of Music Titels
        /// </summary>
        public List<Title> Title { get; set; }
    }
}
