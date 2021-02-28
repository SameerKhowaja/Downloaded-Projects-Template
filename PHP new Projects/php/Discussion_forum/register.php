<?php  require("header.php"); ?>
<script type="text/javascript">
	function check(form1)
	{
		if(
		form1.u_name.value == "" ||
		form1.f_name.value == "" ||
		form1.pwd.value == "" ||
		form1.e_mail.value == ""||
		form1.gender.value == ""||
		form1.dob.value == ""||
		form1.add.value == ""||
		form1.sta.value == "" ||
		form1.cou.value == "" )
		{
		
			if (form1.u_name.value == "")
			{
				document.getElementById("a").innerHTML = "Please, Enter user name.";
				//alert("Please, Enter The Username");
			form1.u_name.form1.focus();
				
			}
			else
			{
				document.getElementById("a").innerHTML = "";
				//alert("Please, Enter The Username");
				form1.u_name.focus();
				
			}
			 if (form1.f_name.value == "")
			{
				document.getElementById("b").innerHTML = "Please, Enter full name.";
				//alert ("Please,Please Enter The Fullname");
				form1.f_name.focus();
				
			}
			else
			{
				document.getElementById("b").innerHTML = "";
				//alert ("Please,Please Enter The Fullname");
				form1.f_name.focus();
			}
			 if (form1.pwd.value == "")
			{
				document.getElementById("c").innerHTML = "Please, Enter password.";
				//alert ("Please,Please Enter The Password");
				form1.pwd.focus();
				
			}
			else
			{
				document.getElementById("c").innerHTML = "";
				//alert ("Please,Please Enter The Password");
				form1.pwd.focus();

			}
			   if (form1.e_mail.value == ""||!= "@")
			{
				document.getElementById("d").innerHTML = "Please, Enter e-mail address.";
				//alert ("Please,Please Enter The E-mail Address");
				form1.e_mail.focus();
				
			}
			
			else
			{
				document.getElementById("d").innerHTML = "";
				//alert ("Please,Please Enter The E-mail Address");
				form1.e_mail.focus();
			}
			 if (form1.gender.value == "")
			{
				document.getElementById("spuid").innerHTML = "Please, Enter the gender.";
				//alert("Please,Please Enter The Gender");
				form1.gender.focus();
				
			}else
			{
				document.getElementById("spuid").innerHTML = "";
				//alert("Please,Please Enter The Gender");
				form1.gender.focus();
			}
			 if (form1.dob.value == "")
			{
				document.getElementById("e").innerHTML = "Please, Enter date of birth.";
		//		alert ("Please,Please Enter The Date Of Birth");
				form1.dob.focus();
				
			}
			else
			{
				document.getElementById("e").innerHTML = "";
		//		alert ("Please,Please Enter The Date Of Birth");
				form1.dob.focus();

			}
			 if (form1.add.value == "")
			{
				document.getElementById("f").innerHTML = "Please, Enter address.";
				//alert ("Please,Please Enter The Address");
				form1.add.focus();
				
			}
			else
			{
				document.getElementById("f").innerHTML = "";
				//alert ("Please,Please Enter The Address");
				form1.add.focus();
			}
			 if (form1.sta.value == "")
			{
				document.getElementById("g").innerHTML = "Please, Enter state.";
				//alert ("Please,Please Enter The State");
				form1.sta.focus();
				
			}
			else
			{
				document.getElementById("g").innerHTML = "";
				//alert ("Please,Please Enter The State");
				form1.sta.focus();

			}
			 if (form1.cou.value == "")
			{
				document.getElementById("h").innerHTML = "Please, Enter country.";
				//alert ("Please,Please Enter The Country");
				form1.cou.focus();
				
			}
			else
			{
				document.getElementById("h").innerHTML = "";
				//alert ("Please,Please Enter The Country");
				form1.cou.focus();
			}
			return false;
		}
		else
			return true;
	}
</script>




