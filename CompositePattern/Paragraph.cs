using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Paragraph : IDocumentComponent
    {
        private string text;

        public Paragraph(string text)
        {
            this.text = text;
        }

        public void Add(IDocumentComponent component)
        {
            throw new InvalidOperationException();
        }

        public void Remove(IDocumentComponent component)
        {
            throw new InvalidOperationException();
        }

        public void Display()
        {
            Console.WriteLine($"{new string(' ', 4)}Paragraph: {text}");
        }
    }
}
