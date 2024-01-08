﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTrackIt.Domain.Contract;

namespace UTrackIt.Domain
{
    /// <summary>
    /// Class that represents Region/Zone comprising several states
    /// </summary>

    public class Region : IEntityBase
    {
        #region Properties

        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Name of the region or zone
        /// </summary>
        [Required]
        [StringLength(15)]
        public string RegionName { get; set; }


        /// <summary>
        /// List of states in the region
        /// </summary>
        public List<State>? States { get; set; }
        #endregion
    }
}
