// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let click = 2;

let queryString = decodeURI(document.location.pathname);
let tag = queryString.substring(queryString.indexOf("/") + 1);
tag = tag.substring(0, tag.indexOf("/") == -1 ? tag.length : tag.indexOf("/"));


$(document).ready(function () {
    $('#MoreNews').click(function (e) {
        // Stop form from sending request to server
        e.preventDefault();

        $.ajax({
            method: "GET",
            url: "api/"+ tag,
            dataType: "json", 
            success: function (data) {
                for (let i = 5 * (click - 1); 5 * click < data.length && i < 5 * click; i++) {
                    let dateArr = data[i].datePublished.replace("T", " ").replace("-", " ").replace("-", " ").split(" ");
                    let dateToNews = "";
                    let temp = dateArr[0];
                    dateArr[0] = dateArr[2];
                    dateArr[2] = temp;
                    for (let j = 0; j < dateArr.length; j++)
                        if(j<2)
                            dateToNews += dateArr[j] + ".";
                        else 
                            dateToNews += dateArr[j] + " ";
                    $('table tbody').append('<tr><td scope = "row"><div><div class="row h4 ml-1"><a href="/ViewNews/'
                        + data[i].id + '">'
                        + data[i].title + '</a></div><div class="row m-1 h6"></div><div class="row"><div class="col">'
                        + data[i].tags + '</div><div class="col text-right">'
                        + dateToNews + '</div></div></div></td></tr>');
                }
                click++;
            },
            error: function (er) {
                console.log(er);
            }
        });
    })

});
