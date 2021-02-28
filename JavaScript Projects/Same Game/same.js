
TILE_COLORS = {0:"#0B03FF",1:"#FF0B03",2:"#FF00FF",3:"#FFF703",4:"#05FFF7"};
TILE_LETTERS = {0:"A",1:"B",2:"C",3:"D",4:"E"};
BOARD_WIDTH = 36;
BOARD_HEIGHT = 17;
gamePoints = 0;
onSelection = false;
gameSet = false;
curColorIndex = -1;

window.onload = initApp;

function initApp(){
	
	setUI();
	loadCells();
	newGame();
}

function setUI(){
	
	var replayButton = document.getElementById("replayGame");
	var newButton = document.getElementById("newGame");
	replayButton.setAttribute("onclick","replayGame();");
	newButton.setAttribute("onclick","newGame();");
	
	var body = document.getElementsByTagName("body");
	var table = document.createElement("table");
	table.setAttribute("style","width:180px;border: 2px gray ridge;background-image:url('oel.png');background-size:100%");
	body[0].appendChild(table);
	
	for (var i=0; i < 5; i++){
		
		var row = document.createElement("tr");
		
		var col1 = document.createElement("td");
			col1.setAttribute("style","width:30px;");
			var tile = document.createElement("div");
				tile.setAttribute("class","tableCell");
				tile.setAttribute("style","background-color:" + TILE_COLORS[i] + ";");
				tile.innerHTML = TILE_LETTERS[i];
			col1.appendChild(tile);
		
		var col2 = document.createElement("td");
			col2.setAttribute("style","width:150px;")
			var initialTileCount = document.createElement("span");
				initialTileCount.setAttribute("id","initialTileCount" + i);
				initialTileCount.setAttribute("style","color:" + TILE_COLORS[i] + "; background-color:black;");
			col2.appendChild(initialTileCount);

			var currentTileCount = document.createElement("span");
				currentTileCount.setAttribute("id","currentTileCount" + i);
				currentTileCount.setAttribute("style","color:black;background-color:white;");
			col2.appendChild(currentTileCount);
			
			var tileSelection = document.createElement("span");
				tileSelection.setAttribute("id","tileSelection" + i);
				tileSelection.setAttribute("style","color:white;background-color:red;");
			col2.appendChild(tileSelection);
		
		row.appendChild(col1);
		row.appendChild(col2);
		table.appendChild(row);
	}
	
	var br = document.createElement("br");
	body[0].appendChild(br);
	
	var gamePoints = document.createElement("div");
	gamePoints.setAttribute("class","gamePoints");
	gamePoints.setAttribute("id","gamePoints");
	gamePoints.innerHTML = "0"; 
	body[0].appendChild(gamePoints);

}

function Cell(id, index, x, y, left, top, size, color, colorindex, blank, visited, letter){

	this.id = id;
	this.index = index;
	this.x = x;
	this.y = y;
	this.left = left;
	this.top = top;
	this.size = size;
	this.color = color;
	this.colorIndex = colorindex;
	this.blank = blank;
	this.visited = visited;
	this.letter = letter;

}

function loadCells(){

	var divBoard = document.getElementById("board");
	var size = 25;
	
	for (var y=0; y<BOARD_HEIGHT; y++){
		for (var x=0; x<BOARD_WIDTH; x++){
			
			var divCell = document.createElement("div");
			var left = x * 29;
			var top = y * 29 ;
			var colorIndex = Math.floor(Math.random() * 5);
			var style = "background-color:" + TILE_COLORS[colorIndex] + ";" +
						"left:" + left + "px;" +
						"top:" + top + "px;"
			var id = "cell_" + x + "_" + y;
			
			divCell.setAttribute("style", style);
			divCell.setAttribute("class", "cell");
			divCell.setAttribute("id", id);
			divCell.innerHTML = TILE_LETTERS[colorIndex];
			divCell.setAttribute("onmouseover", "onMouseOver(" + id + ");");
			divCell.setAttribute("onclick", "onClick(" + id + ");");
			divBoard.appendChild(divCell);
		}
	}
	
}

