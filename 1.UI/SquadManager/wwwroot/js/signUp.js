$("form").on("submit", function (event) {
    event.preventDefault()

    if($("#password").val() != $("#confirmPassword").val()) {
        $(".error span").show()
        return;
    }

    $(".error span").hide()

    let formData = {
        username: $("#username").val(),
        email: $("#email").val(),
        password: $("#password").val(),
        confirmPassword: $("#confirmPassword").val()
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "http://localhost:5101/api/user/create",
        success: function (result) {
            if(result.response == "OK")
                alert("Criado")
            else
                alert("Erro ao criar")
        },
        error: function (error) {
            console.log(error)
        }
    })
})