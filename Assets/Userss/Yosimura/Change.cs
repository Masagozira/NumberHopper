using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    // public GameObject[] myArray = new GameObject[10];

    public static int desCount;
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DesFloor"))
        {
            desCount++;
            Debug.Log("Hit"); // ÉçÉOÇï\é¶Ç∑ÇÈ
            this.gameObject.SetActive(false);
        }
    }
}
