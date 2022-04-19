using UnityEngine;
[System.Serializable]

public class Wave{
    public string waveName;
    public int noOfEmemies;
    public GameObject[] typeOfEnemies;
    public float spawnInterval;
}
public class Wave_Spawner : MonoBehaviour
{
   public Wave[] waves;
   private Wave currentWave;
   private int currentWaveNumber;

   private void Update(){
       currentWave = waves[currentWaveNumber];
       SpawnWave();
   }
   void SpawnWave(){
       GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)];
        
   }
}