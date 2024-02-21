$("form").on("submit", function (event) {
    event.preventDefault()
    let formData = {
        "password": $("#password").val(),
        "person": {
            "email": $("#email").val(),
            "username": $("#email").val()
        }
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "http://localhost:5101/api/user",
        success: function (result) {
            if(result.response == "ERROR")
                alert("Erro ao logar")
            else {
                let baseUrl = $('#btnLogin').data('url')
                location = `${baseUrl}?UserId=${result.userId}&PersonId=${result.personId}&Username=${result.username}&Email=${result.email}`
            }
        },
        error: function (error) {
            console.log(error)
        }
    })
})