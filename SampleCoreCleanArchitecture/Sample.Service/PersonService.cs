using Sample.Core.Models;
using Sample.Core.Repositories;
using Sample.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Service
{
    public class PersonService : IPersonService<Person>
    {
        IPersonRepository<Person> _repository;
        ICompanyRepository<Company> _companyRepository;

        public PersonService(IPersonRepository<Person> repo, ICompanyRepository<Company> companyRepository)
        {
            _repository = repo;
            _companyRepository = companyRepository;
        }
        public int Insert(Person data)
        {
            return _repository.Insert(data);
        }

        public Person Load(int id)
        {
            return _repository.Load(id);
        }

        public List<Person> LoadAll()
        {
            return LoadAllReference(_repository.LoadAll());
        }
        public List<Person> LoadAllReference(List<Person> person)
        {
            foreach (var p in person)
            {
                p.CompanyRefence = _companyRepository.SearchCompanyById(p.Company);
            }

            return person;
        }
        public void Remove(Person data)
        {
            throw new NotImplementedException();
        }

        public void Update(Person data)
        {
            throw new NotImplementedException();
        }
    }
}
