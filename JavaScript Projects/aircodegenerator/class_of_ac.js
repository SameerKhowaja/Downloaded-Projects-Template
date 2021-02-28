<script type="text/javascript">
			var aircode_up = [
				'\u030d', /*     ?     */		'\u030e', /*     ?     */		'\u0304', /*     ?     */		'\u0305', /*     ?     */
				'\u033f', /*     ?     */		'\u0311', /*     ?     */		'\u0306', /*     ?     */		'\u0310', /*     ?     */
				'\u0352', /*     ?     */		'\u0357', /*     ?     */		'\u0351', /*     ?     */		'\u0307', /*     ?     */
				'\u0308', /*     ?     */		'\u030a', /*     ?     */		'\u0342', /*     ?     */		'\u0343', /*     ?     */
				'\u0344', /*     ?     */		'\u034a', /*     ?     */		'\u034b', /*     ?     */		'\u034c', /*     ?     */
				'\u0303', /*     Þ     */		'\u0302', /*     ?     */		'\u030c', /*     ?     */		'\u0350', /*     ?     */
				'\u0300', /*     Ì     */		'\u0301', /*     ì     */		'\u030b', /*     ?     */		'\u030f', /*     ?     */
				'\u0312', /*     ?     */		'\u0313', /*     ?     */		'\u0314', /*     ?     */		'\u033d', /*     ?     */
				'\u0309', /*     Ò     */		'\u0363', /*     ?     */		'\u0364', /*     ?     */		'\u0365', /*     ?     */
				'\u0366', /*     ?     */		'\u0367', /*     ?     */		'\u0368', /*     ?     */		'\u0369', /*     ?     */
				'\u036a', /*     ?     */		'\u036b', /*     ?     */		'\u036c', /*     ?     */		'\u036d', /*     ?     */
				'\u036e', /*     ?     */		'\u036f', /*     ?     */		'\u033e', /*     ?     */		'\u035b', /*     ?     */
				'\u0346', /*     ?     */		'\u031a' /*     ?     */
			];

			//those go DOWN
			var aircode_down = [
				'\u0316', /*     ?     */		'\u0317', /*     ?     */		'\u0318', /*     ?     */		'\u0319', /*     ?     */
				'\u031c', /*     ?     */		'\u031d', /*     ?     */		'\u031e', /*     ?     */		'\u031f', /*     ?     */
				'\u0320', /*     ?     */		'\u0324', /*     ?     */		'\u0325', /*     ?     */		'\u0326', /*     ?     */
				'\u0329', /*     ?     */		'\u032a', /*     ?     */		'\u032b', /*     ?     */		'\u032c', /*     ?     */
				'\u032d', /*     ?     */		'\u032e', /*     ?     */		'\u032f', /*     ?     */		'\u0330', /*     ?     */
				'\u0331', /*     ?     */		'\u0332', /*     ?     */		'\u0333', /*     ?     */		'\u0339', /*     ?     */
				'\u033a', /*     ?     */		'\u033b', /*     ?     */		'\u033c', /*     ?     */		'\u0345', /*     ?     */
				'\u0347', /*     ?     */		'\u0348', /*     ?     */		'\u0349', /*     ?     */		'\u034d', /*     ?     */
				'\u034e', /*     ?     */		'\u0353', /*     ?     */		'\u0354', /*     ?     */		'\u0355', /*     ?     */
				'\u0356', /*     ?     */		'\u0359', /*     ?     */		'\u035a', /*     ?     */		'\u0323' /*     ò     */
			];
			
			//those always stay in the middle
			var aircode_mid = [
				'\u0315', /*     ?     */		'\u031b', /*     ?     */		'\u0340', /*     ?     */		'\u0341', /*     ?     */
				'\u0358', /*     ?     */		'\u0321', /*     ?     */		'\u0322', /*     ?     */		'\u0327', /*     ?     */
				'\u0328', /*     ?     */		'\u0334', /*     ?     */		'\u0335', /*     ?     */		'\u0336', /*     ?     */
				'\u034f', /*     ?     */		'\u035c', /*     ?     */		'\u035d', /*     ?     */		'\u035e', /*     ?     */
				'\u035f', /*     ?     */		'\u0360', /*     ?     */		'\u0362', /*     ?     */		'\u0338', /*     ?     */
				'\u0337', /*     ?     */		'\u0361', /*     ?     */		'\u0489' /*     ?_     */		
			];
			
			// random function
			//---------------------------------------------------
			
			//gets an int between 0 and max
			function rand(max)
			{
				return Math.floor(Math.random() * max);
			}

			//gets a random char from a AC char table
			function rand_ac(array)
			{
				var ind = Math.floor(Math.random() * array.length);
				return array[ind];
			}
			
			// utils funcs
			//---------------------------------------------------
			
			//hide show element
			function toggle(id)
			{
				if(document.getElementById(id).style.display == "none")
					document.getElementById(id).style.display = "block";
				else
					document.getElementById(id).style.display = "none";
			}
			
			//lookup char to know if its a zalgo char or not
			function is_ac_char(c)
			{
				var i;
				for(i=0; i<aircode_up.length; i++)
					if(c == aircode_up[i])
						return true;
				for(i=0; i<aircode_down.length; i++)
					if(c == aircode_down[i])
						return true;
				for(i=0; i<aircode_mid.length; i++)
					if(c == aircode_mid[i])
						return true;
				return false;
			}
			
			function draw_ac_table(elid)
			{
				var container = document.getElementById(elid);
				var html = '';

				html += '<b>Chars going up:</b><br />\n';
				html += '<table class="ac_xamp_ref_table">\n';
				html += '<tr>\n';
				for(var i=0; i<aircode_up.length; i++)
				{
					if(!(i % 10))
						html += '</tr><tr>';
					html += '<td class="ac_xamp_td">' + aircode_up[i] + '</td>\n';
				}
				html += '</tr>\n';
				html += '</table>\n';
				
				html += '<br /><b>Chars staying in the middle:</b><br />\n';
				html += '<table class="ac_xamp_ref_table">\n';
				html += '<tr>\n';
				for(var i=0; i<aircode_mid.length; i++)
				{
					if(!(i % 10))
						html += '</tr><tr>';
					html += '<td class="ac_xamp_td">' + aircode_mid[i] + '</td>\n';
				}
				html += '</tr>\n';
				html += '</table>\n';
				
				html += '<br /><b>Chars going down:</b><br />\n';
				html += '<table class="ac_xamp_ref_table">\n';
				html += '<tr>\n';
				for(var i=0; i<aircode_down.length; i++)
				{
					if(!(i % 10))
						html += '</tr><tr>';
					html += '<td class="ac_xamp_td">' + aircode_down[i] + '</td>\n';
				}
				html += '</tr>\n';
				html += '</table>\n';
				
				container.innerHTML = html;
			}
			
			// main shit
			//---------------------------------------------------
			function xamp_textarea(id)
			{
				var p = document.getElementById(id);
				var txt = p.value;
				var newtxt = '';
				for(var i=0; i<txt.length; i++)
				{
					if(is_ac_char(txt.substr(i, 1)))
						continue;
					
					var num_up;
					var num_mid;
					var num_down;
					
					//add the normal character
					newtxt += txt.substr(i, 1);

					//options
					if(document.getElementById('ac_opt_mini').checked)
					{
						num_up = rand(8);
						num_mid = rand(2);
						num_down = rand(8);
					}
					else if(document.getElementById('ac_opt_normal').checked)
					{
						num_up = rand(16) / 2 + 1;
						num_mid = rand(6) / 2;
						num_down = rand(16) / 2 + 1;
					}
					else //maxi
					{
						num_up = rand(64) / 4 + 3;
						num_mid = rand(16) / 4 + 1;
						num_down = rand(64) / 4 + 3;
					}
					
					
					if(document.getElementById('ac_opt_up').checked)
						for(var j=0; j<num_up; j++)
							newtxt += rand_ac(aircode_up);
					if(document.getElementById('ac_opt_mid').checked)
						for(var j=0; j<num_mid; j++)
							newtxt += rand_ac(aircode_mid);
					if(document.getElementById('ac_opt_down').checked)
						for(var j=0; j<num_down; j++)
							newtxt += rand_ac(aircode_down);
				}

				//result is in nextxt, display that
				
				//remove all children of lulz_container
				var container = document.getElementById('lulz_container');
				while(container.childNodes.length)
					container.removeChild(container.childNodes[0]);

				//build blocks for each line & create a <br />
				var lines = newtxt.split("\n");
				for(var i=0; i<lines.length; i++)
				{
					var n = document.createElement('text');
					n.innerHTML = lines[i];
					container.appendChild(n);
					var nl = document.createElement('br');
					container.appendChild(nl);
				}

				//done
			}
		/* ]]> */
		</script>