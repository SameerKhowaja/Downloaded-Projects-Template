<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
<style type="text/css">
<!--

body {
	font: 100%/1.4 Verdana, Arial, Helvetica, sans-serif;
	background:url(images/img36.jpg) repeat fixed;
	margin: 0;
	padding: 0;
	color: #000;
}

/* ~~ Element/tag selectors ~~ */
ul, ol, dl { /* Due to variations between browsers, it's best practices to zero padding and margin on lists. For consistency, you can either specify the amounts you want here, or on the list items (LI, DT, DD) they contain. Remember that what you do here will cascade to the .nav list unless you write a more specific selector. */
	padding: 0;
	margin: 0;
}
h1, h2, h3, h4, h5, h6, p {
	margin-top: 0;	 /* removing the top margin gets around an issue where margins can escape from their containing div. The remaining bottom margin will hold it away from any elements that follow. */
	padding-right: 15px;
	padding-left: 15px; /* adding the padding to the sides of the elements within the divs, instead of the divs themselves, gets rid of any box model math. A nested div with side padding can also be used as an alternate method. */
}
a img { /* this selector removes the default blue border displayed in some browsers around an image when it is surrounded by a link */
	border: none;
}

/* ~~ Styling for your site's links must remain in this order - including the group of selectors that create the hover effect. ~~ */
a:link {
	color: #42413C;
	text-decoration: underline; /* unless you style your links to look extremely unique, it's best to provide underlines for quick visual identification */
}
a:visited {
	color: #6E6C64;
	text-decoration: underline;
}
a:hover, a:active, a:focus { /* this group of selectors will give a keyboard navigator the same hover experience as the person using a mouse. */
	text-decoration: none;
}

/* ~~ this fixed width container surrounds all other divs ~~ */
.container {
	width: 960px;
	background: #FFF;
	margin: 0 auto; /* the auto value on the sides, coupled with the width, centers the layout */
	overflow: hidden; /* this declaration makes the .container understand where the floated columns within ends and contain them */
	border:4px inset #63C;
	box-shadow:0 6px 3px 2px #666;
}

/* ~~ These are the columns for the layout. ~~ 

1) Padding is only placed on the top and/or bottom of the divs. The elements within these divs have padding on their sides. This saves you from any "box model math". Keep in mind, if you add any side padding or border to the div itself, it will be added to the width you define to create the *total* width. You may also choose to remove the padding on the element in the div and place a second div within it with no width and the padding necessary for your design.

2) No margin has been given to the columns since they are all floated. If you must add margin, avoid placing it on the side you're floating toward (for example: a right margin on a div set to float right). Many times, padding can be used instead. For divs where this rule must be broken, you should add a "display:inline" declaration to the div's rule to tame a bug where some versions of Internet Explorer double the margin.

3) Since classes can be used multiple times in a document (and an element can also have multiple classes applied), the columns have been assigned class names instead of IDs. For example, two sidebar divs could be stacked if necessary. These can very easily be changed to IDs if that's your preference, as long as you'll only be using them once per document.

4) If you prefer your nav on the right instead of the left, simply float these columns the opposite direction (all right instead of all left) and they'll render in reverse order. There's no need to move the divs around in the HTML source.

*/
.sidebar1 {
	float: left;
	width: 180px;
	background: #EADCAE;
	padding-bottom: 10px;
}
.content {

	padding: 10px 0;
	width: 780px;
	float: left;
}

/* ~~ This grouped selector gives the lists in the .content area space ~~ */
.content ul, .content ol { 
	padding: 0 15px 15px 40px; /* this padding mirrors the right padding in the headings and paragraph rule above. Padding was placed on the bottom for space between other elements on the lists and on the left to create the indention. These may be adjusted as you wish. */
}

/* ~~ The navigation list styles (can be removed if you choose to use a premade flyout menu like Spry) ~~ */
ul.nav {
	list-style: none; /* this removes the list marker */
	border-top: 1px solid #666; /* this creates the top border for the links - all others are placed using a bottom border on the LI */
	margin-bottom: 15px; /* this creates the space between the navigation on the content below */
}
ul.nav li {
	border-bottom: 1px solid #666; /* this creates the button separation */
}
ul.nav a, ul.nav a:visited { /* grouping these selectors makes sure that your links retain their button look even after being visited */
	padding: 5px 5px 5px 15px;
	display: block; /* this gives the link block properties causing it to fill the whole LI containing it. This causes the entire area to react to a mouse click. */
	width: 160px;  /*this width makes the entire button clickable for IE6. If you don't need to support IE6, it can be removed. Calculate the proper width by subtracting the padding on this link from the width of your sidebar container. */
	text-decoration: none;
	background: #C6D580;
}
ul.nav a:hover, ul.nav a:active, ul.nav a:focus { /* this changes the background and text color for both mouse and keyboard navigators */
	background: #ADB96E;
	color: #FFF;
}

/* ~~ miscellaneous float/clear classes ~~ */
.fltrt {  /* this class can be used to float an element right in your page. The floated element must precede the element it should be next to on the page. */
	float: right;
	margin-left: 8px;
}
.fltlft { /* this class can be used to float an element left in your page. The floated element must precede the element it should be next to on the page. */
	float: left;
	margin-right: 8px;
}
.clearfloat { /* this class can be placed on a <br /> or empty div as the final element following the last floated div (within the #container) if the overflow:hidden on the .container is removed */
	clear:both;
	height:0;
	font-size: 1px;
	line-height: 0px;
}
-->
</style></head>

