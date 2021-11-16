searchtext.addEventListener("keyup", function () {
    const aTags = document.querySelectorAll(".card");
    const searchText = document.getElementById("searchtext").value.toLowerCase();

    for (let i = 0; i < aTags.length; i++) {
        if (!aTags[i].textContent.toLowerCase().includes(searchText)) {
            aTags[i].style.display = "none";
        } else {
            aTags[i].style.display = "block";
        }
    }
})

