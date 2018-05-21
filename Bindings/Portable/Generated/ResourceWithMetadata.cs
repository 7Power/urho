// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// ResourceWithMetadata.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho
{
	/// <summary>
	/// Base class for resources that support arbitrary metadata stored. Metadata serialization shall be implemented in derived classes.
	/// </summary>
	public unsafe partial class ResourceWithMetadata : Resource
	{
		unsafe partial void OnResourceWithMetadataCreated ();

		[Preserve]
		public ResourceWithMetadata (IntPtr handle) : base (handle)
		{
			OnResourceWithMetadataCreated ();
		}

		[Preserve]
		protected ResourceWithMetadata (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnResourceWithMetadataCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ResourceWithMetadata_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (ResourceWithMetadata_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceWithMetadata_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (ResourceWithMetadata_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ResourceWithMetadata_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(ResourceWithMetadata));
			return new StringHash (ResourceWithMetadata_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceWithMetadata_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(ResourceWithMetadata));
			return Marshal.PtrToStringAnsi (ResourceWithMetadata_GetTypeNameStatic ());
		}

		[Preserve]
		public ResourceWithMetadata () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceWithMetadata_ResourceWithMetadata (IntPtr context);

		[Preserve]
		public ResourceWithMetadata (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(ResourceWithMetadata));
			handle = ResourceWithMetadata_ResourceWithMetadata ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
			OnResourceWithMetadataCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_AddMetadata_0 (IntPtr handle, string name, ref Vector3 value);

		/// <summary>
		/// Add new metadata variable or overwrite old value.
		/// </summary>
		public void AddMetadata (string name, Vector3 value)
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_AddMetadata_0 (handle, name, ref value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_AddMetadata_1 (IntPtr handle, string name, ref IntRect value);

		/// <summary>
		/// Add new metadata variable or overwrite old value.
		/// </summary>
		public void AddMetadata (string name, IntRect value)
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_AddMetadata_1 (handle, name, ref value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_AddMetadata_2 (IntPtr handle, string name, ref Color value);

		/// <summary>
		/// Add new metadata variable or overwrite old value.
		/// </summary>
		public void AddMetadata (string name, Color value)
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_AddMetadata_2 (handle, name, ref value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_AddMetadata_3 (IntPtr handle, string name, ref Vector2 value);

		/// <summary>
		/// Add new metadata variable or overwrite old value.
		/// </summary>
		public void AddMetadata (string name, Vector2 value)
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_AddMetadata_3 (handle, name, ref value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_AddMetadata_4 (IntPtr handle, string name, ref Vector4 value);

		/// <summary>
		/// Add new metadata variable or overwrite old value.
		/// </summary>
		public void AddMetadata (string name, Vector4 value)
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_AddMetadata_4 (handle, name, ref value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_AddMetadata_5 (IntPtr handle, string name, ref IntVector2 value);

		/// <summary>
		/// Add new metadata variable or overwrite old value.
		/// </summary>
		public void AddMetadata (string name, IntVector2 value)
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_AddMetadata_5 (handle, name, ref value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_AddMetadata_6 (IntPtr handle, string name, ref Quaternion value);

		/// <summary>
		/// Add new metadata variable or overwrite old value.
		/// </summary>
		public void AddMetadata (string name, Quaternion value)
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_AddMetadata_6 (handle, name, ref value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_AddMetadata_7 (IntPtr handle, string name, ref Matrix4 value);

		/// <summary>
		/// Add new metadata variable or overwrite old value.
		/// </summary>
		public void AddMetadata (string name, Matrix4 value)
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_AddMetadata_7 (handle, name, ref value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_AddMetadata_8 (IntPtr handle, string name, ref Matrix3x4 value);

		/// <summary>
		/// Add new metadata variable or overwrite old value.
		/// </summary>
		public void AddMetadata (string name, Matrix3x4 value)
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_AddMetadata_8 (handle, name, ref value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_AddMetadata_9 (IntPtr handle, string name, int value);

		/// <summary>
		/// Add new metadata variable or overwrite old value.
		/// </summary>
		public void AddMetadata (string name, int value)
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_AddMetadata_9 (handle, name, value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_AddMetadata_10 (IntPtr handle, string name, float value);

		/// <summary>
		/// Add new metadata variable or overwrite old value.
		/// </summary>
		public void AddMetadata (string name, float value)
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_AddMetadata_10 (handle, name, value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_AddMetadata_11 (IntPtr handle, string name, string value);

		/// <summary>
		/// Add new metadata variable or overwrite old value.
		/// </summary>
		public void AddMetadata (string name, string value)
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_AddMetadata_11 (handle, name, value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_AddMetadata_12 (IntPtr handle, string name, bool value);

		/// <summary>
		/// Add new metadata variable or overwrite old value.
		/// </summary>
		public void AddMetadata (string name, bool value)
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_AddMetadata_12 (handle, name, value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_RemoveMetadata (IntPtr handle, string name);

		/// <summary>
		/// Remove metadata variable.
		/// </summary>
		public void RemoveMetadata (string name)
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_RemoveMetadata (handle, name);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceWithMetadata_RemoveAllMetadata (IntPtr handle);

		/// <summary>
		/// Remove all metadata variables.
		/// </summary>
		public void RemoveAllMetadata ()
		{
			Runtime.ValidateRefCounted (this);
			ResourceWithMetadata_RemoveAllMetadata (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool ResourceWithMetadata_HasMetadata (IntPtr handle);

		/// <summary>
		/// Return whether the resource has metadata.
		/// </summary>
		public bool HasMetadata ()
		{
			Runtime.ValidateRefCounted (this);
			return ResourceWithMetadata_HasMetadata (handle);
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		[Preserve]
		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}
	}
}
