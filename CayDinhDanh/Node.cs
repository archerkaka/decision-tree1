using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTreeSimulation
{
    class Node
    {
        public Clause partition_clause;
        public List<Clause> clauses;
        public List<Sample> samples;
        public List<Node> branch;
        public Node(Clause partition_clause, List<Clause> clauses, List<Sample> samples)
        {
            this.partition_clause = partition_clause;
            this.clauses = clauses;
            this.samples = samples;
        }
        public Node()
        {
            
        }
    }
}
