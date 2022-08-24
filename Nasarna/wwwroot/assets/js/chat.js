//class Message {
//    constructor(username, text, when) {
//        this.userName = username;
//        this.text = text;
//        this.when = when;
//    }
//}

//// userName is declared in razor page.
//const username = userName;
//const textInput = document.getElementById('messageText');
//const whenInput = document.getElementById('when');
//const chat = document.getElementById('chat');
//const messagesQueue = [];

//document.getElementById('submitButton').addEventListener('click', () => {
//    var currentdate = new Date();
//    when.innerHTML =
//        (currentdate.getMonth() + 1) + "/"
//        + currentdate.getDate() + "/"
//        + currentdate.getFullYear() + " "
//        + currentdate.toLocaleString('en-US', { hour: 'numeric', minute: 'numeric', hour12: true })
//});

//function clearInputField() {
//    messagesQueue.push(textInput.value);
//    textInput.value = "";
//}

//function sendMessage() {
//    let text = messagesQueue.shift() || "";
//    if (text.trim() === "") return;

//    let when = new Date();
//    let message = new Message(username, text);
//    sendMessageToHub(message);
//}

//function addMessageToChat(message) {
//    let isCurrentUserMessage = message.userName === username;

//    let container = document.createElement('div');
//    container.className = isCurrentUserMessage ? "container darker" : "container";

//    let sender = document.createElement('p');
//    sender.className = "sender";
//    sender.innerHTML = message.userName;
//    let text = document.createElement('p');
//    text.innerHTML = message.text;

//    let when = document.createElement('span');
//    when.className = isCurrentUserMessage ? "time-left" : "time-right";
//    var currentdate = new Date();
//    when.innerHTML =
//        (currentdate.getMonth() + 1) + "/"
//        + currentdate.getDate() + "/"
//        + currentdate.getFullYear() + " "
//        + currentdate.toLocaleString('en-US', { hour: 'numeric', minute: 'numeric', hour12: true })

//    container.appendChild(sender);
//    container.appendChild(text);
//    container.appendChild(when);
//    chat.appendChild(container);
//}


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
        console.log("salamaaa")
        toastr["success"]("Your cause post is accepted!");
    })

    connection.on("causeRejected", function () {
        console.log("salamaaa")
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
        $msgDropdownLi = `<li><a class="dropdown-item" href="/account/index/${id}">${name} | ${message}</a></li>`
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