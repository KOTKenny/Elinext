function sendComment(){

    let comment = {
        username : $('#inputCommentUsername').val(),
        message : $('#inputCommentMessage').val(),
        postid : 1
    }

    fetchSendComment(comment, 'POST');
}

function sendReply(){

    let reply = {
        username : $('#inputReplyUsername').val(),
        message : $('#inputReplyMessage').val(),
        commentid : parseInt($('#hfCommentId').val())
    }

    fetchSendComment(reply, 'POST');
}

function fetchSendComment(item, method){

    const requestUri = requestUrlForComments;
    const requestMetadata = {
        method: method,
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    };

    fetch(requestUri, requestMetadata)
        .then(
            (res) => {
                if(res.status == 200){
                    $('#sendReplyModal').modal('hide');
                    $('#sendCommentModal').modal('hide');
                    toastr.success("Sended!");
                }else{
                    toastr.error("Error!");
                }
            });
}