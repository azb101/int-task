namespace PluginApp.Cli.CommandLine.Commands
{
    public class DummyCommand : ICliCommand
    {
        private readonly string Input;

        public DummyCommand(string input) {
            this.Input = input;
        }

        public void Execute()
        {
            System.Console.WriteLine($"No command found for this input: '{Input}'");
        }
    }
}