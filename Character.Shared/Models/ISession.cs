using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetlifeRP.Character.Shared.Models
{
    public interface ISession
    {
		Guid Id { get; set; }
		Guid CharacterId { get; set; }
		DateTime Created { get; set; }
		DateTime? Connected { get; set; }
		DateTime? Disconnected { get; set; }
    }
}
