var channelName = 'BBB Wise Giving Alliance';
$(document).ready(function () {
    $.get(
        'https://www.googleapis.com/youtube/v3/channels',
        {
            part: 'contentDetails',
            id: 'UCxK66eTWA00R9qVk-5SfZyw',
            key: 'AIzaSyDSWjSqvhB-NdjinRpufql1NObgF2BsKP4',
        },
        function (data) {
            $.each(data.items, function (i, item) {
                pid = item.contentDetails.relatedPlaylists.uploads;
                
                getVideos();
                getDetails();

            });
        }
    );

    function getVideos() {
        var playList = document.getElementById('playList').innerHTML;
        $.get(
            'https://www.googleapis.com/youtube/v3/playlistItems',
            {
                part: 'snippet',
                maxResults: 30,
                playlistId: playList,
                key: 'AIzaSyDSWjSqvhB-NdjinRpufql1NObgF2BsKP4',
            },
            function (data) {
                var output;
                var next;
                var test;
                $.each(data.items, function (i, item) {
                    console.log(item);
                    videoTitle = item.snippet.title;
                    videoDesc = item.snippet.description;
                    videoId = item.snippet.resourceId.videoId;
                    //videoImg = item.snippet.thumbnails.standard.url;
                    output = '<li>' + videoTitle + '</li>';
                    next =
                        '<li><iframe src="//www.youtube.com/embed/' +
                        videoId +
                        '"></frame></li>';
                    text =
                        '<div class="card shadow" style="flex:1 0 30%; margin-bottom: 50px;"><img src="https://i.ytimg.com/vi/' +
                        videoId +
                        '/hqdefault.jpg"/><div class="card-body"><a class="venobox" data-autoplay="true" data-vbtype="video" href="https://youtu.be/' +
                        videoId +
                        '"><h5 style="color:#18306b;" class="card-title card-title-font"><strong>' +
                        videoTitle +
                        '</strong></h5></a><p class="card-text card-font">' +
                        videoDesc +
                        '</p></div></div>';

                    $('#load').append(text);
                    $('.venobox').venobox();
                });
            }
        );
    }

    function getDetails() {
        var videoId1 = document.getElementById('videoId1').innerHTML;
        var videoId2 = document.getElementById('videoId2').innerHTML;
        var videoId3 = document.getElementById('videoId3').innerHTML;
        
        $.get(
            'https://www.googleapis.com/youtube/v3/videos',
            {
                part: 'snippet',
                id: videoId1,
                key: 'AIzaSyDSWjSqvhB-NdjinRpufql1NObgF2BsKP4',
            },
            function (firstContent) {
                $.each(firstContent.items, function (i, item) {
                    console.log(item);
                    firstTitle = item.snippet.title;
                    firstDesc = item.snippet.description;

                    firstOutput = '<div class="card shadow" style="flex:1 0 30%; margin-bottom: 50px;"><img style="height:400px; width:100%" src="https://i.ytimg.com/vi/' +
                        videoId +
                        '/hqdefault.jpg"/><div class="card-body"><a class="venobox" data-autoplay="true" data-vbtype="video" href="https://youtu.be/' +
                        videoId +
                        '"><h5 style="color:#18306b;" class="card-title card-title-font"><strong>' +
                        videoTitle +
                        '</strong></h5></a><p class="card-text card-font">' +
                        videoDesc +
                        '</p></div></div>';

                    $('#video1').append(firstOutput);
                });
            }
        );

        $.get(
            'https://www.googleapis.com/youtube/v3/videos',
            {
                part: 'snippet',
                id: videoId2,
                key: 'AIzaSyDSWjSqvhB-NdjinRpufql1NObgF2BsKP4',
            },
            function (secondContent) {
                $.each(secondContent.items, function (i, item) {
                    console.log(item);
                    secondTitle = item.snippet.title;
                    secondDesc = item.snippet.description;

                    secondOutput = '<iframe style="height:400px;" src="//www.youtube.com/embed/' +
                        videoId2 +
                        '" frameborder="0"></iframe><div class="card-body"><h5 style="color:#008c56;" class="card-title card-title-font"><strong>' +
                        secondTitle +
                        '</strong></h5><p class="card-text card-font">' +
                        secondDesc +
                        '</p></div>';

                    $('#video2').append(secondOutput);
                });
            }
        );
        
        $.get(
            'https://www.googleapis.com/youtube/v3/videos',
            {
                part: 'snippet',
                id: videoId3,
                key: 'AIzaSyDSWjSqvhB-NdjinRpufql1NObgF2BsKP4',
            },
            function (secondContent) {
                $.each(secondContent.items, function (i, item) {
                    console.log(item);
                    thirdTitle = item.snippet.title;
                    thirdDesc = item.snippet.description;

                    thirdOutput = '<iframe style="height:400px;" src="//www.youtube.com/embed/' +
                        videoId3 +
                        '" frameborder="0"></iframe><div class="card-body"><h5 style="color:#008c56;" class="card-title card-title-font"><strong>' +
                        thirdTitle +
                        '</strong></h5><p class="card-text card-font">' +
                        thirdDesc +
                        '</p></div>';

                    $('#video3').append(thirdOutput);
                });
            }
        );
    }
});