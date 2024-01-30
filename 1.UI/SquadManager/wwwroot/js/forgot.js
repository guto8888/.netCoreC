$("form").on("submit", function (event) {
    event.preventDefault()

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify($("#email").val()),
        url: "http://localhost:5101/api/user/forgot",
        success: function (result) {
            if(result.response == "OK")
                alert("E-mail enviado para recuperar a senha")
            else
                alert("Erro ao enviar")
        },
        error: function (error) {
            console.log(error)
        }
    })
})