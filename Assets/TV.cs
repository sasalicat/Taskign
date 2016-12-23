using UnityEngine;
using System.Collections;
using System;

public class TV : ButtonClint
{
    public const int MAX_CHANNEL = 30;
    public const int MIN_CHANNEL = 1;
    private int Channel = 15;
    private bool running = false;
    public void turnDown()
    {
        if (running)
        {
            if (Channel > MIN_CHANNEL)

                Channel--;
            else
                Channel = MAX_CHANNEL;

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
            if (Channel < MAX_CHANNEL)
                Channel++;
            else
                Channel = MIN_CHANNEL;
        }
    }
    public string GetDeviceName()
    {
        return "電視機";
    }

    public string GetShowNum()
    {
        return "" + Channel;
    }
}
