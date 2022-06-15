using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    [SerializeField] AI ai;
    [SerializeField] aiHard aiH;

    [SerializeField] GameObject prefabX;
    [SerializeField] GameObject prefabO;

    [SerializeField] float time;

    public bool isPlaceable = true;
    public bool xPlaced = false;
    public bool oPlaced = false;

    void OnMouseDown()
    {
        if(Game.gameOver)
        {
            return;
        }

        else if(Game.x && isPlaceable) 
        {
        Instantiate(prefabX, transform.position, Quaternion.identity);
        isPlaceable = false;
        xPlaced = true;
        Game.round ++;
            if(Game.isAI)
            {
                Invoke("CallAI", time);
            }
        }

        else if(!Game.x && isPlaceable && !Game.isAI)
        {
        Instantiate(prefabO, transform.position, Quaternion.identity);
        isPlaceable = false;
        oPlaced = true;
        Game.round++;
        }
    }

    void CallAI()
    {
        aiH.Turn();
    }
}
