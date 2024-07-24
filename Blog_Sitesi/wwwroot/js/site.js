
    $(document).ready(function () {
        var selectedTags = [];

    $('.tag').click(function () {
            var tagId = $(this).data('id');
    if ($(this).hasClass('selected')) {
        $(this).removeClass('selected').css('background-color', '');
                selectedTags = selectedTags.filter(id => id !== tagId);
            } else {
        $(this).addClass('selected').css('background-color', 'green');
    selectedTags.push(tagId);
            }
    $('#SelectedTags').val(selectedTags.join(','));
        });
    });



