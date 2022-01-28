using KanbanApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace KanbanApi
{
    public class DataGenerator
    {
        public static void DadosTeste(IServiceProvider serviceProvider)
        {
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                context.Cards.AddRange(
                new Card
                {
                    Id = new Guid(),
                    Titulo = "Adicionar lista de cards",
                    Conteudo = string.Empty,
                    Lista = "In Progress"
                },

                new Card
                {
                    Id = new Guid(),
                    Titulo = "Criar Botão Importar Planilha",
                    Conteudo = "Ao clicar no botão deve criar uma planilha com os cards",
                    Lista = "In Progress"
                },

                new Card
                {
                    Id = new Guid(),
                    Titulo = "Adicionar novo campo",
                    Conteudo = string.Empty,
                    Lista = "In Progress"
                }
                );

                context.SaveChanges();
            }
        }
    }
}
