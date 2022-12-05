using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Test2.Business.Models
{
    public class MisOutputData
    {
        public string source_id { get; set; }
        public string old_source_id { get; set; }
        public string pupil_admission_number { get; set; }
        public string first_name { get; set; }
        public string legal_first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string legal_last_name { get; set; }
        public string former_last_name { get; set; }
        public string gender { get; set; }
        public string year_code { get; set; }
        public string year_group_source_id { get; set; }
        public DateTime? dob { get; set; }
        public string upn { get; set; }
        public string former_upn { get; set; }
        public string uln { get; set; }
        public bool is_eal { get; set; }
        public string free_meal { get; set; }
        public string free_meal_6 { get; set; }
        public DateTime? fsm_review_date { get; set; }
        public string ethnicity_code { get; set; }
        public string is_pp { get; set; } = false;
        public bool service_child { get; set; }
        public bool looked_after { get; set; }
        public bool ever_in_care { get; set; }
        public string sen_category { get; set; }
        public string enrolment_status { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string town_city { get; set; }
        public string county { get; set; }
        public string country { get; set; }
        public string postcode { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public string home_language_code { get; set; }
        public string home_language_name { get; set; }
        public string first_language_code { get; set; }
        public string first_language_name { get; set; }
        public string proficiency_in_english_code { get; set; }
        public string proficiency_in_english_name { get; set; }
        public string nationalities { get; set; }
        public string country_of_birth { get; set; }
        public string photo_hash { get; set; }
        public string nhs_number { get; set; }
        public string is_pregnant { get; set; }
        public string has_emergency_consent { get; set; }
    }
}
