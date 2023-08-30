using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueTrigger : MonoBehaviour
{

    string btnTxt;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
        {
            btnTxt = hit.transform.tag;
            Debug.Log(btnTxt);
            if (btnTxt == "Cue")
            {
                hit.transform.Find("Cue").gameObject.SetActive(true);
            }

        }
        else
        {

        }
    }

    //public void TestDebug()
    //{
    //    audioSource = this.gameObject.GetComponent<AudioSource>();
    //    audioSource.clip = aClips[0];
    //    audioSource.Play();
    //    Debug.Log(aClips[0].name);
    //    Debug.Log("Cue Trigger script readable");
    //}

}
