using UnityEngine;
using System.Collections;

public class CarregarImagem : MonoBehaviour {

	void Start () {
		Texture2D img;
		img = Resources.LoadAssetAtPath<Texture2D> (
			"Assets/Estrela.png");
		Debug.Log (img);
		renderer.material.SetTexture ("_MainTex", img);
	}
}
