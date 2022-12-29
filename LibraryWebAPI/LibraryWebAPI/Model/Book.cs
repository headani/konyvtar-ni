namespace NationalInstruments.LibraryWebAPI.Model
{
    public class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public int StorageNumber { get; set; }
        public int PublishingYear { get; set; }
    }
}
