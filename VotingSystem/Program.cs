namespace VotingSystem
{
    class Program : VoteManager
    {
       public static List<ElectionBase> elections=new();
       public static int totatVotes;
       public static void Main()
       {
         bool programActive=true;
         Console.WriteLine("Welcome to the National Voting System Management!");
          while(programActive==true)
          {
            Console.Write("Type whether you enter as a host or as a participant. 0 as a host or 1 as a participant. If you want to exit type 'x' \n> ");
            # pragma warning disable 
            string? personNr=Console.ReadLine().ToLower();
            # pragma warning restore
            if(personNr=="0")
            {
              Console.WriteLine("Password required to enter as a host");
              while(true){
              Console.Write("> "); string? passWord=Console.ReadLine();
              if(passWord==hostPassword)
              {
                HostManager electionProgramHost=new HostManager();
                Console.WriteLine("Do you want to organise a new election or see the results of the current one?. Type 0 for new election and 1 for the results. \n>");
                string? hostChoice=Console.ReadLine();
                if(hostChoice=="1")
                {
                  electionProgramHost.LiveResults();
                }
                else
                {
                  electionProgramHost.MakeElection();
                  electionProgramHost.RegisterCandidates();
                  for(int i=0;i<=4;++i){
                  Console.WriteLine($"{i+1}.{elections[0].candidates[i].name}");
                  }
                  break;
                }
              }
              else if(passWord=="x") { programActive=false; break; }
              else { Console.WriteLine("Invalid Password. Try Again!"); } 
              }
            }

           else if(personNr=="1")
           {
            VoteManager electionProgramPart=new();
            if(elections.Count!=0 && elections[0].candidates.Length>=2)
            {
               electionProgramPart.ListCandidates();
               Console.Write("Do you want to vote? Type 1 for yes and 0 for no\n> ");
               string? choice=Console.ReadLine();
               switch(choice)
               {
                 case "1":
                  totatVotes++;
                  electionProgramPart.VoteForCandidate();
                  break;
                 case "0":
                  break;
               }
            }
            else {Console.WriteLine("There is no election held.");}
           }
           else if(personNr=="x") { programActive=false; } 
         }
       }
    }
}
