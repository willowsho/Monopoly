using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        byte phase = 0;//何を行なう時間なのか（０ならさいころを振る前、1ならさいころが振られた、2なら移動前、3なら移動、4ならマスの処理）

    }

    // Update is called once per frame
    //
    byte dice 
    byte dice_2
    void Update()
    {
        if (phase == 0)
        {
            int seed = Environment.TickCount;
            for (int i = 0; i < 50; i++)
            {
                GameObject object = GameObject.Find("predice");
                object.vecter3 = (-2, 0, 0);
                GameObject object_2 = GameObject.Find("predice_2");
                object.vecter3 = (2, 0, 0);
                dice = new Random(seed++);
                dice_2 = new Random(seed++);
                phase = 1;
            }
        }
        if (phase==1)&&(input.getbutton("Submit"))
        {
            object.vecter3 = (-12, 7, 0);
            object.vecter3_2 = (-12, 10, 0);
            GameObject object = GameObject.Find(dice.ToString);
            GameObject object_2 = GameObject.Find(dice_2.ToString+"_2");
            object.vecter3 = (-2, 0, 0);
            object.vecter3_2 = (2, 0, 0);
            phase = 2;
            
        }
        if (phase==2)&&(input.getbutton("Submit"))
        {


        }

    }
}