<h1 style="color: #2A0055; font-weight: bold">Register User</h1>
<form action="registerH.php" method="post" onsubmit="return check(this)" enctype="multipart/form-data" name = "form1">
<table>
<tr><td><span style="font-weight: bold; color: #2A0000">Access No</span></td>
<td>:</td><td><input name="username" type="text" id="username"required autofocus placeholder="e.g A00000"pattern="[A-Z||0-9]{6}" title="please enter your access number and not more than 6 characters" >
<span id='a' style="color: red;"></span></td></tr>
<tr><td><span style="font-weight: bold; color: #2A0000">Fullname</span></td>
<td>:</td>
<td><input name="fullname" type="text" id="fullname"required autofocus placeholder="full name"pattern="[a-zA-Z]{6,}"title="please enter your full name and not less than 6 letters" />
  <span id='b' style="color: red;"></span></td>
</tr>
<tr><td><span style="font-weight: bold; color: #2A0000">Password</span></td>
<td>:</td><td><input name="password" type="password" id="password"required autofocus placeholder="password"pattern="[a-zA-Z,0-9]{5,}"title="please enter the password">
<span id='c' style="color: red;"></span></td></tr>
<tr><td><span style="font-weight: bold; color: #2A0000">E_Mail</span></td>
<td>:</td><td><input type="email" name="e_mail"><span id='d' style="color: red;"></span></td></tr>
<tr><td><span style="font-weight: bold; color: #2A0000">Gender</span></td>
<td>:</td>
  <td><input type="radio" name="gender" value="male" checked="checked" />
    <span style="font-weight: bold; color: #2A0000">male</span>
    <input type="radio" name="gender" value="female">
    <span style="font-weight: bold; color: #2A0000">female</span></td>
</tr>
<tr><td><span style="font-weight: bold; color: #2A0000">Date Of Birth</span></td>
<td>:</td><td><input type="date" name="dob" id="dob" required autofocus placeholder="year/month/date"title="please enter the correct fomat"><span id='e' style="color: red;"></span></td></tr>
<tr><td><span style="font-weight: bold; color: #2A0000">Address</span></td>
<td>:</td><td><textarea name="address" cols="15" rows="3" id="address"required autofocus placeholder="Address"></textarea><span id='f' style="color: red;"></span></td></tr>
<tr>
  <td><span style="color: #2A0000">state</span></td>
