using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTreeSimulation
{
    class Sample
    {
        public List<string> answers { get; private set; }
        public string name { get; private set; }
        public Sample(List<string> answers,string name)
        {
            this.answers = answers;
            this.name = name;
        }
        public Sample copy()
        {
            List<string> ans = new List<string>();
            string name = string.Copy(this.name);
            foreach(string s in this.answers)
            {
                ans.Add(string.Copy(s));
            }
            Sample rs = new Sample(ans,name);
            return rs;
        }
    }
}
