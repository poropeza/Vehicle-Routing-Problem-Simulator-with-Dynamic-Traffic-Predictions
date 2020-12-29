using UnityEngine;
using System.Collections;

public class coli : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        
            Destroy(col.gameObject);
            
       
    }
 
}
