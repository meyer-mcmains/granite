using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite
{
    class Test    
    {
        private string id { get; set; }
        private DateTime date { get; set; }
        private double score { get; set; }  //average score for the test

        private List<Question> q;
        private List<int> qScores;

        public Test()
        {
            this.id = "";
            this.date = DateTime.Today;
            this.score = 0;
            q = new List<Question>();
            qScores = new List<int>();
            q = new List<Question>();
            qScores = new List<int>();
        }
        public Test(string id, List<Question> qList)
        {
            this.id = id;
            this.date = DateTime.Today;
            this.score = 0;
            q = new List<Question>();
            qScores = new List<int>();
            foreach(Question quest in qList)
            {
                q.Add(quest);
            }
        }

        public void CalcScore()
        {
            int current = 0;
            foreach(int i in qScores)
            {
                current += i;
            }
            score = (current / qScores.Count);
        }


    }
}
