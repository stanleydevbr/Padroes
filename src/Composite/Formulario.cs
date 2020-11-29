using System.Collections.Generic;
using System;

namespace Composite
{
    public class Formulario : Component
    {
        private List<Component> _children = new List<Component>();
        public Formulario(string name)
            : base(name)
        {
            
        }
        public override void Add(Component c)
        {
            this._children.Add(c);
        }
        public override void Display()
        {
            Console.WriteLine(_name);
            foreach (var item in _children){
                item.Display();
            }
        }
        public override void Remove(Component c)
        {
            this._children.Remove(c);
        }
    }
}