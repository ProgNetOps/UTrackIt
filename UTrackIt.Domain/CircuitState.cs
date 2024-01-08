using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTrackIt.Domain
{
    /// <summary>
    /// Class that represents the current state of the service - Active, Suspended etc
    /// </summary>
    public class CircuitState
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
