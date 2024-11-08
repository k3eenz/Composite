using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CompositePattern
{
    public class Section : IDocumentComponent
    {
        private List<IDocumentComponent> components = new List<IDocumentComponent>();
        private string title;

        public Section(string title)
        {
            this.title = title;
        }

        public void Add(IDocumentComponent component)
        {
            components.Add(component);
        }

        public void Remove(IDocumentComponent component)
        {
            components.Remove(component);
        }

        public void Display()
        {
            Console.WriteLine($"{new string(' ', 2)}Section: {title}");
            foreach (var component in components)
            {
                component.Display();
            }
        }
    }
}
