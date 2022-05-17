using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaveAndPlay.Domain.Models;

namespace WaveAndPlay.Domain.Interfaces
{
    public interface IDisciplineRepository
    {
        int AddDiscipline(Discipline discipline);
        void DeleteDiscipline(int disciplineId);
        void EditDiscipline(int disciplineId);
        Discipline GetDisciplineById(int disciplineId);
        IQueryable<Match> GetAllDisciplineMatches(int disciplineId);
    }
}
