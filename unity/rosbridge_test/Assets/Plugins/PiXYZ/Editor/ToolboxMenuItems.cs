using UnityEditor;

using PiXYZ.Plugin.Unity.Tools;

namespace PiXYZ.Plugin.Unity {

	/// This script is autogenerated. You can regenerate it by clicking PiXYZ > Toolbox > Refresh Toolbox.
	public static class ToolboxMenuItems {

		[MenuItem("PiXYZ/Toolbox/Add/Child", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Add/Child", priority = -20)]
		public static void AddChild() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.AddChild()); }

		[MenuItem("PiXYZ/Toolbox/Add/Collider", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Add/Collider", priority = -20)]
		public static void AddCollider() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.AddCollider()); }

		[MenuItem("PiXYZ/Toolbox/Add/Custom Script", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Add/Custom Script", priority = -20)]
		public static void AddCustomScript() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.AddCustomScript()); }

		[MenuItem("PiXYZ/Toolbox/Add/Light", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Add/Light", priority = -20)]
		public static void AddLight() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.AddLight()); }

		[MenuItem("PiXYZ/Toolbox/Add/Rigidbody", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Add/Rigidbody", priority = -20)]
		public static void AddRigidbody() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.AddRigidbody()); }

		[MenuItem("PiXYZ/Toolbox/Debug/GameObjects Info", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Debug/GameObjects Info", priority = -20)]
		public static void DebugGameObjectsInfo() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.PrintGameObjectsInfo()); }

		[MenuItem("PiXYZ/Toolbox/Debug/Materials Info", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Debug/Materials Info", priority = -20)]
		public static void DebugMaterialsInfo() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.PrintMaterialsInfo()); }

		[MenuItem("PiXYZ/Toolbox/Debug/Meshes Info", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Debug/Meshes Info", priority = -20)]
		public static void DebugMeshesInfo() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.PrintMeshesInfo()); }

		[MenuItem("PiXYZ/Toolbox/Filter/On Layer", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Filter/On Layer", priority = -20)]
		public static void FilterOnLayer() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.FilterOnLayer()); }

		[MenuItem("PiXYZ/Toolbox/Filter/On Material", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Filter/On Material", priority = -20)]
		public static void FilterOnMaterial() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.FilterOnMaterial()); }

		[MenuItem("PiXYZ/Toolbox/Filter/On Name", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Filter/On Name", priority = -20)]
		public static void FilterOnName() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.FilterOnName()); }

		[MenuItem("PiXYZ/Toolbox/Filter/On Position", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Filter/On Position", priority = -20)]
		public static void FilterOnPosition() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.FilterOnPosition()); }

		[MenuItem("PiXYZ/Toolbox/Filter/On Property", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Filter/On Property", priority = -20)]
		public static void FilterOnProperty() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.FilterOnMetadata()); }

		[MenuItem("PiXYZ/Toolbox/Filter/On Tag", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Filter/On Tag", priority = -20)]
		public static void FilterOnTag() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.FilterOnTag()); }

		[MenuItem("PiXYZ/Toolbox/Get/Child at", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Get/Child at", priority = -20)]
		public static void GetChildat() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.GetChildAt()); }

		[MenuItem("PiXYZ/Toolbox/Get/Children", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Get/Children", priority = -20)]
		public static void GetChildren() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.GetChildren()); }

		[MenuItem("PiXYZ/Toolbox/Modify/Create UVs", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Modify/Create UVs", priority = -20)]
		public static void ModifyCreateUVs() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.CreateUVs()); }

		[MenuItem("PiXYZ/Toolbox/Modify/Decimate", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Modify/Decimate", priority = -20)]
		public static void ModifyDecimate() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.Decimate()); }

		[MenuItem("PiXYZ/Toolbox/Modify/Flip Normals", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Modify/Flip Normals", priority = -20)]
		public static void ModifyFlipNormals() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.FlipNormals()); }

		[MenuItem("PiXYZ/Toolbox/Modify/Merge", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Modify/Merge", priority = -20)]
		public static void ModifyMerge() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.Merge()); }

		[MenuItem("PiXYZ/Toolbox/Modify/Move Origin", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Modify/Move Origin", priority = -20)]
		public static void ModifyMoveOrigin() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.MoveOrigin()); }

		[MenuItem("PiXYZ/Toolbox/Modify/Randomize Transform", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Modify/Randomize Transform", priority = -20)]
		public static void ModifyRandomizeTransform() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.RandomizeTransform()); }

		[MenuItem("PiXYZ/Toolbox/Modify/Replace GameObject", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Modify/Replace GameObject", priority = -20)]
		public static void ModifyReplaceGameObject() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.ReplaceGameObject()); }

		[MenuItem("PiXYZ/Toolbox/Modify/Switch Materials", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Modify/Switch Materials", priority = -20)]
		public static void ModifySwitchMaterials() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.SwitchMaterials()); }

		[MenuItem("PiXYZ/Toolbox/Set/As Static", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Set/As Static", priority = -20)]
		public static void SetAsStatic() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.SetAsStatic()); }

		[MenuItem("PiXYZ/Toolbox/Set/Layer", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Set/Layer", priority = -20)]
		public static void SetLayer() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.SetLayer()); }

		[MenuItem("PiXYZ/Toolbox/Set/Material", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Set/Material", priority = -20)]
		public static void SetMaterial() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.SetMaterial()); }

		[MenuItem("PiXYZ/Toolbox/Set/Mesh", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Set/Mesh", priority = -20)]
		public static void SetMesh() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.SetMesh()); }

		[MenuItem("PiXYZ/Toolbox/Set/Metadata", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Set/Metadata", priority = -20)]
		public static void SetMetadata() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.SetMetadata()); }

		[MenuItem("PiXYZ/Toolbox/Set/Name", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Set/Name", priority = -20)]
		public static void SetName() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.SetName()); }

		[MenuItem("PiXYZ/Toolbox/Set/Position", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Set/Position", priority = -20)]
		public static void SetPosition() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.SetPosition()); }

		[MenuItem("PiXYZ/Toolbox/Set/Tag", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Set/Tag", priority = -20)]
		public static void SetTag() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.SetTag()); }

		[MenuItem("PiXYZ/Toolbox/Set/Visibility", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Set/Visibility", priority = -20)]
		public static void SetVisibility() { Toolbox.RunToolboxAction(new PiXYZ.Plugin.Unity.Tools.BaseActions.SetEnabled()); }

	}
}