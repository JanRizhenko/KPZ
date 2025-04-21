namespace Authenticator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a1 = Authenticator.Instance;
            a1.Authenticate("admin");

            var a2 = Authenticator.Instance;
            a2.Authenticate("guest");

            Console.WriteLine($"Same object? {ReferenceEquals(a1, a2)}");
        }
    }
}