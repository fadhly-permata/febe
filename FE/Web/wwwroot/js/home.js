$('document').ready(() => {
    $.ajax({
        method: 'GET',
        url: 'http://localhost:5288/api/Storage'
    }).done(r => console.log(r));
});