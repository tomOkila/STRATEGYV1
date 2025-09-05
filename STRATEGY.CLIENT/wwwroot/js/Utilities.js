function initializeInactivityTimer(dotnetHelper) {
    var timer;
    document.onmousemove = resetTimer;
    document.onkeypress = resetTimer;

    function resetTimer() {
        clearTimeout(timer);
        timer = setTimeout(logout, 300000); ////60,000 milliseconds = 1 minute
    }

    function logout() {
        dotnetHelper.invokeMethodAsync("Logout");
    }
}