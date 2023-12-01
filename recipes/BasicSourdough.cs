namespace recipes
{
    public class BasicSourdough
    {
        private const int _baseRecipeTotal = 1685;
        
        private const decimal _wholemealFlourRatio = 150/_baseRecipeTotal;
        private const decimal _plainFlourRatio = 750/_baseRecipeTotal;
        private const decimal _saltRatio = 25/_baseRecipeTotal;
        private const decimal _starterRatio = 200/_baseRecipeTotal;
        private const decimal _waterRatio = 560/_baseRecipeTotal;
        
        public BasicSourdough(int totalWeight)
        {
            TotalWeight = totalWeight;

            WholemealFlour = Math.Ceiling(totalWeight * _wholemealFlourRatio);
        }

        public int TotalWeight { get; set; }

        public decimal WholemealFlour { get; private set; }
        public decimal PlainFlour { get; private set; }
        public decimal Salt { get; private set; }
        public decimal Starter { get; private set; }
        public decimal Water { get; private set; }
    }
}
