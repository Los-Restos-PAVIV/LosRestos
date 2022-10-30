using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    public float delay = 15;
 public string NewLevel;
  void Start()
 {
     StartCoroutine(LoadLevelAfterDelay(delay));     
 }
 
 IEnumerator LoadLevelAfterDelay(float delay)
 {
  yield return new WaitForSeconds(delay);
  SceneManager.LoadScene(1);
 }
}
