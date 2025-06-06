namespace Lego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new LegoContext();
            var colorRepo = new Lego.Logic.LegoRepository<Lego.model.LegoColor>(context);
            var colors = colorRepo.GetAll();
            foreach (var color in colors)
            {
                Console.WriteLine($"Color ID: {color.Id}, Name: {color.Name}, RGB: {color.Rgb}");
            }

            var themeRepo = new Lego.Logic.LegoRepository<Lego.model.LegoTheme>(context);
            var themes = themeRepo.GetAll();
            foreach (var theme in themes)
            {
                Console.WriteLine($"Theme ID: {theme.Id}, Name: {theme.Name}");
            }
        }
    }
}
