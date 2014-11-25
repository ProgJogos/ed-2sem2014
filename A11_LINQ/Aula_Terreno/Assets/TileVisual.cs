using UnityEngine;
using System.Collections;
using System.Linq;

public class TileVisual : MonoBehaviour {

	public Tile info;

	void Update () 
	{
		switch (info.bioma) 
		{
		case EBioma.AGUA : 
			renderer.material.color = Color.blue;
			break;
		case EBioma.DESERTO : 
			renderer.material.color = Color.yellow;
			break;
		case EBioma.SAVANA : 
			renderer.material.color = Color.cyan;
			break;
		case EBioma.FLORESTA : 
			renderer.material.color = Color.green;
			break;
		}
	}

	void OnMouseDown () {
		if (info.bioma != EBioma.SAVANA) {
			info.bioma = EBioma.SAVANA;
		}
		/*
		var noMapa = GeradorMundo.mapa.Find (tile => 
			tile.x == info.x && tile.z == info.z);
		noMapa = info;
		*/
		var resultado = 
			from tile in Mundo.mapa
			where tile.x == info.x && tile.z == info.z
			select tile;
		var noMapa = resultado.First();
		noMapa = info;
		/* debug
		foreach(var tile in GeradorMundo.mapa)
		{
			print (tile.bioma);
		}
		*/
	}
}
