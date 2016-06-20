using UnityEngine;
using UnityEngine.UI;
using System.Collections;

	public class GameController : MonoBehaviour {
	
	public Text GameText;
	
	private enum States {launch, cell, sheets_0, notes_0, mirror, lock_0, cell_mirror, sheets_1, notes_1, lock_1, corridor_0, stairs_0, floor, closet_door,
						stairs_1, corridor_1, in_closet, corridor_2, stairs_2, corridor_3, courtyard};
	private States myState;
		
	// Use this for initialization
	void Start () {
		myState = States.launch;
	}
	
	// Update is called once per frame
	void Update () {
			
		if (myState == States.launch){
			launch();
		}else if (myState == States.cell){
			cell();
		}else if (myState == States.sheets_0){
			sheets_0();
		}else if (myState == States.notes_0){
			notes_0();
		}else if (myState == States.mirror){
			mirror();
		}else if (myState == States.lock_0){
			lock_0();
		}else if (myState == States.cell_mirror){
			cell_mirror();
		}else if (myState == States.sheets_1){
			sheets_1();
		}else if (myState == States.notes_1){
			notes_1();
		}else if (myState == States.lock_1){
			lock_1();
		}else if (myState == States.corridor_0){
			corridor_0();
		}else if (myState == States.stairs_0){
			stairs_0();
		}else if (myState == States.floor){
			floor();
		}else if (myState == States.closet_door){
			closet_door();
		}else if (myState == States.stairs_1){
			stairs_1();
		}else if (myState == States.corridor_1){
			corridor_1();
		}else if (myState == States.in_closet){
			in_closet();
		}else if (myState == States.corridor_2){
			corridor_2();
		}else if (myState == States.stairs_2){
			stairs_2();
		}else if (myState == States.corridor_3){
			corridor_3();
		}else if (myState == States.courtyard){
			courtyard();
		}
	}
	
	
	void launch(){
			GameText.fontSize = 35;
			GameText.text = "PRESS 'ENTER' TO START YOUR STORY";
			if(Input.GetKeyDown(KeyCode.Return)){
				myState = States.cell;
			}
	}
	
	void cell(){
		GameText.fontSize = 20;
		GameText.text = "My name is Matias and I just achieve my third year on prision for a crime that i didn't commit and I just can't being here for one more second. I past the last" +
						" six months planning my escape and now i have everything that i need for make it work. Is already midnight, and is also the time for begin my escape, there" +
						" is a lockpick behind of my mirror, I already used it a couple of times, I'm not sure of what is gonna happen after open my gate, but i'm decided to" +
						" escape or die on the try.\n\n" +
						"You are in a prision cell, and you want to escape. There are some dirty notes on the bed, a mirror on the wall, and the door is locked from the outside" +
						" is already midnight and there is no time to waste you must hurry now.\n\n" +
						"Press 'N' to view the Notes, 'M' to view the Mirror and 'L' to view the Lock.\n\n";
						
		if(Input.GetKeyDown(KeyCode.N)){
			myState = States.sheets_0;
		}else if(Input.GetKeyDown(KeyCode.M)){
			myState = States.mirror;
		}else if(Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_0;
		}	
	}
	
	void sheets_0(){
		GameText.text = "There are some letters from my daughter here, i miss her so much i believe that some day i can see her again,I don't see her from the day that a kill" +
						" the guy that tried to kidnap her.  I can barely remember his face but  i'll never forget his sweet voice.\n\n" +
						"Press 'R' to Read the notes and press 'B' to Back to roaming your cell";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.notes_0;
		}else if(Input.GetKeyDown(KeyCode.B)){
			myState = States.cell;
		}
	}
	
	void notes_0(){
		GameText.text = "You try to read the letter but it is to dirty, and you can barely see some drawings that your daughter make for you. The draw shows you playing" +
						" with her and your dog Rocky having a good time.\n\n" +
						"Press 'B' to Back to roaming your cell";
		if(Input.GetKeyDown(KeyCode.B)){
			myState = States.cell;
		}
	}
	
	void mirror(){
		GameText.text = "I see my reflect on the mirror and i can't even recognize me, just passed 3 years from where i get here, but I'm feeling so old and destroyed inside, is like i" +
						" past the last 20 years inside of this prision, but nobody is gonna rescue me, and i prefer to be dead than past the rest of my life locked like a dog." +
						" My lockpick is behind the mirror, i should pick it.\n\n" +
						"Press 'B' to Return to roaming your cell, press 'T' to Take the lockpick";
		if(Input.GetKeyDown(KeyCode.B)){
			myState = States.cell;
		}else if(Input.GetKeyDown(KeyCode.T)){
			myState = States.cell_mirror;
		}
	}
	
	void lock_0(){
		GameText.text = "Caught like a bird for a crime that i didn't commit, here is my first step to liberty, now i need my lockpick to escape from the cell, i'm sure" +
						" that i put it right behind my mirror i should loke for it before it is too late for escape.\n\n" +
						"Press 'B' to Return to roaming your cell";
		if(Input.GetKeyDown(KeyCode.B)){
			myState = States.cell;
		}
	}
	
	void cell_mirror(){
		GameText.text = "Ok, I'm ready to escape, now i just need to use my lockpick on the cell and i'll be free, i use it a couple of times so it should work.\n\n" +
						" You are still in your cell, and you STILL want to escape, now you have the lockpick that you needed to open the cell. There are some dirty notes" +
						" on the bed, and the door is locked from the outside is already midnight and there is no time to waste you must hurry now.\n\n" +
						"Press 'N' to view the Notes and 'L' to use the Lockpick.";
		if(Input.GetKeyDown(KeyCode.N)){
			myState = States.sheets_1;
		}else if(Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_1;
		}
	}
	
	void sheets_1(){
		GameText.text = "There are some letters from my daughter here, i miss her so much i believe that some day i can see her again,I don't see her from the day that a kill" +
						" the guy that tried to kidnap her.  I can barely remember his face but  i'll never forget his sweet voice. I promise that i'll see you again.\n\n" +
						"Press 'R' to Read the notes and press 'B' to Back to roaming your cell";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.notes_1;
		}else if(Input.GetKeyDown(KeyCode.B)){
			myState = States.cell_mirror;
		}
	}
	
	void notes_1(){
		GameText.text = "You try to read the letter but it is to dirty, and you can barely see some drawings that your daughter make for you. The draw shows you playing" +
						" with her and your dog Rocky having a good time.\n\n" +
						"Press 'B' to Back to roaming your cell";
		if(Input.GetKeyDown(KeyCode.B)){
			myState = States.cell_mirror;
		}
	}
	
	void lock_1(){
		GameText.text = "This is my first step, my oportunity to escape and finally be free\n\n" +
						"You carefully put the lockpick through the bars, and turn it round so you can see the lock. You can just make out fingerprints around " +
						"the buttons. You press the dirty buttons, and hear a click.\n\n" +
						"Press 'B' to Back to roaming your cell, press E to Escape from the cell";
		if(Input.GetKeyDown(KeyCode.B)){
			myState = States.cell_mirror;
		}else if(Input.GetKeyDown(KeyCode.E)){
			myState = States.corridor_0;
		}
	}
	
	void corridor_0(){
		GameText.text = "One step ahead, you are now on the prision corridor, but when you force the cell gate your lockpick broke in the process, the first things" +
						" that you see is the stairs to the courtyard, something shining on the dirty floor and the cleaning department closet door. \n\n" +
						"Press 'S' to go to the Stairs, press 'F' to see the floor and press 'C' to view the Closet door";
		if(Input.GetKey(KeyCode.S)){
			myState = States.stairs_0;
		}else if(Input.GetKeyDown(KeyCode.F)){
			myState = States.floor;
		}else if(Input.GetKeyDown(KeyCode.C)){
			myState = States.closet_door;
		}
	}
	
	void stairs_0(){
		GameText.text = "When you get near the Stairs you notice that there are some prision guards upstairs doing a patrol on the second floor, if you want to escape" +
						" you need to find another way to escape from the prision.\n\n" +
						"Press 'B' to Back to the prision corridor";
		if(Input.GetKeyDown(KeyCode.B)){
			myState = States.corridor_0;
		}
	}
	
	void floor(){
		GameText.text = "There is something shining on that dirty floor. You try to bend over to see it well, it is a clip you could use it as a new lockpick, it is not the best" +
						" option, but there is no time to look for something else.\n\n" +
						"Press 'B' to Back to the prision corridor and press 'T' to take the clip";
		if (Input.GetKeyDown(KeyCode.B)){
			myState = States.corridor_0;
		}else if(Input.GetKeyDown(KeyCode.T)){
			myState = States.corridor_1;
		}
	}
	
	void closet_door(){
		GameText.text = "You try to open the closet door in silence, but the door is locked, anyway is a really bad lock, you just need something to force it and open the door" +
						" is a shame that your lockpick is now broken.\n\n" +
						"Press 'B' to back to the prision corridor";
		if(Input.GetKeyDown(KeyCode.B)){
			myState = States.corridor_0;
		}
	}
	
	void stairs_1(){
		GameText.text = "When you get near the Stairs you notice that there are some prision guards upstairs doing a patrol on the second floor, if you want to escape" +
						" you need to find another way to escape from the prision.\n\n" +
						"Press 'B' to Back to the prision corridor";
		if(Input.GetKeyDown(KeyCode.B)){
			myState = States.corridor_1;
		}
	}
	
	void corridor_1(){
		GameText.text = "You are now on the prision corridor, you have a new clip that you found on the floor and you could use it as a key the first things" +
						" that you see is the stairs to the courtyard and the cleaning department closet door. \n\n" +
						"Press 'S' to go to the Stairs and 'O' to open the Closet door";
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.stairs_1;
		}else if(Input.GetKeyDown(KeyCode.O)){
			myState = States.in_closet;
		}
	}
	
	void in_closet(){
		GameText.text = "You open the closet door with your new clip, the only thing that you see that could be useful is a cleaning suit, you could use it to" +
						" make the prision guards think that you are the cleaning guy. \n\n" +
						"Press 'D' to dress up with the suit and press 'B' to back to the corridor";
		if(Input.GetKeyDown(KeyCode.D)){
			myState = States.corridor_3;
		}else if(Input.GetKeyDown(KeyCode.B)){
			myState = States.corridor_2;
		}
	}
	
	void corridor_2(){
		GameText.text = "You are now on the prision corridor and you had opened the cleaning department closet door. the first things" +
						" that you see is the stairs to the courtyard and the cleaning department closet door. \n\n" +
						"Press 'S' to go to the Stairs and 'O' to open the Closet door";
		if(Input.GetKey(KeyCode.S)){
			myState = States.stairs_2;
		}else if(Input.GetKey(KeyCode.O)){
			myState = States.in_closet;
		}
	}
	
	void stairs_2(){
		GameText.text = "When you get near the Stairs you notice that there are some prision guards upstairs doing a patrol on the second floor, if you want to escape" +
						" you need to find another way to escape from the prision, you could try to use the clean suit to trick the prision guards.\n\n" +
						"Press 'B' to Back to the prision corridor";
		if(Input.GetKey(KeyCode.B)){
			myState = States.corridor_2;
		}
	}
	
	void corridor_3(){
		GameText.text = "You are now on the prision corridor and you are dressed up with the cleaning suit, now you can go up stairs and trick the prision guards" +
						" to get to the courtyard or you could go back and put on your prision clothes again.\n\n" +
						"Press 'S' to use the Stairs and press 'B' to back to the closet";
		if (Input.GetKey(KeyCode.B)){
			myState = States.in_closet;
		}else if(Input.GetKey(KeyCode.S)){
			myState = States.courtyard;
		}
	}
	
	void courtyard(){
		GameText.text = "You go upstairs dressed as a cleaner and there is two prision guards, but they don't recognize you, the guard tips his hat at you as you waltz past, claiming" +
						"your freedom. You heart races as you walk into the sunset\n\n" +
						"Press 'P' to play again";
		if(Input.GetKeyDown(KeyCode.P)){
			myState = States.cell;
		}
	
	}
}