<body>
<div class="ii">
<div class="container">
  <div class="sidebar1">
    <ul class="nav">
      <li><a href="index.php">HOME</a></li>
      <li><a href="ViewPass.php">VIEW PASSERS</a></li>
      <li><a href="high.php">HIGHEST SCORE</a></li>
      <li></li>
    </ul>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>Created by:</p>
    <p>John Matthews C. Mascarenas</p>
    <p>&nbsp;</p>
    <!-- end .sidebar1 --></div>
  <div class="content">
    <h1>&nbsp;</h1>
    <p align="center"><strong>*  TEST BEGINS HERE *</strong><br />
    <img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image001.gif" alt="" width="358" height="2" />&nbsp;</p>
    <br clear="all" />
    <br />
    <strong>DIRECTIONS:</strong> Choose from among the  suggested answers the word that means most nearly the same as the word in  capital letters. On your Answer Sheet, shade completely the box that  corresponds to your answer.<br />
    <img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image002.gif" alt="" width="358" height="2" />&nbsp; <br clear="all" />
    <ol>
      <li>Ang PAGAL na guro ay sandaling  tumigil bago muling nagpatuloy sa pagsasalita.</li>
    </ol>
    <p>1. pagod                      2. galit                         3.  pihikan<br />
      4. mabagal                   5.  mahinahon</p>
    <ol>
      <li>A special group in the police  force is believe to be engage in FURTIVE activities.</li>
    </ol>
    <p>                  1. illegal                       2. suspicious                3. unusual<br />
      4. worthy                     5. secret</p>
    <ol>
      <li>The Defense presented its case  to the jury in a TRENCHANT manner.</li>
    </ol>
    <p>1. Legalistic                 2.  dignified                 3. vague<br />
      4. emphatic                  5. cautious</p>
    <ol>
      <li>Ang mga magbubukid ay NABIHASA  sa paggamit ng kalabaw bilang katulong nila sa pagsasaka.</li>
    </ol>
    <p>1. nagsawa                  2. nagtiwala                 3. nasanay<br />
      4. natuto                      5. nahirapan</p>
    <ol>
      <li>Pilo&rsquo;s insensitivity has  created ANIMOSITY to the worker&rsquo;s demands.</li>
    </ol>
    <p>                  1. distrust                    2. hostility                   3. fear<br />
      4. distance                   5. dependence</p>
    <ol>
      <li>The baffled owner ACQUIESCED to  the worker&rsquo;s demands.</li>
    </ol>
    <p>                  1. opposed                   2. reacted                    3. agreed<br />
      4. resisted                    5. listened</p>
    <ol>
      <li>The recommendation of the wage  council is REPUGNANT to the employers.</li>
    </ol>
    <p>                  1. acceptable               2. objectionable           3. beneficial<br />
      4. degrading                5. embarrassing</p>
    <ol>
      <li>Sanctuaries for wildlife have  DWINDLED alarmingly in the last decade.</li>
    </ol>
    <p>                  1. disappeared             2. changed                   3.  decreased<br />
      4. multiplied                5. deteriorated</p>
    <p>&nbsp;</p>
    <ol>
      <li>Recklessness always entails  JEOPARDY.</li>
    </ol>
    <p>            1. danger                     2.  crisis                        3.  apprehension<br />
      4.  control                     5. aggression</p>
    <ol>
      <li>Business, like life, is much  too extensive and LEQUESCENT to be wholly contained by any checklist, formula  or theory.</li>
    </ol>
    <p>1. structured                2. changeable              3. complicated <br />
      4. shapeless                 5. confusing</p>
    <p><img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image003.gif" alt="" width="358" height="2" />&nbsp;</p>
    <br clear="all" />
    <br />
    <strong>Directions:</strong> In each of the following sentences is a blank space indicating that  a word or group of words has been omitted. From among the suggested answers  choose the word or groups of words that best conveys the concept or meaning of  the sentence as a whole. On your Answer Sheet, shade completely the box that  corresponds to your answer.
    <p><img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image002_0000.gif" alt="" width="358" height="2" />&nbsp;</p>
    <br clear="all" />
    <ol>
      <li>Realizing that we were  determined to go, our experienced friends __________ that there might be more  difficulties along the way than we expect.</li>
    </ol>
    <p>1. dismissed                2.  intimated                 3. insisted<br />
      4. projected                 5.  concluded</p>
    <ol>
      <li>Ang patuloy na pag-angkat ng  mga produktong banyaga, na siya naming tinatangkilik ng mga mamamayan, ang  dahilan ng __________ ng mga industriyang local.</li>
    </ol>
    <p>                  1. paghinto                  2. pagbabago               3. pagtitipid<br />
      4. pagkawala               5. pagkalugi</p>
    <ol>
      <li>A strong government is needed  to promote __________, not dependency, and to encourage free enterprise.</li>
    </ol>
    <p>                  1. self-alienation          2. self-evaluation         3. self reliance<br />
      4. self-awaremenss      5. self-determination</p>
    <ol>
      <li>Mass media develop in us level  of consciousness that keeps us __________, current events.</li>
    </ol>
    <p>                  1. interested in            2. adjusting to             3. excited over<br />
      4. fearful of                 5.  abreast of</p>
    <ol>
      <li>Failure is the most tiring  experience a person can ever have; there is nothing more __________ than not  succeeding being blocked, not moving ahead.</li>
    </ol>
    <p>                  1. invigorating             2. discouraging            3. exhilarating<br />
      4. enervating               5.  depressing</p>
    <p><img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image002_0001.gif" alt="" width="358" height="2" /><strong>&nbsp;</strong></p>
    <br clear="all" />
    <br />
    <strong>DIRECTIONS:</strong> Some of the sentences in  this section contain an error in grammar or correct usage. On your Answer  sheet, shade completely the box that corresponds to that section of the  sentence that contains the error. If there is no error in the sentence, shade  completely box number 5.<br />
    <img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image002_0002.gif" alt="" width="358" height="2" />&nbsp; <br clear="all" />
    <br />
