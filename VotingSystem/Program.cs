namespace VotingSystem
{
    class Program
    {
       public static void Main()
       {
         Console.WriteLine("Welcome to the National Voting System Management!");
         Console.WriteLine("Type whether you enter as a host or as a participant");
         string? person=Console.ReadLine().ToLower();
         if(person=="host"){
         Console.WriteLine("Password required to enter as a host");
         while(true){
            Console.Write("> "); string? passWord=Console.ReadLine();
            if(passWord==HostManager.password){ 
              HostManager election=new HostManager();
              election.MakeElection();
              election.RegisterCandidates();
              for(int i=0;i<=1;++i){
                Console.WriteLine($"{i+1}.{election.electionForHost.candidates[i]}");
              }
              break;
            }
            else {Console.WriteLine("Invalid Password. Try Again!");} 
         }
        }
        else if(person=="participant"){
          
        } 
      }
    }
}
