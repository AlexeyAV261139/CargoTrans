﻿using Application.Interfaces.Repositories;
using Core.Models;

namespace Application.Services
{
    public class RouteService(IRouteRepository repository)
    {
        private readonly IRouteRepository _repository = repository;

        public async Task CreateRouteAsync(Route route)
        {
            await _repository.Create(route);
        }

        public async Task<List<Route>> GetRoutesAsync()
        {
            return await _repository.Get();
        }
    }
}
