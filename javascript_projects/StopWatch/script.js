const stopwatchTag = document.getElementsByClassName("stopwatch")[0];
const startButtonTag = document.getElementsByClassName("startbutton")[0];
const pauseButtonTag = document.getElementsByClassName("pausebutton")[0];
const continueButtonTag = document.getElementsByClassName("continuebutton")[0];
const restartButtonTag = document.getElementsByClassName("restartbutton")[0];
const milisecondsTag = document.getElementsByClassName("milisecond")[0];

let   miliseconds = 0, seconds=0, minutes =0, hour= 0;

const startTime = () => {
    miliseconds += 1;
    if (miliseconds === 100) {
        miliseconds = 0;
        seconds += 1;
    }

    if (seconds === 60) {
        seconds = 0;
        minutes += 1;   
    }
    if (minutes === 60) {
        minutes = 0;
        hour += 1;
    }


    const secondsText = seconds < 10 ? "0" + seconds.toString() : seconds;
    const minutesText = minutes < 10 ? "0" + minutes.toString() : minutes;
    const hourText = hour < 10 ? "0" + hour.toString() : hour;
    const milisecondsText = miliseconds < 100 ?  + miliseconds.toString() : miliseconds;
    milisecondsTag.textContent= milisecondsText;
    stopwatchTag.textContent = hourText + ":" + minutesText + ":" + secondsText;
    console.log (hour,minutes,seconds,miliseconds);
}


let intervalId;
startButtonTag.addEventListener("click", () => {
     intervalId = setInterval(startTime,10);
})

pauseButtonTag.addEventListener("click", () => {
    clearInterval(intervalId); 
})

continueButtonTag.addEventListener ("click", ()=> {
    clearInterval(intervalId);
    intervalId = setInterval(startTime,10);
})

restartButtonTag.addEventListener ("click", ()=> {
    clearInterval(intervalId);
    seconds=0, minutes =0, hour= 0, miliseconds= 0;
    intervalId = setInterval(startTime,10);
})