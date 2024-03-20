using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Veh.Model
{
    [Table("Vehicle_Catalog")]
    public class Vehicle
    {
        [Key]
        [Required]
        [Column("Veh_Id")]
        public int Id {get; set; }

        [Required]
        [MinLength(2), MaxLength(20)]
        [Column(TypeName = "Varchar")]
        public string Company_name { get; set; }

        [Required]
        [MinLength(2), MaxLength(20)]
        [Column(TypeName = "Varchar")]
        public string Veh_model { get; set; }


        [Required]
        [Column(TypeName = "Varchar(10)")]
        public string Seating_capacity { get; set; }


        [Required]
        [Column(TypeName = "Decimal(10,2)")]
        public decimal ShowroomPrice { get; set; }

      
        [Column(TypeName = "Decimal(10,2)")]
        public decimal LocalTax { get; set; }

    
        [Column(TypeName = "Decimal(10,2)")]
        public decimal GST { get; set; }



        [Required]
        [Column(TypeName = "Decimal(10,2)")]
        public decimal RoadPrice { get; set; }

    }
}
