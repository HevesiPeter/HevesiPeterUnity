
using UnityEngine;

public class LoopPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


       // int i = 1;
        int found = 0;

        for (int i = 1; found < 100; i++)
        {

            bool d3 = i % 3 == 0;
            bool d7 = i % 7 == 0;

            if(d3 || d7)
            {
                Debug.Log(i);
                found++;
            }

            
            
            //i += 1;
        }
        int lenght = 10;

        for (int i = 1000; i >= 100; i--)
        {
            Debug.Log(i);
        }

    }

}
