﻿namespace VotingSystem
{
    class Program : VoteManager
    {
       public static List<ElectionBase> elections=new();
       public static void Main()
       {
         bool programActive=true;
         Console.WriteLine("Welcome to the National Voting System Management!");
          while(programActive==true)
          {
            Console.Write("Type whether you enter as a host or as a participant. 0 as a host or 1 as a participant. If you want to exit type 'esc' \n> ");
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
                electionProgramHost.MakeElection();
                electionProgramHost.RegisterCandidates();
                for(int i=0;i<=1;++i){
                  Console.WriteLine($"{i+1}.{elections[0].candidates[i].name}");
               }
               break;
             }
              else { Console.WriteLine("Invalid Password. Try Again!"); } 
           }
         }

           else if(personNr=="1")
           {
            VoteManager electionProgramPart=new();
            if(elections[0].candidates.Length>=2)
            {
               electionProgramPart.ListCandidates();
               Console.Write("Do you want to vote? Type 1 for yes and 0 for no\n> ");
               string? choice=Console.ReadLine();
               switch(choice)
               {
                 case "1":
                  electionProgramPart.VoteForCandidate();
                  break;
                 case "0":
                  break;
               }
            }
            else {Console.WriteLine("There is no election held.");}
           }
           else if(personNr=="esc") { programActive=false; } 
         }
       }
    }
}