<td>:</td><td><input name="state" type="text" id="state" required autofocus placeholder="village" pattern="[a-zA-Z}{5,}"title=" please eneter the correct fomat"><span id='g' style="color: red;"></span></td></tr>
<tr><td><span style="font-weight: bold">Country</span></td>
<td>:</td><td><select name="country" id="country">
      <option value="Afghanistan">Afghanistan</option>
      <option value="Albania">Albania</option>
      <option value="Algeria">Algeria</option>
      <option value="American">American Samoa</option>
      <option value="Andorra">Andorra</option>
      <option value="Angola">Angola</option>
      <option value="Anguilla">Anguilla</option>
      <option value="Antarctica">Antarctica</option>
      <option value="Antigua">Antigua and Barbuda</option>
      <option value="Argentina">Argentina</option>
      <option value="Armenia">Armenia</option>
      <option value="Aruba">Aruba</option>
      <option value="Australia">Australia</option>
      <option value="Austria">Austria</option>
      <option value="Azerbaijan">Azerbaijan</option>
      <option value="Bahama&rsquo;">Bahamas</option>
      <option value="Bahrain">Bahrain</option>
      <option value="Bangladesh">Bangladesh</option>
      <option value="Barbados">Barbados</option>
      <option value="Belarus">Belarus</option>
      <option value="Belgium">Belgium</option>
      <option value="Belize">Belize</option>
      <option value="Benin">Benin</option>
      <option value="Bermuda">Bermuda</option>
      <option value="Bhutan">Bhutan</option>
      <option value="Bolivia">Bolivia</option>
      <option value="Bosnia">Bosnia and Herzegovina</option>
      <option value="Botswana">Botswana</option>
      <option value="Bouvet">Bouvet Island</option>
      <option value="Brazil">Brazil</option>
      <option value="Bulgaria">Bulgaria</option>
      <option value="Burundi">Burundi</option>
      <option value="Cambodia">Cambodia</option>
      <option value="Cameroon">Cameroon</option>
      <option value="Canada">Canada</option>
      <option value="Chad">Chad</option>
      <option value="Chile">Chile</option>
      <option value="China">China</option>
      <option value="Colombia">Colombia</option>
      <option value="Comoros">Comoros</option>
      <option value="Congo">Congo</option>
      <option value="Croatia&lsquo;">Croatia</option>
      <option value="Cuba">Cuba</option>
      <option value="Czech">Czech Republic</option>
      <option value="Ecuador">Ecuador</option>
      <option value="Egypt">Egypt</option>
      <option value="Eritrea">Eritrea</option>
      <option value="Estonia">Estonia</option>
      <option value="Ethiopia">Ethiopia</option>
      <option value="Fiji">Fiji</option>
      <option value="Finland">Finland</option>
      <option value="France">France</option>
      <option value="French">French Guiana</option>
      <option value="French">French Polynesia</option>
      <option value="French">French Southern Territories</option>
      <option value="Gabon">Gabon</option>
      <option value="Gambia">Gambia</option>
      <option value="Georgia">Georgia</option>
      <option value="Germany">Germany</option>
      <option value="Ghana">Ghana</option>
      <option value="Gibraltar">Gibraltar</option>
      <option value="Greece">Greece</option>
      <option value="Greenland">Greenland</option>
      <option value="Grenada">Grenada</option>
      <option value="Guadeloupe">Guadeloupe</option>
      <option value="Guam">Guam</option>
      <option value="Guatemala">Guatemala</option>
      <option value="Guinea">Guinea</option>
      <option value="Guinea-bissau">Guinea-bissau</option>
      <option value="Guyana">Guyana</option>
      <option value="Haiti">Haiti</option>
      <option value="Honduras">Honduras</option>
      <option value="Hong" kong;="Kong">Hong Kong</option>
      <option value="Hungary">Hungary</option>
      <option value="Iceland">Iceland</option>
      <option value="India">India</option>
      <option value="Indonesia">Indonesia</option>
      <option value="Iran," islamic="Islamic" republic="Republic" of;="of">Iran, Islamic Republic of</option>
      <option value="Iraq">Iraq</option>
      <option value="Ireland">Ireland</option>
      <option value="Israel">Israel</option>
      <option value="Italy">Italy</option>
      <option value="Jamaica">Jamaica</option>
      <option value="Japan">Japan</option>
      <option value="Jordan">Jordan</option>
      <option value="Kazakhstan">Kazakhstan</option>
      <option value="Kenya">Kenya</option>
      <option value="Kiribati">Kiribati</option>
      <option value=";Korea," republic="Republic" of="of">Korea, Republic of</option>
      <option value=";Kuwait">Kuwait</option>
      <option value=";Kyrgyzstan">Kyrgyzstan</option>
      <option value="Latvia">Latvia</option>
      <option value="Lebanon">Lebanon</option>
      <option value="Lesotho">Lesotho</option>
      <option value="Liberia">Liberia</option>
      <option value="Libyan" arab="Arab" jamahiriya;="Jamahiriya">Libyan Arab Jamahiriya</option>
      <option value="Liechtenstein">Liechtenstein</option>
      <option value="Lithuania">Lithuania</option>
      <option value="Luxembourg">Luxembourg</option>
      <option value="Macao">Macao</option>
      <option value="Madagascar">Madagascar</option>
      <option value="Malawi">Malawi</option>
      <option value="Malaysia">Malaysia</option>
      <option value="Maldives">Maldives</option>
      <option value="Mali">Mali</option>
      <option value="Malta">Malta</option>
      <option value="Marshall" islands;="Islands">Marshall Islands</option>
      <option value="Martinique">Martinique</option>
      <option value="Mauritania">Mauritania</option>
      <option value="Mauritius">Mauritius</option>
      <option value="Mayotte">Mayotte</option>
      <option value="Mexico">Mexico</option>
      <option value="Monaco">Monaco</option>
      <option value="Mongolia">Mongolia</option>
      <option value="Montserrat">Montserrat</option>
      <option value="Morocco">Morocco</option>
      <option value="Mozambique">Mozambique</option>
      <option value="Myanmar">Myanmar</option>
      <option value="Namibia">Namibia</option>
      <option value="Nauru">Nauru</option>
      <option value="Nepal">Nepal</option>
      <option value="Netherlands">Netherlands</option>
      <option value="New">New Caledonia</option>
      <option value="Nicaragua">Nicaragua</option>
      <option value="Niger">Niger</option>
      <option value="Nigeria">Nigeria</option>
      <option value="Niue">Niue</option>
      <option value="Norfolk">Norfolk Island</option>
      <option value="Norway">Norway</option>
      <option value="Oman">Oman</option>
      <option value="Pakistan">Pakistan</option>
      <option value="Palau">Palau</option>
      <option value="Panama">Panama</option>
      <option value="Papua">Papua New Guinea</option>
      <option value="Paraguay">Paraguay</option>
      <option value="Peru">Peru</option>
      <option value="Philippines">Philippines</option>
      <option value="Pitcairn">Pitcairn</option>
      <option value="Poland">Poland</option>
      <option value="Portugal">Portugal</option>
      <option value="Puerto">Puerto Rico</option>
      <option value="Qatar">Qatar</option>
      <option value="Reunion">Reunion</option>
      <option value="Romania">Romania</option>
      <option value="Russian">Russian Federation</option>
      <option value="Rwanda">Rwanda</option>
      <option value="Saint">Saint Helena</option>
      <option value="Saint">Saint Kitts and Nevis</option>
      <option value="Saint">Saint Lucia</option>
      <option value="Samoa">Samoa</option>
      <option value="San">San Marino</option>
      <option value="Sao">Sao Tome and Principe</option>
      <option value="Saudi">Saudi Arabia</option>
      <option value="Senegal">Senegal</option>
      <option value="Serbia">Serbia and Montenegro</option>
      <option value="Seychelles">Seychelles</option>
      <option value="Sierra">Sierra Leone</option>
      <option value="Singapore">Singapore</option>
      <option value="Slovakia">Slovakia</option>
      <option value="Slovenia">Slovenia</option>
      <option value="Solomon">Solomon Islands</option>
      <option value="Somalia">Somalia</option>
      <option value="South">South Africa</option>
      <option value="Spain">Spain</option>
      <option value="Sri">Sri Lanka</option>
      <option value="Sudan">Sudan</option>
      <option value="Suriname">Suriname</option>
      <option value="Swaziland">Swaziland</option>
      <option value="Sweden">Sweden</option>
      <option value="Switzerland">Switzerland</option>
      <option value="Tajikistan">Tajikistan</option>
      <option value="Thailand">Thailand</option>
      <option value="Timor-leste">Timor-leste</option>
      <option value="Togo">Togo</option>
      <option value="Tokelau">Tokelau</option>
      <option value="Tonga">Tonga</option>
      <option value="Trinidad">Trinidad and Tobago</option>
      <option value="Tunisia">Tunisia</option>
      <option value="Turkey">Turkey</option>
      <option value="Turkmenistan">Turkmenistan</option>
      <option value="Tuvalu">Tuvalu</option>
      <option value="Uganda" selected="selected">Uganda</option>
      <option value="Ukraine">Ukraine</option>
      <option value="United Kingdom">United Kingdom</option>
      <option value="United States">United States</option>
      <option value="Uruguay">Uruguay</option>
      <option value="Uzbekistan">Uzbekistan</option>
      <option value="Vanuatu">Vanuatu</option>
      <option value="Venezuela">Venezuela</option>
      <option value="Viet Nam">Viet Nam</option>
      <option value="Yemen">Yemen</option>
      <option value="Zambia">Zambia</option>
      <option value="Zimbabwe">Zimbabwe</option>
    </select><span id='h' style="color: red;"></span></td></tr>
<tr>
  <td><span style="font-weight: bold; color: #2A0000">Usertype</span></td>
  <td>:</td>
  <td><span id='h' style="color: red;">
    <label>
    <select name="usertype">
      <option value="Usertyp">-----Choose-Usertype----</option>
      <option value="user">user</option>
    </select>
    </label>
  </span></td>
</tr>


<tr><td><input type="submit" value="Submit"></td><td></td><td><input type="reset" value="Reset"></td></tr></table>
</form>

<?php require("footer.php"); ?>