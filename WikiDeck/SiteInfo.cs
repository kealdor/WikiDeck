namespace WikiDeck
{
    public class SiteInfo
    {
        public string Name { get; private set; }
        public string Url { get; private set; }
        public string CardDataFileName { get; private set; }
        public bool UseRarityForMaxInHand { get; private set; }

        public SiteInfo(string name, string url, string cardDataFileName, bool useRarityForMaxInhand)
        {
            Name = name;
            Url = url;
            CardDataFileName = cardDataFileName;
            UseRarityForMaxInHand = useRarityForMaxInhand;
        }
    }
}
