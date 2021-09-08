﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChartist
{

    /// <summary>
    /// Adds a data series to the enclosing <see cref="Chart"/> component.
    /// </summary>
    public class Series : ComponentBase, IDisposable
    {
        //Accept data via Razor syntax
        [Parameter] public string Name { get; set; }
        [Parameter] public IEnumerable<double> Values { get; set; }

        //Each time the params change, update a 'SeriesData' instance
        private readonly SeriesData data = new SeriesData();
        protected override void OnParametersSet()
        {
            data.Name = Name;
            data.Data = Values;
        }

        //When we're first added to the UI, attach our data to parent
        //When we're removed from the UI, remove our data from parent
        [CascadingParameter] public Chart OwnerChart { get; set; }

        protected override void OnInitialized() => OwnerChart.Data.Series.Add(data);

        void IDisposable.Dispose() => OwnerChart.Data.Series.Remove(data);
    }
}
// This will be a "data-only" component. It won't render any markup,
// so there's no need to use a .razor file (though you could).