36. <u>A  three-act play or a novel are to be read</u><u>;</u>            <u>a total of two hundred pages</u>  <br />
                                    1                                                                      2<br />
      <u>of poetry—lyric,  dramatic, or narrative—is</u>          <u>also  required of everyone</u>.<br />
                                    3                                                                      4<br />
      NO ERROR<br />
              5<br />
37. <u>Accuracy of movement</u>,    <u>like  accuracy of words</u>,           <u>are essential to</u>             <br />
                        1                                        2                                        3<br />
      <u>the success of  magical rites</u>.                     NO ERROR<br />
                        4                                                        5
<p>38. <u>If anybody objects</u>,           <u>let them think of a better  scheme</u>        <u>rather than  make fun</u>   <br />
  1                                                  2                                                   3<br />
  <u>of the proposed plan.</u>                    NO ERROR<br />
  4                                               5                        </p>
<p>39. <u>In this modern age of today</u>,        <u>most people are</u>           <u>too highly educated</u>               <br />
  1                                              2                                      3<br />
  <u>to believe in  superstitions</u>.             NO ERROR<br />
  4                                            5</p>
<p>40. <u>College</u><u> teaches us</u>             <u>to form opinions</u>          <u>by the result</u>    <u>of careful thought</u>       <br />
  1                                       2                               3                           4<br />
  NO ERROR.<br />
  5</p>
<p>41. <u>Learners set goals</u>              <u>as  motivation for learning</u>,      <u>and  their successes or failures in </u><br />
  1                                             2                                                                                        <br />
  <u>achieving these goals  determine</u>   <u>how he sets his future goals.</u>               NO ERROR<br />
  3                                                                  4                                               5</p>
<p>42. <u>The Labor Secretary will met representatives</u>       <u>of the entertainment industry tomorrow</u> <br />
  1                                                                                  2<br />
  <u>to discuss problems  affecting the working conditions</u>    <u>of Filipino workers abroad.</u><br />
  3                                                                      4<br />
  NO ERROR<br />
  5<br />
  43. <u>Some people are</u>                <u>simply too opportunities</u>         <u>to take a stand </u>                         <br />
  1                                                  2                                      3                      <br />
  <u>on controversial  issues</u>.                 NO ERROR<br />
  4                                             5</p>
<p>44. <u>We were discussing about political issues</u> <u>so her remarks</u>             <br />
  1                                                          2<br />
  <u>about clothes and  fashion</u>             <u>were completely  beside the point</u>.      NO ERROR<br />
  3                                                          4                                           5</p>
<p>45. <u>The best consultants are those who can suggest</u><br />
  1<br />
  <u>or apply an array of methods aim  at helping  their clients</u><br />
  2<br />
  <u>understand a  situation, diagnose it, and </u><br />
  3<br />
  <u>act accordingly under  a given situation.</u><br />
  4<br />
  NO ERROR<br />
  5</p>
<p>46. <u>We were  touch</u>      <u>by his generosity</u>         <u>when he obviously could ill afford</u><br />
  1                             2                                              3<br />
  <u>to be so generous</u>.            NO ERROR</p>
<ol>
  <ol>
    <li>5</li>
  </ol>
</ol>
<p>47. <u>This is just one approach</u>               <u>to  a selection system</u>               <u>and  there are many</u>      <br />
  1                                                  2                                             3<br />
  <u>from whom to choose</u>                   NO ERROR</p>
<ol>
  <li>5</li>
</ol>
<p>48. Maaaring umabot sa sandaang taon          ang  buhay ng isang tao           <br />
  1                                                      2                              <br />
  kung gugustuhin at susundan lamang       ang mga positibong saloobin.              NO ERROR<br />
  3                                                      4                                               5</p>
<p>49. <u>I use</u>          <u>to take a short siesta</u>       <u>every  afternoon</u>        <u>after lunch.</u>      NO ERROR<br />
  1                            2                                  3                           4                       5</p>
<p>50. <u>The  success of a leader lays</u>          <u>not  only on the leader&rsquo;s ability to influence people,</u>   <br />
  1                                                                        2<br />
  <u>but also in the sincerity  of the purpose</u>     <u>that he desires  to achieve</u>.       NO ERROR<br />
  3                                                    4                                     5</p>
<p><img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image004.gif" alt="" width="358" height="2" /><strong>&nbsp;</strong></p>
<br clear="all" />
<br />
<img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image001_0000.gif" alt="" width="358" height="2" /><strong>DIRECTIONS: </strong>Read each of the following sentences carefully, then choose which  among the several choices in each group is expressed most satisfactorily in  terms of grammar and correct usage. On your sheet, shade completely the box  that corresponds to your answer.
<p>&nbsp;</p>
<p>51.  1.Plumbers who work efficiently from the  point of view of a homemaker are worthy of their  <br />
  wages.<br />
  2. Plumbers are worthy of their wages who work  efficiently from the point of view off a     homemaker.<br />
  3. Plumbers, from the point of view of a  homemaker, who work efficiently, are worthy of their wages.<br />
  4.  From the point of view of a homemaker, plumbers who work efficiently are worthy  of their wages. <br />
  5. Worthy of their wages are plumbers who  work efficiently from the point of view of a  <br />
  homemaker.</p>
<p>52. 1. The time  for most people has come to change their attitudes and lifestyles.<br />
  2. The time has come  when people must change their attitudes and lifestyles.<br />
  3. The time when the  attitudes and lifestyles of the people has come to change.<br />
  4. The people must  change their attitudes and lifestyles and the time had come to change.<br />
  5. People must change  their attitudes and lifestyles, and it is because the time has come to   <br />
  change.</p>
<p>53. 1. Her brother, whom I met in the party, is more richer than you  think.<br />
  2. Her brother, I met  him in the party, is very much richer than you think.<br />
  3. Her brother, whom I  had met in the party, is richer than you think.<br />
  4. Her brother, whom I  met in the party, is much richer than you think.<br />
  5. I met  her  brother in the party and he is richer than you think.</p>
