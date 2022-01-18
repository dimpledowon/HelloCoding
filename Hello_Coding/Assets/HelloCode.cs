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

        Debug.Log("0 번 학생의 점수: " + studenets[0]);
        Debug.Log("1 번 학생의 점수: " + studenets[1]);
        Debug.Log("2 번 학생의 점수: " + studenets[2]);
        Debug.Log("3 번 학생의 점수: " + studenets[3]);
        Debug.Log("4 번 학생의 점수: " + studenets[4]);
    }
}
