namespace Asp.NetDependencyDemo.Models
{
    public interface IMembership
    {
        bool IsUsernameAvailable(string username);
    }
}