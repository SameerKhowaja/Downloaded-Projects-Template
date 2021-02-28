<!-- ============= Footer ================ -->
		<footer>
			<div class="top_footer container-fluid">
				<div class="container">
					<div class="row">
						
						
					</div> <!-- End row -->
				</div>
			</div> <!-- End top_footer -->
			<div class="bottom_footer container-fluid">
				<div class="container">
					<p class="float_left">Copyright &copy; JKUAT Karen Online Catalog 2016. All rights reserved. </p>
					
				</div>
			</div> <!-- End bottom_footer -->
		</footer>
<!-- ============= /Footer =============== -->

		<!-- Js File -->

		<!-- j Query -->
		<script type="text/javascript" src="js/jquery-2.1.4.js"></script>
		<script type="text/javascript" src="js/jquery.mCustomScrollbar.concat.min.js"></script>
		<script type="text/javascript" src="js/jquery.mCustomScrollbar.concat.min.js"></script>
		<script type="text/javascript" src="js/jquery.bxslider.min.js"></script>
		<script src="js/revolution-slider/jquery.themepunch.tools.min.js"></script> <!-- Revolution Slider Tools -->
		<script src="js/revolution-slider/jquery.themepunch.revolution.min.js"></script> <!-- Revolution Slider -->
		<script type="text/javascript" src="js/revolution-slider/extensions/revolution.extension.actions.min.js"></script>
		<script type="text/javascript" src="js/revolution-slider/extensions/revolution.extension.carousel.min.js"></script>
		<script type="text/javascript" src="js/revolution-slider/extensions/revolution.extension.kenburn.min.js"></script>
		<script type="text/javascript" src="js/revolution-slider/extensions/revolution.extension.layeranimation.min.js"></script>
		<script type="text/javascript" src="js/revolution-slider/extensions/revolution.extension.migration.min.js"></script>
		<script type="text/javascript" src="js/revolution-slider/extensions/revolution.extension.navigation.min.js"></script>
		<script type="text/javascript" src="js/revolution-slider/extensions/revolution.extension.parallax.min.js"></script>
		<script type="text/javascript" src="js/revolution-slider/extensions/revolution.extension.slideanims.min.js"></script>
		<script type="text/javascript" src="js/revolution-slider/extensions/revolution.extension.video.min.js"></script>

		<!-- Bootstrap JS -->
		<script type="text/javascript" src="js/bootstrap.min.js"></script>
                
		<script type="text/javascript" src="js/jquery.appear.js"></script>
		<script type="text/javascript" src="js/jquery.countTo.js"></script>
		<script type="text/javascript" src="js/jquery.fancybox.pack.js"></script>
		<!-- owl-carousel -->
		<script type="text/javascript" src="js/owl.carousel.js"></script>
		<script src="js/owl-custom.js"></script>
		<!-- Custom & Vendor js -->
		<script type="text/javascript" src="js/custom.js"></script>
		<script src="js/jquery-ui.js"></script>
                <script>
                    
  $(function() {
      
    $( "#skills" ).autocomplete({
       
      source: 'search.php'
    });
  });
  </script>
  
  <script type="text/javascript" charset="utf-8" language="javascript" src="admin/js/jquery.dataTables.js"></script>
    <script type="text/javascript" charset="utf-8" language="javascript" src="admin/js/DT_bootstrap.js"></script>
<script type="text/javascript">
    $(document).ready(function() {
    $('#example').DataTable();
} );
</script>
<!--Dialog box-->

 <script>
  $(function() {
    $( "#dialog" ).dialog();
  });
  </script>
<script type="text/javascript" src="js/books.js"></script>
<script type="text/javascript" src="js/modal.js"></script>
<script>
 $(document).ready(function(){
      $('#search_text').keyup(function(){
           var txt = $(this).val();
           if(txt != '')
           {
                $.ajax({
                     url:"fetch_author.php",
                     method:"post",
                     data:{search:txt},
                     dataType:"text",
                     success:function(data)
                     {
                          $('#result').html(data);
                     }
                });
           }
           else
           {
                $('#result').html('');
           }
      });
 });
 </script>

