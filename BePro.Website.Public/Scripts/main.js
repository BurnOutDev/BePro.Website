var menuTl = new TimelineMax();
menuTl.add(TweenMax.from($('.navbar-custom-left'), 0.5, { x: -200, ease: Power1.easeInOut }));
menuTl.add(TweenMax.staggerFrom($('.navbar-custom-left').children(), 0.5, { x: -200, ease: Power1.easeInOut }, 0.1), "-=0.5");
menuTl.stop();

var subMenuTl = new TimelineMax();
subMenuTl.add(TweenMax.fromTo($('.navbar-custom-sub-left'), 0.5, { x: -250, ease: Power1.easeInOut }, { x: 200, ease: Power1.easeInOut }));
subMenuTl.add(TweenMax.staggerFrom($('.navbar-custom-sub-left').children(), 0.5, { x: -250, ease: Power1.easeInOut }, 0.1), "-=0.5");
subMenuTl.stop();

$($('.navbar-custom-left').children()[0]).hover(function () {
    subMenuTl.play();
    $('.navbar-custom-sub-left').addClass('opened');
},
function () {
    if ($('.navbar-custom-sub-left').is(':hover')) {
        return;
    }
    else {
        subMenuTl.reverse();
        $('.navbar-custom-sub-left').removeClass('opened');
    }
});

$($('.navbar-custom-sub-left')).hover(function () { },
    function () {
        subMenuTl.reverse();
        $('.navbar-custom-sub-left').removeClass('opened');
});

$('.navbar-brand').on('click',
       function () {
           if ($('.navbar-custom-left').hasClass('opened')) {
               menuTl.play();
               $('.navbar-custom-left').removeClass('opened');
           } else {
               menuTl.reverse();
               $('.navbar-custom-left').addClass('opened');
           }
       });

$('#user-dropdown').on('click', function (e) {
    e.stopPropagation();
});

// Home Logo
$('#Logo').on('click', function () { window.location = '/'; });

function main() {

    (function () {
        'use strict';

        $(window).on('load', function () {

            // will first fade out the loading animation 
            $("#status").fadeOut("slow");

            // will fade out the whole DIV that covers the website. 
            $("#preloader").delay(500).fadeOut("slow").remove();

        })

        // Page scroll
        $('a.page-scroll').click(function () {
            if (location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '') && location.hostname == this.hostname) {
                var target = $(this.hash);
                target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
                if (target.length) {
                    $('html,body').animate({
                        scrollTop: target.offset().top - 40
                    }, 900);
                    return false;
                }
            }
        });

        // Show Menu on Book
        $(window).bind('scroll', function () {
            var navHeight = $(window).height() - 100;
            if ($(window).scrollTop() > navHeight) {
                $('.navbar-default').addClass('on');
            } else {
                $('.navbar-default').removeClass('on');
            }
        });

        $('body').scrollspy({
            target: '.navbar-default',
            offset: 80
        })


        // OWL CAROUSEL
        //$(document).ready(function () {
        //    $("#testimonial").owlCarousel({
        //        navigation: false, // Show next and prev buttons
        //        slideSpeed: 300,
        //        paginationSpeed: 400,
        //        singleItem: true
        //    });

        //});

        // Portfolio Isotope Filter
        $(window).on('load', function () {
            var $container = $('.portfolio-items');
            $container.isotope({
                filter: '*',
                animationOptions: {
                    duration: 750,
                    easing: 'linear',
                    queue: false
                }
            });
            $('.cat a').click(function () {
                $('.cat .active').removeClass('active');
                $(this).addClass('active');
                var selector = $(this).attr('data-filter');
                $container.isotope({
                    filter: selector,
                    animationOptions: {
                        duration: 750,
                        easing: 'linear',
                        queue: false
                    }
                });
                return false;
            });

        });



        // jQuery Parallax
        function initParallax() {
            $('#intro').parallax("100%", 0.3);
            $('#services').parallax("100%", 0.3);
            $('#aboutimg').parallax("100%", 0.3);
            $('#testimonials').parallax("100%", 0.1);
        }
        initParallax();

        // Pretty Photo
        $("a[rel^='prettyPhoto']").prettyPhoto({
            social_tools: false
        });

    }());


}
main();