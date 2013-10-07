using UnityEngine;

public class GenericFunction : MonoBehaviour
{
    private GameObject globalTime;

    public void Awake()
    {
        globalTime = GameObject.Find("globalTime");
    }

    public bool getDependency(GameObject hit, string key, bool value)
    {

        Debug.Log("GET: " + hit + " " + key + " " + value);

        if (hit.GetComponent<NpcObjectives>().dependencyActions[key] == value)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void setDependency(GameObject hit, string key, bool newValue)
    {
        Debug.Log("SET: " + hit + " " + key + " " + newValue);
        hit.GetComponent<NpcObjectives>().dependencyActions[key] = newValue;
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
    public void setNewTimer(int hour, int minut, float second)
    {
        globalTime.GetComponent<GlobalTime>().setNewTimer(hour, minut, second);
    }
}