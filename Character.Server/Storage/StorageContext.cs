using System.Data.Entity;
// using NFive.SDK.Core.Models.Player;
using NFive.SDK.Server.Storage;
using StreetlifeRP.Character.Server.Models;
using CharacterModel = StreetlifeRP.Character.Server.Models.Character;

namespace StreetlifeRP.Character.Server.Storage
{
	public class StorageContext : EFContext<StorageContext>
	{
        // TODO: Is this required?
        // public DbSet<User> Users { get; set; }
        public DbSet<Alias> Aliases { get; set; }
		public DbSet<Apparel> Apparels { get; set; }
		public DbSet<Appearance> Appearances { get; set; }
		public DbSet<Backstory> Backstories { get; set; }
		public DbSet<CharacterModel> Characters { get; set; }
		public DbSet<FaceShape> FaceShapes { get; set; }
		public DbSet<Heritage> Heritages { get; set; }
		public DbSet<Session> Sessions { get; set; }

	}
}
