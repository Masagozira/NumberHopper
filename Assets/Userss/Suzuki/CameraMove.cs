using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraMove : MonoBehaviour
{
   public GameObject playerObj;
   public Player player;
    Transform playerTransform;

    private float posaaa;

    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        player = playerObj.GetComponent<Player>();
        playerTransform = playerObj.transform;
    }
    void LateUpdate()
    {
        posaaa = playerTransform.position.x;

        // カメラストップ中
        if (posaaa < 0)
        {
            transform.position = new Vector3
                (0, transform.position.y, 
                transform.position.z);
            
        }
        else if (posaaa >120.89)
        {
            transform.position = new Vector3
                (120.89f, transform.position.y,
                transform.position.z);
        }
        // カメラ移動中
        else
        {
            transform.position = new Vector3
                (
                playerTransform.transform.position.x, 
                transform.position.y, 
                transform.position.z
                );
        }
    }
}
