namespace VotingSystem
{
    class VoteManager : HostManager
    {
        public void ListCandidates()
        {
            Console.WriteLine($"Here are the candidates for the {Program.elections[0].type} election\n");
            for(int i=0;i<Program.elections[0].candidates.Length;++i){
               Console.WriteLine($"{i+1}. {Program.elections[0].candidates[i].name}");
            }
        }

        public void VoteForCandidate()
        {
           Console.WriteLine("You can vote only for one candidate. Type the number next to the candidate you want to vote for."); 
           for(int i=0;i<Program.elections[0].candidates.Length;++i){
               Console.WriteLine($"{i+1}. {Program.elections[0].candidates[i].name}");
           }
           Console.Write("> "); string? choice=Console.ReadLine();
           switch(choice)
           {
              case "1":
                Program.elections[0].candidates[0].nrVotes++;
                break;
              case "2":
                Program.elections[0].candidates[1].nrVotes++;
                break;
              case "3":
                Program.elections[0].candidates[2].nrVotes++;
                break;
              case "4":
                Program.elections[0].candidates[3].nrVotes++;
                break;
              case "5":
                Program.elections[0].candidates[0].nrVotes++;
                break;
           }
        }
        
        public void CalcAndListPercentage()
        {
            for(int i=0;i<Program.elections[0].candidates.Length;++i){
                Program.elections[0].candidates[i].perVotes=Program.elections[0].candidates[i].nrVotes/Program.totatVotes*100;
                Console.WriteLine($"{i+1}.{Program.elections[0].candidates[i].name} - {Program.elections[0].candidates[i].perVotes} %");
            }
        }
    }
}