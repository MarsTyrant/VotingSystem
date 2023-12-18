namespace VotingSystem
{
    class Program
    {
       
       public static void Main()
       {
         Console.WriteLine("Welcome to the National Voting System Management!");
         Console.Write("Type whether you enter as a host or as a participant\n> ");
         # pragma warning disable 
         string? person=Console.ReadLine().ToLower();
         # pragma warning restore
         if(person=="host"){
         Console.WriteLine("Password required to enter as a host");
         while(true){
            Console.Write("> "); string? passWord=Console.ReadLine();
            if(passWord==HostManager.password){ 
              HostManager electionProgram=new HostManager();
              electionProgram.MakeElection();
              electionProgram.RegisterCandidates();
              for(int i=0;i<=1;++i){
                Console.WriteLine($"{i+1}.{electionProgram.electionHost.candidates[i].name}");
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
