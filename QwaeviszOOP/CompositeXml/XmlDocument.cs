using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeXml
{
    public class XmlDocument
    {

        private CompositeElement root;

        public CompositeElement Root
        {
            get { return this.root; }
        }

        public XmlDocument( string rootName )
        {
            this.root = new CompositeElement(rootName);
        }

    }
}
