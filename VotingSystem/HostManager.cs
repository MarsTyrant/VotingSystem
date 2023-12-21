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
        public ElectionBase electionHost=new();
        public void MakeElection()
        {
            Console.Write("Choose a type of election you want to organise: 1 for Presidential, 2 for Parliamentary or 3 for Local\n> ");
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            while(true){
              
              string? choice=Console.ReadLine();
              switch(choice)
              {
                 // Use a switch statement to choose between election types
                 case "1":
                   Console.WriteLine("You chose to host a presidential election");
                   electionHost.type=ElectionType.Presidential;
                   break;
                 case "2":
                   Console.WriteLine("You chose to host a parliamentary election");
                   electionHost.type=ElectionType.Parliamentary;
                   break;
                 case "3":
                   Console.WriteLine("You chose to host local elections");
                   electionHost.type=ElectionType.Local;
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
          while(true){
            Console.Write("Type the name of the candidate and press enter to register the next candidate. Type x to end the registration\n> ");
            string? choice=Console.ReadLine();
            if(choice=="x") {break;}
            string[] name=choice.Split(' ');
            if(name.Length!=2 && name.Length!=3) {Console.WriteLine("Not valid name");}
            else electionHost.candidates[i].name=name[0]+' '+name[1];
            i++;
          }

        }

        public int LiveResults()
        {
          return 0;
          
        }
    }

} 