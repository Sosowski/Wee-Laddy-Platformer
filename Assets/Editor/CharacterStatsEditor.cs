using UnityEditor;
using UnityEngine;
using System.Collections;
 
[CustomEditor(typeof(CharacterStats))] public class CharacterStatsEditor : Editor
{
	CharacterStats m_Instance;
	PropertyField[] m_fields;
 
	public void OnEnable()
	{
		m_Instance = target as CharacterStats;
		m_fields = ExposeProperties.GetProperties(m_Instance);
	}
 
	public override void OnInspectorGUI()
	{
		if (m_Instance == null)
			return;
		this.DrawDefaultInspector();
		ExposeProperties.Expose(m_fields);
	}
}