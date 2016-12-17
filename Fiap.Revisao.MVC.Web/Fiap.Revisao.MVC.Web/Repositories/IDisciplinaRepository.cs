﻿using Fiap.Revisao.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Revisao.MVC.Web.Repositories
{
    public interface IDisciplinaRepository
    {
        void Cadastrar(Disciplina disciplina);
        List<Disciplina> Listar();
    }
}
