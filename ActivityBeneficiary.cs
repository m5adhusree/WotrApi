using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WotrApi.Models
{
    [Table("activity_beneficiaries")]
    public class ActivityBeneficiary
    {
        [Key]
        public string uid { get; set; }
        public string? state_name { get; set; }
        public string? district_name { get; set; }
        public string? taluka_name { get; set; }
        public string? village_name { get; set; }
        public string? project_name { get; set; }
        public string? project_code { get; set; }
        public string? funder_name { get; set; }
        public string? activity_name { get; set; }

        public string? total_number_of_beneficiaries { get; set; }
        public string? area_covered_ha { get; set; }
        public string? plantations_saplings { get; set; }

        public string? geographic_location_of_work { get; set; }

        public string? deleted_at { get; set; }   // ✅ FIX
    }
}