// Global variable definition

		// boolean that if its false, keep geting digits into the first number. it will turn true when a mathematical opertator key is clicked
		bOperatorClicked = false
		dFirstNum = 0
		dSecNum = 0
		dSum = 0
		
		// when the equal button is pressed we check what operator was clicked using this variable.
		// 1 = +, 2 = -, 3 = *, 4 = /.
		nOperator = 0 
		
		// the function for the equals key
		function equ()
		{
			strSecNum = document.getElementById("ResultsText").innerHTML
			dSecNum = parseFloat(strSecNum)
			
			// do the math according to what operator was picked
			var nAction = nOperator
			switch (nAction)
			{
				case 1:
				dSum = dFirstNum + dSecNum
				break
				
				case 2:
				dSum = dFirstNum - dSecNum
				break
				
				case 3:
				dSum = dFirstNum * dSecNum
				break
				
				case 4:
				dSum = dFirstNum / dSecNum
				break
			}
			
			// display the second number in the operations box
			strFinal = document.getElementById("OperationBox").innerHTML
			strFinal = strFinal.concat(dSecNum)
			document.getElementById("OperationBox").innerHTML = strFinal
			
			// Puts the result of the math in the main outputbox
			document.getElementById("ResultsText").innerHTML = dSum
		}
		
		// the functions for the operator keys
		// includes the code that converts the output which is currently a string into a double for calculation
		function add()
		{
			// If no button was clicked dont concatenate
			if 	(document.getElementById("ResultsText").innerHTML != 0)
			{
				// Stops adding new numbers into the outputbox
				bOperatorClicked = true  

				// converts the number in the output box to a double
				strFinalFirstNum = document.getElementById("ResultsText").innerHTML 
				dFirstNum = parseFloat(strFinalFirstNum)

				// concatenates the "+" sign and the first number into the secondary box
				strSecNum = strFinalFirstNum.concat(" + ")
				document.getElementById("OperationBox").innerHTML = strSecNum
				
				// Clears the main output box
				document.getElementById("ResultsText").innerHTML = " "
				
				// sets the operator code to addition.
				nOperator = 1
			}	
		}
		
		function sub()
		{
			// If no button was clicked dont concatenate
			if 	(document.getElementById("ResultsText").innerHTML != 0)
			{
				// Stops adding new numbers into the outputbox
				bOperatorClicked = true  

				// converts the number in the output box to a double
				strFinalFirstNum = document.getElementById("ResultsText").innerHTML 
				dFirstNum = parseFloat(strFinalFirstNum)

				// sets the operator code to subtraction.
				nOperator = 2
				
				// concatenates the "-" sign and the first number into the secondary box
				strSecNum = strFinalFirstNum.concat(" - ")
				document.getElementById("OperationBox").innerHTML = strSecNum
				
				// Clears the main output box
				document.getElementById("ResultsText").innerHTML = " "
			}	
		}
		
		function mul()
		{
			// If no button was clicked dont concatenate
			if 	(document.getElementById("ResultsText").innerHTML != 0)
			{
				// Stops adding new numbers into the outputbox
				bOperatorClicked = true  

				// converts the number in the output box to a double
				strFinalFirstNum = document.getElementById("ResultsText").innerHTML 
				dFirstNum = parseFloat(strFinalFirstNum)

				// sets the operator code to multiplication.
				nOperator = 3
				
				// concatenates the "X" sign and the first number into the secondary box
				strSecNum = strFinalFirstNum.concat(" X ")
				document.getElementById("OperationBox").innerHTML = strSecNum
				
				// Clears the main output box
				document.getElementById("ResultsText").innerHTML = " "
			}	
		}
		
		function div()
		{
			// If no button was clicked dont concatenate
			if 	(document.getElementById("ResultsText").innerHTML != 0)
			{
				// Stops adding new numbers into the outputbox
				bOperatorClicked = true  

				// converts the number in the output box to a double
				strFinalFirstNum = document.getElementById("ResultsText").innerHTML 
				dFirstNum = parseFloat(strFinalFirstNum)

				// sets the operator code to division.
				nOperator = 4
				
				// concatenates the ":" sign and the first number into the secondary box
				strSecNum = strFinalFirstNum.concat(" : ")
				document.getElementById("OperationBox").innerHTML = strSecNum
				
				// Clears the main output box
				document.getElementById("ResultsText").innerHTML = " "
			}	
		}
		
		function Clear()
		{
			document.getElementById("ResultsText").innerHTML = "0"
			document.getElementById("OperationBox").innerHTML = ""
			bOperatorClicked = false
			dFirstNum = 0
			dSecNum = 0
			dSum = 0
			nOperator = 0
		}

		// each key click will add that number to the output box. on the first click, clears the output box first.
			
		//  functions for each key
		function b0()
		{
			// clears the outputbox on the first run
			ClearBox()
			
			// outputs the number
			if (bOperatorClicked == false)
			{
				strFirstNum = document.getElementById("ResultsText").innerHTML
				strFirstNum = strFirstNum.concat(0)
				document.getElementById("ResultsText").innerHTML = strFirstNum
			}
			else
			{
				strSecNum = document.getElementById("ResultsText").innerHTML
				document.getElementById("ResultsText").innerHTML = strSecNum.concat(0)
			}
			
		}

		function b1()
		{
			// clears the outputbox if no button has been clicked yet
			ClearBox()
			
			// outputs the number
			if (bOperatorClicked == false)
			{
				strFirstNum = document.getElementById("ResultsText").innerHTML
				strFirstNum = strFirstNum.concat(1)
				document.getElementById("ResultsText").innerHTML = strFirstNum
			}
			else
			{
				strSecNum = document.getElementById("ResultsText").innerHTML
				document.getElementById("ResultsText").innerHTML = strSecNum.concat(1)
			}
			
		}
		
		function b2()
		{
			// clears the outputbox if no button has been clicked yet
			ClearBox()
			
			// outputs the number
			if (bOperatorClicked == false)
			{
				strFirstNum = document.getElementById("ResultsText").innerHTML
				strFirstNum = strFirstNum.concat(2)
				document.getElementById("ResultsText").innerHTML = strFirstNum
			}
			else
			{
				strSecNum = document.getElementById("ResultsText").innerHTML
				document.getElementById("ResultsText").innerHTML = strSecNum.concat(2)
			}
			
		}
		
		function b3()
		{
			// clears the outputbox if no button has been clicked yet
			ClearBox()
			
			// outputs the number
			if (bOperatorClicked == false)
			{
				strFirstNum = document.getElementById("ResultsText").innerHTML
				strFirstNum = strFirstNum.concat(3)
				document.getElementById("ResultsText").innerHTML = strFirstNum
			}
			else
			{
				strSecNum = document.getElementById("ResultsText").innerHTML
				document.getElementById("ResultsText").innerHTML = strSecNum.concat(3)
			}
			
		}
		
		function b4()
		{
			// clears the outputbox if no button has been clicked yet
			ClearBox()
			
			// outputs the number
			if (bOperatorClicked == false)
			{
				strFirstNum = document.getElementById("ResultsText").innerHTML
				strFirstNum = strFirstNum.concat(4)
				document.getElementById("ResultsText").innerHTML = strFirstNum
			}
			else
			{
				strSecNum = document.getElementById("ResultsText").innerHTML
				document.getElementById("ResultsText").innerHTML = strSecNum.concat(4)
			}
			
		}
		
		function b5()
		{
			// clears the outputbox if no button has been clicked yet
			ClearBox()
			
			// outputs the number
			if (bOperatorClicked == false)
			{
				strFirstNum = document.getElementById("ResultsText").innerHTML
				strFirstNum = strFirstNum.concat(5)
				document.getElementById("ResultsText").innerHTML = strFirstNum
			}
			else
			{
				strSecNum = document.getElementById("ResultsText").innerHTML
				document.getElementById("ResultsText").innerHTML = strSecNum.concat(5)
			}
			
		}
		
		function b6()
		{
			// clears the outputbox if no button has been clicked yet
			ClearBox()
			
			// outputs the number
			if (bOperatorClicked == false)
			{
				strFirstNum = document.getElementById("ResultsText").innerHTML
				strFirstNum = strFirstNum.concat(6)
				document.getElementById("ResultsText").innerHTML = strFirstNum
			}
			else
			{
				strSecNum = document.getElementById("ResultsText").innerHTML
				document.getElementById("ResultsText").innerHTML = strSecNum.concat(6)
			}
			
		}
		
		function b7()
		{
			// clears the outputbox if no button has been clicked yet
			ClearBox()
			
			// outputs the number
			if (bOperatorClicked == false)
			{
				strFirstNum = document.getElementById("ResultsText").innerHTML
				strFirstNum = strFirstNum.concat(7)
				document.getElementById("ResultsText").innerHTML = strFirstNum
			}
			else
			{
				strSecNum = document.getElementById("ResultsText").innerHTML
				document.getElementById("ResultsText").innerHTML = strSecNum.concat(7)
			}
			
		}
		
		function b8()
		{
			// clears the outputbox if no button has been clicked yet
			ClearBox()
			
			// outputs the number
			if (bOperatorClicked == false)
			{
				strFirstNum = document.getElementById("ResultsText").innerHTML
				strFirstNum = strFirstNum.concat(8)
				document.getElementById("ResultsText").innerHTML = strFirstNum
			}
			else
			{
				strSecNum = document.getElementById("ResultsText").innerHTML
				document.getElementById("ResultsText").innerHTML = strSecNum.concat(8)
			}
			
		}
		
		function b9()
		{
			// clears the outputbox if no button has been clicked yet
			ClearBox()
			
			// outputs the number
			if (bOperatorClicked == false)
			{
				strFirstNum = document.getElementById("ResultsText").innerHTML
				strFirstNum = strFirstNum.concat(9)
				document.getElementById("ResultsText").innerHTML = strFirstNum
			}
			else
			{
				strSecNum = document.getElementById("ResultsText").innerHTML
				document.getElementById("ResultsText").innerHTML = strSecNum.concat(9)
			}
			
		}
		
		function ClearBox()
		{
			if (document.getElementById("ResultsText").innerHTML == 0)
			{
				document.getElementById("ResultsText").innerHTML = " "
			}
		}