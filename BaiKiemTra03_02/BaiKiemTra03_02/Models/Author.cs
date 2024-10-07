namespace BaiKiemTra03_02.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Nationality { get; set; }
        public int BirthYear { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
