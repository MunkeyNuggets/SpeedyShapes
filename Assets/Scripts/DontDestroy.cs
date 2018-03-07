using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

   // public GameObject musicBlock;
    
        //creating a singleton
    private static DontDestroy instance = null;
    public static DontDestroy Instance
    {
        get
    { return instance;
    }
    }

    void Awake()
        //makes sure the music doesn't loop every time you return to the main menu.
        //removes object if there is another instance of the object already in existance.
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start()
    {

    }
	
	// Update is called once per frame
	void Update () {
        //thiswas terrible...
        // Instantiate(musicBlock, transform.position, transform.rotation);
    }

}
