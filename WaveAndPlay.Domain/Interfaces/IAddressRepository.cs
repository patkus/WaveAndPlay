using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaveAndPlay.Domain.Models;

namespace WaveAndPlay.Domain.Interfaces
{
    public interface IAddressRepository
    {
        int AddAddress(Address address);
        void DeleteAddress(int addressId);
        void EditAddress(int addressId);
        Address GetAddressById(int addressId);
        IQueryable<Match> GetAllAddressMatches(int addressId);
    }
}