<p>54. 1. The  fisher folks decided to go to the nearby hut finally drenched with rain.<br />
  2. The fisher folks  finally decided to go to the nearby hut drenched with rain.<br />
  3. Drenched with rain,  the fisher folks finally decided to go the nearby hut.<br />
  4. Finally drenched with  rain, the fisher folks decided to go the nearby hut.<br />
  5. Finally deciding to  go to the nearby hut, the fisher folks were drenched with rain.</p>
<p>55. 1. The Filipino  people have regained their respect and trust in their government.<br />
  2. The Filipino people  have regained their respect and trust for their government.<br />
  3. The Filipino people  have regained their respect for their government and even their trust in    <br />
  it.<br />
  4. The Filipino people  have regained their respect for and trust in their government.<br />
  5. The Filipino people  have regained, for their government their respect and trust in it.</p>
<p>56. 1. The education of his children is most paramount in his plans.<br />
  2. The education of his  children is more paramount in his plans.<br />
  3. The education of his children is paramount in  his plans.<br />
  4. The most paramount of  all his plans is how to educate his children.<br />
  5. Paramount in his plans more than any other  things is the education of his children.</p>
<p>97. Point E, F, G, I are arranged in a line in such a way that F is  between G and I, and E is between F and I. If E proceeds G, in what order are  they arranged?<br />
  1. E F G I                                2. E I G F                                3. F I G E<br />
  4. I E F G                                5. I G F E</p>
<p>98. In a certain examination, 300 competitors passed the first part  and 500 passed the second part. The number of competitors who passed both parts  of the examination will most likely be __________. </p>
<p>            1. 800                          2. between 500 and 600                      3. between 400and 500<br />
  4. between 300 and  400                      5. not more than  300</p>
<p>99. Anna, Karen and Nina take turns in getting the midnight shift at  Ward 143 such that no one is assigned two nights in a row. Anna was assigned  two nights ago and is assigned again tomorrow evening. If Karen is assigned the  night immediately following Anna \&rsquo;s duty, who can take tonight&rsquo;s midnight  shift?</p>
<p>            1. Only Anna                          2. Only Karen                         3. Only Nina<br />
  4. Either Anna or  Karen          5. Either Anna or Nina</p>
<p>100. Mina, Bing, Amy, and Cel have surnames Folres, Mendez, Presez  and Reyex but not respectively. Mina is taller than Amy and Cel. Ms. Mendez is  tallest of the four. Ms. Flores is taller than Ms. Reyes but shorter than Ms.  Perez. Also, Cel is taller than Amy and Bing. What is the full name of the  second tallest person?<br />
  <br />
  1. Amy Mendez                      2. Cel Perez                             3. Cel Flores<br />
  4. Bing Reyes                          5. Mina Perez</p>
<p><img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image002_0003.gif" alt="" width="358" height="2" /><strong>&nbsp;</strong></p>
<br clear="all" />
<br />
<img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image001_0003.gif" alt="" width="358" height="2" /><strong>DIRECTIONS: </strong>Each item in this section consists of a statement or a passage  followed by several assumptions. Determine the best assumption that can be  logically made from the given statement or passage. On your Answer Sheet, shade  completely the box that corresponds to your answer.
<p>101. Gigi is probably a pianist. She can really stretch her hands  and fingers.</p>
<p>            ASSUMPTION:</p>
<ol>
  <li>Only people with big hands and  long fingers can be pianists.</li>
  <li>Playing the piano helps Gigi  stretch her hands and fingers.</li>
  <li>Stretching helps pianist  perform better</li>
  <li>A long stretch enables pianists  to reach more keys on the piano</li>
  <li>Pianists can really stretch  their hands and fingers</li>
</ol>
<p>102. Arlene should not be part of the basketball team because she  does not trust her teammates.</p>
<p>            ASSUMPTION:</p>
<ol>
  <li>The Basketball team needs  Arlene even if she can has no faith in them</li>
  <li>Team mates should have faith in  each other</li>
  <li>Arlene&rsquo;s team mates are not  trustworthy</li>
  <li>Arlene&rsquo;s team mates do not have  faith in the teams</li>
  <li>Arlene is better than  her team mates</li>
</ol>
<p>103. If you are so smart, then why aren&rsquo;t you rich?<br />
  <br />
  ASSUMPTION:</p>
<ol>
  <li>To become rich is difficult</li>
  <li>Only the rich are smart</li>
  <li>Only the smart are rich</li>
  <li>All rich people are smart</li>
  <li>All smart people are rich</li>
</ol>
<p>104. In order to improve our admission process and get better  students, we have decided to include an interview of the applicants as a  criterion.</p>
<p>            ASSUMPTION:</p>
<ol>
  <li>Current admission procedures  are greatly inadequate</li>
  <li>current admission criteria need  to be updated</li>
  <li>An interview of the applicants  will help draw better students</li>
  <li>An interview of the applicants  will be too time consuming</li>
  <li>An interview of the applicants  will ensure the students success in school</li>
</ol>
<p>&nbsp;</p>
<p>105. The present administration helps poor people acquire basic  necessities for living that is why it helps quarter dwellers like Aling Rosie</p>
<p>            ASSUMPTION:</p>
<ol>
  <li>The present administration  hates rich people </li>
  <li>Aling Rosie asked the present  administration to help her</li>
  <li>Squatter dwellers pretended to  be poor</li>
  <li>Squatter dwellers compete with  poor people for the present administration&rsquo;s attention</li>
  <li>Squatter dwellers are  considered poor people</li>
