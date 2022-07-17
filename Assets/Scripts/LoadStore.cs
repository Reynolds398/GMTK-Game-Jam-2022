using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Requests.currentRequest == CustomizationManager.diceId)
        {
            if (Requests.loadRequirement == -1 || Requests.loadRequirement == ArrowButtons.count)
            {
                Customer.satisfied = true;
            } else
            {
                Customer.angry = true;
            }
        } else
        {
            Customer.angry = true;
        }

        Roll.bias = ArrowButtons.count;
        BarterButton.previousDice = CustomizationManager.diceId;
        ArrowButtons.count = 0;
        CustomizationManager.diceId = 0;
        StartCoroutine(LoadNextScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadNextScene()
    {
        // Play transition animation
        yield return new WaitForSeconds(2);;
        SceneManager.LoadScene("Store");
    }
}
