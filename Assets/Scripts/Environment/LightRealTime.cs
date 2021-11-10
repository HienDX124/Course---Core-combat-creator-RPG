using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRealTime : MonoBehaviour
{
    [SerializeField] private float DayTimeSec;
    [SerializeField] private float CurrentTimeSec;

    void Start()
    {
        DayTimeSec = 86400;
        var ClockNow = System.DateTime.Now;
        CurrentTimeSec = ClockNow.Hour * 3600 + ClockNow.Minute * 60 + ClockNow.Second;
        Debug.Log(CurrentTimeSec);
        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.x = 0;
    }

    void Update()
    {
        var rotationVector = transform.rotation.eulerAngles;
        CurrentTimeSec += Time.deltaTime;
        rotationVector.x = (CurrentTimeSec / DayTimeSec) * 180;
        rotationVector.y = 0;
        rotationVector.z = 0;
        transform.rotation = Quaternion.Euler(rotationVector);
    }
}
