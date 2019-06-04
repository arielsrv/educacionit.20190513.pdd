using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Resume();

            foreach (Page page in document.GetPages())
            {
                // SysOut(page.getClass().simpleName())
                Console.WriteLine(page.GetType().Name);
            }
        }
    }

    abstract class Document
    {
        protected List<Page> pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> GetPages()
        {
            return this.pages;
        }

        public abstract void CreatePages();
    }

    class Resume : Document
    {
        public override void CreatePages()
        {
            this.pages.Add(new Skill());
            this.pages.Add(new AcademicalHistory());
            this.pages.Add(new PersonalInfo());
        }
    }

    class Report : Document
    {
        public override void CreatePages()
        {
            this.pages.Add(new Header());
            this.pages.Add(new Body());
        }
    }

    class Page
    {

    }

    class Skill : Page
    {

    }

    class PersonalInfo: Page
    {

    }

    class AcademicalHistory: Page
    {

    }

    class Header : Page
    {

    }

    class Body : Page
    {

    }
}
