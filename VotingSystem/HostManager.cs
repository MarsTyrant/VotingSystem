namespace VotingSystem
{
    public class HostManager
    {
        public static string password="marius";
        public enum electionType {Presidential, Parliamentary, Local}
        public List<ElectionBase> elections=new();
        public struct ElectionBase
        {
            public string[] candidates;
            public electionType type;
            public int[] nrVotes;
            public double[] perVotes;
        }
        public void MakeElection()
        {
            ElectionBase Election=new();
            Console.Write("Choose a type of election you want to organise: 1 for Presidential, 2 for Parliamentary or 3 for Local\n> ");
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            while(true){
              string? choice=Console.ReadLine();
              switch(choice)
              {
                 // Use a switch statement to choose between election types
                 case "1":
                   Console.WriteLine("You chose to host a presidential election");
                   Election.type=electionType.Presidential;
                   break;
                 case "2":
                   Console.WriteLine("You chose to host a parliamentary election");
                   Election.type=electionType.Parliamentary;
                   break;
                 case "3":
                   Console.WriteLine("You chose to host local elections");
                   Election.type=electionType.Local;
                   break;
                 default:
                   Console.Write("Invalid Input. Type 1 for Presidential, 2 for Parliamentary or 3 for Local\n");
                   continue;
               }
               break;
             } 
            elections.Add(Election);
        } 

        public void RegisterCandidates()
        {

        }

        public int LiveResults()
        {
           return 0;
        }
    }

} 