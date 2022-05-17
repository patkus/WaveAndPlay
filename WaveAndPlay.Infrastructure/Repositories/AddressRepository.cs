using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaveAndPlay.Domain.Interfaces;
using WaveAndPlay.Domain.Models;

namespace WaveAndPlay.Infrastructure.Repositories
{
    internal class AddressRepository : IAddressRepository
    {
        private readonly Context _context;
        public AddressRepository(Context context)
        {
            _context = context;
        }
        public int AddAddress(Address address)
        {
            _context.Add(address);
            _context.SaveChanges();

            return address.Id;
        }

        public void DeleteAddress(int addressId)
        {
            var address = _context.Addresses.Find(addressId);
            if(address != null)
            {
                _context.Addresses.Remove(address);
                _context.SaveChanges();
            }
        }

        public void EditAddress(int addressId)
        {
            var address = _context.Addresses.Find(addressId);
            if (address != null)
            {
                _context.Addresses.Update(address);
                _context.SaveChanges();
            }
        }

        public Address GetAddressById(int addressId)
        {
            return _context.Addresses.Find(addressId);
        }

        public IQueryable<Match> GetAllAddressMatches(int addressId)
        {
            return _context.Matches.Where(x => x.AddressId == addressId);
        }
    }
}
