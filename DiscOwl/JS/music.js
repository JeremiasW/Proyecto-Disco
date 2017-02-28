$(document).ready(function ()
{
    $("#name").on("click", function ()
    {
        $(this).val("");
    });

    $("#searchByName").on("click", function ()
    {
        $.ajax({
            "url": "/api/MusicApi/SearchByName",
            "type": "POST",
            "contentType": 'application/json',
            "data": $("#name").val(),
            "dataType": "json",
            "success": function(json)
            {
                console.log(JSON.stringify(json));
            }
        });
    });

    var object = null;

    $.ajax({
        "url": "/api/MusicApi/Get",
        "type": "POST",
        "contentType": 'application/json',
        "data": object,
        "dataType": "json",
        "success": function (json) {

            console.log(JSON.stringify(json));

            $(elements).each(function (key, value) {
                $("#elements").html("<tr>" +
                                        "<td>" + value.DiscName + "</td>" +
                                        "<td>" + value.Author + "</td>" +
                                        "<td>" + value.TypeSet + "</td>" +
                                        "<td>" + value.Score + "</td>" +
                                    "</tr>");
            });
        }
    });
});