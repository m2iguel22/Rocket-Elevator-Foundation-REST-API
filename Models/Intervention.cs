using System;

namespace Rocket_Rest.Models
{   public class Intervention
    {
        public long id { get; set; }
        public string Author { get; set; }
        public DateTime? Interventions_date_time_start { get; set; }
        public DateTime? Interventions_date_time_end { get; set; }
        public string report { get; set; }
        public string status { get; set; }
        public long building_id { get; set; }
        public long customer_id { get; set; }
        public long? battery_id { get; set; }
        public long? column_id { get; set; }
        public long? elevator_id { get; set; }
        public long employee_id { get; set; }
        public string result { get; set; }
      
    }
}