window.welcomeAlert = () => {
    alert("Welcome!");
}

window.toggleClass = (targetId, classToToggle) => {
    document.getElementById(targetId).classList.toggle(classToToggle);
}

window.returnRandomValue = () => {
    return Math.floor(Math.random() * 11);
}

window.incrementRandomNumber = () => {
    let random = Math.floor(Math.random() * 11);
    DotNet.invokeMethodAsync('DemoRest.Client', 'Increment', random)
        .then(data => {
            alert("sent: " + random + ", received: " + data);
        });
};