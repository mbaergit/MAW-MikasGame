using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoconutScript : MonoBehaviour
{
    GameObject player;
    public float detectionRadius;
    public float coconutSpeed;
    public float secondsBetweenLocationChanges;
    float timer = 0f;
    public Vector3 targetLocation;

    // Start is called before the first frame update
    void Start()
    {
        System.Random randomNumber = new System.Random();
        player = GameObject.Find("Player");
        UpdateTargetLocation();
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if(timer >= secondsBetweenLocationChanges * 60)
        {
            Debug.Log("update location target!");
            targetLocation = UpdateTargetLocation();
            timer = 0;
        }

        if (CheckDistanceToPlayer())
        {
            MoveTowardsPlayer();
        }
        else
        {
            Wander();
        }
    }

    bool CheckDistanceToPlayer()
    {
        return (Vector3.Distance(transform.position, player.transform.position) <= detectionRadius);
    }

    void MoveTowardsPlayer()
    {
        transform.LookAt(player.transform);
        transform.Translate(Vector3.forward * coconutSpeed);
    }

    void Wander()
    {
        transform.LookAt(targetLocation);
        transform.Translate(Vector3.forward * coconutSpeed);
    }

    Vector3 UpdateTargetLocation()
    {
        return new Vector3(Random.Range(15f, 95f), 15f, Random.Range(15f, 95f));
    }
}
