
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EnemyMovement))]
public class EnemyMovementEditor : Editor
{
    private int numberOfDestinations = 2;
    int destinationNum;
    public override void OnInspectorGUI()
    {
        EnemyMovement enemyMovement = (EnemyMovement)target;
        serializedObject.UpdateIfRequiredOrScript();

        base.OnInspectorGUI();

        if (GUILayout.Button("Spawn"))
        {
            destinationNum++;
            if (enemyMovement.destinations.Count == numberOfDestinations)
            {
                Debug.LogWarning("Cant Add");
                EditorGUILayout.HelpBox("Cant Add More Points", MessageType.Warning);
            }
            else
            {
                GameObject newDestination = Instantiate(enemyMovement.destinationPointPrefab, enemyMovement.transform.position, Quaternion.identity);
                newDestination.name = $"point {destinationNum}";
                enemyMovement.AddDestination(newDestination);
            }
        }

        if (GUILayout.Button("Remove Points"))
        {
            destinationNum = 0;
            enemyMovement.ResetDestinations();
        }

        serializedObject.ApplyModifiedProperties();
    }
}
