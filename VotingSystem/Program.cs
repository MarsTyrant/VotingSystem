namespace VotingSystem
{
    class Program : VoteManager
    {
       
       public static void Main()
       {
         bool programActive=true;
         Console.WriteLine("Welcome to the National Voting System Management!");
          while(programActive==true){
            Console.Write("Type whether you enter as a host or as a participant. If you want to exit type 'esc' \n> ");
            # pragma warning disable 
            string? person=Console.ReadLine().ToLower();
            # pragma warning restore
            if(person=="host"){
              Console.WriteLine("Password required to enter as a host");
              while(true){
              Console.Write("> "); string? passWord=Console.ReadLine();
              if(passWord==hostPassword){ 
                HostManager electionProgramHost=new HostManager();
                electionProgramHost.MakeElection();
                electionProgramHost.RegisterCandidates();
                for(int i=0;i<=1;++i){
                  Console.WriteLine($"{i+1}.{electionProgramHost.elections[0].candidates[i].name}");
               }
               break;
             }
              else {Console.WriteLine("Invalid Password. Try Again!");} 
           }
         }

           else if(person=="participant"){
            VoteManager electionProgramPart=new();
            Console.WriteLine(electionProgramPart.elections[0].candidates[1].name);
            if(electionProgramPart.elections[0].candidates.Length>=2){
               electionProgramPart.ListCandidates();
               Console.Write("Do you want to vote? Type 1 for yes and 0 for no\n> ");
               string? choice=Console.ReadLine();
               switch(choice){
                 case "1":
                  electionProgramPart.VoteForCandidate();
                  break;
                 case "0":
                  break;
               }
            }
            else {Console.WriteLine("There is no election held.");}
           }
           else if(person=="esc"){
             programActive=false;
           } 
         }
       }
    }
}
