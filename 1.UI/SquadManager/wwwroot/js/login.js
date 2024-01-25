$("form").on("submit", function (event) {
    event.preventDefault()
    let formData = {
        email: $("#email").val(),
        password: $("#password").val()
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "http://localhost:5101/api/user",
        success: function (result) {
            if(result.response == "OK")
                alert("Logado")
            else
                alert("Erro ao logar")
        },
        error: function (error) {
            console.log(error)
        }
    })
})