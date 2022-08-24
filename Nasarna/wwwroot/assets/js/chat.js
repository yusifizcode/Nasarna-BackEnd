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
        console.log($(this));
        console.log("necesen");
        class Message {
            constructor(id, message) {
                this.id = id;
                this.message = message
            }
        }

        

        console.log(e);
        let id = $("#chatIdInput").val();
        let message = $("#messageInput").val();
        let userMessage = new Message(id, message)
        console.log(userMessage)
        e.preventDefault();
        $createMessageUrl = `http://localhost:8296/Home/CreateMessage`
        //fetch($createMessageUrl).then((result) => {

        //    console.log(result);
        //    connection.invoke("SendPrivateMessage", id, message);

            //})
        const requestOptions = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json'   },
            body: userMessage
        };
        fetch(`http://localhost:8296/Home/CreateMessage`, requestOptions)
            .then(async response => {
                

                // check for error response
                if (!response.ok) {
                    // get error message from body or default to response status
                    alert("olmadi")
                    return
                }
                alert("oldu")

            })
            .catch(error => {
                element.parentElement.innerHTML = `Error: ${error}`;
                console.error('There was an error!', error);
            });
    })

    connection.on("recievePrivateMessage", function (id, name, message) {
        $messageLi = `<li class="self"><span>${name}</span>${message}</li>`
        $msgDropdownLi = `<li><a class="dropdown-item" href="/account/index/${id}">${name} | ${message}</a></li>`
        $(".msg-dropdown").append($msgDropdownLi)
        $(".messages").append($messageLi)
        console.log(`Sender: ${name}`)
        console.log(`message: ${message}`)
    })

    connection.on("sendPrivMessage", function (id, name, message) {
        $messageLi = `<li class="other"><span>${name}</span>${message}</li>`
        $(".messages").append($messageLi)
        console.log(`Sender: ${name}`)
        console.log(`message: ${message}`)
    })

})