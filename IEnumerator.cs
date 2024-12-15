using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    internal interface IEnumerator<ResearchTeam>
    {
        bool MoveNext();
        ResearchTeam Current { get; }
        void Reset();
    }
}
