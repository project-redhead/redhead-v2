using System;
using System.Collections.Generic;
using System.Text;
using ProjectRedhead.Core.Domain;

namespace ProjectRedhead.Domain.BetAggregrate
{
    public class BetGame : Entity
    {
        public string UserId { get; set; }

        public List<string> PossibleAnswers { get; set; }

        public string ActualAnswer { get; set; }


        public BetGame(string userId, List<string> possibleAnswers)
        {
            UserId = userId;
            PossibleAnswers = possibleAnswers;
        }
    }
}
