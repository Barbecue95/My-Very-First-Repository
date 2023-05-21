const squares = document.querySelectorAll(".square");
const mole = document.querySelector(".mole");
const timeLeft = document.querySelector("#time-left");
const score = document.querySelector("#score");

let result = 0;
let hitposition;
let CurrentTime = 60;

function RandomSquare () {
    squares.forEach(square => {
        square.classList.remove('mole');
    });
    let RandomPosition = squares[Math.floor(Math.random() * 9)];
    RandomPosition.classList.add('mole');
    hitposition =RandomPosition.id;
};

squares.forEach(square => {
    square.addEventListener('mousedown' , () => {
        if (square.id == hitposition) {
            result++;
            score.textContent = result;
            hitposition = null;
        };
    });
});

function moveMole () {
    let timerId = null;
    timerId = setInterval(RandomSquare, 500);
};

moveMole();

function countdown () {
    CurrentTime--;
    timeLeft.innerHTML = CurrentTime;

    if (CurrentTime === 0) {
        clearInterval(CurrentTimeId);
        alert("Game Over!Your Final Score is" + result);
    }
};

let CurrentTimeId = setInterval(countdown, 1000);

