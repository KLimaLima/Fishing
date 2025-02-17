using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatchingFish : MonoBehaviour
{
    public int catchfish = 0;
    [SerializeField] private Texture[] image;
    private RawImage parentImage;
    private Color temp;
    //[SerializeField] CatchingFish catchingFish;
    [SerializeField] private GameObject fishGameObject;
    //private CatchingFish fishScript;
    [SerializeField] private int ran;
/*    private int imageNum;
    private int scoreValue;*/
    // Start is called before the first frame update
    void Start()
    {
        parentImage = GetComponent<RawImage>();
        temp = parentImage.color;
    }

    // Update is called once per frame
    void Update()
    {
/*        if (fishScript.catchfish == 1)
        {
            parentImage.texture = image[imageNum];
            parentImage.color = Color.white;
            ScoreViewmodel.totalScore += scoreValue;
            scoreValue = 0;
            Debug.Log(ScoreViewmodel.totalScore);
        }
        else
        {
            ran = Random.Range(0, 100);
            if (ran <= 10)
            {
                imageNum = 3;
                scoreValue = 5;
            }
            else if (ran <= 30)
            {
                imageNum = 2;
                scoreValue = 3;
            }
            else if (ran <= 50)
            {
                imageNum = 1;
                scoreValue = 2;
            }
            else
            {
                imageNum = 0;
                scoreValue = 1;
            }
            parentImage.color = temp;*/
        //}
    }

    public int CatchFish()
    {
        return catchfish;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            StartCoroutine(ChangePos());
            //Destroy(this.gameObject);
        }
    }

    private IEnumerator ChangePos()
    {
        //gameObject.transform.Find("shadow").gameObject.SetActive(false);
        CatchFishViewmodel.catchFishViewModel = 1;
        catchfish = 1;
        yield return new WaitForSeconds(1);
        CatchFishViewmodel.catchFishViewModel = 0;
        catchfish = 0;
        //Vector3 pos = transform.position;
        //pos.x = Random.Range(-40, 40);
        //pos.y = 0;
        //pos.z = Random.Range(-40, 40);
        //transform.position = pos;
        //gameObject.transform.Find("shadow").gameObject.SetActive(true);
    }
}
