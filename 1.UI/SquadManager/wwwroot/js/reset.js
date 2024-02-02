$("form").on("submit", function (event) {
    event.preventDefault()

    if($("#password").val() != $("#confirmPassword").val()) {
        $(".error span").show()
        return;
    }

    $(".error span").hide()

    const urlParam = new URLSearchParams(location.search)
    const id = urlParam.get("id")

    let formData = {
        password: $("#password").val(),
        confirmPassword: $("#confirmPassword").val(),
        id: id
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "http://localhost:5101/api/user/reset",
        success: function (result) {
            if(result.response == "OK")
                alert("Senha redefinida")
            else
                alert("Erro ao redefinir senha")
        },
        error: function (error) {
            console.log(error)
        }
    })
})