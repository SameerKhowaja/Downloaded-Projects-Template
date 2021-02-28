
	var imgWidth, imgHeight;
	var vWidth;
	var	vHeight;
	var puzzleBoard;
	var mouseEvent;

	window.onload=function(){
		
		includeJS("js/board.js");
		includeJS("js/piece-holder.js");
		includeJS("js/piece.js");
		includeJS("js/mouse-events.js");
		
		setTimeout(function () {
			
			puzzleBoard = new Board($("srcImage"), 7,7);
			puzzleBoard.draw(); 
			puzzleBoard.initializePieceHolders();
			puzzleBoard.loadJigzawPieces();
			
			imgWidth = puzzleBoard.ImageWidth([]);
			imgHeight = puzzleBoard.ImageHeight([]);
			
			mouseEvent = new MouseEvent();
			document.onmousedown = mouseEvent.startDrag;
			document.onmouseup = mouseEvent.stopDrag;
			document.onmousemove = mouseEvent.dragPiece;
			
			vWidth = document.body.clientWidth;
			vHeight = document.body.clientHeight;
			
			setTimeout(function(){setOutline(true);}, 1000);
			disableRightClick();
			positionFooter();
			scramblePieces();
			initAbout();
			
        }, 1000);

	}

	function disableRightClick(e){
		
		if(!document.rightClickDisabled){
			if(document.layers) 
			{
				document.captureEvents(Event.MOUSEDOWN);
				document.onmousedown = disableRightClick;
			}else{
				document.oncontextmenu = disableRightClick;
			}
			return document.rightClickDisabled = true;
		}
		
		if(document.layers || (document.getElementById && !document.all)){
			if (e.which == 2||e.which == 3){
				return false;
			}
		}else{
			return false;
		}
	}

	
	function initAbout(){
		var about = document.getElementById('my-logo');
		about.setAttribute('onclick','showAbout();');
		showAbout();
	}
	
	function positionFooter(){
		var pb = $('puzzle-board');
		var footer = $('footer');
		if(imgHeight > 600){
			pb.style.height = imgHeight + "px";
		}else{
			pb.style.height = "600px";
		}
		footer.setAttribute('class', 'footer');
	}
	
	function setOutline(visible){
	
		var oBuffer = document.createElement('img');
		var oBoard = document.getElementById('Board');
		
		oBuffer.setAttribute('id', 'imgOutline');
		oBuffer.setAttribute('style', 'position: absolute; left:0px; top:0px; width:' + imgWidth + 'px; height:' + imgHeight + 'px; visibility: visible;z-index:-1;');
		oBuffer.setAttribute('src', oBoard.src);
		oBuffer.setAttribute('title', 'New image element');
		addElement(oBuffer);
		oBoard.style.visibility = "hidden";
		
		var
			colCount = puzzleBoard.ColCount([]),
			rowCount = puzzleBoard.RowCount([]),
			ellipseOffset = puzzleBoard.EllipseOffset([]),
			horDistance = puzzleBoard.CellWidth([]),
			verDistance = puzzleBoard.CellHeight([]),
			ellipseRadius = puzzleBoard.EllipseRadius([]),
			originOffset = ellipseRadius / 2,
			bX = puzzleBoard.OffsetX([]),
			bY = puzzleBoard.OffsetY([]);

		var oCanvas = createCanvas("oCanvas", oBoard.width, oBoard.height);
		var oCtx = oCanvas.getContext("2d");
		oCtx.drawImage(oBuffer, 0, 0, oBoard.width, oBoard.height);
		
		var base = Math.sqrt( Math.pow(ellipseRadius, 2) - Math.pow(originOffset, 2));
		
		var x = bX;
		var y = bY + verDistance;
		var tX = (horDistance/2) - base;
		oCtx.strokeStyle = "#444";
		
		for (var j=0; j <rowCount-1; j++){
			for (var i=0; i<=colCount; i++){
				
				oCtx.beginPath();
				oCtx.moveTo(x, y)
				oCtx.lineTo(x + tX, y);
				oCtx.stroke();
				oCtx.closePath();
				
				tX = (i<(colCount-1)) ? (horDistance - (2 * base)) : ((horDistance/2) - base);	
				x += (i == 0) ? ((horDistance/2) + base) : (horDistance);
				
				if((i % 2 == 0) && (j % 2 == 0)){
					oCtx.beginPath();
					oCtx.arc(x - base, y+originOffset, ellipseRadius, (11 * Math.PI)/6, (7 * Math.PI)/6 );
					oCtx.stroke();
					oCtx.closePath();
				}
				if((i % 2 != 0) && (j % 2 == 0) && (i < colCount-1)){
					oCtx.beginPath();
					oCtx.arc(x - base, y-originOffset, ellipseRadius, (5 * Math.PI)/6, Math.PI/6 );
					oCtx.stroke();
					oCtx.closePath();
				}
				
				if((i % 2 == 0) && (j % 2 != 0)){
					oCtx.beginPath();
					oCtx.arc(x - base, y-originOffset, ellipseRadius, (5 * Math.PI)/6, Math.PI/6 );
					oCtx.stroke();
					oCtx.closePath();
				}
				if((i % 2 != 0) && (j % 2 != 0) && (i < colCount-1)){
					oCtx.beginPath();
					oCtx.arc(x - base, y+originOffset, ellipseRadius, (11 * Math.PI)/6, (7 * Math.PI)/6 );
					oCtx.stroke();
					oCtx.closePath();
				}
				
			}
			y = y + verDistance;
			x = bX;
		}
		
		y = bY;
		x = bX + horDistance;
		var tY = (verDistance/2) - base;
		
		for (j=0; j <colCount-1; j++){
			for (i=0; i<=rowCount; i++){

				oCtx.beginPath();
				oCtx.moveTo(x, y)
				oCtx.lineTo(x, y + tY);
				oCtx.stroke();
				oCtx.closePath();
				
				tY = (i<(rowCount-1)) ? (verDistance - (2 * base)) : ((verDistance/2) - base);
				y += (i == 0) ? ((verDistance/2) + base) : (verDistance);
				
				if((i % 2 == 0) && (j % 2 == 0)){
					oCtx.beginPath();
					oCtx.arc(x+originOffset, y - base, ellipseRadius, (4 * Math.PI/3), (2 * Math.PI)/3);
					oCtx.stroke();
					oCtx.closePath();
				}
				if((i % 2 != 0) && (j % 2 == 0) && (i < rowCount-1)){
					oCtx.beginPath();
					oCtx.arc(x-originOffset, y - base, ellipseRadius, ( Math.PI/3), ( 5 * Math.PI)/3);
					oCtx.stroke();
					oCtx.closePath();
				}
				if((i % 2 == 0) && (j % 2 != 0)){
					oCtx.beginPath();
					oCtx.arc(x-originOffset, y - base, ellipseRadius, ( Math.PI/3), ( 5 * Math.PI)/3);
					oCtx.stroke();
					oCtx.closePath();
				}
				if((i % 2 != 0) && (j % 2 != 0) && (i < rowCount-1)){
					oCtx.beginPath();
					oCtx.arc(x+originOffset, y - base, ellipseRadius, (4 * Math.PI/3), (2 * Math.PI)/3);
					oCtx.stroke();
					oCtx.closePath();
				}

			}
			x = x + horDistance;
			y = bY;
		}
		
		oBuffer.src = oCanvas.toDataURL("image/png");
		drawIndexBuffer();
	
	}
	
	function hidePieces(){
		var pieces = document.getElementsByTagName('img');
		for(var i = 0; i < pieces.length; i++ ){
			if(pieces[i].getAttribute('class') == "piece"){
				pieces[i].style.visibility = "hidden";
			}
		}
	}
	
	function scramblePieces(){
		var pieces = document.getElementsByTagName('canvas');
		for(var i = 0; i < pieces.length; i++ ){
			if(pieces[i].getAttribute('class') == "piece"){
			
				var left = Math.random() * (document.body.clientWidth - (imgWidth + 80)) + imgWidth;
				var top = Math.random() * (document.body.clientHeight - 120);
				pieces[i].style.left = left+"px";
				pieces[i].style.top = top+"px";
				
			}
		}
	}
	
	function drawIndexBuffer(){
	
		var
			colCount = puzzleBoard.ColCount([]),
			rowCount = puzzleBoard.RowCount([]),
			cellWidth = puzzleBoard.CellWidth([]),
			cellHeight = puzzleBoard.CellHeight([]),
			oCanv = createCanvas("bufCanvas", imgWidth, imgHeight),
			oiCtx = oCanv.getContext("2d"),
			x = (cellWidth / 2) - (cellWidth/3),
			y = (cellHeight / 2) - (cellHeight/3),
			r=1,g=0,b=0;
		
		for (var j=0; j<rowCount; j++){
			for (var i=0; i<colCount; i++){
				
				oiCtx.beginPath();
				oiCtx.fillStyle = "#" + decToHex(r) + decToHex(g) + decToHex(b);
				oiCtx.fillRect(x,y,cellWidth,cellHeight);
				oiCtx.closePath();
				x += cellWidth;
				
				r++;
				if(r>255){
					r=0;
					g++;
					if (g>255){
						g=0;
						b++;
					}
				}
			}
			
			y += cellHeight;
			x = (cellWidth / 2) - (cellWidth/3);
			
		}
	
	}
	
	function getIndex(x, y){
		
		var 
			xy = document.getElementById('xy'),
			xyCanvas = document.getElementById('bufCanvas'),
			xyCtx = xyCanvas.getContext("2d"),
			offset = puzzleBoard.EllipseRadius([]) + (puzzleBoard.EllipseRadius([])/2),
			img = xyCtx.getImageData(x+offset, y+offset, 1, 1),
			pix = img.data,
			index = (pix[0] + (pix[1] * 256));
		
		return index;
		
	}
	
	function includeJS(p_file) {
		var v_js  = document.createElement('script');
		v_js.type = 'text/javascript';
		v_js.src = p_file;
		document.getElementsByTagName('head')[0].appendChild(v_js);
	}
	
	// Utility function to create canvases for rendering the board.
	function createCanvas(_canvasID, _width, _height){
		var _canvas = document.createElement("canvas");
		_canvas.setAttribute("id", _canvasID);
		_canvas.setAttribute("style", "background-color: black;visibility: hidden; position: fixed; left:-2000px;top:-1000px;");
		_canvas.setAttribute("width", _width);
		_canvas.setAttribute("height", _height);
		addElement(_canvas);
		return _canvas;
	}
	
	function removeElement(_ID){
		var obj = document.getElementById(_ID);
		obj.parentNode.removeChild(obj);
	}
	
	function addElement(_element){
		//var body = document.getElementsByTagName("body");
		//body[0].appendChild(_element);
		var content = document.getElementById("puzzle-board");
		content.appendChild(_element);
		
	}
	
	function $(id){
		return document.getElementById(id);
	}

	function decToHex(dec){
	
		var digits = new Array("0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F");
		var hex ="";
		
		while(dec>=16){
			var w = parseInt(dec / 16);
			hex = digits[w] + hex;
			dec = dec % 16; 	
		}
		hex = hex + digits[dec];
		hex = (hex.length==1) ? "0" + hex : hex;
		return hex;
	
	}
	
	function play(){
		resetPieceHolders();
		scramblePieces();
	}
	
	function resetPieceHolders(){
		for(var i=0; i < puzzleBoard.pieceHolders.length; i++){
			puzzleBoard.pieceHolders[i].PieceIndex([-1]);
		}
		puzzleBoard.PieceCount([0, 0]);
	}
	
	function checkPuzzle(){
		for(var i=0; i < puzzleBoard.pieceHolders.length; i++){
			if(puzzleBoard.pieceHolders[i].PieceIndex([]) != i){
				return false;
			}
		}
		return true;
	}
	
	function showAbout(){
		
		var about = "Coded (June, 2013) by: " + "\n\n" ;
			about += "\t"+ "Oelasor Sabilot" + "\n";
			about += "\t"+ "Ninoy Aquino Ave., Youngfield Dist.," + "\n";
			about += "\t"+ "Tacloban City, Leyte" + "\n";
			about += "\t"+ "6500, Philippines" + "\n";
			about += "\t"+ "----------------------------------" + "\n";
			about += "\t"+ "+639398316664 (Smart)" + "\n";
			about += "\t"+ "+639176951738/+639163238227 (Globe)" + "\n";
			about += "\t"+ "oelasor@gmail.com" + "\n";
		
		alert(about);
		
	}
	
	
	
		