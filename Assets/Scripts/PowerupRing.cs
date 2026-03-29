using UnityEngine;

public class PowerupRing : MonoBehaviour
{
    public PlayerController playerController;
    public Transform playerPos;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPowerUpCheck();
    }

    public void PlayerPowerUpCheck()
    {
        if (playerController.hasPowerUp)
        {
            Debug.Log("Power up");
            gameObject.SetActive(true);
            Instantiate(gameObject, playerPos.position, Quaternion.identity);
            transform.position = playerPos.position;
        }
    }
}
