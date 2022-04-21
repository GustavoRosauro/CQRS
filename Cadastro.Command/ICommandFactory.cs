namespace Cadastro.Command
{
    public interface ICommandFactory
    {
        void Process(Command command, object objeto);
    }
}