using UnityEngine;
using System.Collections;

public class Qualidade : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		// qual plataforma tah rodando AGORA?
		print ("eh mobile?: " + Application.isMobilePlatform);
		if (Application.isMobilePlatform) {
			QualitySettings.SetQualityLevel (0);
		} else {
			QualitySettings.SetQualityLevel (1);
		}

		print ("qualidade: " + QualitySettings.GetQualityLevel ());

		// pra qual eu to fazendo build
		#if !UNITY_STANDALONE
			print ("mobile");
		#else
			print ("standalone");
		#endif

		Application.OpenURL ("http://google.com");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
