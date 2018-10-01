using UnityEngine;

public class ifStatements : MonoBehavior;

{
    public bool LightOn;
    public string Password;
    public int A, B, C;

    public Floatdata WizardPower, PawnPower;
    public NameID Lock, Key;

    void Update()
    {
        if (Lock == Key)
        {
            print("Open Door");
        }
        
        if (WizardPower).Value > PawnPower.Value
        {
            print("The Wizard Wins");
        }
      
       if (Password == "OU812")
        {
                print("You are correct!");
        }

        if (C == A + B)
        {
            print(C);
        }

        if (LightOn)
        {
            print("Lights Off");
        }
            

    }

}