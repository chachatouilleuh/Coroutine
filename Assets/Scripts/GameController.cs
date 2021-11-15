using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Waypoint> waypointList;
    public CubeObject Cube;
    //int currentID;

    void Start()
    {
        //Cube.transform.position = waypointList[0].transform.position;
        StartCoroutine(moveObject());
        InvokeRepeating("launchMove", 0f, 1f);
        launchMove();
    }

    void launchMove()
    {
        StartCoroutine(moveObject());
    }
    // Update is called once per frame
    IEnumerator moveObject()
    {
        yield return new WaitForSeconds(1f);
        /*currentID++;
        

        if (currentID == waypointList.Count)
        {
            currentID = 0;
        }*/

        int _random = Random.Range(0, waypointList.Count);
        Waypoint _target = waypointList[_random];
        Cube.attributeTarget(_target);
        //Cube.transform.position = _target.transform.position;
    
    }
}
