using Microsoft.EntityFrameworkCore;
using RentWaveApp.DataAccess.Interfaces;
using RentWaveApp.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentWaveApp.DataAccess.Imlementations
{
    public class CastRepository : IRepository<Cast>
    {
        private readonly RentWaveDbContext _context;

        public CastRepository(RentWaveDbContext context)
        {
            _context = context;
        }
        public void Create(Cast entity)
        {
            _context.Casts.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var cast = GetById(id);
            if (cast != null)
            {
                _context.Casts.Remove(cast);
                _context.SaveChanges();
            }
        }

        public List<Cast> GetAll()
        {
            var casts = _context.Casts
                .Include(x => x.Movie)
                .ToList();
            return casts;
        }

        public Cast GetById(int id)
        {
            var cast = _context.Casts.FirstOrDefault(x => x.Id == id);
            return cast;
        }

        public void Update(Cast entity)
        {
            _context.Casts.Update(entity);
            _context.SaveChanges();
        }
    }
}
