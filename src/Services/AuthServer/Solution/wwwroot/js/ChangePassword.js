$(document).ready(()=>{
    $(".overlay").hide();
    $('.changePasswordForm').submit(function () {
        if($(this).valid())
            $(".overlay").show();
         else
            $(".overlay").hide();
    });
})