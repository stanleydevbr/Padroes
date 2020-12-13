using System.Collections.Generic;
using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configurar a estrutura
            ObjectStructure obj = new ObjectStructure();
            obj.Attach(new ConcreteElementA());
            obj.Attach(new ConcreteElementB());

            // criar os visitors
            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            // estrutura aceitar visitors
            obj.Accept(v1);
            obj.Accept(v2);
        }
    }

    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }

    public class ConcreteVisitor1: Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name} visitado por {this.GetType().Name}");
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine($"{concreteElementB.GetType().Name} visitado por {this.GetType().Name}");
        }
    }
    public class ConcreteVisitor2: Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name} visitado por {this.GetType().Name}");
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine($"{concreteElementB.GetType().Name} visitado por {this.GetType().Name}");
        }
    }   

    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    } 

    public class ConcreteElementA: Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA()
        {

        }
    }
    public class ConcreteElementB: Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB()
        {

        }
    }    

    public class ObjectStructure
    {
        private List<Element> _elements = new List<Element>();
        public void Attach(Element element){
            _elements.Add(element);
        }

        public void DeAttach(Element element){
            _elements.Remove(element);
        }

        public void Accept(Visitor visitor){
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }    
}
