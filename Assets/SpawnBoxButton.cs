using UnityEngine;

namespace DefaultNamespace
{
    public class SpawnBoxButton : BasicButton
    {
        public GameObject[] SpawnableBoxes;
        public Transform SpawnPoint;
        public override void OnPush()
        {
            if (!IsPushed)
            {
                base.OnPush();
                
                Instantiate(SpawnableBoxes[Random.Range(0, SpawnableBoxes.Length)], SpawnPoint.position, Quaternion.identity);
            }
        }
    }
}