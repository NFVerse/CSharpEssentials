//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
    public FireArm bazooka;
	public void Main()
	{
        bazooka = new FireArm();
		bazooka.ammoAmount++;
		bazooka.ammoAmount--;
		bazooka.ammoAmount = 30;
		bazooka.ammoAmount += 30;
		bazooka.ammoAmount -= 5;
		Console.WriteLine(bazooka.weaponThing + " has an ammo count of " + bazooka.ammoAmount);
		
	}
}

public class FireArm {
    public int ammoAmount = 10;
    public string weaponThing = "Bazooka";
    public float weaponDamage = 11.5f;

}