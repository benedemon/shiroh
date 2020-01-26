document.addEventListener("DOMContentLoaded", function (event) {
    document.getElementById('love-story-head').addEventListener("click", function () {
        document.getElementById('love-story-body').classList.remove('mobile-hide');
    });

    document.getElementById('love-story-body').addEventListener("click", function () {
        document.getElementById('love-story-body').classList.add('mobile-hide');
    });
});