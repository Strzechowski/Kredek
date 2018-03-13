//Ta funkcja obsługuje wyświetlanie wszystkich rankingów (info a angielskich komentarzach w opisie programu)
$(document).ready(function () {
    // Send an AJAX request
    $.getJSON('api/ranking') //gotowa funkcja getJSON
        .done(function (data) {
            // On success, 'data' contains a list of products.
            $.each(data, function (key, item) {
                // Add a list item for the product.
                $('<li>', { text: formatRanking(item) }).appendTo($('#users'));
            });
        });

});

//Ustawia jakie elementy rankingu są wyświetlane
function formatRanking(item) {
    return 'ID=' + item.ID + ' ' + item.User.FirstName + ' ' + item.User.Surname + ' Punkty: ' + item.Score;
}

//Ta funkcja obsługuje wyświetlanie wszystkich gier
$(document).ready(function () {
    // Send an AJAX request
    $.getJSON('api/games') //gotowa funkcja getJSON
        .done(function (data) {
            // On success, 'data' contains a list of products.
            $.each(data, function (key, gam) {
                // Add a list item for the product.
                $('<li>', { text: formatGame(gam) }).appendTo($('#games'));
            });
        });

});

//Ustawia jakie elementy gier są wyświetlane
function formatGame(gam) {
    return gam.NameOfGame + ' - Ilość wyświetleń: ' + gam.Stats.NumberOfViews;
}

//Funkcja pozwala na wyszukiwanie konkretnego rankingu po ID
function find() {
    var id = $('#userId').val();
    $.getJSON('api/ranking' + '/' + id)  //użycie gotowej funckji getJSON
        .done(function (data) {
            $('#user').text(formatUser(data));
        })
        .fail(function (jqXHR, textStatus, err) {
            $('#user').text('Error: ' + err);
        });
}

//Pozwala wyświetlać imię, nazwisko i ulubione zwierzę użytkowników z rankingu
function formatUser(item) {
    return item.User.FirstName + ' ' + item.User.Surname + ' ulubione zwierzę: ' + item.User.FavouriteAnimal;
}

//Pozwala usunąć użytkownika przy użyciu metody DELETE
function remove() {
    var id = $('#userId').val();

    var request = $.ajax({
        url:  'api/ranking/' + id,
        method: "DELETE"
    })
        .done(function (data) {
            $('#user').text('Udało się usunąć użytkownika');
        })
        .fail(function (jqXHR, textStatus, err) {
            $('#user').text('Error: ' + err);
        });
}

//Pozwala dodać użytkownika przy użyciu metody POST
function add() {
    var id = 1; // nie ma znaczenia jakie id wybierzemy i tak zostanie przydzielone kolejne dostępne
    var firstName = $('#rankingFirstName').val();
    var surname = $('#rankingSurname').val();
    var score = $('#rankingScore').val();
    var animal = $('#rankingAnimal').val();

    var request = $.ajax({
        url: 'api/ranking',
        method: "POST",
        data: {
            ID: id,
            Score : score,
            User : {
                ID: id,
                FirstName: firstName,
                Surname: surname,
                EyeColor: "nie podano",
                FavouriteAnimal: animal
            }
        }
    })
        .done(function (data) {
            $('#user').text('Udało się dodać nowego użytkownika');
        })
        .fail(function (jqXHR, textStatus, err) {
            $('#user').text('Error: ' + err);
        });
}

//Funkcja służy do edycji użytkownika przy pomocy PUT
function edit() {
    var id = $('#userId').val(); 
    var firstName = $('#rankingFirstName').val();
    var surname = $('#rankingSurname').val();
    var score = $('#rankingScore').val();
    var animal = $('#rankingAnimal').val();

    var request = $.ajax({
        url: 'api/ranking/' + id,
        method: "PUT",
        data: {
            ID: id,
            Score: score,
            User: {
                ID: id,
                FirstName: firstName,
                Surname: surname,
                EyeColor: "nie podano",
                FavouriteAnimal: animal
            }
        }
    })
        .done(function (data) {
            $('#user').text('Udało się edytować użytkownika');
        })
        .fail(function (jqXHR, textStatus, err) {
            $('#user').text('Error: ' + err);
        });
}