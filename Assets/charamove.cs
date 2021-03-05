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
        tmp.x += 1.5f;
      }
      else if (num == 1)
      {
        tmp.x += 1.5f;
      }
      else if (num == 2)
      {
        tmp.x += 1.5f;
      }
      else if (num == 3)
      {
        tmp.x += 1.5f;
      }
      else if (num == 4)
      {
        tmp.x += 1.5f;
      }
      else if (num == 5)
      {
        tmp.x += 1.5f;
      }
      else if (num == 6)
      {
        tmp.y -= 1.5f;
      }
      else if (num == 7)
      {
        tmp.y -= 1.5f;
      }
      else if (num == 8)
      {
        tmp.y -= 1.5f;
      }
      else if (num == 9)
      {
        tmp.y -= 1.5f;
      }
      else if (num == 10)
      {
        tmp.y -= 1.5f;
      }
      else if (num == 11)
      {
        tmp.x -= 1.5f;
      }
      else if (num == 12)
      {
        tmp.x -= 1.5f;
      }
      else if (num == 13)
      {
        tmp.x -= 1.5f;
      }
      else if (num == 14)
      {
        tmp.x -= 1.5f;
      }
      else if (num == 15)
      {
        tmp.x -= 1.5f;
      }
      else if (num == 16)
      {
        tmp.y += 1.5f;
      }
      else if (num == 17)
      {
        tmp.y += 1.5f;
      }
      else if (num == 18)
      {
        tmp.y += 1.5f;
      }
      else if (num == 19)
      {
        tmp.y += 1.5f;
      }
      else if (num == 20)
      {
        num = 0;
        tmp.y += 1.5f;
      }
    }
    transform.position = Vector2.MoveTowards(transform.position, tmp, step);
  }
}
