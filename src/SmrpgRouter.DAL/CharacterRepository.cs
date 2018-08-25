using System;
using System.Collections.Generic;
using System.Linq;

using SmrpgRouter.Domain;
using SmrpgRouter.Domain.Utils;

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
            List<Character> characters =  _unitOfWork.Query<Character>().ToList();
            return characters;
        }

        public void Insert(string name)
        {
            throw new NotImplementedException();
        }
    }
}
