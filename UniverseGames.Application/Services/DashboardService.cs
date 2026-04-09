using System;
using System.Collections.Generic;
using System.Text;

namespace UniverseGames.Application.Services
{
    public class DashboardService
    {
        public object GetDados()
        {
            return new
            {
                vendas = 1000,
                usuarios = 50,
                produtos = 200
            };
        }
    }
}
