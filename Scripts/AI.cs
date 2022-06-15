using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{

    [SerializeField] GameObject [] points;
    [SerializeField] Waypoint [] waypoint;

    [SerializeField] GameObject prefabO;

    [SerializeField] float cooldownDuration;

    void Start()
    {
        waypoint[0] = points[0].GetComponent<Waypoint>();
        waypoint[1] = points[1].GetComponent<Waypoint>();
        waypoint[2] = points[2].GetComponent<Waypoint>();
        waypoint[3] = points[3].GetComponent<Waypoint>();
        waypoint[4] = points[4].GetComponent<Waypoint>();
        waypoint[5] = points[5].GetComponent<Waypoint>();
        waypoint[6] = points[6].GetComponent<Waypoint>();
        waypoint[7] = points[7].GetComponent<Waypoint>();
        waypoint[8] = points[8].GetComponent<Waypoint>();
    }

    public void Turn()
    {
        StartCoroutine(StartCooldown());
    }

    public IEnumerator StartCooldown()
    {
        yield return new WaitForSeconds(cooldownDuration);
        if(!Game.gameOver)
        {
            Logic();
        }
    }

    void Logic()
    {
        int random = Random.Range(0,8);
            Debug.Log(random);

            if(waypoint[random].isPlaceable)
            {
                Instantiate(prefabO, points[random].transform.position, Quaternion.identity);
                waypoint[random].isPlaceable = false;
                waypoint[random].oPlaced = true;
                Game.round++;
            }
            else
            {
                Logic();
            }
                
    }
}
