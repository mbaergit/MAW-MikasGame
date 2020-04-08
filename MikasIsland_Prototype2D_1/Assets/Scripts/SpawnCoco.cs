using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnCoco : MonoBehaviour
{
    public Transform prefab;
    public int cocoNum = 1;
    public TextMeshProUGUI cocoNumText;
    
    public void SpawnCoconut()
    {
        Instantiate(prefab, new Vector2(-2, 0), Quaternion.identity);
        cocoNum++;
    }

    private void Update()
    {
        cocoNumText.text = cocoNum.ToString();
    }
}
