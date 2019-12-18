using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NFive.SDK.Core.Models;
using StreetlifeRP.Character.Shared.Models;

namespace StreetlifeRP.Character.Server.Models
{
    public class Character : IdentityModel, ICharacter
    {
        public bool IsAlive { get; set; }
        public int Health { get; set; }
        public int Armour { get; set; }
        public string Model { get; set; }
        public string WalkingStyle { get; set; }
        public Position Position { get; set; }
        public DateTime? LastUpdated { get; set; }

		[Required]
		[ForeignKey("Alias")]
        public Guid AliasId { get; set; }
        public virtual Alias Alias { get; set; }

		[Required]
		[ForeignKey("Apparel")]
        public Guid ApparelId { get; set; }
        public virtual Apparel Apparel { get; set; }

        [Required]
        [ForeignKey("Appearance")]
        public Guid AppearanceId { get; set; }
        public virtual Appearance Appearance { get; set; }

        [Required]
        [ForeignKey("Backstory")]
        public Guid BackstoryId { get; set; }
        public virtual Backstory Backstory { get; set; }

        [Required]
        [ForeignKey("FaceShape")]
        public Guid FaceShapeId { get; set; }
        public virtual FaceShape FaceShape { get; set; }

        [Required]
        [ForeignKey("Heritage")]
        public Guid HeritageId { get; set; }
        public virtual Heritage Heritage { get; set; }
    }
}
