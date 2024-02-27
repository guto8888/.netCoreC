$("form").on("submit", function (event) {
    event.preventDefault()

    let formData = {
        "password": $("#password").val(),
        "username": $("#email").val(),
        "person": {
            "email": $("#email").val(),
        }
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "http://localhost:5101/api/user",
        success: function (result) {
            if(result.response == "Error"){
                $("#email").css("border-color", "red");
                $("#password").css("border-color", "red");
                $("#errorAlert").css("display", "block");
            } else {
                let baseUrl = $('#btnLogin').data('url')
                location = `${baseUrl}?UserId=${result.userId}&PersonId=${result.personId}&Username=${result.username}&Email=${result.email}`
            }
        },
        error: function (error) {
            console.log(error)
        }
    })
})