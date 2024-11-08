using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Document : IDocumentComponent
    {
        private List<IDocumentComponent> sections = new List<IDocumentComponent>();

        public void Add(IDocumentComponent component)
        {
            sections.Add(component);
        }

        public void Remove(IDocumentComponent component)
        {
            sections.Remove(component);
        }

        public void Display()
        {
            Console.WriteLine("Document:");
            foreach (var section in sections)
            {
                section.Display();
            }
        }
    }
}
