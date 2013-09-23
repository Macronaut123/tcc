using UnityEngine;

public class GenericFunction : MonoBehaviour{

    public float GenericFunctionFloat()
    {
        return GameObject.Find("globalTime").GetComponent<GlobalTime>().globalTimer;
    }

    public int GenericFunctionInt()
    {
        return (int)GameObject.Find("globalTime").GetComponent<GlobalTime>().globalTimer;
    }
}
