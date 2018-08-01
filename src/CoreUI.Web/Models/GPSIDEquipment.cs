using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    public class GPSIDEquipment
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public String ESN { get; set; }

    }
}
