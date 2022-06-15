using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiHard : MonoBehaviour
{
    [SerializeField] GameObject [] points;
    [SerializeField] Waypoint [] waypoint;

    [SerializeField] GameObject prefabO;

    [SerializeField] float cooldownDuration;
    [SerializeField] float time;

    int X = -1;
    int O = 1;

    int a;
    int b;
    int c;
    int d;
    int e;
    int f;
    int g;
    int h;

    bool played = false;
    bool wasC = false;
    bool wasD = false;
    bool thisStart = false;

    void Start()
    {
        for(int i = 0; i <= waypoint.Length; i++)
        {
            waypoint[i] = points[i].GetComponent<Waypoint>();
        }
    }

    public void Turn()
    {
        if(Game.gameOver)
        {
            return;
        }

        played = false;
        wasC = false;
        wasD = false;

        if(a >= 2)
        {
            A();
        }
        else if(b >= 2)
        {
            B();
        }
        else if(c >= 2)
        {
            C();
        }
        else if(d >= 2)
        {
            D();
        }
        else if(e >= 2)
        {
            E();
        }
        else if(f >= 2)
        {
            F();
        }
        else if(g >= 2)
        {
            G();
        }
        else if(h >= 2)
        {
            H();
        }
            endTurn();
            StartCoroutine(StartCooldown());
    }

    public IEnumerator StartCooldown()
    {
        yield return new WaitForSeconds(cooldownDuration);
        if(!Game.gameOver)
        {
            aiLogic();
        }
    }

    void aiLogic()
    {
        A();
        B();
        if(waypoint[4].xPlaced)
        {
            D();
        }
        else
        {
            C();
        }
        if(!wasC)
        {
            C();
        }
        if(!wasD)
        {
            D();
        }
        E();
        F();
        G();
        H();
        Invoke("Alternate", time);
    }

    void A()
    {
        for(int i = 0; i <= 8; i = i+4)
        {
            if(waypoint[i].oPlaced)
            {
                a += O;
            }

            if(waypoint[i].xPlaced)
            {
                a += X;
            }

            if(a >= 2)
            {
                for(int j = 0; j <= 8; j = j+4)
                {
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        a += O;
                        Game.round++;
                    }
                } 
            }
            else if(a <= -2)
            {
                for(int j = 0; j <= 8; j = j+4)
                {
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        a += O;
                        Game.round++;
                    }
                }
            }
        }
    }

    void B()
    {
        for(int i = 2; i <= 6; i = i+2)
        {
            if(waypoint[i].oPlaced)
            {
                b += O;
            }

            if(waypoint[i].xPlaced)
            {
                b += X;
            }

            if(b >= 2)
            {
                for(int j = 2; j <= 6; j = j+2)
                {
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        b += O;
                        Game.round++;
                    }
                }
            }
            else if(b <= -2)
            {
                for(int j = 2; j <= 6; j = j+2)
                {
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        b += O;
                        Game.round++;
                    }
                }
            }
        }
    }

    void C()
    {
        for(int i = 0; i <= 2; i++)
        {
            if(waypoint[i].oPlaced)
            {
                c += O;
            }

            if(waypoint[i].xPlaced)
            {
                c += X;
            }

            if(c >= 2)
            {
                for(int j = 0; j <= 2; j++)
                {
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        c += O;
                        Game.round++;
                    }
                }
            }
            else if(c <= -2)
            {
                for(int j = 0; j <= 2; j++)
                { 
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        c += O;
                        Game.round++;
                    }
                }
            }

        }
        wasC = true;
    }

    void D()
    {
        for(int i = 3; i <= 5; i++)
        {
            if(waypoint[i].oPlaced)
            {
                d += O;
            }

            if(waypoint[i].xPlaced)
            {
                d += X;
            }

            if(d >= 2)
            {
                for(int j = 3; j <= 5; j++)
                {
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        d += O;
                        Game.round++;
                    }
                }
            }
            else if(d <= -2)
            {
                for(int j = 3; j <= 5; j++)
                {
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        d += O;
                        Game.round++;
                    }
                }
            }
        }
        wasD = true;
    }

    void E()
    {
        for(int i = 6; i <= 8; i++)
        {
            if(waypoint[i].oPlaced)
            {
                e += O;
            }

            if(waypoint[i].xPlaced)
            {
                e += X;
            }

            if(e >= 2)
            {
                for(int j = 6; j <= 8; j++)
                {
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        e += O;
                        Game.round++;
                    }
                }
            }
            else if(e <= -2)
            {
                for(int j = 6; j <= 8; j++)
                {                
                    if(waypoint[j].isPlaceable && !played)
                    {                    
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        e += O;
                        Game.round++;
                    }
                }
            }
        }
    }

    void F()
    {
        for(int i = 0; i <= 6; i = i+3)
        {
            if(waypoint[i].oPlaced)
            {
                f += O;
            }

            if(waypoint[i].xPlaced)
            {
                f += X;
            }

            if(f >= 2)
            {
                for(int j = 0; j <= 6; j = j+3)
                {
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        f += O;
                        Game.round++;
                    }
                }  
            }
            else if(f <= -2)
            {
                for(int j = 0; j <= 6; j = j+3)
                {
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        f += O;
                        Game.round++;
                    }
                }
            }
        }
    }

    void G()
    {
        for(int i = 1; i <= 7; i = i+3)
        {
            if(waypoint[i].oPlaced)
            {
                g += O;
            }

            if(waypoint[i].xPlaced)
            {
                g += X;
            }

            if(g >= 2)
            {
                for(int j = 1; j <= 7; j = j+3)
                {
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        g += O;
                        Game.round++;
                    }
                }
            }
            else if(g <= -2)
            {
                for(int j = 1; j <= 7; j = j+3)
                {
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        g += O;
                        Game.round++;
                    }
                }
            }
        }
    }
    
    void H()
    {
        for(int i = 2; i <= 8; i = i+3)
        {
            if(waypoint[i].oPlaced)
            {
                h += O;
            }

            if(waypoint[i].xPlaced)
            {
                h += X;
            }

            if(h >= 2)
            {
                for(int j = 2; j <= 8; j = j+3)
                {
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        h += O;
                        Game.round++;
                    }
                }
            }
            else if(h == -2)
            {
                for(int j = 2; j <= 8; j = j+3)
                {
                    if(waypoint[j].isPlaceable && !played)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        h += O;
                        Game.round++;
                    }
                }
            }
        }
    }
    
    void Alternate()
    {
        if(thisStart && waypoint[8].isPlaceable && waypoint[1].xPlaced && waypoint[5].xPlaced && !played)
        {
            Instantiate(prefabO, waypoint[8].transform.position, Quaternion.identity);
            played = true;
            waypoint[8].isPlaceable = false;
            waypoint[8].oPlaced = true;
            a += O;
            e += O;
            h += O;
            Game.round++;
        }
        else if(thisStart && waypoint[0].isPlaceable && !played && !waypoint[7].xPlaced)
        {
            Instantiate(prefabO, waypoint[0].transform.position, Quaternion.identity);
            played = true;
            waypoint[0].isPlaceable = false;
            waypoint[0].oPlaced = true;
            a += O;
            c += O;
            f += O;
            Game.round++;
        }
        else if(thisStart && waypoint[6].isPlaceable && waypoint[3].xPlaced && waypoint[7].xPlaced && !played)
        {
            Instantiate(prefabO, waypoint[6].transform.position, Quaternion.identity);
            played = true;
            waypoint[6].isPlaceable = false;
            waypoint[6].oPlaced = true;
            b += O;
            e += O;
            f += O;
            Game.round++; 
        }
        else if(thisStart && waypoint[2].isPlaceable && !played)
        {
            Instantiate(prefabO, waypoint[2].transform.position, Quaternion.identity);
            played = true;
            waypoint[2].isPlaceable = false;
            waypoint[2].oPlaced = true;
            b += O;
            c += O;
            h += O;
            Game.round++; 
        }

        if(waypoint[1].xPlaced && waypoint[4].isPlaceable && !played || waypoint[3].xPlaced && waypoint[4].isPlaceable && !played || waypoint[5].xPlaced && waypoint[4].isPlaceable && !played || waypoint[7].xPlaced && waypoint[4].isPlaceable && !played)
        {
            if(waypoint[3].isPlaceable && !played)
            {
                Instantiate(prefabO, waypoint[3].transform.position, Quaternion.identity);
                played = true;
                waypoint[3].isPlaceable = false;
                waypoint[3].oPlaced = true;
                d += O;
                f += O;
                thisStart = true;
                Game.round++;   
            }
            else if(waypoint[5].isPlaceable && !played)
            {
                Instantiate(prefabO, waypoint[5].transform.position, Quaternion.identity);
                played = true;
                waypoint[5].isPlaceable = false;
                waypoint[5].oPlaced = true;
                d += O;
                h += O;
                thisStart = true;
                Game.round++; 
            }
        }

        if(waypoint[4].isPlaceable && !played)
        {
            Instantiate(prefabO, waypoint[4].transform.position, Quaternion.identity);
            played = true;
            waypoint[4].isPlaceable = false;
            waypoint[4].oPlaced = true;
            a += O;
            b += O;
            d += O;
            g += O; 
            Game.round++;
        }
        else if(waypoint[0].xPlaced && waypoint[8].xPlaced && !played || waypoint[2].xPlaced && waypoint[6].xPlaced && !played)
        {
            Instantiate(prefabO, waypoint[3].transform.position, Quaternion.identity);
            played = true;
            waypoint[3].isPlaceable = false;
            waypoint[3].oPlaced = true;
            d += O;
            f += O;
            Game.round++;
        }
        else if(!waypoint[0].isPlaceable && !waypoint[4].isPlaceable && !waypoint[8].isPlaceable && !played || waypoint[2].isPlaceable && waypoint[4].isPlaceable && waypoint[6].isPlaceable && !played)
        {
            for(int i = 0; i <= waypoint.Length; i = i+2)
            {
                if(waypoint[i].isPlaceable && !played)
                {
                    Instantiate(prefabO, waypoint[i].transform.position, Quaternion.identity);
                    played = true;
                    waypoint[i].isPlaceable = false;
                    waypoint[i].oPlaced = true;
                    Game.round++;
                }
            }
        }
        else if(waypoint[0].isPlaceable && !played)
        {
            Instantiate(prefabO, waypoint[0].transform.position, Quaternion.identity);
            played = true;
            waypoint[0].isPlaceable = false;
            waypoint[0].oPlaced = true;
            a += O;
            c += O;
            f += O;
            Game.round++;
        }
        else
        {
            for(int i = 0; i <= waypoint.Length; i = i+4)
            {
                if(waypoint[i].isPlaceable && !played)
                {
                    Instantiate(prefabO, waypoint[i].transform.position, Quaternion.identity);
                    played = true;
                    waypoint[i].isPlaceable = false;
                    waypoint[i].oPlaced = true;
                    Game.round++;
                    if(i == 0)
                    {
                        a += O;
                        c += O;
                        f += O;
                    }
                    else if(i == 4)
                    {
                        a += O;
                        b += O;
                        d += O;
                        g += O; 
                    }
                    else if(i == 8)
                    {
                        a += O;
                        e += O;
                        h += O;
                    }
                }
            }

            for(int i = 0; i <= waypoint.Length; i++)
            {
                if(waypoint[i].isPlaceable && !played && !thisStart)
                {
                    Instantiate(prefabO, waypoint[i].transform.position, Quaternion.identity);
                    played = true;
                    waypoint[i].isPlaceable = false;
                    waypoint[i].oPlaced = true;
                    Game.round++;
                }
                else if(thisStart && waypoint[i].isPlaceable && !played)
                {
                    for(int j = 1; j <= waypoint.Length; j++)
                    {
                        Instantiate(prefabO, waypoint[j].transform.position, Quaternion.identity);
                        played = true;
                        waypoint[j].isPlaceable = false;
                        waypoint[j].oPlaced = true;
                        Game.round++;
                    }
                }
            }
        }

    }

    void endTurn()
    {
        a = 0;
        b = 0;
        c = 0;
        d = 0;
        e = 0;
        f = 0;
        g = 0;
        h = 0;
    }
}
