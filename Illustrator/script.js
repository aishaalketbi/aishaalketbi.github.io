let insideOfBackground = document.getElementById("Background");

insideOfBackground.addEventListener("click", () => {
    document.getElementById("text").innerText = "You have clicked on the background!"
});
