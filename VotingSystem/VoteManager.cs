namespace VotingSystem
{
    class VoteManager : HostManager
    {
        VoteManager electionVote=new();
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

            
        }
    }
}