using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeXml
{
    public class CompositeElement : Element
    {

        private List<Element> children;

        public Element this[int i]
        {
            get { return this.children.ElementAt(i); }
        }

        public CompositeElement( string rootName ): base(rootName)
        {
            this.children = new List<Element>();
        }

        public void AddChild( Element element )
        {
            this.children.Add(element);
        }

        public override void ToUpperCase()
        {
            foreach ( Element child in this.children )
            {
                child.ToUpperCase();
            }
        }

        public override void MultiplyBy(int multiplier)
        {
            foreach (Element child in this.children)
            {
                child.MultiplyBy(multiplier);
            }
        }

        public override string Print()
        {
            StringBuilder content = new StringBuilder(100);
            content.AppendLine("<" + this.name + ">");
            foreach (Element child in this.children)
            {
                content.AppendLine(child.Print());
            }
            content.Append("</" + this.name + ">");
            return content.ToString();
        }
    }
}
