jQuery(function ($) {
    'use strict',

    //#main-slider
        $(function () {
            $('#main-slider.carousel').carousel({
                interval: 3000
            });
        });


    // accordian
    $('.accordion-toggle').on('click', function () {
        $(this).closest('.panel-group').children().each(function () {
            $(this).find('>.panel-heading').removeClass('active');
        });

        $(this).closest('.panel-heading').toggleClass('active');
    });

    //Initiat WOW JS
    new WOW().init();

    // portfolio filter
    $(window).load(function () {
        'use strict';
        var $portfolio_selectors = $('.portfolio-filter >li>a');
        var $portfolio = $('.portfolio-items');
        $portfolio.isotope({
            itemSelector: '.portfolio-item',
            layoutMode: 'fitRows'
        });

        $portfolio_selectors.on('click', function () {
            $portfolio_selectors.removeClass('active');
            $(this).addClass('active');
            var selector = $(this).attr('data-filter');
            $portfolio.isotope({ filter: selector });
            return false;
        });
    });

    // Contact form
    var form = $('#main-contact-form');
    var baseurl = location.protocol + "//" + location.hostname + (location.port && ":" + location.port) + "/";
    form.submit(function (event) {
        event.preventDefault();
        var form_status = $('<div class="form_status"></div>');
        var username = $('#userName').val(); var userMailId = $('#userMailId').val(); var userPhoneNo = $('#userPhoneNo').val(); var userCmpyName = $('#userCmpyName').val();
        var userSubject = $('#userSubject').val(); var userMessage = $('#userMessage').val();
        var details = { 'UserName': username, 'UserMailId': userMailId, 'UserPhoneNo': userPhoneNo, 'UserCmpyName': userCmpyName, 'UserSubject': userSubject, 'UserMessage': userMessage };
        $.ajax({
            type: "POST",
            url: baseurl + 'mailmanager/SendMail',
            data: JSON.stringify(details),
            async: true,
            contentType: "application/json;charset=utf-8",
            processData: true,
            beforeSend: function () {
                form.prepend(form_status.html('<p><i class="fa fa-spinner fa-spin"></i> Email is sending...</p>').fadeIn());
            },
            success: function (data) {
                var result;
                if (data.toString().toLowerCase() == "success") {
                    result = "Mail sent.";
                    $('#userName').val(''); $('#userMailId').val(''); $('#userPhoneNo').val(''); $('#userCmpyName').val('');
                    $('#userSubject').val(''); $('#userMessage').val('');
                }
                else {
                    result = "Some error occured. Please try again.";
                }
                form_status.html('<p class="text-success">' + result + '</p>').delay(3000).fadeOut();
            },
            error: function (xhr) {
            }
        });
    });



    //goto top
    $('.gototop').click(function (event) {
        event.preventDefault();
        $('html, body').animate({
            scrollTop: $("body").offset().top
        }, 500);
    });

    //Pretty Photo
    $("a[rel^='prettyPhoto']").prettyPhoto({
        social_tools: false
    });
});