function InitShowReplyBtn(){
    $('button.reply').click(function (){
        if($('#comment-' + $(this).attr("data-key")).children().length == 1)
            fetchReplies($(this).attr("data-key"));
    });
}

function InitReplySendBtn(){
    $('button.reply-send').click(function (){
        $('#hfCommentId').val($(this).attr("data-key"));
        $('#sendReplyModal').modal('show');
    });
}

$('#sendComment').click(function (){

    var form = $("#sendCommentForm");

    if (form[0].checkValidity() === false) {
      event.preventDefault()
      event.stopPropagation()
    }else{
        sendComment();
    }
    
    form.addClass('was-validated');
});

$('#sendReply').click(function (){

    var form = $("#sendReplyForm");
    console.log("Clicked");

    if (form[0].checkValidity() === false) {
      event.preventDefault()
      event.stopPropagation()
    }else{
        sendReply();
    }
    
    form.addClass('was-validated');
});