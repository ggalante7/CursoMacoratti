using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Models;

namespace Tarefas.Services
{
    public class TempTarefaItemService : ITarefaItemService
    {
        Task<IEnumerable<TarefaItem>> ITarefaItemService.GetItemAsync()
        {
            IEnumerable<TarefaItem> items = new[]
            {
                new TarefaItem
                {
                    Nome = "Aprender ASP.NET core 2.0",
                    EstaCompleta = false,
                    DataConclusao = DateTimeOffset.Now.AddDays(1)
                },
                new TarefaItem
                {
                    Nome = "Comer um cuzin",
                    EstaCompleta = false,
                    DataConclusao = DateTimeOffset.Now.AddDays(20)
                }
            };
            return Task.FromResult(items);
        }
    }
}