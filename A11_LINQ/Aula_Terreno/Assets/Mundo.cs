using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Mundo : MonoBehaviour {

	public int tamanho;
	public TileVisual prefabTileVisual;
	public static List<Tile> mapa;

	void Start () {
		mapa = new List<Tile> ();

		// cada linha
		for (int x = 0; x < tamanho; x++) 
		{
			// cada coluna
			for (int z = 0; z < tamanho; z++) 
			{
				// adiciona novo tile ao mapa
				mapa.Add (new Tile(x, z));
				// cria um tile visual
				TileVisual novo = Instantiate (prefabTileVisual,
					new Vector3(x*10, 0, z*10),
				    Quaternion.identity) as TileVisual;
				// a info do tile visual recebe o ultimo tile
				novo.info = mapa[mapa.Count-1];
			}
		}
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.T)) {
			SimularTemperatura();
		}
		
		if(Input.GetKeyDown(KeyCode.A)) {
			AgruparTiles();
		}
	}
	
	void SimularTemperatura () 
	{
		List<int> temperaturasNovas = new List<int> ();
		// calculo de novas temperaturas
		foreach (var tile in Mundo.mapa)
		{
			// procura a temperatura de todos 
			// os vizinhos possiveis
			var vizinhos =
				from t in Mundo.mapa
				where 
					(t.x == tile.x + 1 && t.z == tile.z) ||
					(t.x == tile.x && t.z == tile.z + 1) ||
					(t.x == tile.x - 1 && t.z == tile.z) ||
					(t.x == tile.x && t.z == tile.z - 1)
				select t.temperatura;
			// calcula a media das tempertauras
			float temp = (float) vizinhos.Average() ;
			temperaturasNovas.Add(Mathf.FloorToInt(temp));
		}
		// aplicando temperaturas novas
		for(int i = 0; i < Mundo.mapa.Count; i++)
		{
			Mundo.mapa[i].temperatura = temperaturasNovas[i];
		}
	}
	
	void AgruparTiles () 
	{
		// consulta com ordenacao e agrupamento
		var consulta = 
			from tile in Mundo.mapa
			orderby tile.bioma.ToString()
			group tile by tile.bioma;
		
		// eh necessario percorrer os grupos para depois
		// percorrer os elementos
		foreach (var grupo in consulta) {
			print (grupo.Key);
			foreach (var elemento in grupo) {
				print (elemento.temperatura);
			}	
		}
	}
}
