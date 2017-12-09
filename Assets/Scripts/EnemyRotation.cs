using UnityEngine;

public class EnemyRotation : MonoBehaviour {
    public float rotateSpeed = 0f;
    public Transform player;
    // Update is called once per frame

        private void Start()
    {

    }
    private void Update ()
    {

        Vector2 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
       Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
      transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSpeed * Time.deltaTime);

    }
}
