using System;
using System.Collections.Generic;
using System.Linq;

using SmrpgRouter.Domain;

namespace SmrpgRouter.DAL
{
    public class CharacterRepository
    {
        private readonly SmrpgContext _db;

        public CharacterRepository(SmrpgContext db)
        {
            _db = db;
        }

        public List<Character> GetAll()
        {
            return _db.Characters.ToList();
        }

        public void Insert(string name)
        {
            throw new NotImplementedException();
        }
    }
}
