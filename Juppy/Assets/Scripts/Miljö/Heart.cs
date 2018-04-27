using UnityEngine;

public class Heart : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
	if(other.tag == "Juppy"){
	    Juppy juppy = other.GetComponent<Juppy>();
	    juppy.Hearts = juppy.Hearts + 1;
	    Destroy(this.gameObject);
	}
    }
}
