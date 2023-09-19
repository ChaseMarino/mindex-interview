using CodeChallenge.Models;
using System;
using System.Threading.Tasks;

namespace CodeChallenge.Repositories
{
    public interface ICompensationRepository
    {
        Compensation Get(String id);
        void Add(Compensation comp);
        Task SaveAsync();
    }
}