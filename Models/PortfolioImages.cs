namespace EternaAgain.Models
{
    public class PortfolioImages
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PortfoiloId { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
