
using UnityEngine;

public class GridGame : MonoBehaviour
{
    int prevNum = 0;
    public bool cont = true;

    public GameObject[] number;
    public GameObject NextLevel, Replay;

    public GameObject game;
    
    public void  Check(int a, Vector2 pos)
    {
        print(a);
        if(cont)
        {
            if (prevNum + 1 == a)
            {
                prevNum += 1;
                GameObject g= Instantiate(number[a - 1], pos, Quaternion.identity);
                g.transform.SetParent(game.transform);
                if(a == 9)
                {
                    NextLevel.SetActive(true);
                }
            }
            else
            {
                cont = false;
                Instantiate(number[9], pos, Quaternion.identity);
                Replay.SetActive(true);
            }
        }
       
    }

   
}
