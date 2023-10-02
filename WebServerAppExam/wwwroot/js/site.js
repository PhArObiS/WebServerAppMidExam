// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// This event listener waits for the entire content of the web page to load
document.addEventListener('DOMContentLoaded', (event) => {

    // This function changes the theme between light and dark mode
    const toggleDarkMode = () => {
        // It checks the current theme; if it's dark, it changes to light and vice versa
        const theme = document.body.getAttribute('data-theme') === 'dark' ? 'light' : 'dark';

        // It then sets the new theme to the body element
        document.body.setAttribute('data-theme', theme);

        // And stores the user's preference in the local storage to remember it next time
        localStorage.setItem('theme', theme);
    }

    // This checks if there's a stored theme preference in local storage, or checks the system's preference
    const savedTheme = localStorage.getItem('theme') ?? (window.matchMedia("(prefers-color-scheme: dark)").matches ? 'dark' : 'light');

    // It then applies the stored or system's preferred theme
    document.body.setAttribute('data-theme', savedTheme);

    // Here, it selects the button with the id of "darkModeToggle"
    const btn = document.querySelector("#darkModeToggle");

    // If the button is found, it adds a click event listener to it
    if (btn) {
        btn.addEventListener('click', toggleDarkMode);  // When the button is clicked, it calls the toggleDarkMode function
    }
});
