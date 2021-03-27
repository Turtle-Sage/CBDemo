using System;
using System.Collections.Generic;
using System.Text;

namespace CBDataLibrary.Models
{
    public class OutputModel
    {
        public string source_id { get; set; }
        public object old_source_id { get; set; }
        public string pupil_admission_number { get; set; }
        public string first_name { get; set; }
        public string legal_first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string legal_last_name { get; set; }
        public string former_last_name { get; set; }
        public string gender { get; set; }
        public string year_code { get; set; }
        public string year_group_source_id { get; set; } = "2018-1718";
        public string dob { get; set; }
        public string upn { get; set; }
        public string former_upn { get; set; }
        public string uln { get; set; }
        public bool is_eal { get; set; }
        public object free_meal { get; set; }
        public object free_meal_6 { get; set; }
        public object fsm_review_date { get; set; }
        public string ethnicity_code { get; set; }
        public bool is_pp { get; set; }
        public bool service_child { get; set; }
        public bool looked_after { get; set; } = false;
        public object ever_in_care { get; set; } = false;
        public string sen_category { get; set; }
        public string enrolment_status { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string town_city { get; set; }
        public string county { get; set; }
        public string country { get; set; }
        public string postcode { get; set; }
        public string start_date { get; set; }
        public object end_date { get; set; }
        public object home_language_code { get; set; }
        public object home_language_name { get; set; }
        public string first_language_code { get; set; }
        public object first_language_name { get; set; }
        public object proficiency_in_english_code { get; set; }
        public object proficiency_in_english_name { get; set; }
        public string nationalities { get; set; } = "GBR";
        public string country_of_birth { get; set; } = "GBR";
        public object photo_hash { get; set; }
        public object nhs_number { get; set; }
        public object is_pregnant { get; set; }
        public object has_emergency_consent { get; set; }

    }
}

