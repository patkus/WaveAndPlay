using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaveAndPlay.Domain.Interfaces;
using WaveAndPlay.Domain.Models;

namespace WaveAndPlay.Infrastructure.Repositories
{
    public class DisciplineRepository : IDisciplineRepository
    {
        private readonly Context _context;
        public DisciplineRepository(Context context)
        {
            _context = context;
        }
        public int AddDiscipline(Discipline discipline)
        {
            _context.Disciplines.Add(discipline);
            _context.SaveChanges();

            return discipline.Id;
        }

        public void DeleteDiscipline(int disciplineId)
        {
            var discipline = _context.Disciplines.Find(disciplineId);
            if (discipline != null)
            {
                _context.Disciplines.Remove(discipline);
                _context.SaveChanges();
            }
        }

        public void EditDiscipline(int disciplineId)
        {
            var discipline = _context.Disciplines.Find(disciplineId);
            if(discipline != null)
            {
                _context.Disciplines.Update(discipline);
                _context.SaveChanges();
            }
        }
        public Discipline GetDisciplineById(int disciplineId)
        {
            return _context.Disciplines.Find(disciplineId);
        }
        public IQueryable<Match> GetAllDisciplineMatches(int disciplineId)
        {
            return _context.Matches.Where(x => x.DisciplineId == disciplineId);
        }
    }
}
