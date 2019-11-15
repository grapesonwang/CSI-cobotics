using UnityEditor;
using PiXYZ.Tools.Editor;

namespace PiXYZ.Tools {

	// THIS SCRIPT IS AUTOGENERATED. PLEASE DO NOT MODIFY OR MOVE IT.
	public static class ToolboxMenuItems {

		[MenuItem("PiXYZ/Toolbox/Decimate", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Decimate", priority = -19)]
		public static void A9070250() { Toolbox.RunToolboxAction(new PiXYZ.Tools.Builtin.Decimate()); }

		[MenuItem("PiXYZ/Toolbox/Merge", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Merge", priority = -18)]
		public static void A5733143() { Toolbox.RunToolboxAction(new PiXYZ.Tools.Builtin.Merge()); }

		[MenuItem("PiXYZ/Toolbox/Explode", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Explode", priority = -17)]
		public static void A9545938() { Toolbox.RunToolboxAction(new PiXYZ.Tools.Builtin.ExplodeSubmeshes()); }

		[MenuItem("PiXYZ/Toolbox/Create UVs", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Create UVs", priority = -16)]
		public static void A5704741() { Toolbox.RunToolboxAction(new PiXYZ.Tools.Builtin.CreateUVs()); }

		[MenuItem("PiXYZ/Toolbox/Create UVs for Lightmaps", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Create UVs for Lightmaps", priority = -15)]
		public static void A693663() { Toolbox.RunToolboxAction(new PiXYZ.Tools.Builtin.CreateLightmapUVs()); }

		[MenuItem("PiXYZ/Toolbox/Create Normals", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Create Normals", priority = -14)]
		public static void A110030() { Toolbox.RunToolboxAction(new PiXYZ.Tools.Builtin.CreateNormals()); }

		[MenuItem("PiXYZ/Toolbox/Flip Normals", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Flip Normals", priority = -13)]
		public static void A6288260() { Toolbox.RunToolboxAction(new PiXYZ.Tools.Builtin.FlipNormals()); }

		[MenuItem("PiXYZ/Toolbox/Replace by...", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Replace by...", priority = -12)]
		public static void A5709207() { Toolbox.RunToolboxAction(new PiXYZ.Tools.Builtin.ReplaceBy()); }

		[MenuItem("PiXYZ/Toolbox/Remove Hidden", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Remove Hidden", priority = -11)]
		public static void A2973659() { Toolbox.RunToolboxAction(new PiXYZ.Tools.Builtin.RemoveHidden()); }

		[MenuItem("PiXYZ/Toolbox/Repair Mesh", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Repair Mesh", priority = -10)]
		public static void A4113339() { Toolbox.RunToolboxAction(new PiXYZ.Tools.Builtin.RepairMesh()); }

		[MenuItem("PiXYZ/Toolbox/Retopologize", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Retopologize", priority = -9)]
		public static void A6980956() { Toolbox.RunToolboxAction(new PiXYZ.Tools.Builtin.Retopologize()); }

		[MenuItem("PiXYZ/Toolbox/Move Pivot", priority = 22)]
		[MenuItem("GameObject/PiXYZ/Move Pivot", priority = -7)]
		public static void A6845374() { Toolbox.RunToolboxAction(new PiXYZ.Tools.Builtin.MoveOrigin()); }

	}
}