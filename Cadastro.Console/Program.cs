// See https://aka.ms/new-console-template for more information
using Cadastro.Command;
using Cadastro.Contracts;
using Cadastro.Infraestructure;
using SimpleInjector;


var container = new Container();
container.Register<ICommandFactory, CommandFactory>();
container.RegisterInstance<IUnidadeTrabalho>(new UnidadeTrabalho("server=localhost;database=dockerdsv;uid=gustavo;pwd=gustavo;"));

var commandFactory = container.GetInstance<ICommandFactory>();
var unidadeTrabalho = container.GetInstance<IUnidadeTrabalho>();
commandFactory.Process(new SalvarUsuarioCommand(unidadeTrabalho), new UsuarioContract()
{
    Nome = "Gustavo",
    Ambiente = "Desenvolvimento"
}) ;
Console.WriteLine("Cadastrado com sucesso");
