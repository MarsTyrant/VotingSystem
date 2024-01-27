namespace VotingSystem
{
    public class HostManager
    {
        public static string hostPassword="marius";
        public enum ElectionType {Presidential, Parliamentary, Local}
        public struct CandidateBase
        {
           public string name;
           public int nrVotes;
           public double perVotes;
        }
        public struct ElectionBase
        {
            public CandidateBase[] candidates=new CandidateBase[5];
            //public string[] candidates=new string[5];
            public ElectionType type;
            #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            public ElectionBase(){}
            #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        }
        
        public void MakeElection()
        {
           Console.Write("Choose a type of election you want to organise: 1 for Presidential, 2 for Parliamentary or 3 for Local\n> ");
           #pragma warning disable CS8602 // Dereference of a possibly null reference.
           ElectionBase election=new();
           Program.elections.Add(election);
           while(true)
           {
             string? choice=Console.ReadLine();
             switch(choice)
             {
                 // Use a switch statement to choose between election types
                 case "1":
                   Console.WriteLine("You chose to host a presidential election");
                   ElectionBase typeElectionPresidential=Program.elections[0];
                   typeElectionPresidential.type=ElectionType.Presidential;
                   Program.elections[0]=typeElectionPresidential; // election[0]=new (candidates,)
                   break;
                 case "2":
                   Console.WriteLine("You chose to host a parliamentary election");
                   ElectionBase typeElectionParliamentary=Program.elections[0];
                   typeElectionParliamentary.type=ElectionType.Parliamentary;
                   Program.elections[0]=typeElectionParliamentary;
                   break;
                 case "3":
                   Console.WriteLine("You chose to host local elections");
                   ElectionBase typeElectionLocal=Program.elections[0];
                   typeElectionLocal.type=ElectionType.Local;
                   Program.elections[0]=typeElectionLocal;
                   break;
                 default:
                   Console.Write("Invalid Input. Type 1 for Presidential, 2 for Parliamentary or 3 for Local\n");
                   continue;
               }
               break;
            } 
         } 

        public void RegisterCandidates()
        {
          Console.WriteLine("Register the candidates");
          int i=0;
          while(true)
          {
            Console.Write("Type the name of the candidate and press enter to register the next candidate. Type x to end the registration\n> ");
            string? choice=Console.ReadLine();
            if(choice=="exit") { break; }
            string[] name=choice.Split(' ');
            if(name.Length!=2 && name.Length!=3) { Console.WriteLine("Not valid name"); }
            else Program.elections[0].candidates[i].name=name[0]+' '+name[1];
            i++;
          }

        }

        public void LiveResults()
        {
          VoteManager results=new();
          Console.WriteLine("So far, these are the results.");
          results.CalcAndListPercentage();

        }
    }

} 