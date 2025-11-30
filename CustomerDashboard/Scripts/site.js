document.addEventListener('DOMContentLoaded', () => {    
    const links = document.querySelectorAll('.sidebar .nav-link');
    links.forEach(link => {
        if (link.href === window.location.href) link.classList.add('active');
    });
});
