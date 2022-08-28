/*
const ctx = document.getElementById('myChart').getContext('2d');
const myChart = new Chart(ctx, {
    type: 'bar',
    data: {
        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
        datasets: [{
            label: '# of Votes',
            data: [12, 19, 3, 5, 2, 3],
            backgroundColor: [
                'rgba(255, 99, 132, 0.2)',
                'rgba(54, 162, 235, 0.2)',
                'rgba(255, 206, 86, 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(153, 102, 255, 0.2)',
                'rgba(255, 159, 64, 0.2)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});
*/

$(function () {
    console.log("Asdadsasd")
    $.ajax({
        type: "POST",
        url: "/manage/Dashboard/GetCauses",
        data: "",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: OnSuccessResult,
        error: OnError
    });

    function OnSuccessResult(data) {

        var _data = data;
        var _chratLabels = _data[0];
        var _chartData = _data[1];
        var _chartLabels1 = _data[2];
        var _chartData1 = _data[3];

        var barColor = ["red", "green", "blue", "orange", "brown", "purple", "gray", "yellow"];

        new Chart("myChart", {
            type: "bar",
            data: {
                labels: _chartLabels1,
                datasets: [{
                    backgroundColor: barColor,
                    data: _chartData1
                }]
            }
        })

        new Chart("pieChart", {
            type: "pie",
            data: {
                labels: _chratLabels,
                datasets: [{
                    backgroundColor: barColor,
                    data: _chartData
                }]
            }
        })

    }

    function OnError(err) {

    }
})


