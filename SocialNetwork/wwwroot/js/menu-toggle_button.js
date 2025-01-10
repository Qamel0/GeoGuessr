document.addEventListener('DOMContentLoaded', () => {
    const button = document.getElementById('menu-toggle');
    const elements = document.querySelectorAll('.navbar');

    button.addEventListener('click', () => {
        elements.forEach(element => {
            element.classList.toggle('navbar')
        })
    });
});