function newGame(){

	cells = [];
	replay = [];
	tileCount =[];
	
	onReset = true;
	var index = 0;
	var size = 25;
	
	for (var y=0; y<BOARD_HEIGHT; y++){
		for (var x=0; x<BOARD_WIDTH; x++){

			var left = x * 29;
			var top = y * 29;
			var colorIndex = Math.floor(Math.random() * 5);
			var id = "cell_" + x + "_" + y;
			
			tileCount.push(colorIndex);
			cells.push(new Cell(id, index, x, y, left, top, size, TILE_COLORS[colorIndex], colorIndex, false, false, TILE_LETTERS[colorIndex]));
			replay.push(new Cell(id, index, x, y, left, top, size, TILE_COLORS[colorIndex], colorIndex, false, false, TILE_LETTERS[colorIndex]));
			setCell(cells[index], index);
			
			index++;
		}
	}
	
	updateTileCounts();
	resetGamePoints();	
	gameSet = true;

}

function replayGame(){

	cells = [];
	tileCount = [];
	onReset = true;

	for (var i = 0; i < replay.length; i++){
		var cell = new Cell(replay[i].id, replay[i].index, replay[i].x, replay[i].y, replay[i].left, replay[i].top, replay[i].size, replay[i].color, replay[i].colorIndex, false, false, replay[i].letter);
		tileCount.push(replay[i].colorIndex);
		cells.push(cell);
		setCell(cell, i);
	}
		
	updateTileCounts();	
	resetGamePoints();
	gameSet = true;

}

function updateTileCount(){

	var j=0;
	var colorIndex = oToSelect[0].colorIndex;
	
	for (var i=0; i < tileCount.length; i++){
		if(colorIndex == tileCount[i]){
			tileCount.splice(i,1);
			j++;
			if (j == oToSelect.length){
				break;
			}
		}
	}
}

function updateTileCounts(){

	for (var i=0; i< 5; i++){
		var tCount = document.getElementById("currentTileCount"+i);
		var iCount = document.getElementById("initialTileCount"+i);
		tCount.innerHTML = countTiles(tileCount)[i];
		if (onReset == true){
			iCount.innerHTML = "[" + countTiles(tileCount)[i] + "]    ";
		}
	}
	onReset = false;
}

function countTiles(tile) {
	var tiles = {}, i = tile.length, colorIndex;
	while( i-- ) {
		colorIndex = tiles[tile[i]];
		tiles[tile[i]] = colorIndex ? colorIndex + 1 : 1;
	}
	return tiles;
}

function setSelectionPoints(){
	var tileSelection = document.getElementById("tileSelection" + oToSelect[0].colorIndex);
	tileSelection.innerHTML = "  " + tileSelectionPoints() + " [" + oToSelect.length + "]  ";
}

function clearSelectionPoints(){
	var tileSelection = document.getElementById("tileSelection" + oToSelect[0].colorIndex);
	tileSelection.innerHTML = "";
}

function tileSelectionPoints(){
	return oToSelect.length * (oToSelect.length - 2);
}

function updateGamePoints(){
	gamePoints += tileSelectionPoints();
	var divGamePoints = document.getElementById("gamePoints");
	divGamePoints.innerHTML = gamePoints;
}

function resetGamePoints(){
	gamePoints = 0;
	var divGamePoints = document.getElementById("gamePoints");
	divGamePoints.innerHTML = gamePoints;
}

function hasStillMove(){

    for (var y = 0; y < BOARD_HEIGHT; y++){
        for (var x = 0; x < BOARD_WIDTH; x++){
			var index = (y * BOARD_WIDTH) + x;
            if (cells[index].blank == false){
                makeSelection(cells[index], true);
                if (oToSelect.length > 1){
                    return true;
                }
            }
        }
    }

	return false;
}

function searchColor(cell, currentColor){
        
    var x = cell.x;
    var y = cell.y;
    cells[cell.index] = cell;
    cells[cell.index].visited = true;
    
    /*
	 Iterate through the current cell's neighboring cells (Top, Right, Bottom and Left)
          ____
         |T=0 |
     ____|____|____
    |L=3 |Cell|R=1 |
    |____|____|____|
         |B=2 |
         |____|
    
	*/
	
	for (var i = 0; i<4; i++)
	{
        
        // Reset the new cell coordinates values.
        var nX = x;
        var nY = y;
			
        switch (i)
		{
            case 0: 
				nY = y - 1;      // The cell on top of the current cell.
				break;
            case 1: 
				nX = x + 1;      // The cell to the right of the current cell.
				break;
            case 2: 
				nY = y + 1;      // The cell below the current cell.
				break;
            case 3: 
				nX = x - 1;      // The cell to the left of the current cell.
				break;
			default:
				break;
        }
		
        if ((nY >= 0) && (nY < BOARD_HEIGHT) && (nX >= 0) && (nX < BOARD_WIDTH)){
			var index = (nY * BOARD_WIDTH) + nX;
            if ((currentColor == cells[index].color) && (cells[index].visited == false) && (cells[index].blank == false)){
				oToSearch.push(cells[index]);    			// Add the cell at the end of the collection.
                oToSelect.unshift(cells[index]);            // Add the cell at the beginning of the collection
                cells[index].visited = true;                // Mark the cell as visited to avoid getting into it again.
            }
        }
    }
}

