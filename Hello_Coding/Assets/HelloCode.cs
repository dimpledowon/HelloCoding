using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    void Start()
    {
        int[] studenets = new int[5];

        studenets[0] = 100;
        studenets[1] = 90;
        studenets[2] = 80;
        studenets[3] = 70;
        studenets[4] = 60;

        Debug.Log("0 �� �л��� ����: " + studenets[0]);
        Debug.Log("1 �� �л��� ����: " + studenets[1]);
        Debug.Log("2 �� �л��� ����: " + studenets[2]);
        Debug.Log("3 �� �л��� ����: " + studenets[3]);
        Debug.Log("4 �� �л��� ����: " + studenets[4]);
    }
}
