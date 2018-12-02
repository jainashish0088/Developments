//console.log('%c Proudly Crafted with ZiOn.', 'background: #222; color: #bada55');

/* ---------------------------------------------- /*
 * Preloader
 /* ---------------------------------------------- */
(function(){
    $(window).on('load', function() {
        $('.loader').fadeOut();
        $('.page-loader').delay(350).fadeOut('slow');
    });
})(jQuery);
//Top function End

$(document).ready(function () {
	
	/*Back Top Link*/
    var offset = 200;
    var duration = 500;
    $(window).scroll(function() {
      if ($(this).scrollTop() > offset) {
        $('.back-to-top').fadeIn(400);
      } else {
        $('.back-to-top').fadeOut(400);
      }
    });

    $('.back-to-top').on('click',function(event) {
      event.preventDefault();
      $('html, body').animate({
        scrollTop: 0
      }, 600);
      return false;
    })
		
});


$(document).ready(function () {
//owl-example 
	$("#owl-top-sallers").owlCarousel({
		autoPlay: 4000, //Set AutoPlay to 4 seconds
		items: 4,
		itemsDesktop: [1199, 3],
		itemsDesktopSmall: [979, 3]

	});
	var owl = $("#owl-top-sallers");
	owl.owlCarousel();
	// Custom Navigation Events
	$(".prev").click(function () {
		owl.trigger('owl.prev');
	})
	$(".next").click(function () {
		owl.trigger('owl.next');
	});
	
});

$(document).ready(function () {
	
	//owl-example-logo-slider 
	$("#owl-logo-slider").owlCarousel({
		autoPlay: 4000, //Set AutoPlay to 4 seconds

		items: 5,
		itemsDesktop: [1199, 5],
		itemsDesktopSmall: [979, 5],
		itemsMobile: [375, 3]

	});
	var owl = $("#owl-logo-slider");
	owl.owlCarousel();
	// Custom Navigation Events
	$(".prev").click(function () {
		owl.trigger('owl.prev');
	})
	$(".next").click(function () {
		owl.trigger('owl.next');
	});

});

$(document).ready(function () {
	$('.collapse').on('shown.bs.collapse', function(){
	$(this).parent().find(".fa-angle-down").removeClass("fa-angle-down").addClass("fa-angle-up");
	}).on('hidden.bs.collapse', function(){
	$(this).parent().find(".fa-angle-up").removeClass("fa-angle-up").addClass("fa-angle-down");
        });
    
});	
	