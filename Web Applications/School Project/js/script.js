const header = document.querySelector('header');

window.addEventListener("scroll", function() {
    header.classList.toggle("sticky", this.window.scrollY > 0);
});

let menu = document.querySelector("#nav-menu");
let navmenu = document.querySelector(".nav-pages");

menu.onclick = () => {
    menu.classList.toggle('bx-x');
    navmenu.classList.toggle('open');
}

let search = document.querySelector('.search-box');
let btn = document.querySelector('#search-icon');
btn.onclick = () => {
    search.classList.toggle('active');
}

let user = document.querySelector(".user");
let login_button = document.querySelector("#user-icon");
login_button.onclick = () => {
    user.classList.toggle('active');
}

document.querySelector(".pop-up").addEventListener("click", function(){
    document.querySelector(".pop-up").style.display = "none";
})