</ol>
<p><img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image002_0004.gif" alt="" width="358" height="2" />&nbsp;</p>
<br clear="all" />
<br />
<strong>DIRECTION:</strong> Each item in this section  consists of statements followed by several possible conclusions. Assume that  all statements are true, then determine the best conclusion that can be  logically made from the given statements. On your Answer Sheet, shade  completely the box that corresponds to your answer.<br />
<img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image002_0005.gif" alt="" width="358" height="2" />&nbsp; <br clear="all" />
<p>106. Artists are never ham-handed. All artists are inquisitive.  Peter is not ham-handed.<br />
  Florence is not inquisitive.</p>
<p>            CONCLUSION:</p>
<ol>
  <li>Peter is an artist</li>
  <li>Peter is not an artist</li>
  <li>Florence is not an  artists</li>
  <li>Florence is not an  artists</li>
  <li>Inquisitive people are not  ham-handed</li>
</ol>
<p>107. Subscribing to Cable T.V. is a luxury. All luxuries are needles  expenditures. Having a cellular phone is not a luxury. Dining in a Five-Star  hotel is a needless expenditure<br />
  CONCLUSION:</p>
<ol>
  <li>Having a cellular phone is not  a needless expenditure</li>
  <li>Subscribing to Cable TV is a  needless expenditure</li>
  <li>Subscribing to cable TV is not  a needless expenditure</li>
  <li>Dining in a Five-Star hotel is  not a luxury</li>
  <li>Dining in a Five-Star hotel is  a luxury</li>
</ol>
<p>108. Some managers are not analytical. All managers are ruthless.  Vicente is Ruthless. <br />
  <br />
  CONCLUSION:</p>
<ol>
  <li>Vicente is a manager but is not  analytical</li>
  <li>Vicente is analytical but is  not a manager</li>
  <li>Some ruthless managers are not  analytical</li>
  <li>Not all analytical managers are  ruthless</li>
  <li>All ruthless people are  analytical</li>
</ol>
<p>109. All of my friends believe in marriage. Geraldine is a new  friend. She lives with an officemate in an apartment downtown.</p>
<p>            CONCLUSION:</p>
<ol>
  <li>Her housemate is most likely a  good friend</li>
  <li>She is living-in with her  boyfriend</li>
  <li>She needs a companion in the  city</li>
  <li>Geraldine believes in marriage</li>
  <li>Geraldine is not married yet</li>
</ol>
<p>110. There are fewer juvenile delinquents in communities where the  youth participate actively in different socio-civic and religious clubs.  Barangay X has a number of youth clubs.<br />
  <br />
  CONCLUSION:</p>
<ol>
  <li>Barangay X has fewer juvenile  delinquents than other barangays</li>
  <li>Parents in Barangay X exert  great efforts to prevent juvenile delinquency</li>
  <li>Municipal officials encourage  the organization of youth clubs</li>
  <li>Community development workers  in Baranggay X give training in organizing youth clubs</li>
  <li>All young people in Baranggay X  are member of at least two youth clubs.</li>
</ol>
<p><img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image001_0004.gif" alt="" width="358" height="2" />&nbsp;</p>
<br clear="all" />
<br />
<strong>DIRECTION:</strong> For each item in this  section, determine the relationship between the first and the second numbers or  the first and third number. From among the suggested answer, choose the number  that will complete the analogy.<br />
<img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image009.gif" alt="" width="358" height="2" />&nbsp; <br clear="all" />
<p>111. 32 is to 9 as 92 is to __________<br />
  1. 18                            2. 27                            3. 72<br />
  4. 81                            5. 90</p>
<p>112. 30% is to 3/5 as 60% is to __________<br />
  1. 1 1/5                        2. 1 ¼                          3. 3 ½<br />
  4. 2 1/3                        5. 2 ¾</p>
<p>113. 0.25 is to 0.125 as 1.25 is to __________<br />
  1. 6.250                       2. 2.125                       3. 1.625<br />
  4. 1.125                       5. 0.625</p>
<p>114. 12.5 is to 1/8 as 20 is to __________<br />
  1. 1/6                           2. 1/5                           3. ¼<br />
  4. 1/3                           5. ½</p>
<p>115. 6  is to 15 as 36 is to  ___________<br />
  1. 90                            2. 82                            3. 75<br />
  4. 72                            5. 60<br />
  <img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image004_0000.gif" alt="" width="358" height="2" />&nbsp;</p>
<br clear="all" />
<br />
<strong>DIRECTION: </strong>Each item section contains a  series of numbers arranged according to a certain rule or order. Study the  series and determine which number is next. You may use the margin of the page  for your computations. On your Answer Sheet, shade completely the box that  corresponds to your answer.<br />
<img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image004_0001.gif" alt="" width="358" height="2" /><strong>&nbsp;</strong> <br clear="all" />
<p>116.     9.12     18.13   16.15   13.18   9.22     __________<br />
  <br />
  1. 3.25                         2 . 4.27                                    3. 5.23<br />
  4. 6.29                         5. 5.26             </p>
<p>117.      1         4          13        40        121      364      __________</p>
<p>            1. 623                          2. 719                          3. 865<br />
  4. 997                          5. 1093</p>
<p>118.     5          17        19        6          14        16        7          10        12        8          _________</p>
<p>            1. 17                            2. 15                            3. 11<br />
  4. 9                              5. 5</p>
<p>119.     795      2611    684      2722    573      2833    __________</p>
<p>            1. 543                          2. 484                          3. 462<br />
  4. 446                          5. –426</p>
<p>120.     -6         30        -150     750      __________</p>
<p>            1. 3750                        2. 2250                        3. –1500<br />
  4. –2250                      5. –3750</p>
<p>121.     1/3       3/9       5/15     7/21     9/27     __________<br />
  <br />
  1. 11/35                       2. 11/33                       3. 9/29<br />
  4. 8/25                         5. 4/13</p>
