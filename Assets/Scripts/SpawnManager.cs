using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;

    private Coroutine goodByeCoroutine;
    //public Rigidbody box;
    void Start()
    {
        //InvokeRepeating(nameof(RandonSpawn), 0, 4);
        //StartCoroutine(Hello());
        //goodByeCoroutine = StartCoroutine(Goodbye());
        StartCoroutine(SpawnRoutine());

    }
    void RandonSpawn()
    {
        var index = Random.Range(0, spawnPoints.Length);
        var spawn = spawnPoints[index];
        Instantiate(enemyPrefab, spawn.position, Quaternion.identity);
    }

    //IEnumerable MoveBox()
    //{
    //    box.linearVelocity = 10 * Vector3.up;
    //    yield return new WaitForSeconds(2);
    //}

    private void Update()
    {
        //if(Time.time > 5)
        //{

        //    //StopAllCoroutines();
        //    if (goodByeCoroutine != null)
        //    {
        //        StopCoroutine(goodByeCoroutine);
        //    }
            
        //}
    }

    IEnumerator SpawnRoutine()
    {
        yield return new WaitForSeconds(5);
        while (true)
        {
            RandonSpawn();
            yield return new WaitForSeconds(3);
        }
    }

    //IEnumerator Goodbye()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(1);
    //        Debug.Log("Sayonara " + Time.frameCount + " " + Time.time);

    //        //if (Time.time > 5)
    //        //{
    //        //    yield break;
    //        //}
            

    //        yield return Hello();
    //    }

    //}

    //IEnumerator Hello()
    //{
    //    Debug.Log("Privet " + Time.frameCount);
    //    yield return null;
    //    Debug.Log("Privet " + Time.frameCount);
    //}
}
