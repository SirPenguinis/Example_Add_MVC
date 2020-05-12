$(document).on('click', "#save-btn", function () {
    const dateElement = $('#new-date');
    const messageElement = $('#new-message');
    const messageList = $('#message-list');
    const newIndex = $('#message-list li').length; // Order the new elements to 0 based index

    const newDate = dateElement.val(); // Get the value of the entered date
    const newMessage = messageElement.val(); // Get the value of the entered message
    const newId = 0; // Default new ID

    // Add new element
    messageList.append('<li><input type="hidden" value="' + newMessage + '" name="Messages[' + newIndex + '].Message"/>' +
        '<input type="hidden" value="' + newDate + '" name="Messages[' + newIndex + '].Date"/>' +
        '<input type="hidden" value="' + newId + '" name="Messages[' + newIndex + '].DatabaseId"/>' +
        '/' + newMessage + "&nbsp; - " + newDate + '</li>');

    dateElement.val('');
    messageElement.val('');

    $('#add-modal').modal('hide');
});