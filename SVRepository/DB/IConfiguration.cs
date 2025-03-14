namespace SVRepository.DB
{
    public interface IConfiguration
    {
        string GetConnectionString(string name);
    }
}