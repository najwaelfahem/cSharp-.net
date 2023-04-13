// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace WizardNinjaSamurai {
    class Program {
        static void Main (string[] args) {
            Wizard xavier = new Wizard("Xavier");
            Ninja elektra = new Ninja("Elektra");
            Samurai logan = new Samurai("Logan");
            logan.Attack(xavier);
            xavier.Attack(elektra);
            elektra.Attack(logan);
            elektra.Steal(xavier);
            logan.Meditate();
            xavier.Heal(xavier);
        }
    }}