//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
    public FireArm bazooka;
    public instantPower wepPowerUp;
	public void Main()
	{

        wepPowerUp = new instantPower();

        bazooka = new FireArm();
		bazooka.ammoAmount++;
        bazooka.weaponDamage += wepPowerUp.levelofPower;
	
		Console.WriteLine(bazooka.weaponThing + " has an ammo count of " + bazooka.ammoAmount + ".");
		Console.WriteLine("The Fire power is now " + bazooka.weaponDamage + ", it has increased.");
	}
}

public class FireArm {
    public int ammoAmount = 10;
    public string weaponThing = "Bazooka";
    public float weaponDamage = 11.5f;

}

public class instantPower {
    public float levelofPower = 1.5f;
}