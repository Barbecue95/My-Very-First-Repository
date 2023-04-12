const cardArray = [
    {
        name : 'fries',
        img  : 'images/fries.png',
    },
    {
        name : 'cheeseburger',
        img  : 'images/cheeseburger.png',
    },
    {
        name : 'hotdog',
        img  : 'images/hotdog.png',
    },
    {
        name : 'ice-cream',
        img  : 'images/ice-cream.png',
    },
    {
        name : 'milkshake',
        img  : 'images/milkshake.png',
    },
    {
        name : 'pizza',
        img  : 'images/pizza.png',
    },
    {
        name : 'fries',
        img  : 'images/fries.png',
    },
    {
        name : 'cheeseburger',
        img  : 'images/cheeseburger.png',
    },
    {
        name : 'hotdog',
        img  : 'images/hotdog.png',
    },
    {
        name : 'ice-cream',
        img  : 'images/ice-cream.png',
    },
    {
        name : 'milkshake',
        img  : 'images/milkshake.png',
    },
    {
        name : 'pizza',
        img  : 'images/pizza.png',
    }
];

cardArray.sort(()=> 0.5 - Math.random());

const gridDisplay = document.querySelector('#grid');
const resultDisplay = document.querySelector('#result');
let cardsChosen = [];
let cardsChosenIds = [];
const cardWon = [];

function createBoard () {
   for (let i = 0; i < cardArray.length; i++) {
    const card = document.createElement ('img');
    card.setAttribute ('src', 'images/blank.png');
    card.setAttribute ('data-id', i);
    card.addEventListener ('click', flipCard);
    gridDisplay.appendChild(card);
}
};

createBoard();

function checkMath () {
    const cards = document.querySelectorAll('img');
    const optionOneId = cardsChosenIds[0];
    const optionTwoId = cardsChosenIds[1];
    console.log (cards);
    console.log ('check for math');
    if (optionOneId === optionTwoId) {
        alert('You have clicked the same image!');
    };
    if (cardsChosen[0] == cardsChosen[1]) {
        alert('You have found a match!');
        cards[optionOneId].setAttribute('src', 'images/white.png');
        cards[optionTwoId].setAttribute('src', 'images/white.png');
        cards[optionOneId].removeEventListener('click', flipCard);
        cards[optionTwoId].removeEventListener('click', flipCard);
        cardWon.push (cardsChosen);
    } else {
        cards[optionOneId].setAttribute('src', 'images/blank.png');
        cards[optionTwoId].setAttribute('src', 'images/blank.png');
        alert('Sorry Try Again!')
    };
    resultDisplay.textContent = cardWon.length;
    cardsChosen = [];
    cardsChosenIds = [];
    if (cardWon.length == cardArray.length/2) {
        resultDisplay.innerHTML = 'Congratulations! You have found them all!'
    }
};

function flipCard () {
    const cardId = this.getAttribute('data-id');
    cardsChosen.push(cardArray[cardId].name);
    cardsChosenIds.push (cardId);
    console.log (cardsChosen);
    console.log (cardsChosenIds);
    this.setAttribute('src', cardArray[cardId].img);
    if (cardsChosen.length === 2) {
        setTimeout ( checkMath, 500);
    };
};