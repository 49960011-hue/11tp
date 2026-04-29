using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreuimanagment : MonoBehaviour
{ public textMeshProUGUI txtScore;
        public int score =0;
    // Start is called before the first frame update
    void Start()
    {
       txt_score.text=score.ToString();
    }

    // Update is called once per frame
    void addpointAndUpdateScore()
    {
        score ++;
        Txt_score.text=score.ToString();
    }
}
