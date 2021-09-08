var BlazorChartist = {

    createChart: function (elem, type) {
        // An example pasted from chartist.js docs
        var constructor = Chartist[type];
        elem.chart = new constructor(elem, { series: [] });
    },
    updateChart: function (elem, data) {
        elem.chart.update(data);
    }

};