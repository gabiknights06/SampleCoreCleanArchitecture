using Sample.Core.Models;
using Sample.Core.Repositories;
using Sample.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Service
{
    public class CompanyService : ICompanyService<Company>
    {
        ICompanyRepository<Company> _repository;
        public CompanyService(ICompanyRepository<Company> repo)
        {
            _repository = repo;
        }

        public int Insert(Company data)
        {
            return _repository.Insert(data);
        }

        public List<Company> LoadAll()
        {
            return _repository.LoadAll();
        }

        public void Remove(Company data)
        {
            throw new NotImplementedException();
        }

        public Company GetCompanyById(int id)
        {
            return _repository.SearchCompanyById(id);
        }

        public void Update(Company data)
        {
            throw new NotImplementedException();
        }

        public Company Load(int id)
        {
            return _repository.Load(id);
        }
    }
}