function makeSelection(cell, onCheck) {

    var currentColor;
    oToSearch = [];		
    oToSelect = [];		
    
    oToSearch.push(cell);
    oToSelect.push(cell);
    currentColor = cell.color;
    
    do 
    {
		var dcell = oToSearch[0];
        searchColor(dcell, currentColor);
        if (oToSearch.length > 0){
			oToSearch.splice(0,1);	// Remove the first item in the array
		}
    }
	while (oToSearch.length > 0)

    resetVisitedStatus();
	if (onCheck == true){
		onCheck = false;
		return;
	}
	
    if (oToSelect.length > 1){
		markSelection();
    }

}

function markSelection(){
	for (var i=0; i<oToSelect.length; i++){
		drawCell(oToSelect[i], "white");
	}
	setSelectionPoints();
	onSelection = true;
}

function unmarkSelection(){
	for (var i=0; i<oToSelect.length; i++){
		drawCell(oToSelect[i], "black");
	}
	clearSelectionPoints();
	onSelection = false;
}

function resetVisitedStatus(){
	for (var i=0; i < oToSelect.length; i++){
		cells[oToSelect[i].index].visited = false;
    }
}

function cellClicked2(obj){

	if (gameSet == false){
		return;
	}

	var divCel = null;
	for (var i=0; i < cells.length; i++){
		divCell = cells[i];
		if (divCell.id == obj.id){
			break;
		}
	}
	
	if (divCell.blank == true){
		if (onSelection == true){
            unmarkSelection();
        }
		return;
	}
	
	if (onSelection == false){
		if (curColorIndex != divCell.colorIndex){
			makeSelection(divCell, false);
			curColorIndex = divCell.colorIndex;
		}
	} 
	else 
	{
		if (inTheSelection(divCell) == true){
        //    updateUndo
            clearSelection();
        //    updateScore
        //    updateBestTilePoints
            moveCells();
            moveBlock();
        //    RaiseEvent TileClick(undo.Count)
        //    RaiseEvent TileClear
            if (hasStillMove() == false){
        //        displayPlayStats()'
				alert("Done");
                gameSet = false;
                return;
            }
		}
        else
		{
			if (curColorIndex != divCell.colorIndex){
				unmarkSelection();
				curColorIndex = divCell.colorIndex;
			}
		}
	}
}

function onMouseOver(obj){

	if (gameSet == false){
		return;
	}

	var divCel = null;
	for (var i=0; i < cells.length; i++){
		divCell = cells[i];
		if (divCell.id == obj.id){
			break;
		}
	}
	
	if (divCell.blank == true){
		if (onSelection == true){
            unmarkSelection();
        }
		return;
	}
	
	if (curColorIndex != divCell.colorIndex){
		if (onSelection == true) {
			unmarkSelection();
		}
		makeSelection(divCell, false);
		curColorIndex = divCell.colorIndex;
	}

}

function onClick(){
	
	if (onSelection == true)
	{
		if (inTheSelection(divCell) == true){
        //    updateUndo
            clearSelection();
        //    updateScore
        //    updateBestTilePoints
            moveCells();
            moveBlock();
        //    RaiseEvent TileClick(undo.Count)
        //    RaiseEvent TileClear
            if (hasStillMove() == false){
        //        displayPlayStats()'
				alert("Done");
                gameSet = false;
                return;
            }
		}
        //else
		//{
		//	unmarkSelection();
		//}
	}
	
}

function inTheSelection(cell){
	for (var i=0; i < oToSelect.length; i++){
		if (cell.id == oToSelect[i].id){
			return true;
		}
    }
	return false;
}

function clearSelection() {
    
	for (var i=0; i < oToSelect.length; i++){
		clearCell(oToSelect[i]);
    }
	updateTileCount();
	updateTileCounts();
	clearSelectionPoints();
	updateGamePoints();
	onSelection = false;
}

function clearCell(cell){
	var divCell = document.getElementById(cell.id);
	var style = "background-color:transparent;" +
				"border-style:none;" +
				"left:" + cell.left + "px;" +
				"top:" + cell.top + "px;" 
	divCell.setAttribute("style", style);
	divCell.innerHTML = "";
	cells[cell.index].blank = true;
}

