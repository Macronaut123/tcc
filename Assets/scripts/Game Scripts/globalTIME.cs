using UnityEngine;
using System.Collections;

public class GlobalTime : MonoBehaviour
{
    public bool disable = true;
    public float second = 0f;
    public int minut = 0;
    public int hour = 6;

    private void FixedUpdate()
    {		
        if (disable)
        {
            if (second >= 60)
            {
                minut = minut + 1;
                second = 0f;
            }
            else
            {
                second += Time.deltaTime * 20;
            }

            if (minut == 60)
            {
                minut = 0;
                hour = hour + 1;
            }
        }
    }

    public void setNewTimer(int hour, int minut, float second)
    {
        this.hour = hour;
        this.minut = minut;
        this.second = second;
    }

    private string FormatSeconds()
    {
        return string.Format("{0:00}:{1:00}:{2:00}", hour, minut, second);
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 150, 50), FormatSeconds());
    }

    internal void setNewDisable(bool disable)
    {
        this.disable = disable;
    }
}
