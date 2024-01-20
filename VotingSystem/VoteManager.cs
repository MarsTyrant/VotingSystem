namespace VotingSystem
{
    class VoteManager : HostManager
    {
        public void ListCandidates()
        {
            Console.WriteLine($"Here are the candidates for the {elections[0].type} election\n");
            for(int i=0;i<=elections[0].candidates.Length;++i){
               Console.WriteLine($"{i+1}. {elections[0].candidates[i]}");
            }
        }

        public void VoteForCandidate()
        {
           Console.WriteLine("You can vote only for one candidate. Type the number next to the candidate you want to vote for."); 
           for(int i=0;i<=elections[0].candidates.Length;++i){
               Console.WriteLine($"{i+1}. {elections[0].candidates[i]}");
           }
           Console.Write("> "); string? choice=Console.ReadLine();
           switch(choice){
              case "1":
                elections[0].candidates[0].nrVotes++;
                break;
              case "2":
                elections[0].candidates[1].nrVotes++;
                break;
              case "3":
                elections[0].candidates[2].nrVotes++;
                break;
              case "4":
                elections[0].candidates[3].nrVotes++;
                break;
              case "5":
                elections[0].candidates[0].nrVotes++;
                break;
           }
        }
        
        public void CalcAndListPercentage()
        {
            for(int i=0;i<=elections[0].candidates.Length;++i){
                elections[0].candidates[i].perVotes=elections[0].candidates[i].nrVotes/10;
                Console.WriteLine($"{i+1}.{elections[0].candidates[i].name} - {elections[0].candidates[i].perVotes}");
            }
        }
    }
}