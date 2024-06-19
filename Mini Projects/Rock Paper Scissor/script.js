const ComputerChoice = document.getElementById('computer');
const UserChoice = document.getElementById('user');
const ResultDisplay = document.getElementById('result');
const Possibleoutcomes = document.querySelectorAll('button');
let UserChoiceDisplay
let ComputerChoiceDisplay

Possibleoutcomes.forEach(Possibleoutcome => Possibleoutcome.addEventListener ('click', (e) => {
    UserChoiceDisplay = e.target.id;
    UserChoice.innerHTML = UserChoiceDisplay; 
    generateComputerChoice();
    getresult();
}));

function generateComputerChoice() {
    const randomNumber = Math.floor(Math.random() *3) + 1;//the same as Possibleoutcomes.length

    if (randomNumber === 1) {
        ComputerChoiceDisplay = 'rock';
    }

    if (randomNumber === 2) {
        ComputerChoiceDisplay = 'paper';
    }

    if (randomNumber === 3 ) {
        ComputerChoiceDisplay = 'scissor';
    };

    ComputerChoice.innerHTML = ComputerChoiceDisplay;

};

function getresult () {
    if (ComputerChoiceDisplay === UserChoiceDisplay ){
        ResultDisplay.innerHTML = ' Draw! '; 
    };

    if (ComputerChoiceDisplay === 'rock' && UserChoiceDisplay === 'paper' ){
        ResultDisplay.innerHTML = ' You win! '; 
    };

    if (ComputerChoiceDisplay === 'rock' && UserChoiceDisplay === 'scissor' ){
        ResultDisplay.innerHTML = ' You lost!'; 
    };

    if (ComputerChoiceDisplay === 'paper' && UserChoiceDisplay === 'rock' ){
        ResultDisplay.innerHTML = ' You lost! ';
    };

    if (ComputerChoiceDisplay === 'paper' && UserChoiceDisplay === 'scissor' ){
        ResultDisplay.innerHTML = ' You win! '; 
    };

    if (ComputerChoiceDisplay === 'scissor' && UserChoiceDisplay === 'rock' ){
        ResultDisplay.innerHTML = ' You win! '; 
    };

    if (ComputerChoiceDisplay === 'scissor' && UserChoiceDisplay === 'paper' ){
        ResultDisplay.innerHTML = ' You lost! '; 
    }

};



