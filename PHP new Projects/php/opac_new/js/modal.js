
 $(document).ready( function() {
				
		$('a[name=show]').click(function(e) {
	/* 	$('.resulter').hide();	 */	
		e.preventDefault();
		/* $(".display_all").fadeOut() */
		var id = $(this).attr('id');
		
		var maskHeight = $(document).height();
		var maskWidth = $(window).width();

		$('#mask').css({'width':maskWidth,'height':maskHeight});
		
		$('#mask').fadeIn(500);	
		$('#mask').fadeTo("slow",0.8);	
	
		var winH = $(window).height();
		var winW = $(window).width();
              
		$(".show" + id).css('top',  winH/2-$(".show" + id).height()/2);
		$(".show" + id).css('left', winW/2-$(".show" + id).width()/2);
		
		$(".show" + id).fadeIn(500); 	

		});
		
		$(".close").click( function() {
			$("#mask").fadeOut(500);			
			$(".display_all").fadeOut(500);					
		});

 });
 