// Character Class for prefabication
// Jake Preston 
// last edit 1-16-17

// namespaces:
using UnityEngine;
using System.Collections;

// Character class - base class for characters
public class Character : MonoBehaviour {

	// fields
	public string direction;
	public int tileName;

	// Actor Initialization
	void Start() {
		// extract initial direction from lvl file
		// direction = ;

		// extract initial tileName player is on
		// tileName = ;
	}
	
	// Actor Update
	void Update() {
		// check for characters turn to walk

		// check enemy and trap collisions:
		// if (collision with enemy || trap) {
		// 	 	// play death sprite/animation
	    //		Destroy(GameObject)
	    //}

		// Check goal collision
		//if (goalCollision) {
		//	win
		//}
	}

	// player checks for the first possible direction 
	// they can walk to
	void checkDirection() {
	}

	// walk to new tile
	void walk(){
	}

	// player moves with tile that's being slid
	//Game master should call this every time the tile is slid, setting the player's coordinates correctly.
	public void slide(int x, int y){
		transform.position = new Vector3 (x, y, 0);
	}
}
