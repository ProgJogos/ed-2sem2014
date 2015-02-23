using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GeradorImagens : MonoBehaviour {

	public GameObject img;
	public Canvas canvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.J)) {
			GameObject imgNova = Instantiate(img, Vector3.zero, 
			                                 Quaternion.identity) 
				as GameObject;
			imgNova.transform.SetParent(canvas.transform, false);
			imgNova.transform.localPosition = new Vector3(
				Random.Range(-100, 100),
				Random.Range(-100,100));
		}
	}
}
