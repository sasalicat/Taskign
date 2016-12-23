using UnityEngine;
using System.Collections;
using System;

public class Air :ButtonClint {
    public int MAX_C = 30;
    public int MIN_C = 18;
    private int C=23;
    private bool running = false;

    public string GetDeviceName()
    {
        return "冷氣機";
    }

    public string GetShowNum()
    {
        return "" + C;
    }

    public void turnDown()
    {
        if (running)
        {
            if (C > MIN_C)
            {
                C--;
            }
           
        }
    }

    public void turnOff()
    {
        running = false;
    }

    public void turnOn()
    {
        running = true;
    }

    public void turnUp()
    {
        if (running)
        {
            if (C < MAX_C)
            {
                C++;
            }
        }
    }

    
}
