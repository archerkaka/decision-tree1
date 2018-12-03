using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTreeSimulation
{
    class Clause
    {
        public string question { get; private set; }
        public List<string> possibleAnswers { get; private set; }
        public Clause(string question, List<string> possibleAnswers)
        {
            this.question = question;
            this.possibleAnswers = possibleAnswers;
        }
    }
}
