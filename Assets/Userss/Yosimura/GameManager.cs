using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class GameManager : MonoBehaviour
{
    public GameObject[] Obj;

   public int b;

    // Update is called once per frame
    void Update()
    {

        if (Change.desCount == 0)
        {
            Debug.Log("aaa");
            Instantiate(Obj[0], new Vector3(5.0f, 0.0f, 0.0f), Quaternion.identity);
            b++;
        }

        if (Change.desCount == 1)
        {
            if (b == 1)
            {
                Debug.Log("aaa");
                Instantiate(Obj[1], new Vector3(5.0f, 0.0f, 0.0f), Quaternion.identity);
                b++;
            }
          
        }

        if (Change.desCount == 2)
        {
            if (b == 2)
            {
                Debug.Log("aaa");
                Instantiate(Obj[1], new Vector3(5.0f, 0.0f, 0.0f), Quaternion.identity);
                b++;
            }
        }

        if (Change.desCount == 3)
        {
            if (b == 3)
            {
                Debug.Log("aaa");
                Instantiate(Obj[2], new Vector3(5.0f, 0.0f, 0.0f), Quaternion.identity);
                b++;
            }
        }

        if (Change.desCount == 4)
        {
            if (b == 4)
            {
                Debug.Log("aaa");
                Instantiate(Obj[3], new Vector3(5.0f, 0.0f, 0.0f), Quaternion.identity);
                b++;
            }
        }

        if (Change.desCount == 5)
        {
            if (b == 5)
            {
                Debug.Log("aaa");
                Instantiate(Obj[4], new Vector3(5.0f, 0.0f, 0.0f), Quaternion.identity);
                b++;
            }
        }

        if (Change.desCount == 6)
        {
            if (b == 6)
            {
                Debug.Log("aaa");
                Instantiate(Obj[5], new Vector3(5.0f, 0.0f, 0.0f), Quaternion.identity);
                b++;
            }
        }

        if (Change.desCount == 7)
        {
            if (b == 7)
            {
                Debug.Log("aaa");
                Instantiate(Obj[6], new Vector3(5.0f, 0.0f, 0.0f), Quaternion.identity);
                b++;
            }
        }

        if (Change.desCount == 8)
        {
            if (b == 8)
            {
                Debug.Log("aaa");
                Instantiate(Obj[7], new Vector3(5.0f, 0.0f, 0.0f), Quaternion.identity);
                b++;
            }
        }

        if (Change.desCount == 9)
        {
            if (b == 9)
            {
                Debug.Log("aaa");
                Instantiate(Obj[8], new Vector3(5.0f, 0.0f, 0.0f), Quaternion.identity);
                Change.desCount = 0;
                b = 0;
            }
        }
    }

  
}
