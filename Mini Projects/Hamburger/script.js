const hamburgerMenuContainerTag = document.querySelector(
    ".hamburgerMenuContainer"
);

const hamburgerline1tag = document.querySelector(".line1");
const hamburgerline2tag = document.querySelector(".line2");
const hamburgerline3tag = document.querySelector(".line3");

hamburgerMenuContainerTag.addEventListener("click", () => {
    if (hamburgerMenuContainerTag.classList.contains("isOpened")) {
        hamburgerline2tag.classList.remove("hideline2");
        hamburgerline1tag.classList.remove("rotatePlus45deg");
        hamburgerline3tag.classList.remove("rotateMinus45deg");
        hamburgerMenuContainerTag.classList.remove("isOpened");
    } else {
        hamburgerline2tag.classList.add("hideline2");
        hamburgerline1tag.classList.add("rotatePlus45deg");
        hamburgerline3tag.classList.add("rotateMinus45deg");
        hamburgerMenuContainerTag.classList.add("isOpened");
    }
})
