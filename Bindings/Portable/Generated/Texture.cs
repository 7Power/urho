// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Texture.cs
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
	/// Base class for texture resources.
	/// </summary>
	public unsafe partial class Texture : Resource, IGPUObject
	{
		unsafe partial void OnTextureCreated ();

		[Preserve]
		public Texture (IntPtr handle) : base (handle)
		{
			OnTextureCreated ();
		}

		[Preserve]
		protected Texture (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnTextureCreated ();
		}

		public GPUObject AsGPUObject ()
		{
			return new GPUObject (handle);
		}

		[Preserve]
		public Texture () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Texture_Texture (IntPtr context);

		[Preserve]
		public Texture (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Texture));
			handle = Texture_Texture ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
			OnTextureCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Texture_SetNumLevels (IntPtr handle, uint levels);

		/// <summary>
		/// Set number of requested mip levels. Needs to be called before setting size.
		/// </summary>
		public void SetNumLevels (uint levels)
		{
			Runtime.ValidateRefCounted (this);
			Texture_SetNumLevels (handle, levels);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Texture_SetFilterMode (IntPtr handle, TextureFilterMode filter);

		/// <summary>
		/// Set filtering mode.
		/// </summary>
		private void SetFilterMode (TextureFilterMode filter)
		{
			Runtime.ValidateRefCounted (this);
			Texture_SetFilterMode (handle, filter);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Texture_SetAddressMode (IntPtr handle, TextureCoordinate coord, TextureAddressMode address);

		/// <summary>
		/// Set addressing mode by texture coordinate.
		/// </summary>
		public void SetAddressMode (TextureCoordinate coord, TextureAddressMode address)
		{
			Runtime.ValidateRefCounted (this);
			Texture_SetAddressMode (handle, coord, address);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Texture_SetAnisotropy (IntPtr handle, uint level);

		/// <summary>
		/// Set texture max. anisotropy level. No effect if not using anisotropic filtering. Value 0 (default) uses the default setting from Renderer.
		/// </summary>
		private void SetAnisotropy (uint level)
		{
			Runtime.ValidateRefCounted (this);
			Texture_SetAnisotropy (handle, level);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Texture_SetShadowCompare (IntPtr handle, bool enable);

		/// <summary>
		/// Set shadow compare mode. Not used on Direct3D9.
		/// </summary>
		private void SetShadowCompare (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Texture_SetShadowCompare (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Texture_SetBorderColor (IntPtr handle, ref Urho.Color color);

		/// <summary>
		/// Set border color for border addressing mode.
		/// </summary>
		private void SetBorderColor (Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			Texture_SetBorderColor (handle, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Texture_SetSRGB (IntPtr handle, bool enable);

		/// <summary>
		/// Set sRGB sampling and writing mode.
		/// </summary>
		private void SetSRGB (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Texture_SetSRGB (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Texture_SetBackupTexture (IntPtr handle, IntPtr texture);

		/// <summary>
		/// Set backup texture to use when rendering to this texture.
		/// </summary>
		private void SetBackupTexture (Texture texture)
		{
			Runtime.ValidateRefCounted (this);
			Texture_SetBackupTexture (handle, (object)texture == null ? IntPtr.Zero : texture.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Texture_SetMipsToSkip (IntPtr handle, int quality, int toSkip);

		/// <summary>
		/// Set mip levels to skip on a quality setting when loading. Ensures higher quality levels do not skip more.
		/// </summary>
		public void SetMipsToSkip (int quality, int toSkip)
		{
			Runtime.ValidateRefCounted (this);
			Texture_SetMipsToSkip (handle, quality, toSkip);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Texture_GetFormat (IntPtr handle);

		/// <summary>
		/// Return API-specific texture format.
		/// </summary>
		private uint GetFormat ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetFormat (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Texture_IsCompressed (IntPtr handle);

		/// <summary>
		/// Return whether the texture format is compressed.
		/// </summary>
		private bool IsCompressed ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_IsCompressed (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Texture_GetLevels (IntPtr handle);

		/// <summary>
		/// Return number of mip levels.
		/// </summary>
		private uint GetLevels ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetLevels (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Texture_GetWidth (IntPtr handle);

		/// <summary>
		/// Return width.
		/// </summary>
		private int GetWidth ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetWidth (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Texture_GetHeight (IntPtr handle);

		/// <summary>
		/// Return height.
		/// </summary>
		private int GetHeight ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetHeight (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Texture_GetDepth (IntPtr handle);

		/// <summary>
		/// Return height.
		/// </summary>
		private int GetDepth ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetDepth (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern TextureFilterMode Texture_GetFilterMode (IntPtr handle);

		/// <summary>
		/// Return filtering mode.
		/// </summary>
		private TextureFilterMode GetFilterMode ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetFilterMode (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern TextureAddressMode Texture_GetAddressMode (IntPtr handle, TextureCoordinate coord);

		/// <summary>
		/// Return addressing mode by texture coordinate.
		/// </summary>
		public TextureAddressMode GetAddressMode (TextureCoordinate coord)
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetAddressMode (handle, coord);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Texture_GetAnisotropy (IntPtr handle);

		/// <summary>
		/// Return texture max. anisotropy level. Value 0 means to use the default value from Renderer.
		/// </summary>
		private uint GetAnisotropy ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetAnisotropy (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Texture_GetShadowCompare (IntPtr handle);

		/// <summary>
		/// Return whether shadow compare is enabled. Not used on Direct3D9.
		/// </summary>
		private bool GetShadowCompare ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetShadowCompare (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color Texture_GetBorderColor (IntPtr handle);

		/// <summary>
		/// Return border color.
		/// </summary>
		private Urho.Color GetBorderColor ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetBorderColor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Texture_GetSRGB (IntPtr handle);

		/// <summary>
		/// Return whether is using sRGB sampling and writing.
		/// </summary>
		private bool GetSRGB ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetSRGB (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Texture_GetMultiSample (IntPtr handle);

		/// <summary>
		/// Return texture multisampling level (1 = no multisampling).
		/// </summary>
		private int GetMultiSample ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetMultiSample (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Texture_GetAutoResolve (IntPtr handle);

		/// <summary>
		/// Return texture multisampling autoresolve mode. When true, the texture is resolved before being sampled on SetTexture(). When false, the texture will not be resolved and must be read as individual samples in the shader.
		/// </summary>
		private bool GetAutoResolve ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetAutoResolve (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Texture_IsResolveDirty (IntPtr handle);

		/// <summary>
		/// Return whether multisampled texture needs resolve.
		/// </summary>
		private bool IsResolveDirty ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_IsResolveDirty (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Texture_GetBackupTexture (IntPtr handle);

		/// <summary>
		/// Return backup texture.
		/// </summary>
		private Texture GetBackupTexture ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Texture> (Texture_GetBackupTexture (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Texture_GetMipsToSkip (IntPtr handle, int quality);

		/// <summary>
		/// Return mip levels to skip on a quality setting when loading.
		/// </summary>
		public int GetMipsToSkip (int quality)
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetMipsToSkip (handle, quality);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Texture_GetLevelWidth (IntPtr handle, uint level);

		/// <summary>
		/// Return mip level width, or 0 if level does not exist.
		/// </summary>
		public int GetLevelWidth (uint level)
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetLevelWidth (handle, level);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Texture_GetLevelHeight (IntPtr handle, uint level);

		/// <summary>
		/// Return mip level width, or 0 if level does not exist.
		/// </summary>
		public int GetLevelHeight (uint level)
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetLevelHeight (handle, level);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Texture_GetLevelDepth (IntPtr handle, uint level);

		/// <summary>
		/// Return mip level depth, or 0 if level does not exist.
		/// </summary>
		public int GetLevelDepth (uint level)
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetLevelDepth (handle, level);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern TextureUsage Texture_GetUsage (IntPtr handle);

		/// <summary>
		/// Return texture usage type.
		/// </summary>
		private TextureUsage GetUsage ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetUsage (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Texture_GetDataSize (IntPtr handle, int width, int height);

		/// <summary>
		/// Return data size in bytes for a rectangular region.
		/// </summary>
		public uint GetDataSize (int width, int height)
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetDataSize (handle, width, height);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Texture_GetDataSize0 (IntPtr handle, int width, int height, int depth);

		/// <summary>
		/// Return data size in bytes for a volume region.
		/// </summary>
		public uint GetDataSize (int width, int height, int depth)
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetDataSize0 (handle, width, height, depth);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Texture_GetRowDataSize (IntPtr handle, int width);

		/// <summary>
		/// Return data size in bytes for a pixel or block row.
		/// </summary>
		public uint GetRowDataSize (int width)
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetRowDataSize (handle, width);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Texture_GetComponents (IntPtr handle);

		/// <summary>
		/// Return number of image components required to receive pixel data from GetData(), or 0 for compressed images.
		/// </summary>
		private uint GetComponents ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetComponents (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Texture_GetParametersDirty (IntPtr handle);

		/// <summary>
		/// Return whether the parameters are dirty.
		/// </summary>
		private bool GetParametersDirty ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetParametersDirty (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Texture_SetParameters (IntPtr handle, IntPtr xml);

		/// <summary>
		/// Set additional parameters from an XML file.
		/// </summary>
		public void SetParameters (Urho.Resources.XmlFile xml)
		{
			Runtime.ValidateRefCounted (this);
			Texture_SetParameters (handle, (object)xml == null ? IntPtr.Zero : xml.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Texture_SetParameters1 (IntPtr handle, ref Urho.Resources.XmlElement element);

		/// <summary>
		/// Set additional parameters from an XML element.
		/// </summary>
		public void SetParameters (Urho.Resources.XmlElement element)
		{
			Runtime.ValidateRefCounted (this);
			Texture_SetParameters1 (handle, ref element);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Texture_SetParametersDirty (IntPtr handle);

		/// <summary>
		/// Mark parameters dirty. Called by Graphics.
		/// </summary>
		public void SetParametersDirty ()
		{
			Runtime.ValidateRefCounted (this);
			Texture_SetParametersDirty (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Texture_UpdateParameters (IntPtr handle);

		/// <summary>
		/// Update dirty parameters to the texture object. Called by Graphics when assigning the texture.
		/// </summary>
		public void UpdateParameters ()
		{
			Runtime.ValidateRefCounted (this);
			Texture_UpdateParameters (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Texture_GetShaderResourceView (IntPtr handle);

		/// <summary>
		/// Return shader resource view. Only used on Direct3D11.
		/// </summary>
		private IntPtr GetShaderResourceView ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetShaderResourceView (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Texture_GetSampler (IntPtr handle);

		/// <summary>
		/// Return sampler state object. Only used on Direct3D11.
		/// </summary>
		private IntPtr GetSampler ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetSampler (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Texture_GetResolveTexture (IntPtr handle);

		/// <summary>
		/// Return resolve texture. Only used on Direct3D11.
		/// </summary>
		private IntPtr GetResolveTexture ()
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetResolveTexture (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Texture_GetSRGBFormat (IntPtr handle, uint format);

		/// <summary>
		/// Convert format to sRGB. Not used on Direct3D9.
		/// </summary>
		public uint GetSRGBFormat (uint format)
		{
			Runtime.ValidateRefCounted (this);
			return Texture_GetSRGBFormat (handle, format);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Texture_SetResolveDirty (IntPtr handle, bool enable);

		/// <summary>
		/// Set or clear the need resolve flag. Called internally by Graphics.
		/// </summary>
		private void SetResolveDirty (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Texture_SetResolveDirty (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Texture_CheckMaxLevels (int width, int height, uint requestedLevels);

		/// <summary>
		/// Check maximum allowed mip levels for a specific texture size.
		/// </summary>
		public static uint CheckMaxLevels (int width, int height, uint requestedLevels)
		{
			Runtime.Validate (typeof(Texture));
			return Texture_CheckMaxLevels (width, height, requestedLevels);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Texture_CheckMaxLevels2 (int width, int height, int depth, uint requestedLevels);

		/// <summary>
		/// Check maximum allowed mip levels for a specific 3D texture size.
		/// </summary>
		public static uint CheckMaxLevels (int width, int height, int depth, uint requestedLevels)
		{
			Runtime.Validate (typeof(Texture));
			return Texture_CheckMaxLevels2 (width, height, depth, requestedLevels);
		}

		/// <summary>
		/// Return filtering mode.
		/// Or
		/// Set filtering mode.
		/// </summary>
		public TextureFilterMode FilterMode {
			get {
				return GetFilterMode ();
			}
			set {
				SetFilterMode (value);
			}
		}

		/// <summary>
		/// Return texture max. anisotropy level. Value 0 means to use the default value from Renderer.
		/// Or
		/// Set texture max. anisotropy level. No effect if not using anisotropic filtering. Value 0 (default) uses the default setting from Renderer.
		/// </summary>
		public uint Anisotropy {
			get {
				return GetAnisotropy ();
			}
			set {
				SetAnisotropy (value);
			}
		}

		/// <summary>
		/// Return whether shadow compare is enabled. Not used on Direct3D9.
		/// Or
		/// Set shadow compare mode. Not used on Direct3D9.
		/// </summary>
		public bool ShadowCompare {
			get {
				return GetShadowCompare ();
			}
			set {
				SetShadowCompare (value);
			}
		}

		/// <summary>
		/// Return border color.
		/// Or
		/// Set border color for border addressing mode.
		/// </summary>
		public Urho.Color BorderColor {
			get {
				return GetBorderColor ();
			}
			set {
				SetBorderColor (value);
			}
		}

		/// <summary>
		/// Return whether is using sRGB sampling and writing.
		/// Or
		/// Set sRGB sampling and writing mode.
		/// </summary>
		public bool SRGB {
			get {
				return GetSRGB ();
			}
			set {
				SetSRGB (value);
			}
		}

		/// <summary>
		/// Return backup texture.
		/// Or
		/// Set backup texture to use when rendering to this texture.
		/// </summary>
		public Texture BackupTexture {
			get {
				return GetBackupTexture ();
			}
			set {
				SetBackupTexture (value);
			}
		}

		/// <summary>
		/// Return API-specific texture format.
		/// </summary>
		public uint Format {
			get {
				return GetFormat ();
			}
		}

		/// <summary>
		/// Return whether the texture format is compressed.
		/// </summary>
		public bool Compressed {
			get {
				return IsCompressed ();
			}
		}

		/// <summary>
		/// Return number of mip levels.
		/// </summary>
		public uint Levels {
			get {
				return GetLevels ();
			}
		}

		/// <summary>
		/// Return width.
		/// </summary>
		public int Width {
			get {
				return GetWidth ();
			}
		}

		/// <summary>
		/// Return height.
		/// </summary>
		public int Height {
			get {
				return GetHeight ();
			}
		}

		/// <summary>
		/// Return height.
		/// </summary>
		public int Depth {
			get {
				return GetDepth ();
			}
		}

		/// <summary>
		/// Return texture multisampling level (1 = no multisampling).
		/// </summary>
		public int MultiSample {
			get {
				return GetMultiSample ();
			}
		}

		/// <summary>
		/// Return texture multisampling autoresolve mode. When true, the texture is resolved before being sampled on SetTexture(). When false, the texture will not be resolved and must be read as individual samples in the shader.
		/// </summary>
		public bool AutoResolve {
			get {
				return GetAutoResolve ();
			}
		}

		/// <summary>
		/// Return whether multisampled texture needs resolve.
		/// Or
		/// Set or clear the need resolve flag. Called internally by Graphics.
		/// </summary>
		public bool ResolveDirty {
			get {
				return IsResolveDirty ();
			}
			set {
				SetResolveDirty (value);
			}
		}

		/// <summary>
		/// Return texture usage type.
		/// </summary>
		public TextureUsage Usage {
			get {
				return GetUsage ();
			}
		}

		/// <summary>
		/// Return number of image components required to receive pixel data from GetData(), or 0 for compressed images.
		/// </summary>
		public uint Components {
			get {
				return GetComponents ();
			}
		}

		/// <summary>
		/// Return whether the parameters are dirty.
		/// </summary>
		public bool ParametersDirty {
			get {
				return GetParametersDirty ();
			}
		}

		/// <summary>
		/// Return shader resource view. Only used on Direct3D11.
		/// </summary>
		public IntPtr ShaderResourceView {
			get {
				return GetShaderResourceView ();
			}
		}

		/// <summary>
		/// Return sampler state object. Only used on Direct3D11.
		/// </summary>
		public IntPtr Sampler {
			get {
				return GetSampler ();
			}
		}

		/// <summary>
		/// Return resolve texture. Only used on Direct3D11.
		/// </summary>
		public IntPtr ResolveTexture {
			get {
				return GetResolveTexture ();
			}
		}
	}
}
