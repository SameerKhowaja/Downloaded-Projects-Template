package com.realtutsgml.src.input;

import java.awt.Graphics2D;
import java.util.LinkedList;
import com.realtutsgml.src.objects.Enemy;

public final class Controller {

	static LinkedList<Enemy> e = new LinkedList<Enemy>();
	Enemy TempEnemy;
	
	public Controller(){
		addEnemy(new Enemy(0, 50));
		addEnemy(new Enemy(700, 50));
		addEnemy(new Enemy(800, 50));
		addEnemy(new Enemy(300, 50));
		addEnemy(new Enemy(500, 50));
		addEnemy(new Enemy(100, 130));
		addEnemy(new Enemy(700, 130));
		addEnemy(new Enemy(550, 130));
		addEnemy(new Enemy(180, 230));
		addEnemy(new Enemy(700, 230));
		addEnemy(new Enemy(480, 230));
		addEnemy(new Enemy(0, 230));
		addEnemy(new Enemy(0, 300));
		addEnemy(new Enemy(750, 300));
		addEnemy(new Enemy(50, 350));
		addEnemy(new Enemy(200, 450));
		addEnemy(new Enemy(400, 350));
		addEnemy(new Enemy(350, 450));
		addEnemy(new Enemy(700, 450));
		addEnemy(new Enemy(500, 450));
		
	}
	
	public void draw(Graphics2D g2d){
		for(int i = 0; i < e.size(); i++){
			TempEnemy = e.get(i);
			TempEnemy.draw(g2d);
		}
	}
	
	public void update(){
		for(int i = 0; i < e.size(); i++){
			TempEnemy = e.get(i);
			TempEnemy.update();
		}
	}
	
	public void addEnemy(Enemy enemy){
		e.add(enemy);
	}
	public void removeEnemy(Enemy enemy){
		e.remove(enemy);
	}
	
	public static LinkedList<Enemy> getEnemyBounds(){
		return e;
	}
	
}
