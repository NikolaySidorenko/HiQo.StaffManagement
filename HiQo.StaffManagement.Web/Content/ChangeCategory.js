$(function () {

    $('#category').change(function () {
        // получаем выбранный id
        var id = $(this).val();
        $.ajax({
            type: 'GET',
            url: '@Url.Action("PartialEditPositions")/' + id,
            success: function (data) {

                // заменяем содержимое присланным частичным представлением
                $('#position').replaceWith(data);
            }
        });
    });
});

$(function () {

    $('#department').change(function () {
        // получаем выбранный id
        var id = $(this).val();
        $.ajax({
            type: 'GET',
            url: '@Url.Action("PartialEditCategories")/' + id,
            success: function (data) {

                // заменяем содержимое присланным частичным представлением
                $('#category').replaceWith(data);
            }
        });
    });
});