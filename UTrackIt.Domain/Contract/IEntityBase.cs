using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTrackIt.Domain.Contract
{
    public interface IEntityBase
    {
        public int Id { get; set; }
    }
}
