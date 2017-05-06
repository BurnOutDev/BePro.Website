$(window).on('load', function () {
    var $container = $('.portfolio-items');
    $container.isotope({
        masonry: {
            columnWidth: 65,
            isFitWidth: true
        },
        filter: '*',
        animationOptions: {
            duration: 750,
            easing: 'linear',
            queue: false,
        }
    });


});
