using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EnnemySpawner : NetworkBehaviour {

    public GameObject ennemyPrefab;

    public int numberOfEnnemies;

    public override void OnStartServer()
    {
        for (int i = 0; i < numberOfEnnemies; i++)
        {
            var SpawnPosition = new Vector3(Random.Range(8, -8), 0, Random.Range(8, -8));

            var ennemy = (GameObject)Instantiate(ennemyPrefab, SpawnPosition, Quaternion.Euler(0, Random.Range(0, 180), 0));
            NetworkServer.Spawn(ennemy);
        }
    }
}
