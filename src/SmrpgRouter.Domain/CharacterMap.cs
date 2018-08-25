using FluentNHibernate.Mapping;

namespace SmrpgRouter.Domain
{
    public class CharacterMap : ClassMap<Character>
    {
        public CharacterMap()
        {
            Id(x => x.Id).Column("id");
            Map(x => x.Name).Column("name");
        }
    }
}