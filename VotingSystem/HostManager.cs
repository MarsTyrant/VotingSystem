namespace VotingSystem
{
    public class HostManager
    {
        public static string password="marius";
        public enum electionType {Presidential, Parliamentary, Local}
        public struct ElectionBase
        {
            public string[] candidates=new string[5];
            public electionType type;
            public int[] nrVotes;
            public double[] perVotes;
            public ElectionBase(){}
        }
        public ElectionBase electionForHost=new();
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
                   electionForHost.type=electionType.Presidential;
                   break;
                 case "2":
                   Console.WriteLine("You chose to host a parliamentary election");
                   electionForHost.type=electionType.Parliamentary;
                   break;
                 case "3":
                   Console.WriteLine("You chose to host local elections");
                   electionForHost.type=electionType.Local;
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
            Console.WriteLine(name[0]);
            if(name.Length!=2 && name.Length!=3) {Console.WriteLine("Not valid name");}
            else electionForHost.candidates[i]=name[0]+' '+name[1];
            i++;
          }

        }

        public int LiveResults()
        {
          return 0;
        }
    }

} 