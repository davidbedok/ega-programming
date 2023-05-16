using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace CompositeXml
{
    public class LeafElement : Element
    {

        private string text;

        public LeafElement(string name, string text) : base(name)
        {
            this.text = text;
        }

        public string Text {
            get { return this.text; }
            set { this.text = value; }
        }

        public override void ToUpperCase()
        {
            if ( this.text != null)
            {
                this.text = this.text.ToUpper();
            }
        }

        public override void MultiplyBy(int multiplier)
        {
            try { 
                double value = Convert.ToDouble(this.text);
                this.text = "" + (value * multiplier);
            } catch ( FormatException e )
            {
                // 
            }
        }

        public override string Print()
        {
            return "<" + this.name + ">" + this.text + "</" + this.name + ">";
        }

    }
}
