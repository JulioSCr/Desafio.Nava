using Desafio.Nava.Console.CasoUso;
using Desafio.Nava.Console.Interfaces;
using Desafio.Nava.Console.Servico;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<IAtividadeServico, AtividadeServico>();
services.AddScoped<TrabalhandoAtividades>();
var provedor = services.BuildServiceProvider();
var trabalhando = provedor.GetService<TrabalhandoAtividades>();
trabalhando.Usar();
Console.ReadLine();