using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreupdate : MonoBehaviour
{
    private TextMeshProUGUI endScore;
    public TextMeshProUGUI TextScore;
    // Start is called before the first frame update
    void Awake()
    {
        endScore = GetComponent<TextMeshProUGUI>();
        endScore.text = TextScore.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
