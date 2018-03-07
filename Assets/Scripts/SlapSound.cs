using UnityEngine;
using System.Collections;

public class SlapSound : MonoBehaviour {

    public AudioSource slapSound;
    public Transform spaceEffect;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
        slapped();

    }
    void slapped()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform effect = (Transform)Instantiate(spaceEffect, transform.position, transform.rotation);
            slapSound.Play();
            Destroy(effect.gameObject,.3f);
          
           
            
        }
    }

}
