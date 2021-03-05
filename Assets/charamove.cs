using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charamove : MonoBehaviour
{

  // 速度
  float speed = 10f;
  public Vector2 tmp = new Vector2(-3.75f, 3.75f);
  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // 移動処理
    Move();
  }
  public static byte num = 0;

  // 移動関数
  void Move()
  {
    // 現在位置をPositionに代入
    float step = speed * Time.deltaTime;
    Vector2 Position = transform.position;
    if (Input.GetKeyDown("right"))
    {
      num++;
      if (num == 0)
      {
        //Position.x += 1.5f;
        tmp.x += 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 1)
      {
        tmp.x += 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
        //Position.x += 1.5f;
      }
      else if (num == 2)
      {
        tmp.x += 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
        //Position.x += 1.5f;
      }
      else if (num == 3)
      {
        tmp.x += 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
        //Position.x += 1.5f;
      }
      else if (num == 4)
      {
        //Position.x += 1.5f;
        tmp.x += 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 5)
      {
        //Position.x += 1.5f;
        tmp.x += 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 6)
      {
        //Position.y -= 1.5f;
        tmp.y -= 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 7)
      {
        //Position.y -= 1.5f;
        tmp.y -= 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 8)
      {
        //Position.y -= 1.5f;
        tmp.y -= 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 9)
      {
        //Position.y -= 1.5f;
        tmp.y -= 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 10)
      {
        //Position.y -= 1.5f;
        tmp.y -= 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 11)
      {
        //Position.x -= 1.5f;
        tmp.x -= 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 12)
      {
        //Position.x -= 1.5f;
        tmp.x -= 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 13)
      {
        //Position.x -= 1.5f;
        tmp.x -= 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 14)
      {
        //Position.x -= 1.5f;
        tmp.x -= 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 15)
      {
        //Position.x -= 1.5f;
        tmp.x -= 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 16)
      {
        //Position.y += 1.5f;
        tmp.y += 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 17)
      {
        //Position.y += 1.5f;
        tmp.y += 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 18)
      {
        //Position.y += 1.5f;
        tmp.y += 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
      }
      else if (num == 19)
      {
        //Position.y += 1.5f;
        //transform.position = Vector2.MoveTowards(tmp, Position, step);
        tmp.y += 1.5f;
      }
      else if (num == 20)
      {
        num = 0;
        //Position.y += 1.5f;
        tmp.y += 1.5f;
      }
    }
    //transform.position = Position;
    transform.position = Vector2.MoveTowards(transform.position, tmp, step);

  }

}
