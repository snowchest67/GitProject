﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    internal class ResearchTeamEnumerator : IEnumerator
    {
        private readonly ArrayList members;
        private readonly ArrayList papers;
        private int position = -1;

        public ResearchTeamEnumerator(ArrayList members, ArrayList papers)
        {
            this.members = members;
            this.papers = papers;
        }

        public bool MoveNext()
        {
            while (++position < members.Count)
            {
                if (HasPublications((Person)members[position]))
                {
                    return true;
                }
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                if (position < 0 || position >= members.Count)
                {
                    throw new InvalidOperationException();
                }
                return members[position];
            }
        }

        private bool HasPublications(Person person)
        {
            foreach (Paper paper in papers)
            {
                if (paper.Author == person)
                {
                    return true;
                }
            }
            return false;
        }



    }
}
