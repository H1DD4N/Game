using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Text Win;
    public Text Score;
    public GameObject PPlayerModel;
    public GameObject Boden;
    public GameObject WinPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Win")
        {
            Win.gameObject.SetActive(true);
            Time.timeScale = 0;
            Score.gameObject.SetActive(true);
            WinPosition.gameObject.SetActive(false);
            Boden.gameObject.SetActive(false);
            PPlayerModel.gameObject.SetActive(false);

        }
    }
}
