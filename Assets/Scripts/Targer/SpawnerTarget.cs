using System.Collections;
using UnityEngine;

public class SpawnerTarget : MonoBehaviour
{
    [SerializeField] private GameObject _targetPrefab;
    [SerializeField] private Vector2 _areaSpawn = new Vector2(1f, 1f);
    [SerializeField] private float _delaySpawn = 2f;

    private void Start()
    {
        StartCoroutine(DelaySpawn());
    }

    private IEnumerator DelaySpawn()
    {
        while (true)
        {
            CreateTarget();

            yield return new WaitForSeconds(_delaySpawn);
        }
    }

    private void CreateTarget()
    {
        float randomPositionX = Random.Range(-_areaSpawn.x, _areaSpawn.x);
        float randomPositionY = Random.Range(-_areaSpawn.y, _areaSpawn.y);

        Vector3 newPosition = new Vector3(randomPositionX, 0, randomPositionY) + transform.position;

        Instantiate(_targetPrefab, newPosition, Quaternion.identity);
    }
}
