using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTrackIt.Domain
{
    /// <summary>
    /// Class that represents the current status of the service - Up, Fluctuating, Slow, Down, Degraded etc
    /// </summary>
    public class LinkStatus
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
