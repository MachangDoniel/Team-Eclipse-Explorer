using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMoon : MonoBehaviour
{
    public GridGame game;
    bool clicked = false;
    int index;

    private void Start()
    {
        
        index =  int.Parse(gameObject.name);
        print(index);
    }
    private void OnMouseDown()
    {
        //
        if(game.cont)
        {
            print("H");
            clicked = true;
            game.Check(index, transform.position);
            
        }
    }
}
