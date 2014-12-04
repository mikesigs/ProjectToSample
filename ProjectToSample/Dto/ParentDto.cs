using System.Collections.Generic;

namespace ProjectToSample
{
    public class ParentDto
    {
        public string Name { get; set; }
        public IEnumerable<string> ChildNames { get; set; }
    }
}