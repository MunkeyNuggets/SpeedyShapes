using UnityEngine;
using System.Collections;


public class SpawnPointScripts : MonoBehaviour {
    public GameObject SpawnPoint;
    //public GameObject ShapeToSpawn;

    public AudioSource shapeSpawnSound;

    public GameObject[] shapes;
    GameObject selectedShape;

   //private GameObject ShapeToSpawn = null;

    private float timeInterval = .8f;
 
	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        //timer to spawn the next shape
        Timer();
	}

    void reactToTimerInterval()
    {
   
            GameObject.Destroy(selectedShape);

            //get random shape
            selectedShape = shapes[Random.Range(0, shapes.Length)];
        //play spawn noise
            selectedShape = GameObject.Instantiate(selectedShape);
            //position at the SpawnPoint location
            selectedShape.transform.position = SpawnPoint.transform.position;
            selectedShape.transform.SetParent(SpawnPoint.transform);
        Debug.Log(selectedShape);        
    }

    void Timer()
    {
        timeInterval -= Time.deltaTime;
        if (timeInterval <= 0)
        {
            reactToTimerInterval();
            timeInterval = .8f;
            BoopNoise();

        }
    }
    public void BoopNoise()
    {
        shapeSpawnSound.Play();
    }
    

 
    
}