function moveCells() {

    var highest = 0;
    var x;
	var y;
	var index;
	
    // Store all the columns affected.
	var oColumns = [];
    for (var i = 0; i < oToSelect.length; i++){
        var divCell = oToSelect[i];
		if (isInColumn(oColumns, divCell.x) == false ){
			oColumns.push(divCell.x);
		}
    }
	
    // Iterate through all the columns
    for (var j = 0; j < oColumns.length; j++){
		
		x = oColumns[j];
        // Get the bottommost blank cell
        for (y = 0; y < BOARD_HEIGHT; y++){
            index = (y * BOARD_WIDTH) + x;
			if (cells[index].blank == true){
                highest = y;
            }
        }

        var colCells = [];
        // Accumulate all the cells in the current column.
        for (y = 0; y <= highest; y++){
			index = (y * BOARD_WIDTH) + x;
            if (cells[index].blank == false){
                colCells.push(cells[index]);
            }
        }
        
        // Clear the column
        for (y = 0; y <= highest; y++){
			index = (y * BOARD_WIDTH) + x;
            cells[index].blank = true;
			clearCell(cells[index]);
        }
		
        if (colCells.length > 0) {
            // Move the cells from the bottom up.
            var ctr = colCells.length - 1;
			for (y = highest; y >= ((highest-colCells.length) + 1); y--){
                index = (y * BOARD_WIDTH) + x;
				var cell = colCells[ctr];
				setCell(cell, index);
                ctr--;
            }
        }
    }
}

function setCell(cell, index){
    cells[index].index = index;
    cells[index].x = index % BOARD_WIDTH;
    cells[index].y = Math.floor(index / BOARD_WIDTH);
    cells[index].left = cells[index].x * 29;
    cells[index].top = cells[index].y * 29;
    cells[index].letter = cell.letter;
    cells[index].color = cell.color;
    cells[index].colorIndex = cell.colorIndex;
    cells[index].blank = false;
    cells[index].visited = false;
    drawCell(cells[index], "black");
}

function drawCell(cell, textColor){
	
	var divCell = document.getElementById(cell.id);
	var style = "background-color:" + cell.color + ";" +
				"left:" + cell.left + "px;" +
				"top:" + cell.top + "px;" +
				"color:" + textColor + ";"
	divCell.setAttribute("style", style);
	divCell.setAttribute("class","cell");
	var id = "cell_" + cell.x + "_" + cell.y;
	divCell.setAttribute("id", id);
	divCell.setAttribute("onmouseover", "onMouseOver(" + id + ");");
	divCell.setAttribute("onclick", "onClick(" + id + ");");
	divCell.innerHTML = cell.letter;
	// Objects in Javascript are passed by reference. 
	cell.id= id;
}

function isInColumn(oColumns, x){
	for (var i = 0; i < oColumns.length; i++){
		if (oColumns[i] == x){
			return true;
		}
	}
	return false;
}

function moveBlock(){

	var rColumn = rightmostNonEmptyColumn();
    var emptyColumn = rightmostEmptyColumn(rColumn);
	
    while (emptyColumn != -1)
    {    
		for (var x = emptyColumn; x < rColumn; x++) {
            for (var y = 0; y < BOARD_HEIGHT; y++){
				var index = (y * BOARD_WIDTH) + (x + 1);
                if (cells[index].blank == false){
					var index2 = (y * BOARD_WIDTH) + x;
                    setCell(cells[index], index2);
                    clearCell(cells[index]);
                    cells[index].blank = true;
                }
            }
        }
        rColumn = rightmostNonEmptyColumn();
        emptyColumn = rightmostEmptyColumn(rColumn);
    }    
}

function rightmostEmptyColumn(rColumn){

    for (var x = rColumn; x >= 0; x--){
        if (columnIsNotEmpty(x) == false){
            return x;
        }
    }
	return -1;
}

function rightmostNonEmptyColumn(){
    
    for (var x = BOARD_WIDTH - 1; x >= 0; x--){
        if (columnIsNotEmpty(x) == true) {
            return x;
        }
    }
	return 0;
}

function columnIsNotEmpty(x){
  
    for (var y = 0; y < BOARD_HEIGHT; y++) {
		var index = (y * BOARD_WIDTH) + x;
        if (cells[index].blank == false){
            return true;
        }
    }
	return false;
}
