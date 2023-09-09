
const database = [];


const form = document.querySelector('form');


form.addEventListener('submit', function(event) {
    
    event.preventDefault();

    
    const adInput = document.querySelector('#ad');
    const soyadInput = document.querySelector('#soyad');
    const yasInput = document.querySelector('#yas');
    const sifreInput = document.querySelector('#sifre');
    const emailInput = document.querySelector('#email');

   
    const ad = adInput.value;
    const soyad = soyadInput.value;
    const yas = yasInput.value;
    const sifre = sifreInput.value;
    const email = emailInput.value;

    
    const yeniIstifadeci = {
        Ad: ad,
        Soyad: soyad,
        Yaş: yas,
        Şifrə: sifre,
        Email: email
    };

    
    database.push(yeniIstifadeci);

    
    adInput.value = '';
    soyadInput.value = '';
    yasInput.value = '';
    sifreInput.value = '';
    emailInput.value = '';

    
    console.log('Yeni istifadəçi əlavə edildi:', yeniIstifadeci);
    
    
});

if (yas < 18) {
    alert('Yaşı 18-dən kiçik olan istifadəçilər qeydiyyatdan keçə bilməz!');
    return; 
}

if (soyad.length < 3) {
    alert('Soyad 3 hərfdən az ola bilməz!');
    return; 