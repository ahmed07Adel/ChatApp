// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var connection = new signalR.HubConnectionBuilder().withUrl("/Chathub").build();
connection.on("recievemessage",
    function (fromuser, message) {
        var msg = fromuser + ": " + message;
        var li = document.createElement("li");
        li.textContent = msg;
        $("#list").prepend(li);

    });
connection.start();
$("#btnsend").on("click",
    function () {
        var fromuser = $("#txtuser").val();
        var message = $("#txtmessage").val();
        connection.invoke("sendmessage", fromuser, message);
    });

//var SendEmail = function () {
//        $.ajax({
//            type: "Post",
//            url: "/Feedbacks/SendMail",
//            success: function (data) {
//                alert("Success");
//            }
//        })
//}
//$(document).ready(function() {

//    $("#btnsend").submit(function(e) {


//        e.preventDefault();

//        var booking = {
//            InputEmail: $("input[name=InputEmail]").val()

//        }


//        $.ajax({
//            type: 'POST',
//            url: "/ChatRoom/recieveemail",
//            dataType: 'json',
//            data: {
//                email: email,
//            },
//            success: function (status) {
//                console.log('Send');
//            },
//            error: function () {
//                console.log('something went wrong - debug it!');
//            }
//        });

//    });


//});

    

    
//connection.on("recievemail",
//    function (fromuser, message) {
//        var msg = fromuser + ": " + message;
//        var li = document.createElement("li");
//        li.textContent = msg;
//        $("#list").prepend(li);

//    });
//connection.start();
//$("#btnsearch").on("click",
//    function () {
//        var fromuser = $("#txtemail").val();
//        var message = $("#txtmessage").val();
//        connection.invoke("Search", fromuser, message);


//    });


