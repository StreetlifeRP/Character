using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StreetlifeRP.Character.Shared.Models;

namespace StreetlifeRP.Character.Server.Models
{
    public class Session : ISession
    {
        public Guid Id { get; set; }
        public Guid CharacterId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Connected { get; set; }
        public DateTime? Disconnected { get; set; }
    }
}
