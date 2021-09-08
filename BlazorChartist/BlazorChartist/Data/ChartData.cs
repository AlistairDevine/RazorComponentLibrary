using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChartist
{
    public class ChartData
    {
        public IEnumerable<string> Labels { get; set; }
        public List<SeriesData> Series { get; set; } = new List<SeriesData>();
    }
}