<p>122.     4          16        8          40        20        120      60        420      __________<br />
  <br />
  1. 480                          2. 360                          3. 240<br />
  4. 210                          5. 140</p>
<p>123.     2          5          8          10        4          17        5          26        6           __________</p>
<p>            1. 40                            2. 38                            3. 37<br />
  4. 35                            5. 33<br />
  124.     .02       .06       .12       .20       .30       __________</p>
<p>            1. 0.36                         2. .40                           3. .42<br />
  4. .46                           5. .48</p>
<p>125.     2          5          12.5     31.25   __________<br />
  <br />
  1. 33.75                       2. 43.25                       3. 50.75<br />
  4. 78.125                     5. 82.125</p>
<p><img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image004_0002.gif" alt="" width="358" height="2" />&nbsp;</p>
<br clear="all" />
<br />
<strong>DIRECTION: </strong>Answer the following  questions by observation or computation. You may use the margins of the page  for your computations. On your Answer Sheet, shade completely the box that  corresponds to your answer.<br />
<img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image010.gif" alt="" width="358" height="2" />&nbsp; <br clear="all" />
<p>126. If the following quantities were arrange from the least to the  greatest,  which one would have the  second greatest value?</p>
<p>            1. 6/12                                     2. 5/12                                     3. 4/10<br />
  4. ¾                                         5. 2/6               </p>
<p>127. The ratio of males to females in an organization is <strong>M</strong> is  to <strong>F.</strong> How many males are there if there are <strong>T</strong> females?</p>
<p>            1. (M x T) + F             2. (F x T) + M             3. T + (F + M)<br />
  4. (M x T) / F                           5. [M / (M+F)] x T</p>
<p>128. Suppose that the time now is 9:30 a.m.  What will be the time 16 hours from now?</p>
<p>            1. 12:30 a.m.               2. 1:30 am                   3. 2:30 am<br />
  4. 11:30 pm                 5. 12:30 pm</p>
<p>129. What number when increased by 90% of itself equals 133?</p>
<p>            1. 30                            2. 43                            3. 70<br />
  4. 119                          5. 120</p>
<p>130. If y- -3. Which of the following has the greatest value?<br />
  1. y2                              2.  y3                            3. 1/y2<br />
  4. 1 + y                        5. 1-y</p>
<p>131. Which of the following has the least numerical value?<br />
  1. 6+3x4                      2. 4+3x6                      3. 4x6+3<br />
  4. 3x6+4                      5. 3+6x4</p>
<p>132. A trader bought a watch and sold it at 30% more than its  original cost. How much did the  trader  earn if the original cost of the watch was P?<br />
  <br />
  1. P + 30%                  2. P – 30%                   3. 30% x P<br />
  4. 30% / P                    5. P + (P x 30%)</p>
<p>133. What is the standard numerical value for 3.54 x 105 ?</p>
<p>            1. 0.000354                 2. 0.00354                   3. 3, 3540<br />
  4. 35, 400                    5. 354, 000</p>
<p>134. Of set S – 4/5, 41/50, 17/20, 75% the element with the largest  value is __________.</p>
<p>            1. 75%                         2. 4/5                           3. 41/50<br />
  4. 17/20                       5. None, they are all  equal</p>
<p>135. What is the smallest positive number that will give a remainder  of 3 when it is divided by 4, 5, or 10 ?</p>
<p>            1. 63                            2. 53                            3. 43<br />
  4. 33                            5. 23<br />
  <img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image010_0000.gif" alt="" width="358" height="2" />&nbsp;</p>
<br clear="all" />
<br />
<strong>DIRECTION:</strong> For each of the problems  below, choose the correct answer from the choices given. You may use the space  at the right portion of the page for your computations. On your Answer Sheet,  shade completely the box that corresponds to your answer.<br />
<img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image001_0005.gif" alt="" width="358" height="2" />&nbsp;
<p>&nbsp;</p>
<br clear="all" />
<ol>
  <li>There are 36 reams of bond paper  in a drawer. If 1 ¼ dozens of reams of paper were to be used in printing, how  many reams should be left in the drawer?</li>
</ol>
<p>1. 15                               2.  20                                        3.  21<br />
  4. 22                               5.  23</p>
<ol>
  <li>If a poster, which is 3 inches  wide and 5 inches long, is enlarged such that the ratio of the width to the  length is maintained, how many inches long will it be if the new width is 9  inches?</li>
</ol>
<p>&nbsp;</p>
<p>1. 11                               2.  13                                        3.  15<br />
  4. 25                               5.  27</p>
<ol>
  <li>If a worker can wash all the  glass windows of a building in 9 days, what part of the job can said workers  finish in 6 days?</li>
</ol>
<p>&nbsp;</p>
<p>1. ¼                                2.  1/3                                       3.  2/3<br />
  4. 3/5                              5.  ¾</p>
<ol>
  <li>Ms. Cortez bought 20 blouses  for P2, 400 and marked them to sell at P145 each. After selling 16 pieces at  this rate, She decided to sell the remaining blouses at a lower price. At what  price may she sell each remaining blouse and still realize a profit of P480 on  the 20 blouses?</li>
</ol>
<p>&nbsp;</p>
<p>1. P143                           2.  P140                                    3.  P138<br />
  4. P135                           5.  P133</p>
<ol>
  <li>In a room of ten people, how  many handshakes will there be if every person shakes hands with everyone else  exactly once?</li>
</ol>
<p>&nbsp;</p>
<p>1. 10                               2.  45                                        3.  54<br />
  4. 60                               5.  81</p>
<ol>
  <li>The numerator of a fraction is  4 less than its denominator. If 3 added to both the numerator and the  denominator the resulting number is ¾. What is the original fraction?</li>
</ol>
<p>&nbsp;</p>
<p>1. 8.14                            2.  9/12                                     3.  10/12<br />
  4. 9/13                            5.  10/13</p>
