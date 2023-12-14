namespace VotingSystem
{
    class Program
    {
       public static void Main()
       {
          HostManager election=new();
          election.MakeElection();
          Console.WriteLine(election.elections[0].type);
       }
       
       
    }
}
