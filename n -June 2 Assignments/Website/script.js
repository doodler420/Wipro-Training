const likeButton = document.querySelector('.like-button');
likeButton.addEventListener('click', function() {
    const isLiked = this.classList.toggle('liked');
    if (isLiked) {
        this.textContent = 'Liked!';
        this.style.backgroundColor = '#e74c3c';
        this.style.color = 'white';
    } 
});

const changeButton = document.getElementById('change-button');
const colors = ['#808080', '#ffffff', '#000000', '#ff0000', '#0000ff'];
let colorIndex = 0;

changeButton.addEventListener('click', () => {
    colorIndex = (colorIndex + 1) % colors.length;
    document.body.style.backgroundColor = colors[colorIndex];
});