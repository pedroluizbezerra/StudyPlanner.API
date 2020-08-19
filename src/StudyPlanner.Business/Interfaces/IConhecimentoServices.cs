﻿using StudyPlanner.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyPlanner.Business.Interfaces
{
    interface IConhecimentoServices
    {
        Task<Conhecimento> ObterPorId(Guid id);
        Task<List<Conhecimento>> ObterTodos();
        Task<IEnumerable<Conhecimento>> BuscarPorFiltro(); //TODO Falta o filtro
        Task Adcionar(Conhecimento conhecimento);
        Task Atualizar(Conhecimento conhecimento);
        Task Remover(int id);
    }
}