namespace VotingSystem
{
    class VoteManager : HostManager
    {
        public void ListCandidates()
        {
            Console.WriteLine($"Here are the candidates for the {electionHost.type} election\n");
            for(int i=0;i<=electionHost.candidates.Length;++i){
               Console.WriteLine($"{i+1}. {electionHost.candidates[i]}");
            }
        }

        public void VoteForCandidate()
        {
           Console.WriteLine("You can vote only for one candidate. Type the number next to the candidate you want to vote for."); 
           for(int i=0;i<=electionHost.candidates.Length;++i){
               Console.WriteLine($"{i+1}. {electionHost.candidates[i]}");
           }
           Console.Write("> "); string? choice=Console.ReadLine();
           switch(choice){
              case "1":
                electionHost.candidates[0].nrVotes++;
                break;
              case "2":
                electionHost.candidates[1].nrVotes++;
                break;
              case "3":
                electionHost.candidates[2].nrVotes++;
                break;
              case "4":
                electionHost.candidates[3].nrVotes++;
                break;
              case "5":
                electionHost.candidates[0].nrVotes++;
                break;
           }
        }
        
        public void CalcAndListPercentage()
        {
            for(int i=0;i<=electionHost.candidates.Length;++i){
                electionHost.candidates[i].perVotes=electionHost.candidates[i].nrVotes/10;
                Console.WriteLine($"{i+1}.{electionHost.candidates[i].name} - {electionHost.candidates[i].perVotes}");
            }
        }
    }
}