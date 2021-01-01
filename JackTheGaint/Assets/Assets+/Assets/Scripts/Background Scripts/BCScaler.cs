using UnityEngine;
using System.Collections;

public class BCScaler : MonoBehaviour {
    
	void Start () {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Vector3 tempScale = transform.localScale;

        float width = sr.sprite.bounds.size.x;

        //background height
        float worldHeight = Camera.main.orthographicSize * 2.0f;
        //geting width by  dividing worldHeight from screen height time screen width
        float worldWidth = worldHeight / Screen.height * Screen.width;

        
        tempScale.x = worldWidth/ width;
      
        transform.localScale = tempScale;
	}
	
	
}
