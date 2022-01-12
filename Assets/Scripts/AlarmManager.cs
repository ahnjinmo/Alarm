using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmManager : MonoBehaviour
{
    [SerializeField]
    private static int targetHour;
    [SerializeField]
    private static int targetMinute;

    private int hour;
    private int minute;

    private void OnEnable()
    {
        TimeManager.OnTick += OnTickHandler;
    }

    private void OnDisable()
    {
        TimeManager.OnTick -= OnTickHandler;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTickHandler(object sender, TimeManager.OnTickEventArgs e)
    {
        hour = e.hour;
        minute = e.minute;

        if (targetHour != hour) return;
        if (targetMinute != minute) return;

        // �˶��� ������ �ð� ����
        Debug.Log("�˶��� �︳�ϴ�.");

    }

    public static void SetAlarm(int hour, int minute)
    {
        targetHour = hour;
        targetMinute = minute;
        Debug.Log("alarm is set");
    }
}
