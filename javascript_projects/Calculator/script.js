const numbers = document.querySelectorAll('.numbers');
const result = document.querySelector('.result span');
const signs = document.querySelectorAll('.sign');
const equals = document.querySelector('.equals');
const clear = document.querySelector('.clear');
const negative = document.querySelector('.negative');
const percent = document.querySelector('.percent');


let FirstValue = "";
let isFirstValue = false;
let SecondValue = "";
let isSecondValue = false;
let sign = "";
let resultValue = 0;

for(let i = 0; i < numbers.length; i++) {
    numbers[i].addEventListener("click", (e) => {
        let atr = e.target.getAttribute("value");
        if(isFirstValue == false) {
            getFirstValue(atr);
        }
        if(isSecondValue == false) {
            getSecondValue(atr);
        }
    })
}

function getFirstValue(el) {
    result.innerHTML = "";
    FirstValue += el;
    result.innerHTML = FirstValue;
    FirstValue = +FirstValue;
}

function getSecondValue(el) {
    if(FirstValue != "" && sign != "") {
        SecondValue += el;
        result.innerHTML = SecondValue;
        SecondValue = +SecondValue;
    }
}

function getSign() {
    for(let i =0; i < signs.length; i++) {
        signs[i].addEventListener("click", (e) => {
            sign = e.target.getAttribute("value");
            isFirstValue = true;
        })
    }
}

getSign();

equals.addEventListener ('click',() => {
    result.innerHTML = "";
    if(sign === "+") {
        resultValue = FirstValue + SecondValue;
    } else if(sign === "-") {
        resultValue = FirstValue - SecondValue;
    } else if(sign === "x") {
        resultValue = FirstValue * SecondValue;
    } else if(sign === "%") {
        resultValue = FirstValue / SecondValue;
    }
    result.innerHTML = resultValue;
    FirstValue = resultValue;
    SecondValue = "";

    checkResultlength();
})

function checkResultlength () {
    resultValue = JSON.stringify(resultValue);

    if (resultValue.length >= 8) {
        resultValue = JSON.parse(resultValue);
        result.innerHTML = resultValue.toFixed(5);
    }
}

negative.addEventListener('click', () => {
    result.innerHTML = "";
    if(FirstValue != "") {
        resultValue = - FirstValue;
        FirstValue = resultValue;
    }
    if(FirstValue != "" && SecondValue != "" && sign != "") {
        resultValue = -resultValue;
    }
    result.innerHTML = resultValue;
})

percent.addEventListener ("click", () => {
    result.innerHTML = "";
    if(FirstValue != "") {
        resultValue = FirstValue / 100;
        FirstValue = resultValue;
    }
    if(FirstValue != "" && SecondValue != "" && sign != "") {
        resultValue = resultValue / 100;
    }
    result.innerHTML = resultValue;
})

clear.addEventListener ('click', () => {
    result.innerHTML = 0;
    FirstValue = "";
    isFirstValue = false;
    SecondValue = "";
    isSecondValue = false;
    sign = "";
    resultValue = 0;
})