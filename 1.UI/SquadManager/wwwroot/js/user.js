$("form").on("submit", function (event) {
    event.preventDefault()
    let formData = {
        "id": parseInt($("#UserId").val()),
        "password": $("#password").val(),
        "confirmPassword": $("#confirmPassword").val(),
        "personId": parseInt($("#PersonId").val()),
        "username": $("#username").val(),
        "person": {
            "id": parseInt($("#PersonId").val()),
            "email": $("#email").val()
        }
    }

    $.ajax({
        type: "PATCH",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "http://localhost:5101/api/user/update",
        success: function (result) {
            if(result.response == "OK")
                alert("Salvo com sucesso")
        },
        error: function (error) {
            console.log(error)
        }
    })
})