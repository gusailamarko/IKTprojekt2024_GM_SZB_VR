//ELEMEK KIVÁLASZTÁSA
const kepek = document.querySelectorAll('IMG');
const kepDoboz = document.querySelector('#contentdoboz');
const gomb = document.querySelector('#feladatmegoldas');
const gomb2 = document.querySelector('#reset');
const lapozo = document.querySelector('#lapozo');

//HREF TÖMB
const hrefek = ["tombdef.png", "tombfeltolt.png", "tombrendez.png", "tombmainprog.png", "futasi_kepernyo.png"];

//MŰVELETEK
gomb2.disabled = true;
gomb.addEventListener('click', () => {
    const newimg = document.createElement('IMG');
    const jobbNyil = document.createElement('P');
    jobbNyil.innerHTML = '&rarr;'
    lapozo.append(jobbNyil);
    newimg.src = hrefek[0];
    kepDoboz.append(newimg);    
    jobbNyil.addEventListener('click', () => {
        newimg.src = hrefek[1];
        jobbNyil.addEventListener('click', () => {
            newimg.src = hrefek[2];
            jobbNyil.addEventListener('click', () => {
                newimg.src = hrefek[3];
                jobbNyil.addEventListener('click', () => {
                    newimg.src = hrefek[4];
                    gomb2.disabled = false;
                    jobbNyil.remove();
                })
            })
        })
    })
    gomb.disabled = true;
    gomb2.addEventListener('click', () => {
        window.location.reload();
    });
})