<ol>
  <li>Mang Gustin can climb a coconut  tree at the rate of 10 ft. per minute and return at 20 ft. per minute. If it  took him 3 minutes to climb and return, what is the height of the coconut tree?</li>
</ol>
<p>&nbsp;</p>
<p>1.20 ft.                           2.  18 ft.                                   3.  15 ft.<br />
  4. 13 ft.                          5.  10 ft.</p>
<ol>
  <li>A fence is to be on posts 8  meters apart around a rectangular lot that measures 40 meters long and 16  meters wide. How many posts are needed, including the ones placed at each  corner, to fence the entire lot?</li>
</ol>
<p>&nbsp;</p>
<p>1. 20                               2.  18                                        3.  16<br />
  4. 14                               5.  12</p>
<ol>
  <li>How many degrees are there in  the angle made by the hands of a clock at 4 o&rsquo;clock?</li>
</ol>
<p>&nbsp;</p>
<ol>
  <li>150o                          2. 120 o                                    3. 95 o</li>
</ol>
<p>4. 80 o                             5. 20 o</p>
<ol>
  <li>The co-operative trust fund is  P500,000. Part of the fund is invested at an annual interest rate of 6% and the  rest is invested at an annual interest rate of 8%. If the income from both  investments is P39,000, how much is invested at each rate?</li>
</ol>
<p>&nbsp;</p>
<ol>
  <li>P100,000 at 6% ; P400,000 at 8%</li>
  <li>P80,000 at 6% ; P420,000 at 8%</li>
  <li>P75,000 at 6% ; P425,000 at 8%</li>
  <li>P50,000 at 6% ; P450,000 at 8%</li>
  <li>P25,000 at 6% ; P475,000 at 8%</li>
</ol>
<ol>
  <li>The entrance fee in a carnival  is P50 for an adult and P25 for a child. Ferdie pays P225 for the entrance fee  of his family. If his family has equal number of adults and children, how many  are they in the family?</li>
</ol>
<p>&nbsp;</p>
<p>1. 12                               2.  10                            3. 8<br />
  4. 6                                 5.  4</p>
<ol>
  <li>The area of a rectangular field  is 9,000 square meters. If the ratio of the width to the length is 5 is to 8,  what is the length of the rectangular field in meters?</li>
</ol>
<p>&nbsp;</p>
<p>1. 112                             2.  120                          3. 150<br />
  4. 225                             5.  346</p>
<ol>
  <li>If a patient weighs 105 kg. And  is 12.5% underweight, how many more kilograms should the patient weigh?</li>
</ol>
<p>&nbsp;</p>
<p>1.  5                                2.  10                           3.  12<br />
  4.  13                              5.  15</p>
<ol>
  <li>A tenant gets 4 sacks  of palay for every 7 sacks harvested.  Following this ratio, how many sacks of palay would the tenant get if 560 sacks  were harvested?</li>
</ol>
<p>1. 140                             2.  280                          3. 300<br />
  4. 320                             5.  350</p>
<ol>
  <li>A dealer sold a certain number  of portable TV sets at P6,400 each. The dealer would have taken in as much  money had 3 fewer sets been sold at P7,680. How many sets were sold at P6,400</li>
</ol>
<p>&nbsp;</p>
<p>1.  9                                2.  12                           3.  14<br />
  4.  16                              5.  18<br />
  <img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image004_0003.gif" alt="" width="358" height="2" /><strong>&nbsp;</strong></p>
<br clear="all" />
<br />
<strong>DIRECTION:</strong> The following items pertain  to the Philippine Constitution, peace and human rights concepts R.Z. 6713 (Code  of Conduct and Ethical Standards for Public Officials and Employees), values,  and environmental protection and conservation. Read each question carefully and  choose the best answer from the given options. On your Answer Sheet, shade  completely the box that corresponds to your answer.<br />
<img src="../../../Users/acer pc/AppData/Roaming/Adobe/Dreamweaver CS5/en_US/OfficeImageTemp/clip_image011.gif" alt="" width="358" height="2" />&nbsp; <br clear="all" />
<ol>
  <li>Elective or appointive public  officials or employees cannot accept any present, compensation, office or title  of any kind from any foreign government without the consent of</li>
</ol>
<p>1. The President                         2. The Ombudsman                 3. The Chief Justice<br />
  4. The Agency Head                  5. Congress</p>
<ol>
  <li>Which of the following rights  ensure the well-being of the individual and foster preservation, enrichment and  dynamic evolution of national culture based on the principle of unity in  diversity in a climate of free artistic and intellectual expression?</li>
</ol>
<p>&nbsp;</p>
<p>1. Political rights                        2. Civil rights                          3. Inherent rights<br />
  4. Cultural rights                        5. Economic and Social rights</p>
<ol>
  <li>Right that guarantees similar  treatment to all persons similarly situated and precludes arbitrary or unjust  discrimination to secure and safeguard such right is called the _________.</li>
</ol>
<p>&nbsp;</p>
<ol>
  <li>right against double jeopardy</li>
  <li>right to just compensation</li>
  <li>right to equal protection of  the law</li>
  <li>right to due process of law</li>
  <li>right to profess one&rsquo;s faith or  religion</li>
</ol>
<ol>
  <li>The right to privacy of a  person is defined as one&rsquo;s right to __________.</li>
  <li>go where one pleases</li>
  <li>believe whatever one whishes</li>
  <li>build a home wherever one  chooses</li>
  <li>be a member of any group</li>
  <li>be free from unwarranted  publicity</li>
</ol>
<p>&nbsp;</p>
<ol>
  <li>A voter is disqualified from  exercising the right to suffrage if said voter __________.</li>
