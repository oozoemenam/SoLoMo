//const signalR = require('@microsoft/signalr');

const txtUsername = document.getElementById('txtUsername');
const txtMessage = document.getElementById('txtMessage');
const btnSend = document.getElementById('btnSend');

btnSend.disabled = true;

const connection = new signalR.HubConnectionBuilder()
    //.withUrl('https://localhost:6000/chatHub')
    .withUrl('http://localhost:5000/chatHub')
    //.withUrl('/chatHub')
    .build();

connection.on("ReceiveMessage", (username, message) => {
    const li = document.createElement('li');
    li.textContent = `${username}: ${message}`;
    const messageList = document.getElementById('messages');
    messageList.appendChild(li);
    messageList.scrollTop = messageList.scrollHeight;
});

connection
    .start()
    .then(() => (btnSend.disabled = false))
    .catch((err) => console.error(err.toString()));

txtMessage.addEventListener('keyup', (event) => {
    if (event.key === 'Enter') sendMessage();
});

btnSend.addEventListener('click', sendMessage);

function sendMessage() {
    connection
        .invoke('SendMessage', txtUsername.value, txtMessage, value)
        .catch((err) => console.error(err.toString()))
        .then(() => (txtMessage.value = ''));
}