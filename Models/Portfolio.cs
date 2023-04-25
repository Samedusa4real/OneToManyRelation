namespace EternaAgain.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string BgImg { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
    }
}
