namespace MongoRepository.Conventions
{
    public interface ICollectionNamingStrategy
    {
        string Apply(string typeName);
    }
}
