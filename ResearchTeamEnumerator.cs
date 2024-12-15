using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    internal class ResearchTeamEnumerator : IEnumerable<ResearchTeam>
    {
        List<ResearchTeam> states;
        public IEnumerator<ResearchTeam> GetEnumerator() => new ListResearchTeam(states);

        public ResearchTeamEnumerator(List<ResearchTeam> list)
        {
            states = list;
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        System.Collections.Generic.IEnumerator<ResearchTeam> IEnumerable<ResearchTeam>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
