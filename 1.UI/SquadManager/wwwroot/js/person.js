$('form').on('submit', function (event) {
    event.preventDefault();

    let type = document.getElementById('type').value;

    let method = $("#Id").val() != null && $("#Id").val() != "" ? 'PATCH' : 'POST'

    let url = $("#Id").val() != null && $("#Id").val() != "" ? 'update' : 'create'

    let formData = JSON.stringify({
        "id": $("#Id").val() != "" ? parseInt($("#Id").val()) : 0,
        "name": $("#name").val(),
        "email": $("#email").val(),
        "type": type
    })

    $.ajax({
        type: method,
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: formData,
        url: `http://localhost:5101/api/Person/${url}`,
        success: function (result) {
            if(result.response == "OK")
                alert("Salvo com sucesso")
        },
        error: function (error) {
            console.log(error)
        }
    })
});
