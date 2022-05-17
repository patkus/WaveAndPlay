using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WaveAndPlay.Domain.Models;

namespace WaveAndPlay.Infrastructure
{
    public class Context : IdentityDbContext
    { 
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchPlayer> MatchPlayer { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamPlayer> TeamPlayer { get; set; }
        public Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Match>().HasOne(m => m.Address).WithMany(a => a.Matches).HasForeignKey(m => m.AddressId);
            builder.Entity<Match>().HasOne(m => m.Discipline).WithMany(d => d.Matches).HasForeignKey(m => m.DisciplineId);
            builder.Entity<Match>().HasOne(m => m.Organizer).WithMany(p => p.OrganizedMatches).HasForeignKey(m => m.OrganizerId);
            builder.Entity<MatchPlayer>().HasKey(mp => new { mp.MatchId, mp.PlayerId });
            builder.Entity<MatchPlayer>().HasOne<Match>(mp => mp.Match).WithMany(m => m.MatchPlayers).HasForeignKey(mp => mp.MatchId);
            builder.Entity<MatchPlayer>().HasOne<Player>(mp => mp.Player).WithMany(p => p.PlayerMatches).HasForeignKey(mp => mp.PlayerId);
            builder.Entity<TeamPlayer>().HasKey(tp => new { tp.TeamId, tp.PlayerId });
            builder.Entity<TeamPlayer>().HasOne<Team>(tp => tp.Team).WithMany(t => t.TeamPlayers).HasForeignKey(tp => tp.TeamId);
            builder.Entity<TeamPlayer>().HasOne<Player>(tp => tp.Player).WithMany(p => p.PlayerTeams).HasForeignKey(tp => tp.PlayerId);
        }
    }
}
