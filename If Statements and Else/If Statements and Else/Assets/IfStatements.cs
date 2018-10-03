using UnityEngine;

public class IfStatements : MonoBehavior

{
    public bool LightOn;

    void Update()
    {
        if (LightOn)
        {
            print("The light is on.");
        }
    }
}