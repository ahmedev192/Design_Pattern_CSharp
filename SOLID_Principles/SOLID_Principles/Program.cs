namespace SOLID_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Single Responsibility Principle(SRP) :

            string userId = "admin";
            string password = "password";
            var authenticator = new UserAuthenticator();
            var reporter = new UserReporter();


            bool isAuthenticated = authenticator.AuthenticateUser(userId, password);

            if (isAuthenticated)
            {
                string report = reporter.GenerateUserReport(userId);
                Console.WriteLine(report);
            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }

            //--------------------------------------------------------------------------------------------------------------------------------------

            // Open Closed Principle (OCP) : 

            IShape Rectangle = new Rectangle(4, 2 );
            IShape Circle = new Circle(6);
            var areaCalculator = new AreaCalculator();
            Console.WriteLine($"- Rectangle 1 Area : {areaCalculator.CalculateArea(Rectangle)} \n- Circle 1 Area : {areaCalculator.CalculateArea(Circle)}");



            //--------------------------------------------------------------------------------------------------------------------------------------

            // Liskov Substitution Principle (LSP) :

            Bird genericBird = new Bird();
            genericBird.Eat();

            Sparrow sparrow = new Sparrow();
            sparrow.Eat();
            sparrow.Fly();

            Penguin penguin = new Penguin();
            penguin.Eat();

            // List of flying birds
            List<IFlyable> flyingBirds = new List<IFlyable> { new Sparrow() };
            foreach (var bird in flyingBirds)
            {
                bird.Fly();
            }


            //--------------------------------------------------------------------------------------------------------
            //  4. Interface Segregation Principle (ISP) :
            Document doc = new Document();

            IPrinter basicPrinter = new BasicPrinter();
            basicPrinter.Print(doc);

            MultiFunctionPrinter mfp = new MultiFunctionPrinter();
            mfp.Print(doc);
            mfp.Scan(doc);
            mfp.Fax(doc);

            // List of printers
            List<IPrinter> printers = new List<IPrinter> { basicPrinter, mfp };
            foreach (var printer in printers)
            {
                printer.Print(doc);
            }



            //----------------------------------------------------------------
            IEmailService emailService = new EmailService();
            OrderProcessor orderProcessor = new OrderProcessor(emailService);

            orderProcessor.ProcessOrder("Order details");


        }


    }
}
