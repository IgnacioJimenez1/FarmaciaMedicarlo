const logbox = document.querySelector('.log-box');
const loginLink = document.querySelector('.login-register');
const registerLink = document.querySelector('.link-register');

registerLink.addEventListener('click', () => {
  logbox.classList.add('active');
});

loginLink.addEventListener('click', () => {
  logbox.classList.remove('active');
});