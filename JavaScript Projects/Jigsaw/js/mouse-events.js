function MouseEvent(){

	var zindex = 11;
	var curID;
	var vWidth = 0;
	var vHeight = 0;
	var drag = false;
	var offsetX, offsetY, coordX, coordY;
	
	function setLoader(e){
		
		if(!e){e = window.event;}
		
		var targ = e.target ? e.target : e.srcElement;
		
		if(targ.className != "piece"){return;}
		
		var index = (getIndex(parseInt(targ.style.left), parseInt(targ.style.top))) - 1;
		var pieceIndex = targ.id.replace(/jigzaw-piece-/i, "");
		var loader = $('loader');

		var lLeft = puzzleBoard.pieceHolders[pieceIndex].Left([]) + ((puzzleBoard.CellWidth()  - 19) / 2) + puzzleBoard.EllipseOffset();
		var lTop = puzzleBoard.pieceHolders[pieceIndex].Top([]) + ((puzzleBoard.CellHeight() - 19) / 2) + puzzleBoard.EllipseOffset();
		loader.style.left = lLeft + "px";
		loader.style.top = lTop + "px";
		loader.style.visibility = "visible";
		
		return;
		
	}
	
	function unsetLoader(){
		$('loader').style.visibility = "hidden";
		return;
	}
	
	this.startDrag = function (e){
		
		// determine event object
		if(!e){e = window.event;}
	
		if (e.which == 2 || e.which == 3){
			setLoader(e);
		} else {
	
			// determine target element
			var targ = e.target ? e.target : e.srcElement;
				
			if(targ.className != 'piece'){
				return;
			}
		
			// calculate event X,Y coordinates
			offsetX = e.clientX;
			offsetY = e.clientY;

			// calculate integer values for top and left properties
			coordX = parseInt(targ.style.left);
			coordY = parseInt(targ.style.top);
			zindex++;
			targ.style.zIndex = zindex;

			// remember the current canvas being pressed at by the mouse pointer
			curID = targ.id;
			
			drag=true;
			
			var index = (getIndex(parseInt(targ.style.left), parseInt(targ.style.top))) - 1;
			var pieceIndex = targ.id.replace(/jigzaw-piece-/i, "");
			if(puzzleBoard.pieceHolders[index].PieceIndex([]) == pieceIndex){
				puzzleBoard.pieceHolders[index].PieceIndex([-1]);
				puzzleBoard.PieceCount([-1]);
			}
					
			// prevent the default canvas drag behavior.
			e.preventDefault();
		}
	}
			
	// continue dragging
	this.dragPiece = function (e){
		
		if(!drag){
			return;
		}

		if(!e){e=window.event;}
		
		var targ = e.target ? e.target : e.srcElement;

		// avoid "disturbing" other images
		if (targ.id != curID){
			if(targ.id == "loader"){
				targ.style.visibility = "hidden";
			}
			return;
		}
		
		// move piece
		var left = coordX + e.clientX - offsetX;
		var top = coordY + e.clientY - offsetY;
		
		if (left <= 0){left = 1;}
		if (top <= 0){top = 1;}
		
		targ.style.left = left + 'px';
		targ.style.top = top + 'px';
		
	}
			
	// stop dragging
	this.stopDrag = function (e){
		
		drag = false;
		unsetLoader();
		
		var targ = e.target ? e.target : e.srcElement;
		targ.style.cursor = "move";
		
		
		if (targ.id != curID){return;}
		
		var index = (getIndex(parseInt(targ.style.left), parseInt(targ.style.top))) - 1;
		var pieceIndex = targ.id.replace(/jigzaw-piece-/i, "");
		
		if(puzzleBoard.jigzawPieces[pieceIndex].Protruding ==  puzzleBoard.jigzawPieces[index].Protruding ){
			if(puzzleBoard.pieceHolders[index].PieceIndex([]) == -1){
				targ.style.left = puzzleBoard.pieceHolders[index].Left([]) + 'px';
				targ.style.top = puzzleBoard.pieceHolders[index].Top([]) + 'px';
				puzzleBoard.pieceHolders[index].PieceIndex([pieceIndex]);
				puzzleBoard.PieceCount([1]);
			}else{
				targ.style.left = puzzleBoard.pieceHolders[index].Left([]) + (puzzleBoard.EllipseOffset([]) * 1.5) + 'px';
				targ.style.top = puzzleBoard.pieceHolders[index].Top([]) + (puzzleBoard.EllipseOffset([]) * 1.5) + 'px';
			}
		}else{
			targ.style.left = puzzleBoard.pieceHolders[index].Left([]) + (puzzleBoard.EllipseOffset([]) * 1.5) + 'px';
			targ.style.top = puzzleBoard.pieceHolders[index].Top([]) + (puzzleBoard.EllipseOffset([]) * 1.5) + 'px';
		}
		
		if(puzzleBoard.PieceCount([]) >= puzzleBoard.CellCount()-5){
			if(checkPuzzle() == true){
				var response = confirm("Congratulations! Play again?");
				if (response==true){
					play();
				}
			}else{
				//alert("Oppps...");
			}
		}
		
	}
}