using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint0 : MonoBehaviour
{
    private bool check1 = false;
    private GameObject[] allObjects;
    public GameObject banner;
    void Start()
    {
        allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
        foreach(GameObject go in allObjects)
            if(go.tag == "arrowSet1")
                go.SetActive(false);
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "arrow" || other.gameObject.tag == "arrowSet1"){
            other.gameObject.SetActive(false);
        }
        else if(other.gameObject.tag == "plane"){
            Restart();
        }
        else if (other.gameObject.tag == "point1" ) {
            check1 = true;
            foreach(GameObject go in allObjects)
            {
                if((go.tag) == "arrowSet1")
                    go.SetActive (true);
            }
        }
        else if (other.gameObject.tag == "point2"){
            if(check1 == true) {
                Debug.Log ("Complete!");
                // endGame.GameOver = true;
                banner.SetActive(true);
            }
        }
    }
    public void Restart(){
        transform.position = new Vector3(-1.11f,6.46f,5f);
        check1 = false;
        foreach(GameObject go in allObjects)
            if(go.tag == "arrowSet1")
                go.SetActive(false);
            else if (go.tag == "arrow")
                go.SetActive(true);
    }
}
