using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 player_Postion;

    public float max_PullDistance;
    public float _force;

    bool is_Ground = true;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().isKinematic = true;
        player_Postion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDrag()
    {
        Vector2 Position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Vector2.Distance(player_Postion, Position) > max_PullDistance)
        {
            Position = (Position - player_Postion).normalized * max_PullDistance + player_Postion;
        }

        if (Position.x > player_Postion.x && Position.x < player_Postion.x)
        {
            Position.x = player_Postion.x;
        }
        player_Postion = Position;

    }

    private void OnMouseUp()
    {
        var Force = (player_Postion - (Vector2)transform.position) * -_force;
        var Rigidbody2D = GetComponent<Rigidbody2D>();
        Rigidbody2D.isKinematic = false;
        Rigidbody2D.AddForce(new Vector2(Force.x*1, 0), ForceMode2D.Impulse); // x 축으로 힘을 적용
        Rigidbody2D.AddForce(new Vector2(0, Force.y*2), ForceMode2D.Impulse); // y 축으로 힘을 적용
    }
}
