// JavaScript Document
function start_canvas(){
	var canvas_id = document.getElementById('my_canvas').getContext('2d');
	var canvas_h = canvas_id.canvas.height, canvas_w = canvas_id.canvas.width;
	var img = new Image;
	img.addEventListener('load', Obj, false);
	img.src = "ship1.jpg"
	
	function Obj(){
		this.x = 0, this.y = 0, this.w = 20, this.h = 20;
			this.render = function(){
				canvas_id.drawImage(img, this.x, this.y, this.w, this.h);
			}
	}
	var obj = new Obj();
	obj.x = 150;
	obj.y = 130;
	function animate(){
		canvas_id.save();
		canvas_id.clearRect(0, 0, canvas_w, canvas_h);
		obj.render();
		canvas_id.restore();
	}
	var animateInterval = setInterval(animate, 30);
	
	document.addEventListener('keydown', function(event){
		var key_press = String.fromCharCode(event.keyCode);
		if(key_press == "&"){
			obj.y-= 3;
		}else if(key_press == "("){
			obj.y+= 3;
		}else if(key_press == "%"){
			obj.x-= 3;
		}else if(key_press == "'"){
			obj.x+= 3;
		}
	});

}
window.addEventListener('load', function(event){
	start_canvas();
});