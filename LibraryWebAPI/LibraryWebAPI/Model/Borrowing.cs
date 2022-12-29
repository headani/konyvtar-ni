namespace NationalInstruments.LibraryWebAPI.Model
{
    public class Borrowing
    {
        public int MemberBadgeNumber { get; set; }
        public int BookStorageNumber { get; set; }
        public DateTime BorrowingDate { get; set; }
        public DateTime EndOfBorrowing { get; set; }
    }
}
