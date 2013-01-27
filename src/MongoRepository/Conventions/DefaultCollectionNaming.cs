namespace MongoRepository.Conventions
{
    public class DefaultCollectionNaming : ICollectionNamingStrategy
    {
        public string Apply(string typeName)
        {
            return string.Concat(typeName, "s");
        }
    }
}
