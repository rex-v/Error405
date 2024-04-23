using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IslandsCounter : MonoBehaviour
{
    public TMP_Text enemyCounterText;
    public GameObject[] enemyFloor;
    public GameObject portal;
    public GameObject passthru;

    private bool islandDone;
    private int count;
    private int iterator = 0;

    // Start is called before the first frame update
    void Start()
    {
        enemyCounterText.text = "Enemies Left:" + count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        count = enemyFloor[iterator].transform.childCount;
        enemyCounterText.text = "Enemies Left:" + count.ToString();

        if (count == 0 && passthru.activeSelf && !islandDone)
        {
            passthru.SetActive(false);
            islandDone = true;
        }

        if (count == 0 && passthru.activeSelf && islandDone)
        {
            iterator++;
            islandDone = false;
        }
    }
}
