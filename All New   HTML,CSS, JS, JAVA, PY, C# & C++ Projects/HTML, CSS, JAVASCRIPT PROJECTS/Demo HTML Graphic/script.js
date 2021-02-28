/* HTML5 / CSS3 / Javascript Particle System - Demo
	
	01/21/2016, Patrick Stranz
*/

// Function definitions

// Star Shower
function DemoOne(){
	
	// Get a specific element or create a new one
	var target_div = document.getElementById("demo-one");
	// Create a function which returns a random number based on target div width. Will be used as particles init position
	var random_n = function(){ return (Math.random()*target_div.offsetWidth);};
	
	// Create a new particle system. 
	var new_system = new ParticleSystem({syslifetime:0, lifetime: 1000, burstrate: 100, burstamount: 1, 
																		initsize:{x:32, y:32},endsize:{x:12, y:12}, texture: "http://stranz.info/public/h5ps/img/star.png",
																		initpos: {x:random_n, y: 0}, velocity:{x:0, y:100}, 
																		rotation:{start:0, end:180}, target: target_div});
	
	// Get the demo display element and show the particle count
	var display_div = document.getElementById("display-demo-one");
	setInterval( function(){ display_div.innerHTML = "Shower | Particle Count: "+ new_system.particles.length;}, 100);
}

// Fog
function DemoTwo(){

	var target_div = document.getElementById("demo-two");
	var random_n = function(){ return (Math.random()*target_div.offsetWidth);};
	var bottom = function(){ return (target_div.offsetHeight-(target_div.offsetHeight*0.3)) ;};
	var new_system = new ParticleSystem({syslifetime:0, lifetime: 2000, burstrate: 100, burstamount: 1, 
																		initsize:{x:124, y:64},endsize:{x:124, y:248},
																		initpos: {x:random_n, y: bottom}, velocity:{x:0, y:-80},
																		initalpha: 0.3, endalpha: 0, target: target_div,
	                                                                    texture: "http://stranz.info/public/h5ps/img/grad_radial_white.png"
	});
																		
	var display_div = document.getElementById("display-demo-two");
	setInterval( function(){ display_div.innerHTML = "Fog | Particle Count: "+ new_system.particles.length;}, 100);																		
}

// Mouse Follow
function DemoThree(){

	var ipos = {x:0,y:0};
	var isize = {x:32, y:32};
	
	var target_div = document.getElementById("demo-three");
	var p_sys; 
	
	target_div.onmousemove = function(evt){

		ipos.x = evt.pageX - target_div.offsetLeft ;
		ipos.y = evt.pageY - target_div.offsetTop-32;
	};
	
	target_div.onmouseenter = function(evt){
		ipos.x = evt.pageX - target_div.offsetLeft;
		ipos.y = evt.pageY - target_div.offsetTop;
		
		p_sys = new ParticleSystem({syslifetime:0, lifetime: 1000, burstrate: 20, burstamount: 1, 
									initsize:{x:32, y:32}, endsize:{x:8, y:8}, texture: "http://stranz.info/public/h5ps/img/star.png",
									initpos: ipos, velocity:{x:0, y:-10}, initalpha:1, endalpha:0, target:target_div});
	};
	target_div.onmouseleave = function(evt){

		p_sys.params.syslifetime = 10;
	};
	
	var display_div = document.getElementById("display-demo-three");
	setInterval( function(){ if(p_sys!==undefined)display_div.innerHTML = "Mouse Follow | Particle Count: "+ p_sys.particles.length;}, 100);
}

// Combined
function DemoFour(){
	var target_div = document.getElementById("demo-four");
	var random_x = function(){ return (Math.random()*target_div.offsetWidth);};
	var random_y = function(){ return (Math.random()*target_div.offsetHeight*0.5);};
	
	var new_system_one = new ParticleSystem({syslifetime:0, lifetime: 2000, burstrate: 200, burstamount: 5, 
											initsize:{x:64, y:64},endsize:{x:124, y:124},
											initpos: {x:random_x, y: random_y}, velocity:{x:0, y:0},
											initalpha: 0.3, endalpha: 0, target: target_div});

	random_x = function(){ return ((target_div.offsetWidth*0.5)+80 * Math.cos(((0.25*Date.now())%360)*Math.PI/180));};
	random_y = function(){ return ((target_div.offsetHeight*0.5)+30 * Math.sin((0.5*Date.now()%360)*Math.PI/180));};
	
	var new_system_two = new ParticleSystem({syslifetime:0, lifetime: 500, burstrate: 20, burstamount: 1, 
											initsize:{x:32, y:32},endsize:{x:12, y:12}, texture: "http://stranz.info/public/h5ps/img/star.png",
											initpos: {x:random_x, y:random_y}, velocity:{x:0, y:-50}, target: target_div});
															
	
	var display_div = document.getElementById("display-demo-four");
	setInterval( function(){ display_div.innerHTML = "Combined | Particle Count: "+ (new_system_one.particles.length+new_system_two.particles.length);}, 100);
}


// Delayed function calls
setTimeout( function(){ DemoOne(); 
						DemoTwo();
						DemoThree();
						DemoFour();
						} , 1000);