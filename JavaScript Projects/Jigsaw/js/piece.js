function Piece(args){
	
	if(args.length > 0) {
		var 
			left = args[0],	
			top = args[1],
			index = args[2],
			srcImageLeft = args[0],
			srcImageTop = args[1],
			protruding = args[3],
			imgElement = args[4];
	} else {
		var 
			left = -1,	
			top = -1,
			index = -1,
			srcImageLeft = -1,
			srcImageTop = -1,
			protruding = -1,
			imgElement = null;
	}
	
	
	this.Left = left;
	this.Top = top;
	this.Index = index;
	this.Protruding = protruding;
	
	create();
	
	function create(){
	
		var 
			pieceWidth = puzzleBoard.PieceHolderWidth([]),
			pieceHeight = puzzleBoard.PieceHolderHeight([]),
			ellipseOffset = puzzleBoard.EllipseOffset([]),
			ellipseOriginOffset = puzzleBoard.EllipseOriginOffset([]),
			
			tplCanvasID = "templateCanvas" + index,
			tplCanvas = createCanvas(tplCanvasID, pieceWidth, pieceHeight),
			tplContext = tplCanvas.getContext("2d"),
			
			pieceCanvasID = "pieceCanvas" + index,
			pieceCanvas = createCanvas(pieceCanvasID, pieceWidth, pieceHeight),
			pieceContext = pieceCanvas.getContext("2d"),
			
			x = 0, 
			y = 0,
			
			ellipseColor = ((protruding == 1) ? "white" : "black");
			
		pieceContext.drawImage(imgElement, srcImageLeft, srcImageTop, pieceWidth, pieceHeight, 0, 0, pieceWidth, pieceHeight);
		
		var pieceImgData = pieceContext.getImageData(0, 0, pieceWidth, pieceHeight),
			piecePixels = pieceImgData.data; 
		
		// Fill the template canvas with black background.
		tplContext.fillStyle = 'black';
		tplContext.fillRect(0, 0, pieceWidth, pieceHeight);
			
		// Draw a white-filled rectangle at the center of the template canvas.
		tplContext.fillStyle = "white";
		tplContext.fillRect(ellipseOffset, ellipseOffset, pieceWidth - (ellipseOffset * 2) - 1, pieceHeight - (ellipseOffset * 2) - 1);

		// Draw an ellipse at the center of the canvas's top "border".
		x = pieceWidth / 2;
		y = ellipseOffset + ((protruding == 1) ?  -ellipseOriginOffset : ellipseOriginOffset);
		drawEllipse(tplContext, x, y, ellipseColor, protruding);
		draw3DBorder(tplContext, x, y, "top", (protruding == 1) ? true : false);
		
		
		// Draw an ellipse at the center of the canvas's right "border".
		x = (pieceWidth - ellipseOffset) + ((protruding == 1) ?  ellipseOriginOffset : -ellipseOriginOffset);
		y = pieceHeight / 2;
		drawEllipse(tplContext, x, y, ellipseColor, protruding);
		draw3DBorder(tplContext, x, y, "right", (protruding == 1) ? true : false);	
		
		// Draw an ellipse at the center of the canvas's bottom "border".
		x = pieceWidth / 2;
		y = (pieceHeight - ellipseOffset) + ((protruding == 1) ?  ellipseOriginOffset : -ellipseOriginOffset);
		drawEllipse(tplContext, x, y, ellipseColor, protruding);
		draw3DBorder(tplContext, x, y, "bottom", (protruding == 1) ? true : false);
		
		// Draw an ellipse at the center of the canvas's left "border".
		x = ellipseOffset + ((protruding == 1) ?  -ellipseOriginOffset : ellipseOriginOffset);
		y = pieceHeight / 2;
		drawEllipse(tplContext, x, y, ellipseColor, protruding);
		draw3DBorder(tplContext, x, y, "left", (protruding == 1) ? true : false);
	
		var tplImgData = tplContext.getImageData(0, 0, pieceWidth, pieceHeight),
		tplPixels = tplImgData.data;	
		
		for (var i = 0, n = tplPixels.length; i < n; i += 4) {
			
			if (tplPixels[i] >= 100 && tplPixels[i+1] <= 120 && tplPixels[i+2] <= 120){
				// Set the pixel to lighter.
				
				piecePixels[i] = piecePixels[i] + 25; 
				if(piecePixels[i] > 255){piecePixels[i] = 255;}
				piecePixels[i+1] = piecePixels[i+1] + 25; 
				if(piecePixels[i+1] > 255){piecePixels[i+1] = 255;}
				piecePixels[i+2] = piecePixels[i+2] + 25; 
				if(piecePixels[i+2] > 255){piecePixels[i+2] = 255;}
				
			}else
			
			if (tplPixels[i] >= 100 && tplPixels[i+1] <= 120 && tplPixels[i+2] >= 100){
				// Set the pixel to darker.
				piecePixels[i] = piecePixels[i] - 25; 
				if(piecePixels[i] < 0){piecePixels[i] = 0;}
				piecePixels[i+1] = piecePixels[i+1] - 25; 
				if(piecePixels[i+1] < 0){piecePixels[i+1] = 0;}
				piecePixels[i+2] = piecePixels[i+2] - 25; 
				if(piecePixels[i+2] < 0){piecePixels[i+2] = 0;}
			}else
			
			if (tplPixels[i] <= 0 && tplPixels[i+1] <= 0 && tplPixels[i+2] <= 0){
				// Set the pixel to transparent.
				piecePixels[i+3] = 0; 
			}
		}
		
		pieceContext.putImageData(pieceImgData, 0, 0);

		var pieceImgElement = createCanvas("jigzaw-piece-" + index, pieceWidth, pieceHeight);
		pieceImgElement.setAttribute("style", "left:" + srcImageLeft + "px; top:" + srcImageTop + "px; visibility:visible;cursor:move;");
		pieceImgElement.setAttribute("class", "piece");
		pieceImgElement.setAttribute("title", "jigzaw-piece-" + index);
		
		var pieceImgCtx = pieceImgElement.getContext('2d');
		pieceImgCtx.putImageData(pieceImgData, 0, 0);
		
		addElement(pieceImgElement);
		removeElement(tplCanvasID);
		removeElement(pieceCanvasID);

	}
	
	function drawEllipse(_ctx, _x, _y, _color, protruding){
		var radius = (protruding ==1) ? puzzleBoard.EllipseRadius([]) : puzzleBoard.EllipseRadius([]) + 1;
		_ctx.beginPath();
		_ctx.arc(_x, _y, radius, 0, 2 * Math.PI);
		_ctx.fillStyle = _color;
		_ctx.fill();
	}
	
	function draw3DBorder(_ctx, _x, _y, position, protruding){
		
		var 
			base = Math.sqrt( Math.pow(puzzleBoard.EllipseRadius([]), 2) - Math.pow(puzzleBoard.EllipseOriginOffset([]), 2)),
			ellipseOriginOffset = puzzleBoard.EllipseOriginOffset([]),
			halfCW = puzzleBoard.CellWidth([]) / 2,
			halfCH = puzzleBoard.CellHeight([]) / 2;
		
		if (position == 'top'){
			if(protruding == true){
				draw3DArc(_ctx, _x, _y, puzzleBoard.EllipseRadius([]), (5 * Math.PI / 6), (5 * Math.PI / 3), (5 * Math.PI / 3), Math.PI/6);
			}else{
				draw3DArc(_ctx, _x, _y, puzzleBoard.EllipseRadius([]) + 1, (11 * Math.PI / 6), (2 * Math.PI / 3), (2 * Math.PI / 3), (7 * Math.PI/ 6));
			}
			
			draw3DLine(	
						_ctx,
						"#ff0000",
						_x - halfCW, _y + (protruding == true ? ellipseOriginOffset : -ellipseOriginOffset), 
						_x - base - 1, _y + (protruding == true ? ellipseOriginOffset : -ellipseOriginOffset),
						_x + base, _y + (protruding == true ? ellipseOriginOffset : -ellipseOriginOffset),
						_x + halfCW - 1, _y + (protruding == true ? ellipseOriginOffset : -ellipseOriginOffset)
					);
			
			
		}
		if (position == 'bottom'){
			if(protruding == true){
				draw3DArc(_ctx, _x, _y, puzzleBoard.EllipseRadius([]), (2 * Math.PI / 3), (7 * Math.PI / 6), (11 * Math.PI / 6), (2 * Math.PI/3));
			}else{
				draw3DArc(_ctx, _x, _y-1, puzzleBoard.EllipseRadius([]) + 1, (5 * Math.PI / 3), (Math.PI / 6), (5 * Math.PI / 6), (5 * Math.PI/3));
			}
			
			draw3DLine(
						_ctx,
						"#ff00ff",
						_x - halfCW, _y + (protruding == true ? -ellipseOriginOffset : ellipseOriginOffset) - 1,
						_x - base - 1, _y + (protruding == true ? -ellipseOriginOffset : ellipseOriginOffset) - 1,
						_x + base + 1, _y + (protruding == true ? -ellipseOriginOffset : ellipseOriginOffset) - 1,
						_x + halfCW - 1, _y + (protruding == true ? -ellipseOriginOffset : ellipseOriginOffset) - 1
					);
			
		}
		
		if (position == 'left'){
			if(protruding == true){
				draw3DArc(_ctx, _x, _y, puzzleBoard.EllipseRadius([]), (5 * Math.PI / 6), (5 * Math.PI / 3), ( Math.PI / 3), (5 * Math.PI / 6));
			}else{
				draw3DArc(_ctx, _x, _y, puzzleBoard.EllipseRadius([]) + 1, (11 * Math.PI / 6), (2 * Math.PI / 3), (4 * Math.PI / 3), (11 * Math.PI/ 6));
			}
			
			
			draw3DLine(
						_ctx,
						"#ff0000",
						_x + (protruding == true ? ellipseOriginOffset : -ellipseOriginOffset), _y - halfCH,
						_x + (protruding == true ? ellipseOriginOffset : -ellipseOriginOffset), _y - base,
						_x + (protruding == true ? ellipseOriginOffset : -ellipseOriginOffset), _y + base,
						_x + (protruding == true ? ellipseOriginOffset : -ellipseOriginOffset), _y + halfCH
					);
			
		}
		
		if (position == 'right'){
			if(protruding == true){
				draw3DArc(_ctx, _x, _y, puzzleBoard.EllipseRadius([]), (4 * Math.PI / 3) , (11 * Math.PI / 6), (11 * Math.PI / 6), (2 * Math.PI/3));
			}else{
				draw3DArc(_ctx, _x-1, _y, puzzleBoard.EllipseRadius([]) + 1, (Math.PI / 3) , (5 * Math.PI / 6), (5 * Math.PI / 6), (5 * Math.PI/ 3));
			}
			
			
			draw3DLine(
						_ctx,
						"#ff00ff",
						_x + (protruding == true ? -ellipseOriginOffset : ellipseOriginOffset) - 1, _y - halfCH+1,
						_x + (protruding == true ? -ellipseOriginOffset : ellipseOriginOffset) - 1, _y - base-1,
						_x + (protruding == true ? -ellipseOriginOffset : ellipseOriginOffset) - 1, _y + base+1,
						_x + (protruding == true ? -ellipseOriginOffset : ellipseOriginOffset) - 1, _y + halfCH-1
					);
			
		}
		
	}
	
	function draw3DArc(_ctx, _x, _y, radius, sAngle1, eAngle1, sAngle2, eAngle2){
	
		_ctx.beginPath();
		_ctx.strokeStyle = "#ff0000";
		_ctx.arc(_x, _y, radius , sAngle1 ,eAngle1);
		_ctx.stroke();
		_ctx.closePath();
				
		_ctx.beginPath();
		_ctx.strokeStyle = "#ff00ff";
		_ctx.arc(_x, _y, radius , sAngle2 ,eAngle2);
		_ctx.stroke();
		_ctx.closePath();
	
	}
	
	function draw3DLine(_ctx,  _color, _x1, _y1, _x2, _y2, _x3, _y3, _x4, _y4){
	
		_ctx.strokeStyle = _color;
		_ctx.beginPath();
		_ctx.moveTo(_x1, _y1);
		_ctx.lineTo(_x2, _y2);
		_ctx.stroke();
		_ctx.closePath();
		
		_ctx.beginPath();
		_ctx.moveTo(_x3, _y3);
		_ctx.lineTo(_x4, _y4);
		_ctx.stroke();
		_ctx.closePath();
	}
	
	
}