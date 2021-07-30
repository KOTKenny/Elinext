function InitPost(post){
    
    document.getElementById('postTitle').innerHTML = post.title;
    document.getElementById('postDate').innerHTML = post.createDate;
    document.getElementById('postArticle').innerHTML = post.article;

    $('#postSpinner').hide();
    $('#postBody').show();
    $('#postFooter').show();

}

function fetchPost(id){

    const requestUri = requestUrlForPosts + id;

    fetch(requestUri)
        .then(res => res.json())
        .then(
            result => {
                InitPost(result)
            },
        )
}