const newMenuBtn = document.querySelector(".new-menu");
const modal = document.querySelector(".modal");
const addMenuBtn = document.querySelector(".add-menu-btn");
const menuForm = document.querySelector("#menu-form");
const menuContainer = document.querySelector(".menu-container");
let menus = [];
let currentMenuId = null;

newMenuBtn.addEventListener("click", () => {
  currentMenuId = null;
  menuForm.reset();
  addMenuBtn.innerHTML = "Add Menu";
  modal.style.display = "flex";
});

window.addEventListener("click", (event) => {
  if (event.target == modal) {
    modal.style.display = "none";
  }
});

addMenuBtn.addEventListener("click", () => {
  const formData = new FormData(menuForm);
  const menu = {
    id: currentMenuId ? currentMenuId : menus.length + 1,
    name: formData.get("name"),
    price: Number(formData.get("price")),
    isAvailable: formData.get("isAvailable"),
    image: URL.createObjectURL(formData.get("image")),
  };
  if (currentMenuId) {
    menus = menus.map((item) => (item.id === currentMenuId ? menu : item));
  } else {
    menus.push(menu);
  }
  modal.style.display = "none";
  showMenu();
});

const showMenu = () => {
  menuContainer.innerHTML = "";
  menus.forEach((menu) => {
    const menuCard = document.createElement("div");
    menuCard.classList.add("menu-card");
    menuCard.innerHTML = `
        <div class="menu-card-header">
            <h3>${menu.name}</h3>
            <p>${menu.price}</p>
        </div>
        <div class="menu-card-body">
            <img src="${menu.image}" alt="menu-image" width="300" id="${menu.id}">
        </div>
        <div class="menu-card-footer mt-2">
            <button class="btn btn-primary edit-menu-btn" data-id="${menu.id}">Edit</button>
            <button class="btn btn-primary delete-menu-btn" data-id="${menu.id}">Delete</button>
        </div>
        `;
    menuContainer.appendChild(menuCard);
  });

  document.querySelectorAll(".edit-menu-btn").forEach((button) => {
    button.addEventListener("click", (event) => {
      currentMenuId = Number(event.target.dataset.id);
      const menu = menus.find((menu) => menu.id === currentMenuId);
      menuForm.name.value = menu.name;
      menuForm.price.value = menu.price;
      menuForm.isAvailable.checked = menu.isAvailable;
      addMenuBtn.innerText = "Update Menu";
      modal.style.display = "flex";
    });
  });

  document.querySelectorAll(".delete-menu-btn").forEach((button) => {
    button.addEventListener("click", (event) => {
      const menuId = Number(event.target.dataset.id);
      menus = menus.filter((menu) => menu.id !== menuId);
      showMenu();
    });
  });
};
