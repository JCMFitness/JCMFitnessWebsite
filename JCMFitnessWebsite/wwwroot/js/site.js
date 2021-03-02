// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

let downloadButton = document.querySelector('.button');
if (downloadButton) {
    downloadButton.addEventListener('click', function (event) {
        event.preventDefault();

        /* Start loading process. */
        downloadButton.classList.add('loading');

        /* Set delay before switching from loading to success. */
        window.setTimeout(function () {
            downloadButton.classList.remove('loading');
            downloadButton.classList.add('success');
        }, 3000);

        /* Reset animation. */
        window.setTimeout(function () {
            downloadButton.classList.remove('success');
        }, 8000);
    });
};