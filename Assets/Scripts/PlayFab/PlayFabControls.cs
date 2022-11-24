// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using PlayFab;
// using PlayFab.ClientModels;

// public class PlayFabControls : MonoBehaviour
// { 
//     [SerializeField] GameObject RegisterPanel, SigninPanel, LoginPanel, LoginStackPanel, LoggedInStackPanel;
//     public Text registerUsernameField, registerPasswordField, confirmPasswordField, UsernameField, PasswordField, errorSignUp, errorLogIn;
//     string encryptedPassword;
//     public void RegisterPanel(){
//         RegisterPanel. SetActive(true);
//         SigninPanel.SetActive(false);
//         LoggedInStackPanel.SetActive(false);
//     }
//     public void SigninPanel(){
//         RegisterPanel.SetActive(false);
//         SigninPanel.SetActive(true);
//         LoggedInStackPanel.SetActive(false);
//     }
//     public void LoggedInStackPanel(){
//         RegisterPanel.SetActive(false);
//         SigninPanel.SetActive(false);
//         LoggedInStackPanel.SetActive(true);
//     }
// }