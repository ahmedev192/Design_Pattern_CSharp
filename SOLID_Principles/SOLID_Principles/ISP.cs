using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{

    // Initial Example (Violating ISP):
    public interface IMultiFunctionPrinter
    {
        void Print(Document doc);
        void Scan(Document doc);
        void Fax(Document doc);
    }

    public class BadDocument
    {
        // Document details
    }

    public class BadBasicPrinter : IMultiFunctionPrinter
    {
        public void Print(Document doc)
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan(Document doc)
        {
            throw new NotImplementedException();
        }

        public void Fax(Document doc)
        {
            throw new NotImplementedException();
        }
    }

    //----------------------------------------------------------------------------------------------------------------------------------

    // ISP :

    public interface IPrinter
    {
        void Print(Document doc);
    }

    public interface IScanner
    {
        void Scan(Document doc);
    }

    public interface IFax
    {
        void Fax(Document doc);
    }
    public class Document
    {
        // Document details 
    }

    public class BasicPrinter : IPrinter
    {
        public void Print(Document doc)
        {
            Console.WriteLine("Printing document...");
        }
    }

    public class MultiFunctionPrinter : IPrinter, IScanner, IFax
    {
        public void Print(Document doc)
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan(Document doc)
        {
            Console.WriteLine("Scanning document...");
        }

        public void Fax(Document doc)
        {
            Console.WriteLine("Faxing document...");
        }
    }





}
