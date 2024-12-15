using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    internal class ListResearchTeam : IEnumerator<ResearchTeam>
    {
        private List<ResearchTeam> SList;
        public bool disposed = false;
        public int currentIndex = -1;
        public ListResearchTeam(List<ResearchTeam> state) => this.SList = state;
        public ResearchTeam Current
        {
            get { return SList[currentIndex]; }
        }
        public bool MoveNext()
        {
            if (currentIndex + 1 == SList.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                }
                this.disposed = true;
            }
        }
    }
}
