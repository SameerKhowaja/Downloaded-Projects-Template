function PieceHolder(args){
	
	if(args.length > 0) {
		var 
			left = args[0],	
			top = args[1],
			index = args[2],
			pieceIndex = args[3];
	} else {
		var 
			left = -1,	
			top = -1,
			index = -1,
			pieceIndex = -1;
	}
		
	this.Left = function(args){
		if (args.length > 0){
			left = args[0];
		}else{
			return left;
		}
		return 1;
	}

	this.Top = function(args){
		if (args.length > 0){
			top = args[0];
		}else{
			return top;
		}
		return 1;
			
	}		
	
	this.Index = function(args){
		if (args.length > 0){
			index = args[0];
		}else{
			return index;
		}	
		return 1;
	}
	
	this.PieceIndex = function(args){
		if (args.length > 0){
			pieceIndex = args[0];
		}else{
			return pieceIndex;
		}	
		return 1;
	}
	
}