// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function buttonClicked() {
    var checkBox = document.getElementById("myCheck");
    var text = document.getElementById("text");
    var button = document.getElementById("submitBtn")

    if (checkBox.checked == true) {
        button.disabled = false;
        text.style.display = "block";
    } else {
        button.disabled = true;
        text.style.display = "none";
    }
}

