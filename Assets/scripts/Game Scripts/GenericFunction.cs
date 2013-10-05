using UnityEngine;

public class GenericFunction : MonoBehaviour
{
    private GameObject globalTime;

    public void Awake()
    {
        globalTime = GameObject.Find("globalTime");
    }
    
    public int hour()
    {
        return globalTime.GetComponent<GlobalTime>().hour;
    }

    public int minut()
    {
        return globalTime.GetComponent<GlobalTime>().minut;
    }

    public float second()
    {
        return globalTime.GetComponent<GlobalTime>().second;
    }
    public bool disableTime()
    {
        return globalTime.GetComponent<GlobalTime>().disable;
    }
    public void setDisableTime(bool disable)
    {
        globalTime.GetComponent<GlobalTime>().setNewDisable(disable);
    }
}