</ol>
<ol>
  <li>is illiterate</li>
  <li>is poor</li>
  <li>is a naturalized Filipino  citizen</li>
  <li>turned 20 years old just before  the election</li>
  <li>has been a resident of the  Philippine for less than six months</li>
  <li>Who may be appointed as member  of the Cabinet without needing confirmation from the Commission on  Appointments?</li>
</ol>
<p>&nbsp;</p>
<ol>
  <li>Senate President</li>
  <li>Any Senator</li>
  <li>Vice-President</li>
  <li>Speaker of the House</li>
  <li>Any Congress Representative</li>
</ol>
<ol>
  <li>The right of private  individuals to secure for themselves the enjoyment of their means of happiness  such as the right to a name, the right to form a family, and the right to  security of personal papers and effects are called ___________.</li>
</ol>
<p>&nbsp;</p>
<ol>
  <li>Economic and Social rights</li>
  <li>Cultural Rights</li>
  <li>Civil Rights</li>
  <li>Inherent rights</li>
  <li>Political rights</li>
</ol>
<ol>
  <li>At least how many years after  the Constitution has been ratified may the people propose amendments through  initiative?</li>
</ol>
<p>&nbsp;</p>
<p>1. Ten                                         2.  Seven                                  3.  six<br />
  4. Five                                        5.  Three</p>
<ol>
  <li>Which of the following sectors  is NOT represented in the House of Representatives through the party-list  system.</li>
</ol>
<p>&nbsp;</p>
<p>1. Religious                                2.  Youth                                  3.  Women<br />
  4. Peasant                                   5.  Labor</p>
<ol>
  <li>Which of the following  government agencies exercises original and exclusive jurisdiction over all  contests relating to the election returns and the qualifications of the  President and the Vice President</li>
  <li>Supreme Court</li>
  <li>Senate Electoral Tribunal</li>
  <li>Judicial Bar Council</li>
  <li>Commission on Elections</li>
  <li>Commission on Appointments</li>
</ol>
<ol>
  <li>Who among the following is  responsible for determining the existence of probable cause for the issuance of  a warrant of arrest or search warrant?</li>
</ol>
<p>&nbsp;</p>
<p>1. Lawyer                                   2.  Prosecutor                           3.  Plaintiff<br />
  4. Judge                                      5.  Police Investigator</p>
<ol>
  <li>Which of the following  statements BEST describes the relationship between global warming ozone  depletion?</li>
</ol>
<ol>
  <li>Global warming contributes to  ozone depletion.</li>
  <li>Global warming and ozone  depletion have nothing to do with each other</li>
  <li>Excessive build-up of carbon  dioxide causes both global warming and ozone depletion</li>
  <li>Ozone depletion contributes to  global warming</li>
  <li>Ozone depletion and global  warming are synonyms</li>
</ol>
<p>&nbsp;</p>
<ol>
  <li>Monoculture cropping or  planting a single crop in a large area is not advisable because it</li>
</ol>
<ol>
  <li>requires more water</li>
  <li>requires less fertilizers</li>
  <li>causes drought</li>
  <li>lowers the water table</li>
  <li>promotes pest infestation</li>
</ol>
<p>&nbsp;</p>
<ol>
  <li>Which of the following is the  major cause of coral reef destruction?</li>
</ol>
<ol>
  <li>Dynamite fishing</li>
  <li>Muro-Ami</li>
  <li>Oil Spill</li>
  <li>Sewage pollution</li>
  <li>Siltation</li>
</ol>
<p>&nbsp;</p>
<ol>
  <li>The lasting environmental  impact of a large-scale mining operation comes from </li>
</ol>
<ol>
  <li>air pollution</li>
  <li>noise pollution</li>
  <li>deforestation</li>
  <li>mine railings</li>
  <li>unrestored mined out areas</li>
</ol>
<p>&nbsp;</p>
<ol>
  <li>Jaywalking, throwing garbage  anywhere vandalism, not waiting in line, and tardiness are manifestations of  __________.</li>
</ol>
<ol>
  <li>disorderliness</li>
  <li>lack of discipline</li>
  <li>lack of sense of property</li>
  <li>lack of punctuality</li>
  <li>disregard for other people&rsquo;s  property</li>
</ol>
<p>&nbsp;</p>
<ol>
  <li>Fishery resource in marine and  coastal waters may be considered as &ldquo;open access resources&rdquo; because of the  __________.</li>
</ol>
<ol>
  <li>mobile nature of fish and water</li>
  <li>difficulty in marking sea  boundaries</li>
  <li>proliferation of fish pens</li>
  <li>overfishing in municipal waters</li>
  <li>increasing demand for fish,  which is rich in protein</li>
</ol>
<p>&nbsp;</p>
<ol>
  <li>Every government agency is  required to develop, update regularly, and make available to the transacting  public __________.</li>
</ol>
<ol>
  <li>the names of action officers</li>
  <li>the performance targets</li>
  <li>the rates of service fees</li>
  <li>a service guide</li>
  <li>a directory of officials</li>
</ol>
<p>&nbsp;</p>
<ol>
  <li>Within the provided periods of  time, public officials and employees are required to file their statement of  assets and liabilities and financial disclosure in the following instances  EXCEPT __________.</li>
</ol>
<ol>
  <li>compulsory retirement</li>
  <li>voluntary resignation</li>
  <li>acceptance of foreign  scholarship</li>
  <li>assumption to office</li>
  <li>expiration of the term of  office</li>
</ol>
<p>&nbsp;</p>
<ol>
  <li>For expenditures processing of  documents, except otherwise provided by law or regulation, how many initials or  signature must any written action or decision contain?</li>
</ol>
<p>1.  6                                2.  5                             3.  4<br />
  4.  3                                5.  2</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p align="center"><strong>***********************************END*********************************</strong></p>
<!-- end .content --></div>
  <!-- end .container --></div></div>
</body>
</html>