using System.Collections.Generic;

namespace CustomerDashboard.Models
{
    public class FiltersResponse
    {
        public List<FilterCategory> Categories { get; set; }
        public List<DatePreset> DateRangePresets { get; set; }
    }

    public class FilterCategory
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
    }

    public class DatePreset
    {
        public string Label { get; set; }
        public string Value { get; set; }
    }
}
