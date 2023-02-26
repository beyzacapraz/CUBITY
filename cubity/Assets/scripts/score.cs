
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText.SetText(player.position.z.ToString("0"));
    }
}
