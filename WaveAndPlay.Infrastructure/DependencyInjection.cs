using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using WaveAndPlay.Domain.Interfaces;
using WaveAndPlay.Infrastructure.Repositories;

namespace WaveAndPlay.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<IDisciplineRepository, DisciplineRepository>();
            services.AddTransient<IMatchPlayerRepository, MatchPlayerRepository>();
            services.AddTransient<IMatchRepository, MatchRepository>();
            services.AddTransient<IPlayerRepository, PlayerRepository>();
            services.AddTransient<ITeamPlayerRepository, TeamPlayerRepository>();
            services.AddTransient<ITeamRepository, TeamRepository>();

            return services;
        }
    }
}
