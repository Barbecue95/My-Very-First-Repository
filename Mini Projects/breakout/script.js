const grid = document.querySelector(".grid");
const scoreDisplay = document.querySelector('#score');
const blockWidth = 100;
const blockHeight = 20;
const balldiameter = 20;
const boardWidth = 560;
const boardHeight = 300;
let timeId;
let xDirection = -2
let yDirection = 2
let score = 0;

const userStart = [230, 10];
let currentPosition = userStart;

const ballStart = [270, 40];
let ballcurrentPosition = ballStart;

//create block
class Block {
    constructor(xAxix, yAxix) {
        this.bottomLeft = [xAxix,yAxix];
        this.bottomRight = [xAxix + blockWidth, yAxix];
        this.topLeft = [xAxix, yAxix + blockHeight];
        this.topRight = [xAxix + blockWidth, yAxix + blockHeight];
    }
};

//all my blocks
const blocks = [
    new Block(10,270),
    new Block(120,270),
    new Block(230,270),
    new Block(340,270),
    new Block(450,270),
    new Block(10,240),
    new Block(120,240),
    new Block(230,240),
    new Block(340,240),
    new Block(450,240),
    new Block(10,210),
    new Block(120,210),
    new Block(230,210),
    new Block(340,210),
    new Block(450,210),
]; 

//draw all my blocks
function addBlocks() {
    for(let i=0; i < blocks.length; i++) {
        const block = document.createElement("div");
        block.classList.add("block");
        block.style.left = blocks[i].bottomLeft[0] + "px";
        block.style.bottom = blocks[i].bottomLeft[1] + "px";
        grid.appendChild(block);
    }
}

addBlocks();

const user = document.createElement('div');
user.classList.add('user');
drawuser();
grid.appendChild(user);

//draw the user
function drawuser() {
    user.style.left = currentPosition[0] + 'px'
    user.style.bottom = currentPosition[1] + 'px'
}

//draw ball
function drawBall() {
    ball.style.left = ballcurrentPosition[0] + 'px'
    ball.style.bottom = ballcurrentPosition[1] + 'px'
}

//move user
function moveUser(e) {
    switch (e.key) {
        case 'ArrowLeft':
           if  (currentPosition[0] > 0) {
            currentPosition[0] -= 10
            drawuser()
           }
            break;
        case 'ArrowRight':
            if  (currentPosition[0] < boardWidth - blockWidth) {
            currentPosition[0] += 10
            drawuser()
            }
            break;
    }
}

document.addEventListener('keydown', moveUser)

//add ball
const ball = document.createElement('div');
ball.classList.add('ball');
drawBall();
grid.appendChild(ball);

//move ball
function moveBall() {
    ballcurrentPosition[0] += xDirection
    ballcurrentPosition[1] += yDirection
    drawBall()
    checForCollision()
}

timeId = setInterval(moveBall, 15)

// check for colisions
function checForCollision() {
    //check for block collisions
    for(i = 0; i < blocks.length; i++) {
       if (
        (ballcurrentPosition[0] > blocks[i].bottomLeft[0] && ballcurrentPosition[0] < blocks[i].bottomRight[0]) &&
        ((ballcurrentPosition[1] + balldiameter) > blocks[i].bottomLeft[1] && ballcurrentPosition[1] < blocks[i].topLeft[1])
       ) {
            const allBlocks = Array.from(document.querySelectorAll(".block"));
            allBlocks[i].classList.remove('block');
            blocks.splice(i, 1);
            changeDirection();
            score += 1;
            scoreDisplay.innerHTML = score;

            //check for win
            if (blocks.length == 0) {
                scoreDisplay.innerHTML = "You Win";
                clearInterval(timeId);
                document.removeEventListener("keydown", moveUser);
            } 
       }
        
    }


    //check for wall collisions
    if (ballcurrentPosition[0] >= (boardWidth - balldiameter) || 
        ballcurrentPosition[1] >= (boardHeight - balldiameter) ||
        ballcurrentPosition[0] <= 0
        ) {
        changeDirection()
    }

    //check for  user collisions
    if(
        (ballcurrentPosition[0] > currentPosition[0] && ballcurrentPosition[0] < currentPosition[0] + blockWidth) &&
        (ballcurrentPosition[1] > currentPosition[1] && ballcurrentPosition[1] < currentPosition[1] + blockHeight)
        ) {
            changeDirection();
        }

    //check for game over
    if (ballcurrentPosition[1] <= 0) {
        clearInterval(timeId)
        scoreDisplay.innerHTML = "You Lose"
        document.removeEventListener('keydown', moveUser)
    }

}

function changeDirection() {
    if (xDirection === 2 && yDirection === 2) {
        yDirection = -2
        return
    }
    if (xDirection === 2 && yDirection === -2) {
        xDirection = -2
        return
    }
    if (xDirection === -2 && yDirection === -2) {
        yDirection = 2
        return
    }
    if (xDirection === -2 && yDirection === 2){
        xDirection= 2
        return
    }
}