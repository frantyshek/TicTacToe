using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    
    public static int round = 0;

    public static bool x = false;
    public static bool gameOver = false;

    public static bool xWin = false;
    public static bool oWin = false;

    public static bool isAI = true;
    
    Waypoint waypoint1;
    Waypoint waypoint2;
    Waypoint waypoint3;
    Waypoint waypoint4;
    Waypoint waypoint5;
    Waypoint waypoint6;
    Waypoint waypoint7;
    Waypoint waypoint8;
    Waypoint waypoint9;

    [SerializeField] GameObject point1;
    [SerializeField] GameObject point2;
    [SerializeField] GameObject point3;
    [SerializeField] GameObject point4;
    [SerializeField] GameObject point5;
    [SerializeField] GameObject point6;
    [SerializeField] GameObject point7;
    [SerializeField] GameObject point8;
    [SerializeField] GameObject point9;

    [SerializeField] GameObject lineH;
    [SerializeField] GameObject lineV;
    [SerializeField] GameObject lineA;
    [SerializeField] GameObject lineB;

    [SerializeField] GameObject drawScreen;
    [SerializeField] GameObject xWinScreen;
    [SerializeField] GameObject oWinScreen;

    [SerializeField] AI ai;

    void Start()
    {
        waypoint1 = point1.GetComponent<Waypoint>();
        waypoint2 = point2.GetComponent<Waypoint>();
        waypoint3 = point3.GetComponent<Waypoint>();
        waypoint4 = point4.GetComponent<Waypoint>();
        waypoint5 = point5.GetComponent<Waypoint>();
        waypoint6 = point6.GetComponent<Waypoint>();
        waypoint7 = point7.GetComponent<Waypoint>();
        waypoint8 = point8.GetComponent<Waypoint>();
        waypoint9 = point9.GetComponent<Waypoint>();
    }

    void Update()
    {
        CheckIfOWin();
        CheckIfXWin();
        Round();
    }

    void CheckIfOWin()
    {
        if(waypoint1.oPlaced && waypoint2.oPlaced && waypoint3.oPlaced && !oWin)
        {
            Instantiate(lineH, point2.transform.position, Quaternion.identity);
            oWin = true;
        }
        if(waypoint4.oPlaced && waypoint5.oPlaced && waypoint6.oPlaced && !oWin)
        {
            Instantiate(lineH, point5.transform.position, Quaternion.identity);
            oWin = true;
        }
        if(waypoint7.oPlaced && waypoint8.oPlaced && waypoint9.oPlaced && !oWin)
        {
            Instantiate(lineH, point8.transform.position, Quaternion.identity);
            oWin = true;
        }
        if(waypoint1.oPlaced && waypoint5.oPlaced && waypoint9.oPlaced && !oWin)
        {
            Instantiate(lineA, point5.transform.position, Quaternion.Euler (0f, -45f, 0f));
            oWin = true;
        }
        if(waypoint3.oPlaced && waypoint5.oPlaced && waypoint7.oPlaced && !oWin)
        {
            Instantiate(lineB, point5.transform.position, Quaternion.Euler (0f, 45f, 0f));
            oWin = true;
        }
        if(waypoint1.oPlaced && waypoint4.oPlaced && waypoint7.oPlaced && !oWin)
        {
            Instantiate(lineV, point4.transform.position, Quaternion.Euler (0f, 90f, 0f));
            oWin = true;
        }
        if(waypoint2.oPlaced && waypoint5.oPlaced && waypoint8.oPlaced && !oWin)
        {
            Instantiate(lineV, point5.transform.position, Quaternion.Euler (0f, 90f, 0f));
            oWin = true;
        }
        if(waypoint3.oPlaced && waypoint6.oPlaced && waypoint9.oPlaced && !oWin)
        {
            Instantiate(lineV, point6.transform.position, Quaternion.Euler (0f, 90f, 0f));
            oWin = true;
        }

    }

    void CheckIfXWin()
    {
        if(waypoint1.xPlaced && waypoint2.xPlaced && waypoint3.xPlaced && !xWin)
        {
            Instantiate(lineH, point2.transform.position, Quaternion.identity);
            xWin = true;
        }
        if(waypoint4.xPlaced && waypoint5.xPlaced && waypoint6.xPlaced && !xWin)
        {
            Instantiate(lineH, point5.transform.position, Quaternion.identity);
            xWin = true;
        }
        if(waypoint7.xPlaced && waypoint8.xPlaced && waypoint9.xPlaced && !xWin)
        {
            Instantiate(lineH, point8.transform.position, Quaternion.identity);
            xWin = true;
        }
        if(waypoint1.xPlaced && waypoint5.xPlaced && waypoint9.xPlaced && !xWin)
        {
            Instantiate(lineA, point5.transform.position, Quaternion.Euler (0f, -45f, 0f));
            xWin = true;
        }
        if(waypoint3.xPlaced && waypoint5.xPlaced && waypoint7.xPlaced && !xWin)
        {
            Instantiate(lineB, point5.transform.position, Quaternion.Euler (0f, 45f, 0f));
            xWin = true;
        }
        if(waypoint1.xPlaced && waypoint4.xPlaced && waypoint7.xPlaced && !xWin)
        {
            Instantiate(lineV, point4.transform.position, Quaternion.Euler (0f, 90f, 0f));
            xWin = true;
        }
        if(waypoint2.xPlaced && waypoint5.xPlaced && waypoint8.xPlaced && !xWin)
        {
            Instantiate(lineV, point5.transform.position, Quaternion.Euler (0f, 90f, 0f));
            xWin = true;
        }
        if(waypoint3.xPlaced && waypoint6.xPlaced && waypoint9.xPlaced && !xWin)
        {
            Instantiate(lineV, point6.transform.position, Quaternion.Euler (0f, 90f, 0f));
            xWin = true;
        }

    }
    void Round()
    {
        if(oWin)
        {
            oWinScreen.SetActive(true);
            round = 0;
        }
        
        if(xWin)
        {
            xWinScreen.SetActive(true);
            round = 0;
            gameOver = true;
        }

        if(round % 2 == 0)
        {
            x = true;
        }
        else
        {
            x = false;
        }
        if(round >= 9)
        {
            if(!xWin || !oWin)
            {
                drawScreen.SetActive(true);
                gameOver = true;
            }
        }
    }
}
