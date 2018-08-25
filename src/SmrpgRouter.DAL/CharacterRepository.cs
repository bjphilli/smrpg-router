using System.Collections.Generic;
using System.Data;
using System.Linq;

using SmrpgRouter.Domain;

using Npgsql;
using NHibernate;
using System;

namespace SmrpgRouter.DAL
{
    public class CharacterRepository
    {
        private readonly UnitOfWork _unitOfWork;

        public CharacterRepository(UnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public List<Character> GetAll()
        {
            List<Character> characters =  _unitOfWork.Query<Character>().Where(x => true).ToList();
            _unitOfWork.Commit();
            return characters;
        }

        public void Insert(string name)
        {
            throw new NotImplementedException();
        }
    }
}
