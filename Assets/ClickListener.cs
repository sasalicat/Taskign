using UnityEngine;
using System.Collections;
using System;

public class ClickListener : MonoBehaviour {
    public const float VAILD_DRAP_LENGTH=50;
    public const float RESIDUAL_RABGE=30;
    public const float CLICK_INTERVAL = 0.5f;
    public const float CLICK_INTERVAL_MIN = 0.1f;
        Vector3 Begin;
        Vector3 End;
    public YouCode code;
    private Timer record;
	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {
        if (record != null)
        {
            record.addTime(Time.deltaTime);
        }
            if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("mouse down"+Input.mousePosition);

            Begin = new Vector3(Input.mousePosition.x, 0, Input.mousePosition.y);
            if (record == null)
            {
                record = new Timer();

            }
            else
            {
                if (record.time<=CLICK_INTERVAL&&record.time>=CLICK_INTERVAL_MIN)
                {
                    code.DoubleClick();
                    record = null;
                }
                else
                    record.time = 0;
            }
            //Debug.Log("begin"+Begin);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            //Debug.Log("mouse up"+Input.mousePosition);
            End = new Vector3(Input.mousePosition.x, 0, Input.mousePosition.y);
           // Debug.Log("end" + End);
            Vector3 vector = End - Begin;
            //Debug.Log("Vector is" + vector + "mag" + vector.magnitude);
            if ((vector).magnitude > VAILD_DRAP_LENGTH)//
            {
                if (Vector3.Angle(Vector3.forward, vector) < RESIDUAL_RABGE)//上
                {
                    Debug.Log("上");
                    code.WhenUp();
                }
                else if (Vector3.Angle(Vector3.right, vector) < RESIDUAL_RABGE)
                {
                    Debug.Log("右");
                    code.WhenRight();
                }
                else if (Vector3.Angle(Vector3.left, vector) < RESIDUAL_RABGE)
                {
                    Debug.Log("左");
                    code.WhenLeft();
                }

                else if (Vector3.Angle(Vector3.back, vector) < RESIDUAL_RABGE)
                {
                    Debug.Log("下");
                    code.WhenDown();
                }
                else
                {
                    Debug.Log("無效的方向");
                }
            }
        }
	}
}
class Timer
{
    public float time;
    public Timer()
    {
        time = 0;
    }
    public void addTime(float part)
    {
        time += part;
    } 
}
