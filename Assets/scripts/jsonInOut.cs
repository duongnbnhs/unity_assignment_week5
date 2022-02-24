using UnityEngine;
using System.IO;
using System.Collections;
using System;


public class jsonInOut : MonoBehaviour
{
    public TextAsset txtJson;
    public Vectors vectorList = new Vectors();
    [SerializeField]
    public GameObject tedd;
    public void Start()
    {
        vectorList = JsonUtility.FromJson<Vectors>(txtJson.text);
        foreach(Vector v in vectorList.vectors)
        {
            Vector2 location = new Vector2(v.x, v.y);
            /*gameObject.transform.position = location;*/
            /*Vector2 worldLocation = Camera.main.ScreenToWorldPoint(location);*/
            GameObject teddyBear = Instantiate(tedd) as GameObject;
            teddyBear.transform.position = location;
            /*SpriteRenderer spriteRenderer = teddyBear.GetComponent<SpriteRenderer>();*/

        }
    }
        
}
