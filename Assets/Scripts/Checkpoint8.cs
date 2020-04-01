using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint8 : MonoBehaviour
{
    private bool check1 = false ,check2 = false;
    private GameObject[] allObjects;
    public GameObject banner;
    void Start()
    {
        allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
        foreach(GameObject go in allObjects)
            if(go.tag == "arrowSet1" || go.tag == "arrowSet2" || go.tag == "arrowSet3")
                go.SetActive(false);
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "arrow" || other.gameObject.tag == "arrowSet1" || other.gameObject.tag == "arrowSet2" || other.gameObject.tag == "arrowSet3"){
            other.gameObject.SetActive(false);
        }
        else if(other.gameObject.tag == "plane"){
            Restart();
        }
        else if (other.gameObject.tag == "point1" ) {
            check1 = true;
                if(check2 == false) {
                    foreach(GameObject go in allObjects)
                    {
                        if((go.tag) == "arrowSet1")
                            go.SetActive (true);
                    }
                }
                else{
                    foreach(GameObject go in allObjects)
                    {
                        if((go.tag) == "arrowSet3")
                            go.SetActive (true);
                    }
                }
        }
        else if (other.gameObject.tag == "point2"){
            check2 = true;
            check1 = false;
            foreach(GameObject go in allObjects)
            {
                if((go.tag) == "arrowSet2")
                    go.SetActive (true);
            }
        }
        else if (other.gameObject.tag == "point3"){
            if(check1 == true && check2 == true) {
                Debug.Log ("Complete!");
                // endGame.GameOver = true;
                banner.SetActive(true);
            }
        }
    }
    public void Restart(){
        transform.position = new Vector3(-2f,4.36f,5.46f);
        check1 = false;
        check2 = false;
        foreach(GameObject go in allObjects)
            if(go.tag == "arrowSet1" || go.tag == "arrowSet2" || go.tag == "arrowSet3")
                go.SetActive(false);
            else if (go.tag == "arrow")
                go.SetActive(true);
    }
}
