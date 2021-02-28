function Board(_imgElement, _colCount, _rowCount ){
	
	var
		rowCount = _rowCount,
		colCount = _colCount,
		imgElement = _imgElement,
		imageWidth = imgElement.width,
		imageHeight = imgElement.height,
		srcCanvas = createCanvas("srcCanvas", imageWidth, imageHeight),
		destCanvas = createCanvas("destCanvas", imageWidth, imageHeight),
		bfrCanvas = createCanvas("bfrCanvas", imageWidth, imageHeight),
		srcContext = srcCanvas.getContext("2d"),
		destContext = destCanvas.getContext("2d"),
		bfrContext = bfrCanvas.getContext("2d"),
		cellWidth = imageWidth / (colCount + 1),
		cellHeight = imageHeight / (rowCount + 1),
		offsetY = (imageHeight - (cellHeight * rowCount)) / 2,
		offsetX	= (imageWidth - (cellWidth * colCount)) / 2,
		ellipseRadius = (cellHeight >= cellWidth) ? (cellWidth / 6) : (cellHeight / 6),
		ellipseOriginOffset = (ellipseRadius / 2),
		ellipseOffset = ellipseRadius + ellipseOriginOffset,
		pieceHolderWidth = cellWidth + (ellipseOffset * 2),
		pieceHolderHeight = cellHeight + (ellipseOffset * 2),
		pieceCount = 0;
		
	this.pieceHolders = new Array();
	this.jigzawPieces = new Array();
		
	this.CellCount = function(){
		return colCount * rowCount;
	}
	
	// Returns the width of the current img element.
	this.ImageWidth = function(){
		return imageWidth;
	}
	
	// Returns the height of the current img element.
	this.ImageHeight = function(){
		return imageHeight;
	}
	
	// Returns the width of the jigzaw piece compartment cell
	// excluding the space occupied by the protruding ellipses 
	// on each vertical side of the cell.
	this.CellWidth = function(){
		return cellWidth;
	}
	
	// Returns the height of the jigzaw piece compartment cell
	// excluding the vertical distance of the space occupied by the 
	// protruding ellipses on each horizontal side of the cell.
	this.CellHeight = function(){
		return cellHeight;
	}
	
	// Returns the distance between the right or left edge of the
	// protruding ellipse and the board's vertical border.
	this.OffsetX = function(){
		return offsetX;
	}
	
	// Returns the distance between the top or bottom edge of the
	// protruding ellipse and the board's horizontal border.
	this.OffsetY = function(){
		return offsetY;
	}
	
	// Returns the radius of the ellipse.
	this.EllipseRadius = function(){
		return ellipseRadius;
	}
	
	// Returns the distance between the protruding or shrunk ellipse's 
	// origin and the edge of the jigzaw compartment cell.
	this.EllipseOriginOffset = function(){
		return ellipseOriginOffset;
	}
	
	// Returns the distance between the tip of the ellipse and the
	// edge of the jigzaw compartment cell.
	this.EllipseOffset = function(){
		return ellipseOffset;
	}
	
	// Returns the current img element used in the jigzaw puzzle.
	this.ImgElement = function(){
		return imgElement;
	}
	
	// Returns the width of the piece holder.
	this.PieceHolderWidth = function(){
		return pieceHolderWidth;
	}
	
	// Returns the height of the piece holder.
	this.PieceHolderHeight = function(){
		return pieceHolderHeight;
	}
	
	this.JigzawPieces = function(){
		return this.jigzawPieces;
	}

	// +++++++++++++++++++++++++++++++
	// Read/write attributes
	// +++++++++++++++++++++++++++++++
	
	// Sets/returns the number of jigzaw pieces snapped in the board.
	this.PieceCount = function(args){
		if (args.length > 0){
			if (args[1] != null){
				pieceCount = args[1];
			}else{
				pieceCount += args[0];
			}
		}else{
			return pieceCount;
		}
		return null;
	}
	
	this.RowCount = function(args){
		if (args.length > 0){
			rowCount = args[0];
		}else{
			return rowCount;
		}
		return null;
	}
	
	// Sets/returns the number of cell columns in the board.
	this.ColCount = function(args){
		if (args.length > 0){
			colCount = args[0];
		}else{
			return colCount;
		}
		return null;
	}
	
	// 
	this.initializePieceHolders = function(){
		
		var 
			left = offsetX - ellipseOffset,
			top = offsetY - ellipseOffset,
			ctr = 0;
		
		for (var j = 0; j < rowCount; j++){
			for (var i = 0; i < colCount; i++){
				// Position the cells horizontally in an overlapping fashion  
				// starting from the cell in the 2nd column right to the last.
				// left = (i == 0) ? left : left + pieceHolderWidth - (ellipseOffset * 2);
				this.pieceHolders[ctr] = new PieceHolder([left, top, ctr, -1]);
				left = left + pieceHolderWidth - (ellipseOffset * 2);
				ctr++;		
			}
			// Position the cells vertically in an overlapping fashion  
			// starting from the cell in the 2nd row down to the last.
			top = top + pieceHolderHeight - (ellipseOffset * 2);
			left = offsetX - ellipseOffset;
			
		}
	}
	
	//
	this.draw = function(){
		
		// Hide the source image.
		imgElement.setAttribute("style", "position: fixed; left: -2000px;");
		
		// Render the current image on the buffer context.
		bfrContext.drawImage(imgElement, 0, 0, imageWidth, imageHeight);
		
		// Resize the canvas elements.
		srcContext.canvas.width = imageWidth;
		srcContext.canvas.height = imageHeight;
		destContext.canvas.width = imageWidth;
		destContext.canvas.height = imageHeight;
		
		// Set the background color of the board.
		srcContext.fillStyle = 'lime';
		srcContext.fillRect(0, 0, imageWidth, imageHeight);
		
		// Draw a black filled rectangle at the center of the board. 
		srcContext.fillStyle = 'black';
		srcContext.fillRect(offsetX, offsetY, cellWidth * colCount, cellHeight * rowCount);
		
		// Row of alternating black-filled and lime-filled circles on the inner rectangle's top border.
		var x = cellWidth;
		for (var i = 0 ; i <  colCount ; i++){
			if( (i % 2) == 0){
				// Convexed (most of the circle's area is outside the inner black rectangle).
				srcContext.fillStyle = 'black';
				y = offsetY - (ellipseRadius / 2);
			}
			else{
				// Concaved (most of the circle's area is inside the inner black rectangle).
				srcContext.fillStyle = 'lime';
				y = offsetY + (ellipseRadius / 2);
			}
			// Draw the color-filled circle.
			srcContext.beginPath();
			srcContext.arc(x,y,ellipseRadius, 0, 2*Math.PI); 
			srcContext.fill();
			x += cellWidth;
		}

		// Row of alternating black-filled and lime-filled circles on the inner rectangle's bottom border.
		var x = cellWidth;
		var y2 = (rowCount * cellHeight) + offsetY;
		for (var i=0 ; i <  colCount ; i++){
			if( (i % 2) == 0){
				// Circle is concaved for odd row count, otherwise, convexed.
				srcContext.fillStyle = ((rowCount % 2)==0) ? 'lime' : 'black'; 
				y = ((rowCount % 2)==0) ? (y2 - (ellipseRadius / 2)) : (y2 + (ellipseRadius / 2)); 
			}
			else{
				// Circle is convexed for odd row count, otherwise, concaved.
				srcContext.fillStyle = ((rowCount % 2)==0) ? 'black' : 'lime'; 
				y = ((rowCount % 2)==0) ? (y2 + (ellipseRadius / 2)) : (y2 - (ellipseRadius / 2)); 
			}
			// Draw the circle.
			srcContext.beginPath();
			srcContext.arc(x,y,ellipseRadius, 0, 2*Math.PI); 
			srcContext.fill();
			x += cellWidth;
		}

		// Column of alternating black-filled and lime-filled circles on the inner rectangle's left border.
		var y = cellHeight;
		for (var i = 0 ; i <  rowCount ; i++){
			if( (i % 2) == 0){
				srcContext.fillStyle = 'black';
				x = offsetX - (ellipseRadius / 2);
			}
			else{
				srcContext.fillStyle = 'lime';
				x = offsetX + (ellipseRadius / 2);
			}
			srcContext.beginPath();
			srcContext.arc(x,y,ellipseRadius, 0, 2*Math.PI); 
			srcContext.fill();
			y += cellHeight;
		}
		
		// Column of alternating black-filled and lime-filled circles on the inner rectangle's right border.
		var y = cellHeight;
		var x2 = (colCount * cellWidth) + offsetX;
		for (var i = 0 ; i <  rowCount ; i++){
			if( (i % 2) == 0){
				srcContext.fillStyle = ((colCount % 2)==0) ? 'lime' : 'black'; 
				x = ((colCount % 2)==0) ? (x2) - (ellipseRadius / 2) : (x2) + (ellipseRadius / 2); 
			}
			else{
				srcContext.fillStyle = ((colCount % 2)==0) ? 'black' : 'lime'; 
				x = ((colCount % 2)==0) ? (x2) + (ellipseRadius / 2) : (x2) - (ellipseRadius / 2); 
			}
			srcContext.beginPath();
			srcContext.arc(x,y,ellipseRadius, 0, 2*Math.PI);
			srcContext.fill();
			y += cellHeight;
		}
		
		// Render the current image on the canvas.
		destContext.drawImage(imgElement, 0, 0, imageWidth, imageHeight);
		
		// Fetch the pixel data of the modified source canvas.
		var imgd = srcContext.getImageData(0, 0, imageWidth, imageHeight),
		pix = imgd.data;


		// Fetch the pixel data of the target canvas.
		var imgd2 = destContext.getImageData(0, 0, imageWidth, imageHeight),
		pix2 = imgd2.data;
		
		// Modify the pixel data of the target canvas based on the black-colored pixels 
		// in the source canvas to render as semi-transparent.
		for (var i = 0, n = pix.length; i < n; i += 4) {
			// Verify the current pixel in the modified source canvas for blackness.
			// These are the pixel parts that will be rendered semi-transparent in the target canvas.
			// Pixel components
			// pix[0] = Red
			// pix[1] = Green
			// pix[2] = Blue
			// pix[3] = Alpha (Transparency)
			if (pix[i] == 0 && pix[i+1] == 0 && pix[i+2] == 0){
				// 0  	= Fully transparent.
				// 255  = Opaque
				pix2[i+3] = 50; 
			}
		}
		
		// Render the modified pixels on the target canvas.
		destContext.putImageData(imgd2, 0, 0);
		
		// Set the src attribute of the newly created img element to the target canvas.
		var savedImageData = document.createElement("img");
		savedImageData.setAttribute("id","Board");
		savedImageData.setAttribute("style","left: 0; top: 0; position: absolute;border-radius: 5px;");
		savedImageData.src = destCanvas.toDataURL("image/png");
		addElement(savedImageData);
		
	}
	
	this.loadJigzawPieces = function(){
		
		var ctr=0;
		for (var j = 0; j < rowCount; j++){
			for (var i = 0; i < colCount; i++){
				
				this.jigzawPieces[ctr] = new Piece
									([
										this.pieceHolders[ctr].Left([]), 
										this.pieceHolders[ctr].Top([]), 
										this.pieceHolders[ctr].Index([]), 
										(((j%2==0) && (i%2==0)) || ((j%2!=0) && (i%2!=0))) ? 1 : 0, 
										imgElement
									]);
				ctr++;		
			}
		}		
	}
}
