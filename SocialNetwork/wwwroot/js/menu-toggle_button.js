document.addEventListener('DOMContentLoaded', () => {
    const button = document.getElementById('menu-toggle');
    const elements = document.querySelectorAll('.navbar');

    const handleResize = () => {
        if (window.innerWidth > 1280) {
            elements.forEach(element => {
                element.classList.remove('active');
            });
        }
    };

    button.addEventListener('click', () => {
        elements.forEach(element => {
            element.classList.toggle('active')
        })
    });

    window.addEventListener('resize', handleResize);

    handleResize();
});