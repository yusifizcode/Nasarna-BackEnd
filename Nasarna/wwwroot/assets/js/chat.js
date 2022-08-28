
$(document).ready(function () {
    var connection = new signalR.HubConnectionBuilder().withUrl("/nasarnaHub").build();

    connection.start();

    connection.on("showAsOnline", function (id) {
        let elem = document.getElementById(id);
        console.log(elem);
        elem.style.setProperty('border-color', 'green', 'important')
    })

    connection.on("showAsOffline", function (id) {
        let elem = document.getElementById(id);
        elem.style.setProperty('border-color', 'red', 'important')
    })

    connection.on("causeAccepted", function () {
        toastr["success"]("Your cause post is accepted!");
    })

    connection.on("causeRejected", function () {
        toastr["error"]("Your cause post is rejected!");
    })

    $("#sendMessage").click(function (e) {
        e.preventDefault();
        var url = $(this).attr("href");
        var ToUserId = $("#chatIdInput").val();
        var Text = $("#messageInput").val();
        connection.invoke("SendPrivateMessage",ToUserId,Text)

        fetch(url, {
            method: "POST",
            body: JSON.stringify({ "ToUserId": ToUserId, "Text": Text}),
            headers: {
                'Content-type': 'application/json',
            },
        })
            .then(response => {
                if (!response.ok) {
                    console.log(response)
                    return;
                }
                return response;
            });
    })

    connection.on("recievePrivateMessage", function (id, name, message) {
        $messageLi = `<li class="self">${message}</li>`
        $msgDropdownLi = `<li><a class="dropdown-item" style="overflow:hidden" href="/account/index/${id}">${name} | ${message}</a></li>`
        $notificationIcn = '<div class="rounded-circle border border-5 border-warning position-absolute" style="top:0px;right:7px"></div>'
        $("#dropdownMenuButton1").append($notificationIcn)
        $(".msg-dropdown").append($msgDropdownLi)
        $(".messages").append($messageLi)
        console.log(`Sender: ${name}`)
        console.log(`message: ${message}`)
    })

    connection.on("sendPrivMessage", function (id, name, message) {
        $messageLi = `<li class="other">${message}</li>`
        $(".messages").append($messageLi)
        console.log(`Sender: ${name}`)
        console.log(`message: ${message}`)
    })

})