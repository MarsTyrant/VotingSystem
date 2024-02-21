namespace VotingSystem
{
    class VoteManager : HostManager
    {
        public void ListCandidates()
        {
            Console.WriteLine($"Here are the candidates for the {Program.elections[0].type} election\n");
            for(int i=0;i<Program.elections[0].candidates.Count;++i){
               Console.WriteLine($"{i+1}. {Program.elections[0].candidates[i].name}");
            }
        }

        public void VoteForCandidate()
        {
           Console.WriteLine("You can vote only for one candidate. Type the number next to the candidate you want to vote for."); 
           for(int i=0;i<Program.elections[0].candidates.Count;++i){
               Console.WriteLine($"{i+1}. {Program.elections[0].candidates[i].name}");
           }
           Console.Write("> "); string? choice=Console.ReadLine();
           switch(choice)
           {
              case "1":
                CandidateBase firstCandidate=Program.elections[0].candidates[0];
                firstCandidate.nrVotes++;
                Program.elections[0].candidates[0]=firstCandidate;
                break;
              case "2":
                CandidateBase secondCandidate=Program.elections[0].candidates[0];
                secondCandidate.nrVotes++;
                Program.elections[0].candidates[0]=secondCandidate;
                break;
              case "3":
                CandidateBase thirdCandidate=Program.elections[0].candidates[0];
                thirdCandidate.nrVotes++;
                Program.elections[0].candidates[0]=thirdCandidate;
                break;
              case "4":
                CandidateBase forthCandidate=Program.elections[0].candidates[0];
                forthCandidate.nrVotes++;
                Program.elections[0].candidates[0]=forthCandidate;
                break;
              case "5":
                CandidateBase fifthCandidate=Program.elections[0].candidates[0];
                fifthCandidate.nrVotes++;
                Program.elections[0].candidates[0]=fifthCandidate;
                break;
           }
        }
        
        public void CalcAndListPercentage()
        {
            for(int i=0;i<Program.elections[0].candidates.Count;++i){
                //Program.elections[0].candidates[i].perVotes=Program.elections[0].candidates[i].nrVotes/Program.totatVotes*100;
                CandidateBase percentage=Program.elections[0].candidates[i];
                percentage.perVotes=Program.elections[0].candidates[i].nrVotes/Program.totatVotes*100;
                Program.elections[0].candidates[i]=percentage;
                Console.WriteLine($"{i+1}.{Program.elections[0].candidates[i].name} - {Program.elections[0].candidates[i].perVotes} %");
            }
        }
    }
}