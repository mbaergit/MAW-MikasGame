using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public GameObject coconutPrefab;
    public float distance;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();   
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Vector3.Distance(gameObject.transform.position, player.transform.position) < distance)
        {
            Instantiate(coconutPrefab, player.transform.position + new Vector3(0, 3f, 0), Quaternion.identity);
        }
    }
}